using Orleans;
using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public class UnitData : ObjectData
    {
        public int unit_test { get; set; }
    }

    public class UnitImpl : Unit<UnitData>, IUnit
    {
    }

    public class Unit<T> : Object<T>, IUnitImpl
        where T : UnitData
    {
        public override Task<string> VirtualCall()
        {
            return Task.FromResult("Virtual call from unit");
        }

        public Task<string> UnitCall()
        {
            return Task.FromResult("Call from unit");
        }

        public override async Task OnActivateAsync()
        {
            await base.OnActivateAsync();
            State.UpdateFlags = ObjectUpdateFlags.UPDATEFLAG_LIVING | ObjectUpdateFlags.UPDATEFLAG_STATIONARY_POSITION;
        }

        public async Task SetDisplayID(int val)
        {
            await SetInt32(EUnitFields.UNIT_FIELD_DISPLAYID, val);
        }

        public async Task SetNativeDisplayID(int val)
        {
            await SetInt32(EUnitFields.UNIT_FIELD_NATIVEDISPLAYID, val);
        }

        public async Task SetFaction(int val)
        {
            await SetInt32(EUnitFields.UNIT_FIELD_FACTIONTEMPLATE, val);
        }

        public async Task SetRace(byte val)
        {
            await SetByte(EUnitFields.UNIT_FIELD_BYTES_0, 0, val);
        }

        public async Task SetClass(byte val)
        {
            await SetByte(EUnitFields.UNIT_FIELD_BYTES_0, 1, val);
        }

        public async Task SetGender(byte val)
        {
            await SetByte(EUnitFields.UNIT_FIELD_BYTES_0, 2, val);
        }

        public async Task SetPowerType(byte val)
        {
            await SetByte(EUnitFields.UNIT_FIELD_BYTES_0, 3, val);
        }

        public async Task SetBaseHealth(UInt32 val)
        {
            await SetUInt32(EUnitFields.UNIT_FIELD_BASE_HEALTH, val);
        }

        public async Task SetHealth(UInt32 val)
        {
            await SetUInt32(EUnitFields.UNIT_FIELD_HEALTH, val);
        }

        public async Task SetMaxHealth(UInt32 val)
        {
            await SetUInt32(EUnitFields.UNIT_FIELD_MAXHEALTH, val);
        }


        public Task<int> GetDisplayID()
        {
            return Task.FromResult(_GetDisplayID());
        }

        public Task<int> GetNativeDisplayID()
        {
            return Task.FromResult(_GetNativeDisplayID());
        }

        protected int _GetDisplayID()
        {
            return _GetInt32(EUnitFields.UNIT_FIELD_DISPLAYID);
        }

        protected int _GetNativeDisplayID()
        {
            return _GetInt32(EUnitFields.UNIT_FIELD_NATIVEDISPLAYID);
        }

        protected byte _GetRace()
        {
            return _GetByte(EUnitFields.UNIT_FIELD_BYTES_0, 0);
        }

        protected byte _GetClass()
        {
            return _GetByte(EUnitFields.UNIT_FIELD_BYTES_0, 1);
        }

        protected byte _GetGender()
        {
            return _GetByte(EUnitFields.UNIT_FIELD_BYTES_0, 2);
        }

        protected byte _GetPowerType()
        {
            return _GetByte(EUnitFields.UNIT_FIELD_BYTES_0, 3);
        }

        public Task<byte> GetRace()
        {
            return Task.FromResult(_GetRace());
        }

        public Task<byte> GetClass()
        {
            return Task.FromResult(_GetClass());
        }

        public Task<byte> GetGender()
        {
            return Task.FromResult(_GetGender());
        }

        public Task<byte> GetPowerType()
        {
            return Task.FromResult(_GetPowerType());
        }


        public override bool _IsUnit()
        {
            return true;
        }
    }
}