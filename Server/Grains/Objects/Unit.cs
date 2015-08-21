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

    public class UnitImpl : Unit<UnitData>, IUnit { }
    public class Unit<T> : Object<T>, IUnitImpl
        where T : UnitData
    {
        public override Task<string> VirtualCall() { return Task.FromResult("Virtual call from unit"); }
        public Task<string> UnitCall() { return Task.FromResult("Call from unit"); }

        public async override Task OnActivateAsync()
        {
            await base.OnActivateAsync();
            State.UpdateFlags = ObjectUpdateFlags.UPDATEFLAG_LIVING | ObjectUpdateFlags.UPDATEFLAG_STATIONARY_POSITION;
        }


        #region Unitfield Getters and Setters
        public int DisplayID
        {
            get { return _GetInt32((int)EUnitFields.UNIT_FIELD_DISPLAYID); }
            set { SetInt32((int)EUnitFields.UNIT_FIELD_DISPLAYID, value); }
        }

        public int NativeDisplayID
        {
            get { return _GetInt32((int)EUnitFields.UNIT_FIELD_NATIVEDISPLAYID); }
            set { SetInt32((int)EUnitFields.UNIT_FIELD_NATIVEDISPLAYID, value); }
        }

        public int Faction
        {
            get { return _GetInt32((int)EUnitFields.UNIT_FIELD_FACTIONTEMPLATE); }
            set { SetInt32((int)EUnitFields.UNIT_FIELD_FACTIONTEMPLATE, value); }
        }

        public byte Gender
        {
            get { return _GetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 2); }
            set { SetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 2, value); }
        }
        public byte Race
        {
            get { return _GetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 0); }
            set { SetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 0, value); }
        }
        public byte Class
        {
            get { return _GetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 1); }
            set { SetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 1, value); }
        }
        public byte PowerType
        {
            get { return _GetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 3); }
            set { SetByte((int)EUnitFields.UNIT_FIELD_BYTES_0, 3, value); }
        }

        public UInt32 BaseHealth
        {
            get { return _GetUInt32((int)EUnitFields.UNIT_FIELD_BASE_HEALTH); }
            set { SetUInt32((int)EUnitFields.UNIT_FIELD_BASE_HEALTH, value); }
        }

        public Task<int> GetDisplayID() { return Task.FromResult(DisplayID); }
        public Task<int> GetNativeDisplayID() { return Task.FromResult(NativeDisplayID); }

        public override bool _IsUnit() { return true; }

        #endregion
    }
}
