using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System;
using Server;
using Shared;

namespace Server
{
    public interface IRealmManager : IGrainWithIntegerKey
    {
        Task<Realm> GetRealm(int id);
        Task<string> GetRealmName(int id);
        Task RemoveRealm(int id);
        Task AddRealm(RealmSettings r);
        Task<Realm[]> GetRealms(int AccountLevel = 0);
        Task PingRealm(int id);
        Task SetRealmOffline(int id);

        //maps
        Task<IMap> GetMap(UInt32 MapId, UInt32 InstanceID, UInt32 RealmID);
        Task<IMap> GetMap(UInt32 MapId, UInt32 RealmID);
    }
}