using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System;
using Server;
using Shared;

namespace Server
{
    public interface IObject : IObjectImpl { }

    public interface IObjectImpl : IBaseObjectImpl
    {
        Task<string> VirtualCall();
        Task<string> ObjectCall();
        Task Save();

        Task<bool> IsValid();

        Task<ObjectGUID> GetGUID();
        Task<PackedGUID> GetPackedGUID();

        Task<float> GetPositionX();
        Task<float> GetPositionY();
        Task<float> GetPositionZ();
        Task<float> GetOrientation();

        Task UpdateInRangeSet();
        Task UpdateInRangeSet_Add();
        Task UpdateInRangeSet_Remove();
        Task RemoveInRangeObject(ObjectGUID guid, IObjectImpl obj, bool remove_other = true);
        Task AddInRangeObject(ObjectGUID guid, IObjectImpl obj, bool add_other = true);
        Task<bool> CanSee(IObjectImpl other);

        Task<PacketOut> BuildCreateUpdateFor(IPlayer plr);
        Task<PacketOut> BuildValuesUpdateFor(IPlayer plr);

        Task Update();


        //Update FIelds
        Task<byte> GetByte(object field, int index);
        Task<UInt32> GetUInt32(object field);
        Task<float> GetFloat(object field);
        Task SetByte(object field, int index, byte val);
        Task SetUInt32(object field, UInt32 val);
        Task SetInt32(object field, int val);
        Task SetFloat(object field, float val);
        Task SetUInt64(object field, UInt64 val);
        Task SetGUID(object field, ObjectGUID val);

        //Maps
        Task<IMap> GetMap();
        Task SetMap(IMap map);
        Task SetCell(UInt64 cellkey);
        Task<UInt64> GetCell();
        Task ClearMap();
        Task<bool> IsCellActivator();

        Task<bool> IsPlayer();
        Task<bool> IsUnit();
        Task<bool> IsCreature();
        Task<bool> IsPet();
        Task<bool> IsVehicle();
        Task<bool> IsTransport();
        Task<bool> IsGameObject();
    }

    public interface IBaseObjectImpl : IGrainWithIntegerKey
    {

    }
}
