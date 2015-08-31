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
    public class CreatureData : UnitData
    {
        public Int32 Entry = -1;
        public Int32 Template = -1;
    }

    public class CreatureImpl : Creature<CreatureData>, ICreature { }
    public class Creature<T> : Unit<T>, ICreatureImpl
        where T : CreatureData
    {

        public async override Task OnActivateAsync()
        {
            await base.OnActivateAsync();
            await OnConstruct();
        }

        public async Task Create(CreatureEntry entry)
        {
            var datastore = GrainFactory.GetGrain<IDataStoreManager>(0);

            var template = await datastore.GetCreatureTemplate(entry.id);

            if (template == null)
                return;

            State.Entry = (Int32)entry.guid;
            State.Template = (Int32)entry.id;

            State.PositionX = entry.position_x;
            State.PositionY = entry.position_y;
            State.PositionZ = entry.position_z;
            State.Orientation = entry.orientation;

            await CreateUpdateFieldsByType(ObjectType.Creature);

            State.Exists = true;

            await OnConstruct();
        }
        
        public override async Task OnConstruct()
        {
            await base.OnConstruct();

            if (!_IsValid())
                return;

            State.MyType = TypeID.TYPEID_UNIT;

            var datastore = GrainFactory.GetGrain<IDataStoreManager>(0);
            
            if (State.Template != -1)
            {
                var template = await datastore.GetCreatureTemplate((UInt32)State.Template);

                if (template != null)
                {
                    await SetUInt32(EUnitFields.UNIT_NPC_FLAGS, template.npcflag);
                    await SetFaction((int)template.faction);
                    await SetNativeDisplayID((int)template.modelid1);
                    await SetDisplayID((int)template.modelid1);
                    await SetClass((byte)template.unit_class);
                }
            }

            if (State.Entry != -1)
            {
                var entry = await datastore.GetCreatureEntry((UInt32)State.Entry);

                if (entry != null)
                {
                    await SetNativeDisplayID((int)entry.modelid);
                    await SetDisplayID((int)entry.modelid);
                }
            }

            //some defaults for now
            await SetUInt32((int)EUnitFields.UNIT_FIELD_HEALTH, 100);
        }
    }
}
