using System.Threading.Tasks;
using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Linq;
using Shared;
using System.Runtime.InteropServices;

namespace Server
{
    public class SpellStore : DBCStore<SpellEntry>
    {
        public SpellEntry Get(UInt32 SpellID)
        {
            return Get((int) SpellID);
        }
    }

    public enum SpellEnums
    {
        MaxSpellReagents = 8,
        MaxSpellEffects = 3,
    }

    public class SpellEntry : DBCRecordBase
    {
        private UInt32 Id = 0;
        private UInt32 Category;
        private UInt32 Dispel;
        private UInt32 Mechanic;
        private UInt32 Attributes;
        private UInt32 AttributesEx;
        private UInt32 AttributesEx2;
        private UInt32 AttributesEx3;
        private UInt32 AttributesEx4;
        private UInt32 AttributesEx5;
        private UInt32 AttributesEx6;
        private UInt32 AttributesEx7;
        private UInt32 Stances;
        private UInt32 StancesNot;
        private UInt32 Targets;

        private UInt32 TargetCreatureType;
        private UInt32 RequiresSpellFocus;
        private UInt32 FacingCasterFlags;
        private UInt32 CasterAuraState;
        private UInt32 TargetAuraState;
        private UInt32 CasterAuraStateNot;
        private UInt32 TargetAuraStateNot;
        private UInt32 CasterAuraSpell;
        private UInt32 TargetAuraSpell;
        private UInt32 ExcludeCasterAuraSpell;
        private UInt32 ExcludeTargetAuraSpell;
        private UInt32 CastingTimeIndex;
        private UInt32 RecoveryTime;
        private UInt32 CategoryRecoveryTime;
        private UInt32 InterruptFlags;
        private UInt32 AuraInterruptFlags;
        private UInt32 ChannelInterruptFlags;
        private UInt32 ProcFlags;
        private UInt32 ProcChance;
        private UInt32 ProcCharges;
        private UInt32 MaxLevel;
        private UInt32 BaseLevel;
        private UInt32 SpellLevel;
        private UInt32 DurationIndex;
        private UInt32 PowerType;
        private UInt32 ManaCost;
        private UInt32 ManaCostPerLevel;
        private UInt32 ManaPerSecond;
        private UInt32 ManaPerSecondPerLevel;
        private UInt32 RangeIndex;
        private float Speed;
        private UInt32 ModalNextSpell;
        private UInt32 StackAmount;
        private UInt32[] Totem = new UInt32[2];
        //Int32[] Reagent = new Int32[SpellEnums.MaxSpellReagents];


        public override int Read()
        {
            //            char const SpellEntryfmt[] = "niiiiiiiiiiiixixiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiifxiiiiiiiiiiiiiiiiiiiiiiiiiiiifffiiiiiiiiiiiiiiiiiiiiifffiiiiiiiiiiiiiiifffiiiiiiiiiiiiixssssssssssssssssxssssssssssssssssxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxiiiiiiiiiiixfffxxxiiiiixxfffxx";
            var i = 0;

            Id = GetUInt32(i++);
            Category = GetUInt32(i++);
            Dispel = GetUInt32(i++);
            Mechanic = GetUInt32(i++);
            Attributes = GetUInt32(i++);
            AttributesEx = GetUInt32(i++);
            AttributesEx2 = GetUInt32(i++);
            AttributesEx3 = GetUInt32(i++);
            AttributesEx4 = GetUInt32(i++);
            AttributesEx5 = GetUInt32(i++);
            AttributesEx6 = GetUInt32(i++);
            AttributesEx7 = GetUInt32(i++);
            Stances = GetUInt32(i++);
            i += 1; //ignore unk
            StancesNot = GetUInt32(i++);
            i += 1; //ignore unk
            Targets = GetUInt32(i++);
            TargetCreatureType = GetUInt32(i++);
            RequiresSpellFocus = GetUInt32(i++);
            FacingCasterFlags = GetUInt32(i++);
            CasterAuraState = GetUInt32(i++);
            TargetAuraState = GetUInt32(i++);
            CasterAuraStateNot = GetUInt32(i++);
            TargetAuraStateNot = GetUInt32(i++);
            CasterAuraSpell = GetUInt32(i++);
            TargetAuraSpell = GetUInt32(i++);
            ExcludeCasterAuraSpell = GetUInt32(i++);
            ExcludeTargetAuraSpell = GetUInt32(i++);
            CastingTimeIndex = GetUInt32(i++);
            RecoveryTime = GetUInt32(i++);
            CategoryRecoveryTime = GetUInt32(i++);
            InterruptFlags = GetUInt32(i++);


            return (int) Id;
        }
    }
}