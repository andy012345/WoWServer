using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Orleans.Concurrency;
using Orleans.Providers;

namespace Server
{
    public class ObjectCreatorState : GrainState
    {
        private UInt64 _MaxPlayerGuid = 1;
        private UInt64 _MaxCreatureGuid = 1;
        private UInt64 _MaxObjectGuid = 1;
        private UInt32 _MaxInstanceGuid = 1;

        public UInt64 MaxPlayerGUID
        {
            get { return _MaxPlayerGuid; }
            set { _MaxPlayerGuid = value; }
        }

        public UInt64 MaxCreatureGUID
        {
            get { return _MaxCreatureGuid; }
            set { _MaxCreatureGuid = value; }
        }

        public UInt64 MaxObjectGUID
        {
            get { return _MaxObjectGuid; }
            set { _MaxObjectGuid = value; }
        }

        public UInt32 MaxInstanceGUID
        {
            get { return _MaxInstanceGuid; }
            set { _MaxInstanceGuid = value; }
        }
    }

    public class ObjectRetriever
    {
        public static IObjectImpl GetObject(IGrainFactory factory, ObjectGUID guid)
        {
            var highguid = guid.ToHighGUID();

            switch (highguid)
            {
                case HighGuid.HIGHGUID_UNIT:
                {
                    return factory.GetGrain<ICreature>(guid.ToInt64());
                }
                case HighGuid.HIGHGUID_PLAYER:
                {
                    return factory.GetGrain<IPlayer>(guid.ToInt64());
                }
            }

            return factory.GetGrain<IObject>(0);
        }
    }


    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    internal class ObjectCreator : Grain<ObjectCreatorState>, ICreator
    {
        private IDisposable SaveTask = null;
        public double SavePeriodSeconds = 30;

        public override Task OnActivateAsync()
        {
            SaveTask = RegisterTimer(SaveState, null, TimeSpan.FromSeconds(SavePeriodSeconds),
                TimeSpan.FromSeconds(SavePeriodSeconds));
            return base.OnActivateAsync();
        }

        public async Task SaveState(object state)
        {
            await WriteStateAsync();
        }


        public async Task<ObjectGUID> GenerateGUID(ObjectType objectType)
        {
            switch (objectType)
            {
                case ObjectType.Player:
                    return await GeneratePlayerGUID();
                default:
                    return new ObjectGUID(0);
            }
        }

        public Task<ObjectGUID> GenerateCreatureGUID(UInt32 Entry)
        {
            UInt64 counter = State.MaxCreatureGUID;
            UInt64 entry64 = (UInt64) Entry;
            State.MaxCreatureGUID += 1;

            UInt64 highguid = (UInt64) HighGuid.HIGHGUID_UNIT;
            return Task.FromResult(new ObjectGUID(highguid << 48 | (entry64 << 24) | counter));
        }

        public Task<UInt32> GenerateInstanceID()
        {
            var ret = State.MaxInstanceGUID;
            State.MaxInstanceGUID += 1;
            return Task.FromResult(ret);
        }

        private Task<ObjectGUID> GeneratePlayerGUID()
        {
            var guid = new ObjectGUID(State.MaxPlayerGUID | (UInt64) HighGuid.HIGHGUID_PLAYER);
            State.MaxPlayerGUID += 1;
            return Task.FromResult(guid);
        }

        public async Task<Tuple<LoginErrorCode, IPlayer>> CreatePlayer(PlayerCreateData info)
        {
            LoginErrorCode err = LoginErrorCode.CHAR_CREATE_SUCCESS;
            var guid = await GeneratePlayerGUID();
            var plr = GrainFactory.GetGrain<IPlayer>(guid.ToInt64());

            err = await plr.Create(info);

            var ret = new Tuple<LoginErrorCode, IPlayer>(err, err == LoginErrorCode.CHAR_CREATE_SUCCESS ? plr : null);
            return ret;
        }
    }
}