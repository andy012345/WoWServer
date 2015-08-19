using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CreatureTemplate
    {
        public UInt32 entry;
        public UInt32 difficulty_entry_1;
        public UInt32 difficulty_entry_2;
        public UInt32 difficulty_entry_3;
        public UInt32 KillCredit1;
        public UInt32 KillCredit2;
        public UInt32 modelid1;
        public UInt32 modelid2;
        public UInt32 modelid3;
        public UInt32 modelid4;
        public string name;
        public string subname;
        public string IconName;
        public UInt32 gossip_menu_id;
        public UInt32 minlevel;
        public UInt32 maxlevel;
        public UInt32 exp;
        public UInt32 faction;
        public UInt32 npcflag;
        public float speed_walk;
        public float speed_run;
        public float scale;
        public UInt32 rank;
        public UInt32 dmgschool;
        public UInt32 BaseAttackTime;
        public UInt32 RangeAttackTime;
        public UInt32 BaseVariance;
        public UInt32 RangeVariance;
        public UInt32 unit_class;
        public UInt32 unit_flags;
        public UInt32 unit_flags2;
        public UInt32 dynamicflags;
        public UInt32 family;
        public UInt32 trainer_type;
        public UInt32 trainer_spell;
        public UInt32 trainer_class;
        public UInt32 trainer_race;
        public UInt32 type;
        public UInt32 type_flags;
        public UInt32 lootid;
        public UInt32 pickpocketloot;
        public UInt32 skinloot;
        public Int32 resistance1;
        public Int32 resistance2;
        public Int32 resistance3;
        public Int32 resistance4;
        public Int32 resistance5;
        public Int32 resistance6;
        public UInt32 spell1;
        public UInt32 spell2;
        public UInt32 spell3;
        public UInt32 spell4;
        public UInt32 spell5;
        public UInt32 spell6;
        public UInt32 spell7;
        public UInt32 spell8;
        public UInt32 PetSpellDataId;
        public UInt32 VehicleId;
        public UInt32 mingold;
        public UInt32 maxgold;
        public string AIName;
        public UInt32 MovementType;
        public UInt32 InhabitType;
        public float HoverHeight;
        public float HealthModifier;
        public float ManaModifier;
        public float ArmorModifier;
        public float DamageModifier;
        public float ExperienceModifier;
        public UInt32 RacialLeader;
        public UInt32 movementId;
        public UInt32 RegenHealth;
        public UInt32 mechanic_immune_mask;
        public int flags_extra;
        public string ScriptName;
        public Int32 VerifiedBuild;
    }

    public class CreatureEntry
    {
        public UInt32 guid;
        public UInt32 id;
        public UInt32 map;
        public UInt32 zoneId;
        public UInt32 areaId;
        public UInt32 spawnMask;
        public UInt32 phaseMask;
        public UInt32 modelid;
        public Int32 equipment_id;
        public float position_x;
        public float position_y;
        public float position_z;
        public float orientation;
        public UInt32 spawntimesecs;
        public UInt32 spawndist;
        public UInt32 currentwaypoint;
        public UInt32 curhealth;
        public UInt32 curmana;
        public UInt32 MovementType;
        public UInt32 npcflag;
        public UInt32 unit_flags;
        public UInt32 dynamicflags;
        public Int32 VerifiedBuild;
    }
}
