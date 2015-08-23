using Orleans;
using Orleans.Providers;
using Orleans.Concurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public class MapState : GrainState
    {
        public UInt32 MapID { get; set; }
        public UInt32 InstanceID { get; set; } //our index accessor
        public UInt32 RealmID { get; set; } //for non instanced maps
        public UInt32 ExpireTime { get; set; }
        public bool Exists { get; set; }
    }



    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    public partial class Map : Grain<MapState>, IMap
    {
        Dictionary<ObjectGUID, IObjectImpl> objectMap = new Dictionary<ObjectGUID, IObjectImpl>();
        List<IObjectImpl> activeObjects = new List<IObjectImpl>();
        IDisposable UpdateTask = null;
        List<IObjectImpl> updateObjects = new List<IObjectImpl>();
        Dictionary<UInt64, List<CreatureEntry>> CreatureEntryByCellKey = new Dictionary<ulong, List<CreatureEntry>>();

        public override async Task OnActivateAsync()
        {
            if (_IsValid())
                await OnConstruct();
            await base.OnActivateAsync();
        }

        public async Task Create(UInt32 MapID, UInt32 InstanceID, UInt32 RealmID)
        {
            if (_IsValid()) //already created
                return;

            State.MapID = MapID;
            State.InstanceID = InstanceID;
            State.RealmID = RealmID;

            State.Exists = true;
            await OnConstruct();
            await Save();
        }

        public async Task OnConstruct()
        {
            await InitMapCells();

            List<Task> tasks = new List<Task>();

            IDataStoreManager datastore = GrainFactory.GetGrain<IDataStoreManager>(0);

            //get all creatures for my map!
            var creatures = await datastore.GetCreatureEntriesByMap(State.MapID);

            //add them to their cells
            foreach (var cre in creatures)
            {
                var cellkey = GetCellKey(cre.position_x, cre.position_y);

                if (CreatureEntryByCellKey.ContainsKey(cellkey))
                    CreatureEntryByCellKey[cellkey].Add(cre);
                else
                {
                    List<CreatureEntry> l = new List<CreatureEntry>();
                    l.Add(cre);
                    CreatureEntryByCellKey.Add(cellkey, l);
                }
            }

            UpdateTask = RegisterTimer(Update, null, TimeSpan.FromMilliseconds(100), TimeSpan.FromMilliseconds(100));

            await Task.WhenAll(tasks);
        }

        public bool _IsValid() { return State.Exists; }
        public Task<bool> IsValid() { return Task.FromResult(_IsValid()); }
        public async Task Save() { if (_IsValid()) return; await WriteStateAsync(); }

        public IObjectImpl GetObjectByGUID(ObjectGUID guid)
        {
            IObjectImpl ret = null;
            objectMap.TryGetValue(guid, out ret);
            return ret;
        }

        public IObjectImpl GetObjectByGUID(UInt64 guid)
        {
            return GetObjectByGUID(new ObjectGUID(guid));
        }

        public Task<UInt32> GetMapID() { return Task.FromResult(State.MapID); }
        public Task<UInt32> GetInstanceID() { return Task.FromResult(State.InstanceID); }

        public async Task<bool> AddObject(IObjectImpl obj)
        {
            List<Task> tasks = new List<Task>();
            var guid = await obj.GetGUID();

            var isactivator = await obj.IsCellActivator();

            var posx = await obj.GetPositionX();
            var posy = await obj.GetPositionY();
            var cell = await GetCell(posx, posy, true);

            ServerLog.Debug("Adding {0} to map {1} instance {2} at {3}, {4}", guid.ToUInt64(), State.MapID, State.InstanceID, posx, posy);


            if (cell == null)
                return false;

            objectMap.Add(guid, obj);
            tasks.Add(obj.SetMap(this));
            //await obj.SetCell(cell);

            tasks.Add(cell.AddObject(guid, obj));

            if (isactivator)
            {
                activeObjects.Add(obj);
                 tasks.Add(AddRefCells(posx, posy));
            }

            await Task.WhenAll(tasks);

            return true;
        }

        //Returns a key of the cell ((x << 32) | y) and updates cell references
        public async Task<UInt64> OnActivatorMove(IObjectImpl obj, float oldx, float oldy, float newx, float newy)
        {
            var old_cell = GetCell(oldx, oldy);
            var new_cell = GetCell(newx, newy);

            if (old_cell != new_cell)
            {
                await AddRefCells(newx, newy);
                await DecRefCells(oldx, oldy);
            }

            if (new_cell != null)
                return GetCellKey(newx, newy);

            return 0;
        }

        public async Task OnObjectMove(IObjectImpl obj, float oldx, float oldy, float newx, float newy)
        {
            //this activates and deactivates cells
            var is_activator = await obj.IsCellActivator();
            
            if (is_activator)
                await OnActivatorMove(obj, oldx, oldy, newx, newy);
        }

        private async Task AddRefCells(float posx, float posy)
        {
            List<Task> tasks = new List<Task>();

            var cellx = GetCellX(posx);
            var celly = GetCellY(posy);


            for (var x = cellx - 1; x < cellx + 1; ++x)
            {
                for (var y = celly - 1; x < celly + 1; ++y)
                {
                    var cell = await GetCellDirect(x, y, true);

                    if (cell != null)
                        tasks.Add(cell.AddRef());
                }
            }

            await Task.WhenAll(tasks);
        }

        private async Task DecRefCells(float posx, float posy)
        {
            List<Task> tasks = new List<Task>();
            var cellx = GetCellX(posx);
            var celly = GetCellY(posy);

            for (var x = cellx - 1; x < cellx + 1; ++x)
            {
                for (var y = celly - 1; x < celly + 1; ++y)
                {
                    var cell = await GetCellDirect(x, y, true);

                    if (cell != null)
                        tasks.Add(cell.DecRef());
                }
            }

            await Task.WhenAll(tasks);
        }

        public async Task RemoveObject(IObjectImpl obj)
        {
            activeObjects.Remove(obj);

            var isactivator = await obj.IsCellActivator();
            var posx = await obj.GetPositionX();
            var posy = await obj.GetPositionY();

            if (isactivator)
            {
                activeObjects.Remove(obj);
                await DecRefCells(posx, posy);
            }
            var cell = await GetCell(posx, posy);

            if (cell != null)
            {
                await cell.RemoveObject(await obj.GetGUID());
            }
        }

        public async Task SpawnCreatures(CreatureEntry[] cres)
        {
            List<ICreature> creaturespawns = new List<ICreature>();
            List<Task> tasks = new List<Task>();

            var creator = GrainFactory.GetGrain<ICreator>(0);
            foreach (var cre in cres)
            {
                var guid = await creator.GenerateCreatureGUID(cre.id);

                ServerLog.Debug("Spawning creature {0} due to cell activation", cre.guid);

                var creature = GrainFactory.GetGrain<ICreature>(guid.ToInt64());
                creaturespawns.Add(creature);
                tasks.Add(creature.Create(cre));
            }

            await Task.WhenAll(tasks);

            foreach (var c in creaturespawns)
                tasks.Add(AddObject(c));

            await Task.WhenAll(tasks);
        }

        public async Task UpdateInRangeObject(IObjectImpl obj)
        {
            var posx = await obj.GetPositionX();
            var posy = await obj.GetPositionY();
            var cellx = GetCellX(posx);
            var celly = GetCellY(posy);

            var player = await obj.IsPlayer();

            if (player)
                ServerLog.Debug("Updating inrange for player");

             for (var x = cellx - 1; x < cellx + 1; ++x)
             {
                 for (var y = celly - 1; y < celly + 1; ++y)
                 {
                    var cell = await GetCellDirect(x, y);

                    if (cell != null)
                    {
                        foreach (var o in (await cell.GetObjectMap()))
                        {
                            var cansee = await obj.CanSee(o.Value);

                            if (cansee)
                                await obj.AddInRangeObject(o.Key, o.Value);
                        }
                    }
                }
            }
        }

        public Task OnObjectUpdated(IObjectImpl obj)
        {
            updateObjects.Add(obj);
            return TaskDone.Done;
        }

        public async Task Update(object state)
        {
            List<Task> UpdateTasks = new List<Task>();
            foreach (var obj in activeObjects)
            {
                UpdateTasks.Add(obj.Update());
            }

            await Task.WhenAll(UpdateTasks);
        }
    }
}
