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
        Task<byte> GetByte(int field, int index);
        Task<UInt32> GetUInt32(int field);
        Task<float> GetFloat(UInt32 field);
        Task SetByte(int field, int index, byte val);
        Task SetUInt32(int field, UInt32 val);
        Task SetInt32(int field, int val);
        Task SetFloat(int field, float val);
        Task SetUInt64(int field, UInt64 val);
        Task SetGUID(int field, ObjectGUID val);

        //Maps
        Task<IMap> GetMap();
        Task SetMap(IMap map);
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
