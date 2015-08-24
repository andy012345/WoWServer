﻿using Orleans;
using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public enum ObjectUpdateType
    {
        UPDATETYPE_VALUES = 0,
        UPDATETYPE_MOVEMENT = 1,
        UPDATETYPE_CREATE_OBJECT = 2,
        UPDATETYPE_CREATE_OBJECT2 = 3,
        UPDATETYPE_OUT_OF_RANGE_OBJECTS = 4,
        UPDATETYPE_NEAR_OBJECTS = 5
    }

    [Flags]
    public enum ObjectUpdateFlags
    {
        UPDATEFLAG_NONE = 0x0000,
        UPDATEFLAG_SELF = 0x0001,
        UPDATEFLAG_TRANSPORT = 0x0002,
        UPDATEFLAG_HAS_TARGET = 0x0004,
        UPDATEFLAG_UNKNOWN = 0x0008,
        UPDATEFLAG_LOWGUID = 0x0010,
        UPDATEFLAG_LIVING = 0x0020,
        UPDATEFLAG_STATIONARY_POSITION = 0x0040,
        UPDATEFLAG_VEHICLE = 0x0080,
        UPDATEFLAG_POSITION = 0x0100,
        UPDATEFLAG_ROTATION = 0x0200
    }

    public class PlayerData : UnitData
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public int Race { get; set; }
        public int Class { get; set; }
        public int Gender { get; set; }
        public UInt32 RealmID { get; set; }

        //Binds!
        public float BindX { get; set; }
        public float BindY { get; set; }
        public float BindZ { get; set; }
        public UInt32 BindMap { get; set; }
        public UInt32 BindArea { get; set; }

        public List<PacketOut> PendingUpdateData { get; set; }
    }

    public class PlayerByNameIndexState : GrainState
    {
        ObjectGUID _GUID = new ObjectGUID(0);

        public ObjectGUID GUID { get { return _GUID; } set { _GUID = value; } }
    }

    [StorageProvider(ProviderName = "Default")]
    public class PlayerByNameIndex : Grain<PlayerByNameIndexState>, IPlayerByNameIndex
    {
        public Task<ObjectGUID> GetPlayerGUID() { return Task.FromResult(State.GUID); }
        public Task<IPlayer> GetPlayer() { return Task.FromResult(GrainFactory.GetGrain<IPlayer>(State.GUID.ToInt64())); }
        public async Task Save() { await WriteStateAsync(); }

        public async Task<bool> SetPlayer(IPlayer plr)
        {
            ObjectGUID plrGUID = new ObjectGUID((UInt64)plr.GetPrimaryKeyLong());
            if (State.GUID != 0)
                return false;
            State.GUID = plrGUID;
            await Save();
            return true;
        }
    }

    public class PlayerImpl : Player, IPlayer { }
    public class Player : Unit<PlayerData>, IPlayerImpl
    {
        IAccount _Account = null;
        SessionStream _Stream = null;

        UInt32 TimeSyncCounter = 0;

        public async override Task OnActivateAsync()
        {
            await OnConstruct();
            await base.OnActivateAsync();
        }

        public async override Task OnConstruct()
        {
            await base.OnConstruct();
            if (_IsValid())
            {
                State.MyType = TypeID.TYPEID_PLAYER;
                Type = (UInt32)(TypeMask.TYPEMASK_PLAYER | TypeMask.TYPEMASK_UNIT | TypeMask.TYPEMASK_OBJECT);

                if (State.PendingUpdateData == null)
                    State.PendingUpdateData = new List<PacketOut>();
            }
            if (State.Account != null)
                _Account = GrainFactory.GetGrain<IAccount>(State.Account);
        }

        public override IObjectImpl ToRef() { return this.AsReference<IPlayer>(); }

        public override Task<string> VirtualCall() { return Task.FromResult("Virtual call from player"); }
        public Task<string> PlayerCall() { return Task.FromResult("Call from player"); }

        public Task Create()
        {
            SetObjectType(ObjectType.Player);
            return TaskDone.Done;
        }

        public Task Kick()
        {
            return TaskDone.Done;
        }

        public override bool _IsPlayer() { return true; }

        public Task<string> GetAccount() { return Task.FromResult(State.Account); }
        public async Task OnLogin()
        {
            var account = GrainFactory.GetGrain<IAccount>(State.Account);
            var session = await account.GetRealmSession();
            _Stream = await session.GetSessionStream(); //cache this to send packets without tonnes of copying
        }

        public async Task SendPacket(PacketOut p)
        {
            if (_Stream == null)
                return;
            p.Finalise();
            await _Stream.PacketStream.OnNextAsync(p.strm.ToArray());
        }

        public async Task<LoginErrorCode> Create(PlayerCreateData info)
        {
            await Create();
            GUID = (UInt64)this.GetPrimaryKeyLong(); //create cached variables

            State.Name = info.CreateData.Name;
            State.Account = info.AccountName;
            _Account = GrainFactory.GetGrain<IAccount>(State.Account);
            State.Race = info.CreateData.Race;
            State.Class = info.CreateData.Class;
            State.Gender = info.CreateData.Gender;
            State.RealmID = (UInt32)info.RealmID;
            await SetGender(info.CreateData.Gender);
            await SetRace(info.CreateData.Race);
            await SetClass(info.CreateData.Class);
            Skin = info.CreateData.Skin;
            Face = info.CreateData.Face;
            HairStyle = info.CreateData.HairStyle;
            HairColor = info.CreateData.HairColor;
            FacialHair = info.CreateData.FacialHair;
            Type = (int)TypeID.TYPEID_PLAYER;

            var datastore = GrainFactory.GetGrain<IDataStoreManager>(0);
            var chrclass = await datastore.GetChrClasses(info.CreateData.Class);
            var chrrace = await datastore.GetChrRaces(info.CreateData.Race);
            var creationinfo = await datastore.GetPlayerCreateInfo(info.CreateData.Class, info.CreateData.Race);

            if (chrclass == null || chrrace == null || creationinfo == null)
                return LoginErrorCode.CHAR_CREATE_ERROR;

            await SetFaction((int)chrrace.Faction);
            await SetPowerType((byte)chrclass.powerType);

            if (_GetGender() == 0) //male
            {
                await SetDisplayID((int)chrrace.ModelMale);
                await SetNativeDisplayID((int)chrrace.ModelMale);
            }
            else
            {
                await SetDisplayID((int)chrrace.ModelFemale);
                await SetNativeDisplayID((int)chrrace.ModelFemale);
            }

            State.PositionX = creationinfo.position_x;
            State.PositionY = creationinfo.position_y;
            State.PositionZ = creationinfo.position_z;
            State.Orientation = creationinfo.orientation;
            State.MapID = creationinfo.map;

            State.BindX = State.PositionX;
            State.BindY = State.PositionY;
            State.BindZ = State.PositionZ;
            State.BindMap = State.MapID;
            State.BindArea = 0;

            State.Exists = true; //WE EXIST, YAY

            await SetUInt32((int)EUnitFields.UNIT_FIELD_FLAGS_2, 2048); //regen power
            await SetUInt32((int)EUnitFields.PLAYER_FIELD_WATCHED_FACTION_INDEX, 0xFFFFFFFF);
            await SetUInt32((int)EUnitFields.UNIT_FIELD_LEVEL, 1);
            await SetUInt32((int)EUnitFields.PLAYER_FIELD_COINAGE, 1);
            await SetUInt32((int)EUnitFields.UNIT_FIELD_HEALTH, 100);
            await SetUInt32((int)EUnitFields.UNIT_FIELD_MAXHEALTH, 100);

            await OnConstruct();
            await Save();
            return LoginErrorCode.CHAR_CREATE_SUCCESS;
        }

        public Task<PacketOut> BuildEnum()
        {
            PacketOut p = new PacketOut();
            if (_IsValid())
            {
                p.Write(oGUID);
                p.WriteCString(State.Name);
                p.Write(_GetRace());
                p.Write(_GetClass());
                p.Write(_GetGender());
                p.Write(Skin);
                p.Write(Face);
                p.Write(HairStyle);
                p.Write(HairColor);
                p.Write(FacialHair);
                p.Write((byte)1); //level to do
                p.Write((int)0); //zone to do
                p.Write((int)0); //map to do
                p.Write(State.PositionX); //positionx
                p.Write(State.PositionY); //positiony
                p.Write(State.PositionZ); //positionz
                p.Write((int)0); //guildid
                p.Write((int)0); //charflags (stuff like hide helm, is a ghost from death, needs a rename, is locked)
                p.Write((int)0); //customisationflags (race change, faction change etc)
                p.Write((byte)0); //firstlogin
                p.Write((int)0); //petdisplayid
                p.Write((int)0); //petlevel
                p.Write((int)0); //petfamilyid

                //this is a loop of the item display slots, to do when implementing items
                for (int i = 0; i < 23; ++i)
                {
                    p.Write((int)0); //item display
                    p.Write((byte)0); //inventory type
                    p.Write((int)0); //enchantment
                }
            }
            else
            {
                p.Write((UInt64)0); //guid
                p.WriteCString("Unknown"); //name
                p.Write((byte)0); //race
                p.Write((byte)0); //class
                p.Write((byte)0); //gender
                p.Write((byte)0); //skin
                p.Write((byte)0); //face 
                p.Write((byte)0); //hairstyle
                p.Write((byte)0); //haircolor
                p.Write((byte)0); //facialhair
                p.Write((byte)1); //level
                p.Write((int)0); //zoneid
                p.Write((int)0); //mapid
                p.Write((float)0); //positionx
                p.Write((float)0); //positiony
                p.Write((float)0); //positionz
                p.Write((int)0); //guildid
                p.Write((int)0); //charflags
                p.Write((int)0); //customisationflags
                p.Write((byte)0); //firstlogin
                p.Write((int)0); //petdisplayid
                p.Write((int)0); //petlevel
                p.Write((int)0); //petfamilyid

                //this is a loop of the item display slots, to do when implementing items
                for (int i = 0; i < 23; ++i)
                {
                    p.Write((int)0); //item display
                    p.Write((byte)0); //inventory type
                    p.Write((int)0); //enchantment
                }
            }


            return Task.FromResult(p);
        }

        #region Customisation

        public byte Skin
        {
            get { return _GetByte((int)EUnitFields.PLAYER_BYTES, 0); }
            set { SetByte((int)EUnitFields.PLAYER_BYTES, 0, value); }
        }
        public byte Face
        {
            get { return _GetByte((int)EUnitFields.PLAYER_BYTES, 1); }
            set { SetByte((int)EUnitFields.PLAYER_BYTES, 1, value); }
        }
        public byte HairStyle
        {
            get { return _GetByte((int)EUnitFields.PLAYER_BYTES, 2); }
            set { SetByte((int)EUnitFields.PLAYER_BYTES, 2, value); }
        }
        public byte HairColor
        {
            get { return _GetByte((int)EUnitFields.PLAYER_BYTES, 3); }
            set { SetByte((int)EUnitFields.PLAYER_BYTES, 3, value); }
        }
        public byte FacialHair
        {
            get { return _GetByte((int)EUnitFields.PLAYER_BYTES_2, 0); }
            set { SetByte((int)EUnitFields.PLAYER_BYTES_2, 0, value); }
        }
 

        #endregion

        public override Task<bool> IsCellActivator() { return Task.FromResult(true); }

        public async Task Login()
        {
            await OnLogin();

            PacketOut p = new PacketOut(RealmOp.MSG_SET_DUNGEON_DIFFICULTY);

            p.Reset(RealmOp.MSG_SET_DUNGEON_DIFFICULTY);
            p.Write((UInt32)0); //difficulty
            p.Write((UInt32)1); //val
            p.Write((UInt32)0); //isingroup
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_LOGIN_VERIFY_WORLD);
            p.Write(State.MapID);
            p.Write(State.PositionX);
            p.Write(State.PositionY);
            p.Write(State.PositionZ);
            p.Write(State.Orientation);
            await SendPacket(p);

            await _Account.SendAccountDataTimes(0xEA);

            p.Reset(RealmOp.SMSG_FEATURE_SYSTEM_STATUS);
            p.Write((byte)2);
            p.Write((byte)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_MOTD);
            p.Write((UInt32)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_LEARNED_DANCE_MOVES);
            p.Write((UInt32)0);
            p.Write((UInt32)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_CONTACT_LIST);
            p.Write((UInt32)7); //update all
            p.Write((UInt32)0); //nothing yet
            await SendPacket(p);

            await SendBindPointUpdate();

            p.Reset(RealmOp.SMSG_TALENTS_INFO);
            p.Write((byte)0);
            p.Write((UInt32)0);
            p.Write((byte)0);
            p.Write((byte)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_INSTANCE_DIFFICULTY);
            p.Write((UInt32)0);
            p.Write((UInt32)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_INITIAL_SPELLS);
            p.Write((byte)0);
            p.Write((UInt16)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_SEND_UNLEARN_SPELLS);
            p.Write((UInt32)0);
            await SendPacket(p);

            await SendActionButtons();


            p.Reset(RealmOp.SMSG_INITIALIZE_FACTIONS);
            p.Write((UInt32)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_LOGIN_SETTIMESPEED);
            p.WriteWTime(DateTime.Now);
            p.Write((float)0.01666667f);
            p.Write((UInt32)0);
            await SendPacket(p);

       
            p.Reset(RealmOp.SMSG_SEND_UNLEARN_SPELLS);
            p.Write((UInt32)0);
            await SendPacket(p);

            p.Reset(RealmOp.SMSG_SET_FORCED_REACTIONS);
            p.Write((UInt32)0);
            await SendPacket(p);

            //add us to our map
            var realm_manager = GrainFactory.GetGrain<IRealmManager>(0);
            var map = await realm_manager.GetMap(State.MapID, State.InstanceID, State.RealmID);

            await map.AddObject(ToRef());
        }

        public async Task SendBindPointUpdate()
        {
            PacketOut p = new PacketOut(RealmOp.SMSG_BINDPOINTUPDATE);
            p.Write(State.BindX);
            p.Write(State.BindY);
            p.Write(State.BindZ);
            p.Write(State.BindMap);
            p.Write(State.BindArea);
            await SendPacket(p);
        }

        public async Task BuildInitialUpdate()
        {
            var update = await BuildCreateUpdateFor(this as IPlayer);

            PacketOut pkt = new PacketOut(RealmOp.SMSG_UPDATE_OBJECT);
            pkt.Write((UInt32)1);
            pkt.Write(update);
            await SendPacket(pkt);

            await SendTimeSyncReq();
            await SendLoginEffect();
            await SendAuraUpdateAll();
        }

        public async Task SendActionButtons()
        {
            PacketOut pkt = new PacketOut(RealmOp.SMSG_ACTION_BUTTONS);

            pkt.Write((byte)1);

            for (var i = 0; i < 144; ++i)
                pkt.Write((UInt32)0);

            await SendPacket(pkt);
        }

        public async Task SendTimeSyncReq()
        {
            PacketOut pkt = new PacketOut(RealmOp.SMSG_TIME_SYNC_REQ);
            pkt.Write(TimeSyncCounter);
            TimeSyncCounter += 1;
            await SendPacket(pkt);
        }

        public async Task SendLoginEffect()
        {
            PacketOut p = new PacketOut(RealmOp.SMSG_SPELL_GO);
            p.Write(pGUID); //caster
            p.Write(pGUID); //target?
            p.Write((byte)1); //counter
            p.Write((UInt32)836); //LOGINEFFECT
            p.Write((UInt32)256); //flags
            p.Write(Time.GetMSTime());
            p.Write((byte)1); //hit 1 person
            p.Write(oGUID); //hit me
            p.Write((byte)0); //missed 0 people
            p.Write((UInt32)2); //targetmask unit
            p.Write(pGUID); //targetted unit was me
            await SendPacket(p);
        }

        public async Task SendAuraUpdateAll()
        {
            PacketOut p = new PacketOut(RealmOp.SMSG_AURA_UPDATE_ALL);
            p.Write(pGUID);
            await SendPacket(p);
        }

        public void CalulateMaxHealth()
        {
            //
        }

        public override async Task OnAddInRangeObject(ObjectGUID guid, IObjectImpl obj)
        {
            State.PendingUpdateData.Add(await obj.BuildCreateUpdateFor(this as IPlayer));
        }

        public override async Task Update()
        {
            await base.Update();

            await BuildPendingUpdateData();
        }

        public async Task BuildPendingUpdateData()
        {
            List<Task> tasks = new List<Task>();
            PacketOut pkt = new PacketOut(RealmOp.SMSG_UPDATE_OBJECT);
            foreach (var updatedata in State.PendingUpdateData)
            {
                pkt.Reset(RealmOp.SMSG_UPDATE_OBJECT);
                pkt.Write((UInt32)1);
                pkt.Write(updatedata);
                tasks.Add(SendPacket(pkt));
            }

            State.PendingUpdateData.Clear();

            await Task.WhenAll(tasks);
        }
    }
}
