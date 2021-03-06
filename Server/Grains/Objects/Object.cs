﻿using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;
using Orleans.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public enum TypeID
    {
        TYPEID_OBJECT = 0,
        TYPEID_ITEM = 1,
        TYPEID_CONTAINER = 2,
        TYPEID_UNIT = 3,
        TYPEID_PLAYER = 4,
        TYPEID_GAMEOBJECT = 5,
        TYPEID_DYNAMICOBJECT = 6,
        TYPEID_CORPSE = 7
    }

    [Flags]
    public enum TypeMask
    {
        TYPEMASK_OBJECT = 0x0001,
        TYPEMASK_ITEM = 0x0002,
        TYPEMASK_CONTAINER = 0x0006, // TYPEMASK_ITEM | 0x0004
        TYPEMASK_UNIT = 0x0008, // creature
        TYPEMASK_PLAYER = 0x0010,
        TYPEMASK_GAMEOBJECT = 0x0020,
        TYPEMASK_DYNAMICOBJECT = 0x0040,
        TYPEMASK_CORPSE = 0x0080,
        TYPEMASK_SEER = TYPEMASK_PLAYER | TYPEMASK_UNIT | TYPEMASK_DYNAMICOBJECT
    }

    public class ObjectData : GrainState
    {
        public bool Exists { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }

        public UInt32 MapID { get; set; }
        public UInt32 InstanceID { get; set; }
        public UInt64 CurrentCellID { get; set; }

        public TypeID MyType { get; set; }

        public ObjectType ObjType { get; set; }
        public UpdateField[] UpdateFields { get; set; }

        public UpdateMask UpdateFieldsMask { get; set; }

        public ObjectUpdateFlags UpdateFlags { get; set; }
        public List<ObjectGUID> InRangeObjects { get; set; }
        public ObjectGUID SightBase { get; set; }
    }

    public class ObjectImpl : Object<ObjectData>, IObject
    {
    }

    public class Object<T> : BaseObject<T>, IObjectImpl
        where T : ObjectData
    {
        protected ObjectGUID oGUID = null;
        protected PackedGUID pGUID = null;

        protected Dictionary<ObjectGUID, IObjectImpl> _inrangeObjects = new Dictionary<ObjectGUID, IObjectImpl>();
        protected Dictionary<ObjectGUID, IObjectImpl> _inrangePlayers = new Dictionary<ObjectGUID, IObjectImpl>();
        protected Dictionary<ObjectGUID, IObjectImpl> _inrangeObjectTracker = null;

        public override async Task OnActivateAsync()
        {
            await base.OnActivateAsync();
        }

        public virtual async Task OnConstruct()
        {
            if (_IsValid())
            {
                await SetGUID(new ObjectGUID(this.GetPrimaryKeyLong()));

                List<Task> tasks = new List<Task>();
                tasks.Add(SetFloat((int) EObjectFields.OBJECT_FIELD_SCALE_X, 1.0f)); //default scale

                if (State.UpdateFieldsMask == null)
                    State.UpdateFieldsMask = new UpdateMask(State.UpdateFields.Length);
                if (State.InRangeObjects == null)
                    State.InRangeObjects = new List<ObjectGUID>();
                if (State.SightBase == null)
                    State.SightBase = new ObjectGUID(0);

                var inrange = State.InRangeObjects.ToArray(); //copy so we don't get enumeration errors
                foreach (var guid in inrange)
                    AddInRangeObjectImpl(guid, ObjectRetriever.GetObject(GrainFactory, guid));
                await Task.WhenAll(tasks);
            }
        }

        public override async Task OnDeactivateAsync()
        {
            if (_IsValid())
                await Save();

            await base.OnDeactivateAsync();
        }

        public Task<bool> IsValid()
        {
            return Task.FromResult(State.Exists);
        }

        public bool _IsValid()
        {
            return State.Exists;
        }

        public virtual IObjectImpl ToRef()
        {
            return this.AsReference<IObjectImpl>();
        }

        public virtual Task<string> VirtualCall()
        {
            return Task.FromResult("Virtual call from object");
        }

        public Task<string> ObjectCall()
        {
            return Task.FromResult("Call from object");
        }

        public async Task Save()
        {
            if (State.Exists) await WriteStateAsync();
        }

        public Task<ObjectGUID> GetGUID()
        {
            return Task.FromResult(oGUID);
        }

        public Task<PackedGUID> GetPackedGUID()
        {
            return Task.FromResult(pGUID);
        }

        public Task CreateUpdateFields(int sz)
        {
            State.UpdateFields = new UpdateField[sz];
            return TaskDone.Done;
        }

        public async Task SetObjectType(ObjectType type)
        {
            State.ObjType = type;
            await CreateUpdateFieldsByType(type);
        }

        public async Task CreateUpdateFieldsByType(ObjectType type)
        {
            switch (type)
            {
                case ObjectType.Player:
                {
                    await CreateUpdateFields((int) EUnitFields.PLAYER_END);
                    await
                        SetType((UInt32) (TypeMask.TYPEMASK_PLAYER | TypeMask.TYPEMASK_UNIT | TypeMask.TYPEMASK_OBJECT));
                }
                    break;
                case ObjectType.Creature:
                {
                    await CreateUpdateFields((int) EUnitFields.UNIT_END);
                    await SetType((UInt32) (TypeMask.TYPEMASK_UNIT | TypeMask.TYPEMASK_OBJECT));
                }
                    break;

                default:
                    throw new Exception("Cannot to create Update Fields by unknown object type");
            }
        }

        #region UpdateFields

        public byte _GetByte(object field, int index)
        {
            return State.UpdateFields[(int) field].GetByte(index);
        }

        public UInt32 _GetUInt32(object field)
        {
            return State.UpdateFields[(int) field].GetUInt32();
        }

        public Int32 _GetInt32(object field)
        {
            return State.UpdateFields[(int) field].GetInt32();
        }

        public UInt64 _GetUInt64(object field)
        {
            var low = _GetUInt32(field);
            var high = _GetUInt32((int) field + 1);

            var ret = (UInt64) low;
            ret |= (UInt64) high << 32;
            return ret;
        }

        public float _GetFloat(object field)
        {
            return State.UpdateFields[(int) field].GetFloat();
        }

        public async Task SetByte(object field, int index, byte val)
        {
            State.UpdateFields[(int) field].Set(index, val);
            await OnFieldChange(field);
        }

        public async Task SetUInt32(object field, UInt32 val)
        {
            State.UpdateFields[(int) field].Set(val);
            await OnFieldChange(field);
        }

        public async Task SetInt32(object field, int val)
        {
            State.UpdateFields[(int) field].Set(val);
            await OnFieldChange(field);
        }

        public async Task SetFloat(object field, float val)
        {
            State.UpdateFields[(int) field].Set(val);
            await OnFieldChange(field);
        }

        public async Task SetGUID(object field, ObjectGUID val)
        {
            await SetUInt64(field, val.ToUInt64());
            await OnFieldChange(field);
        }

        public async Task SetUInt64(object field, UInt64 val)
        {
            UInt32 high = (UInt32) (val >> 32);
            UInt32 low = (UInt32) val;
            await SetUInt32(field, low);
            await SetUInt32((int) field + 1, high);
            await OnFieldChange(field);
        }

        //Tasks for external people
        public Task<byte> GetByte(object field, int index)
        {
            return Task.FromResult(_GetByte(field, index));
        }

        public Task<UInt32> GetUInt32(object field)
        {
            return Task.FromResult(_GetUInt32(field));
        }

        public Task<float> GetFloat(object field)
        {
            return Task.FromResult(_GetFloat(field));
        }

        #endregion

        #region Updatefield Getters and Setters

        public async Task SetType(UInt32 val)
        {
            await SetUInt32(EObjectFields.OBJECT_FIELD_TYPE, val);
        }

        public Task<UInt32> GetObjectType()
        {
            return Task.FromResult(_GetObjectType());
        }

        public UInt32 _GetObjectType()
        {
            return _GetUInt32(EObjectFields.OBJECT_FIELD_TYPE);
        }

        public async Task SetGUID(ObjectGUID guid)
        {
            await SetGUID(EObjectFields.OBJECT_FIELD_GUID, guid);
            oGUID = guid;
            pGUID = new PackedGUID(guid);
        }

        #endregion

        public async Task SetMap(IMap map)
        {
            State.MapID = await map.GetMapID();
            State.InstanceID = await map.GetInstanceID();

            await UpdateInRangeSet();

            var asref = ToRef();
            if (_IsPlayer())
            {
                var plrthis = this as Player;

                Debug.Assert(plrthis != null);

                await plrthis.BuildInitialUpdate();
            }
        }

        public Task<IMap> GetMap()
        {
            return Task.FromResult(GrainFactory.GetGrain<IMap>(State.InstanceID));
        }

        protected IMap _GetMap()
        {
            if (State.InstanceID == 0)
                return null; //not in a map
            var map = GrainFactory.GetGrain<IMap>(State.InstanceID);
            return map;
        }

        public Task<bool> IsOnMap()
        {
            if (State.InstanceID == 0)
                return Task.FromResult(false);
            return Task.FromResult(true);
        }

        public Task ClearMap()
        {
            State.MapID = 0xFFFFFFFF;
            State.InstanceID = 0;
            return TaskDone.Done;
        }

        public Task SetCell(UInt64 cellkey)
        {
            State.CurrentCellID = cellkey;
            return TaskDone.Done;
        }

        public Task<UInt64> GetCell()
        {
            return Task.FromResult(State.CurrentCellID);
        }

        public virtual Task<bool> IsCellActivator()
        {
            return Task.FromResult(false);
        }


        public async Task UpdateInRangeSet()
        {
            _inrangeObjectTracker = new Dictionary<ObjectGUID, IObjectImpl>();
            List<Task> tasks = new List<Task>();

            var map = _GetMap();
            
            //Remove what we can't see, we must take a copy of inrange list incase it's modified during before CanSee async completes
            var inrangeCopy = _inrangeObjects;
            foreach (var obj in inrangeCopy)
            {
                var cansee = await CanSee(obj.Value);

                if (!cansee)
                    tasks.Add(RemoveInRangeObject(obj.Key, obj.Value));
            }

            var inRangeGuids = _inrangeObjects.Keys.ToList(); //pass these to map to avoid double checks of if we can see them

            if (map != null)
                tasks.Add(map.UpdateInRangeObject(this, inRangeGuids));

            await Task.WhenAll(tasks);
        }

        public async Task AddInRangeObject(ObjectGUID guid, bool add_other = true)
        {
            var obj = ObjectRetriever.GetObject(GrainFactory, guid);
            await AddInRangeObject(guid, obj, add_other);
        }

        public async Task AddInRangeObject(ObjectGUID guid, IObjectImpl obj, bool add_other = true)
        {
            if (guid == oGUID) //Cannot be inrange of self
                return;
            if (_inrangeObjects.ContainsKey(guid))
                return; //already inrange

            AddInRangeObjectImpl(guid, obj);

            await OnAddInRangeObject(guid, obj);

            if (add_other)
                await obj.AddInRangeObject(oGUID, this, false);
        }

        protected void AddInRangeObjectImpl(ObjectGUID guid, IObjectImpl obj)
        {
            if (guid == oGUID) //Cannot be inrange of self
                return;
            if (!State.InRangeObjects.Contains(guid))
                State.InRangeObjects.Add(guid);
            if (!_inrangeObjects.ContainsKey(guid))
            {
                _inrangeObjects.Add(guid, obj);
                if (obj is IPlayer)
                    _inrangePlayers.Add(guid, obj);
            }

            if (_inrangeObjectTracker != null)
                _inrangeObjectTracker.Add(guid, obj);
        }

        protected void RemoveInRangeObjectImpl(ObjectGUID guid, IObjectImpl obj)
        {
            State.InRangeObjects.Remove(guid);
            _inrangeObjects.Remove(guid);
            if (obj is IPlayer)
                _inrangePlayers.Remove(guid);
        }

        public virtual Task OnAddInRangeObject(ObjectGUID guid, IObjectImpl obj)
        {
            return TaskDone.Done;
        }

        public async Task RemoveInRangeObject(ObjectGUID guid, IObjectImpl obj, bool remove_other = true)
        {
            RemoveInRangeObjectImpl(guid, obj);
            if (remove_other)
                await obj.RemoveInRangeObject(oGUID, this, false);
        }

        public Task<IObjectImpl> GetInRangeObject(ObjectGUID guid)
        {
            IObjectImpl ret = null;
            _inrangeObjects.TryGetValue(guid, out ret);
            return Task.FromResult(ret);
        }

        public virtual async Task<bool> CanSee(IObjectImpl other)
        {
            var otherposx = await other.GetPositionX();
            var otherposy = await other.GetPositionY();

            float dist = _GetDistance2DSq(otherposx, otherposy);

            if (dist > (100*100)) //todo: implement, 100 yds for now
                return false;

            return true;
        }

        private float _GetDistance2DSq(float x, float y)
        {
            float myx = State.PositionX;
            float myy = State.PositionY;

            float deltax = myx - x;
            float deltay = myy - y;

            return (deltax*deltax) + (deltay*deltay);
        }

        public Task<PacketOut> BuildCreateUpdateFor(IPlayer plr)
        {
            ObjectUpdateType updateType = ObjectUpdateType.UPDATETYPE_CREATE_OBJECT;

            ObjectUpdateFlags updateFlags = State.UpdateFlags;

            if (plr.GetPrimaryKeyLong() == this.GetPrimaryKeyLong())
                updateFlags |= ObjectUpdateFlags.UPDATEFLAG_SELF;

            if ((updateFlags & ObjectUpdateFlags.UPDATEFLAG_STATIONARY_POSITION) != 0)
            {
                if (_IsPlayer())
                    updateType = ObjectUpdateType.UPDATETYPE_CREATE_OBJECT2;
            }

            PacketOut p = new PacketOut();

            p.Write((byte) updateType);
            p.Write(pGUID);
            p.Write((byte) State.MyType);
            _BuildMovementUpdate(updateType, updateFlags, ref p);
            _BuildValuesUpdate(updateType, updateFlags, ref p, plr);
            return Task.FromResult(p);
        }

        public Task<PacketOut> BuildValuesUpdateFor(IPlayer plr)
        {
            ObjectUpdateType updateType = ObjectUpdateType.UPDATETYPE_CREATE_OBJECT;

            ObjectUpdateFlags updateFlags = State.UpdateFlags;

            if (plr.GetPrimaryKeyLong() == this.GetPrimaryKeyLong())
                updateFlags |= ObjectUpdateFlags.UPDATEFLAG_SELF;

            PacketOut p = new PacketOut();

            p.Write((byte) updateType);
            p.Write(pGUID);
            p.Write((byte) State.MyType);
            _BuildMovementUpdate(updateType, updateFlags, ref p);
            _BuildValuesUpdate(updateType, updateFlags, ref p, plr);
            return Task.FromResult(p);
        }

        public async Task OnFieldChange(object field)
        {
            var map = _GetMap();

            if (map != null)
                await map.OnObjectUpdated(oGUID);
        }

        private void _BuildMovementUpdate(ObjectUpdateType type, ObjectUpdateFlags flags, ref PacketOut pkt)
        {
            var asUnit = ToRef() as IUnitImpl;

            pkt.Write((UInt16) flags);

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_LIVING) != 0)
            {
                UInt32 moveflags = 0;
                UInt16 moveflagsex = 0;

                pkt.Write(moveflags);
                pkt.Write(moveflagsex);
                pkt.Write(Time.GetMSTime());
                pkt.Write(State.PositionX);
                pkt.Write(State.PositionY);
                pkt.Write(State.PositionZ);
                pkt.Write(State.Orientation);

                pkt.Write((UInt32) 0); //fall time

                pkt.Write((float) 14.0); //walk speed
                pkt.Write((float) 14.0); //run speed
                pkt.Write((float) 14.0); //runback speed
                pkt.Write((float) 14.0); //swim speed
                pkt.Write((float) 14.0); //swimback speed
                pkt.Write((float) 14.0); //flight speed
                pkt.Write((float) 14.0); //flightback speed
                pkt.Write((float) 14.0); //turn rate
                pkt.Write((float) 14.0); //pitch rate
            }
            else
            {
                if ((flags & ObjectUpdateFlags.UPDATEFLAG_POSITION) != 0)
                {
                    pkt.Write((byte) 0); //packed guid of transport
                    pkt.Write(State.PositionX);
                    pkt.Write(State.PositionY);
                    pkt.Write(State.PositionZ);

                    pkt.Write((float) 0); //transport offset x
                    pkt.Write((float) 0); //transport offset y
                    pkt.Write((float) 0); //transport offset z

                    pkt.Write(State.Orientation);
                }
                else
                {
                    if ((flags & ObjectUpdateFlags.UPDATEFLAG_STATIONARY_POSITION) != 0)
                    {
                        pkt.Write(State.PositionX);
                        pkt.Write(State.PositionY);
                        pkt.Write(State.PositionZ);
                        pkt.Write(State.Orientation);
                    }
                }
            }

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_UNKNOWN) != 0)
            {
                pkt.Write((UInt32) 0);
            }

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_LOWGUID) != 0)
            {
                //lowguid of some items 2F or 8 for players
                TypeID myType = State.MyType;

                switch (myType)
                {
                    case TypeID.TYPEID_OBJECT:
                    case TypeID.TYPEID_ITEM:
                    case TypeID.TYPEID_CONTAINER:
                    case TypeID.TYPEID_GAMEOBJECT:
                    case TypeID.TYPEID_DYNAMICOBJECT:
                    case TypeID.TYPEID_CORPSE:
                    {
                        pkt.Write((UInt32) _GetUInt64(EObjectFields.OBJECT_FIELD_GUID));
                    }
                        break;
                    case TypeID.TYPEID_UNIT:
                        pkt.Write((UInt32) 0xB);
                        break;
                    case TypeID.TYPEID_PLAYER:
                    {
                        if ((flags & ObjectUpdateFlags.UPDATEFLAG_SELF) != 0)
                            pkt.Write((UInt32) 0x2F);
                        else
                            pkt.Write((UInt32) 0x8);
                    }
                        break;
                    default:
                        pkt.Write((UInt32) 0);
                        break;
                }
            }

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_HAS_TARGET) != 0)
            {
                pkt.Write((byte) 0); //packed guid of target
            }

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_TRANSPORT) != 0)
                pkt.Write(Time.GetMSTime()); //fk knows

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_VEHICLE) != 0)
            {
                pkt.Write((UInt32) 0); //vehicle id
                pkt.Write((float) 0); //orientation
            }

            if ((flags & ObjectUpdateFlags.UPDATEFLAG_ROTATION) != 0)
            {
                //this is the packed quart :(
                pkt.Write((UInt64) 0);
            }
        }

        private void _BuildValuesUpdate(ObjectUpdateType type, ObjectUpdateFlags flags, ref PacketOut pkt, IPlayer plr)
        {
            UpdateMask mask = new UpdateMask(State.UpdateFields.Length);
            PacketOut tmp = new PacketOut();


            UpdatefieldFlags visibilityFlags = UpdatefieldFlags.UF_FLAG_PUBLIC;
            if (plr.GetPrimaryKeyLong() == this.GetPrimaryKeyLong())
                visibilityFlags |= UpdatefieldFlags.UF_FLAG_PRIVATE;

            var fieldFlags = GetFlagVisibility();

            for (var i = 0; i < State.UpdateFields.Length; ++i)
            {
                //if ((fieldFlags[i] & visibilityFlags) == 0)
                //    continue;
                tmp.Write(State.UpdateFields[i].data);
                mask.SetBit(i);
            }

            pkt.Write((byte) mask.GetMaxBlockCount());
            for (var i = 0; i < mask.GetMaxBlockCount(); ++i)
                pkt.Write(mask.m_blocks[i]);

            pkt.Write(tmp);
        }

        private UpdatefieldFlags[] GetFlagVisibility()
        {
            TypeID myType = State.MyType;

            switch (myType)
            {
                case TypeID.TYPEID_CORPSE:
                    return UpdateVisibility.CorpseUpdateFieldFlags;
                case TypeID.TYPEID_DYNAMICOBJECT:
                    return UpdateVisibility.DynamicObjectUpdateFieldFlags;
                case TypeID.TYPEID_CONTAINER:
                case TypeID.TYPEID_ITEM:
                    return UpdateVisibility.ItemUpdateFieldFlags;
                case TypeID.TYPEID_UNIT:
                    return UpdateVisibility.UnitUpdateFieldFlags;
                case TypeID.TYPEID_PLAYER:
                    return UpdateVisibility.UnitUpdateFieldFlags;
                default:
                    return null;
            }
        }

        public Task<float> GetPositionX()
        {
            return Task.FromResult(State.PositionX);
        }

        public Task<float> GetPositionY()
        {
            return Task.FromResult(State.PositionY);
        }

        public Task<float> GetPositionZ()
        {
            return Task.FromResult(State.PositionZ);
        }

        public Task<float> GetOrientation()
        {
            return Task.FromResult(State.Orientation);
        }

        #region Type virtuals

        public virtual bool _IsPlayer()
        {
            return false;
        }

        public virtual bool _IsUnit()
        {
            return false;
        }

        public virtual bool _IsCreature()
        {
            return false;
        }

        public virtual bool _IsPet()
        {
            return false;
        }

        public virtual bool _IsVehicle()
        {
            return false;
        }

        public virtual bool _IsTransport()
        {
            return false;
        }

        public virtual bool _IsGameObject()
        {
            return false;
        }


        public Task<bool> IsPlayer()
        {
            return Task.FromResult(_IsPlayer());
        }

        public Task<bool> IsUnit()
        {
            return Task.FromResult(_IsUnit());
        }

        public Task<bool> IsCreature()
        {
            return Task.FromResult(_IsCreature());
        }

        public Task<bool> IsPet()
        {
            return Task.FromResult(_IsPet());
        }

        public Task<bool> IsVehicle()
        {
            return Task.FromResult(_IsVehicle());
        }

        public Task<bool> IsTransport()
        {
            return Task.FromResult(_IsTransport());
        }

        public Task<bool> IsGameObject()
        {
            return Task.FromResult(_IsGameObject());
        }

        #endregion

        public virtual Task Update()
        {
            return TaskDone.Done;
        }

        //packet sending
        public virtual Task SendPacket(PacketOut p)
        {
            return TaskDone.Done;
        }

        public async Task SendToAll(PacketOut p, bool toself)
        {
            var tasks = new List<Task>();

            foreach (var entry in _inrangePlayers)
            {
                var plr = entry.Value as IPlayer;

                Debug.Assert(plr != null);

                tasks.Add(plr.SendPacket(p));
            }

            if (toself)
                tasks.Add(SendPacket(p));

            await Task.WhenAll(tasks);
        }

        protected async Task UpdatePosition(float x, float y, float z)
        {
            if (await IsCellActivator())
            {
                var map = _GetMap();

                if (map != null)
                    await map.OnActivatorMove(this, State.PositionX, State.PositionY, x, y);
            }

            State.PositionX = x;
            State.PositionY = y;
            State.PositionZ = z;
        }

        protected void UpdateOrientation(float o)
        {
            State.Orientation = o;
        }
    }

    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    public class BaseObject<T> : Grain<T>, IBaseObjectImpl
        where T : GrainState
    {
    }
}