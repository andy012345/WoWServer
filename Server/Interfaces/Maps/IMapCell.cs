using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System;
using Server;
using Shared;

namespace Server
{
    public interface IMapCell : IGrainWithIntegerKey
    {
        Task Init(UInt32 cellx, UInt32 celly, IMap parent);
        Task AddObject(ObjectGUID guid, IObjectImpl obj);
        Task RemoveObject(ObjectGUID guid, IObjectImpl obj);
        Task AddRef();
        Task DecRef();

        Task Update();

        Task Create(UInt32 InstanceID, UInt32 cellx, UInt32 celly);

        Task<bool> IsValid();

        Task UpdateInRange(IObjectImpl obj);
    }
}