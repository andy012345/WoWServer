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
    [Flags]
    public enum HighGuid
    {
        HIGHGUID_ITEM = 0x4000,                      // blizz 4000
        HIGHGUID_CONTAINER = 0x4000,                      // blizz 4000
        HIGHGUID_PLAYER = 0x0000,                      // blizz 0000
        HIGHGUID_GAMEOBJECT = 0xF110,                      // blizz F110
        HIGHGUID_TRANSPORT = 0xF120,                      // blizz F120 (for GAMEOBJECT_TYPE_TRANSPORT)
        HIGHGUID_UNIT = 0xF130,                      // blizz F130
        HIGHGUID_PET = 0xF140,                      // blizz F140
        HIGHGUID_VEHICLE = 0xF150,                      // blizz F550
        HIGHGUID_DYNAMICOBJECT = 0xF100,                      // blizz F100
        HIGHGUID_CORPSE = 0xF101,                      // blizz F100
        HIGHGUID_MO_TRANSPORT = 0x1FC0,                      // blizz 1FC0 (for GAMEOBJECT_TYPE_MO_TRANSPORT)
        HIGHGUID_INSTANCE = 0x1F40,                      // blizz 1F40
        HIGHGUID_GROUP = 0x1F50
    };

    public class ObjectCreatorState : GrainState
    {
        UInt64 _MaxPlayerGuid = 1;
        UInt64 _MaxCreatureGuid = 1;
        UInt64 _MaxObjectGuid = 1;
        UInt32 _MaxInstanceGuid = 1;

        public UInt64 MaxPlayerGUID { get { return _MaxPlayerGuid; } set { _MaxPlayerGuid = value; } }
        public UInt64 MaxCreatureGUID { get { return _MaxCreatureGuid; } set { _MaxCreatureGuid = value; } }
        public UInt64 MaxObjectGUID { get { return _MaxObjectGuid; } set { _MaxObjectGuid = value; } }
        public UInt32 MaxInstanceGUID { get { return _MaxInstanceGuid; } set { _MaxInstanceGuid = value; } }
    }

    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    class ObjectCreator : Grain<ObjectCreatorState>, ICreator
    {
        IDisposable SaveTask = null;
        public double SavePeriodSeconds = 30;

        public override Task OnActivateAsync()
        {
            SaveTask = RegisterTimer(SaveState, null, TimeSpan.FromSeconds(SavePeriodSeconds), TimeSpan.FromSeconds(SavePeriodSeconds));
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
                case ObjectType.Player: return await GeneratePlayerGUID();
                default: return new ObjectGUID(0);
            }
        }

        public Task<ObjectGUID> GenerateCreatureGUID(UInt32 Entry)
        {
            UInt64 counter = State.MaxCreatureGUID;
            UInt64 entry64 = (UInt64)Entry;
            State.MaxCreatureGUID += 1;

            UInt64 highguid = (UInt64)HighGuid.HIGHGUID_UNIT;
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
            var guid = new ObjectGUID(State.MaxPlayerGUID | (UInt64)HighGuid.HIGHGUID_PLAYER);
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
