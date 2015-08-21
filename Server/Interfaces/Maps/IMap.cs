using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System;
using Server;
using Shared;

namespace Server
{
    public interface IMap : IGrainWithIntegerKey
    {
        Task<bool> IsValid();
        Task<UInt32> GetMapID();
        Task<UInt32> GetInstanceID();
        Task Create(UInt32 MapID, UInt32 InstanceID, UInt32 RealmID);

        Task<bool> AddObject(IObjectImpl obj);
        Task UpdateInRangeObject(IObjectImpl obj);

        Task OnObjectUpdated(IObjectImpl obj);

        Task SpawnCreatures(CreatureEntry[] creatures);
    }
}
