using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
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


        Task<IObjectImpl> GetObject(ObjectGUID guid);
        Task<MapAddResult> AddObject(IObjectImpl obj);
        Task RemoveObject(ObjectGUID guid, IObjectImpl obj);
        Task UpdateInRangeObject(IObjectImpl obj, List<ObjectGUID> ignoreGuids);

        Task OnCellActivate(IMapCell cell);
        Task OnCellDeactivate(IMapCell cell);

        Task OnObjectUpdated(ObjectGUID guid);
        Task<UInt64> OnActivatorMove(IObjectImpl obj, float oldx, float oldy, float newx, float newy);

        Task SpawnCreatures(CreatureEntry[] creatures);
    }
}