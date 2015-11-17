using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;
using Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server
{
    public class MapState : GrainState
    {
        public UInt32 MapID { get; set; }
        public UInt32 InstanceID { get; set; } //our index accessor
        public UInt32 RealmID { get; set; } //for non instanced maps
        public UInt32 ExpireTime { get; set; }

        public List<ObjectGUID> ObjectList { get; set; }
        public List<ObjectGUID> ActiveObjects { get; set; }
        public List<UInt64> ActiveCells { get; set; }
        public List<UInt64> CreatedCells { get; set; }
        public List<ObjectGUID> UpdatedObjects { get; set; }
        //objects which have a values update to push out from SMSG_UPDATE_OBJECT

        public bool Exists { get; set; }
    }


    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    public partial class Map : Grain<MapState>, IMap
    {
        public const UInt32 MapUpdateInterval = 100; //100ms
        public const UInt32 MapSaveInterval = 300000; //5m

        private IDisposable UpdateTask = null;
        private IDisposable SaveTask = null;

        private Dictionary<UInt64, List<CreatureEntry>> CreatureEntryByCellKey =
            new Dictionary<ulong, List<CreatureEntry>>();

        protected Dictionary<ObjectGUID, IObjectImpl> _objectCache = new Dictionary<ObjectGUID, IObjectImpl>();

        public override async Task OnActivateAsync()
        {
            if (_IsValid())
                await OnConstruct();
            await base.OnActivateAsync();
        }

        public override async Task OnDeactivateAsync()
        {
            await base.OnDeactivateAsync();
            if (_IsValid())
                await Save();
        }

        public async Task OnConstruct()
        {
            if (State.ObjectList == null)
                State.ObjectList = new List<ObjectGUID>();
            if (State.ActiveCells == null)
                State.ActiveCells = new List<UInt64>();
            if (State.CreatedCells == null)
                State.CreatedCells = new List<UInt64>();
            if (State.ActiveObjects == null)
                State.ActiveObjects = new List<ObjectGUID>();
            if (State.UpdatedObjects == null)
                State.UpdatedObjects = new List<ObjectGUID>();

            SetupUpdateTask();
            SetupSaveTask();

            List<Task> tasks = new List<Task>();


            foreach (var guid in State.ObjectList)
            {
                var obj = ObjectRetriever.GetObject(GrainFactory, guid);
                _objectCache.Add(guid, obj);
            }

            tasks.Add(LoadCreatureEntries());
            tasks.Add(InitMapCells());

            await Task.WhenAll(tasks);
        }

        private async Task LoadCreatureEntries()
        {
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

        public bool _IsValid()
        {
            return State.Exists;
        }

        public Task<bool> IsValid()
        {
            return Task.FromResult(_IsValid());
        }

        public async Task Save()
        {
            if (!_IsValid()) return;
            await WriteStateAsync();
        }

        public IObjectImpl GetObjectByGUID(ObjectGUID guid)
        {
            return GetObjectByGUID(guid.ToUInt64());
        }

        public IObjectImpl GetObjectByGUID(UInt64 guid)
        {
            return GrainFactory.GetGrain<IObjectImpl>((Int64) guid);
        }

        public Task<UInt32> GetMapID()
        {
            return Task.FromResult(State.MapID);
        }

        public Task<UInt32> GetInstanceID()
        {
            return Task.FromResult(State.InstanceID);
        }

        public async Task<MapAddResult> AddObject(IObjectImpl obj)
        {
            List<Task> tasks = new List<Task>();
            var guid = await obj.GetGUID();

            if ((await obj.IsOnMap()))
            {
                var currentmap = await obj.GetMap();

                if (currentmap != this)
                {
                    //could be doing a map quick-change
                    await currentmap.RemoveObject(guid, obj);
                }
            }


            if (State.ObjectList.Contains(guid))
                return MapAddResult.AlreadyOnMap;

            var isactivator = await obj.IsCellActivator();

            var posx = await obj.GetPositionX();
            var posy = await obj.GetPositionY();
            var cellkey = GetCellKey(posx, posy);
            var cell = await GetCell(cellkey, true);

            ServerLog.Debug("Map", "Adding {0} to map {1} instance {2} at {3}, {4}", guid.ToUInt64(), State.MapID,
                State.InstanceID, posx, posy);

            if (cell == null)
                return MapAddResult.InvalidPosition;

            tasks.Add(obj.SetMap(this));
            State.ObjectList.Add(guid);
            _objectCache.Add(guid, obj);

            tasks.Add(cell.AddObject(guid, obj));

            if (isactivator)
            {
                State.ActiveObjects.Add(guid);
                tasks.Add(AddRefCells(posx, posy));
            }

            await Task.WhenAll(tasks);

            return MapAddResult.OK;
        }

        public async Task RemoveObject(ObjectGUID guid, IObjectImpl obj)
        {
            State.ObjectList.Remove(guid);
            State.ActiveObjects.Remove(guid);
            State.UpdatedObjects.Remove(guid);
            _objectCache.Remove(guid);

            bool activator = await obj.IsCellActivator();
            if (activator)
            {
                var posx = await obj.GetPositionX();
                var posy = await obj.GetPositionY();

                await DecRefCells(posx, posy);
            }
        }

        public Task<IObjectImpl> GetObject(ObjectGUID guid)
        {
            IObjectImpl retval;
            _objectCache.TryGetValue(guid, out retval);
            return Task.FromResult(retval);
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


            for (var x = cellx - 1; x <= cellx + 1; ++x)
            {
                for (var y = celly - 1; y <= celly + 1; ++y)
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

            for (var x = cellx - 1; x <= cellx + 1; ++x)
            {
                for (var y = celly - 1; y <= celly + 1; ++y)
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
            var guid = await obj.GetGUID();

            State.ObjectList.Remove(guid);

            var isactivator = await obj.IsCellActivator();
            var posx = await obj.GetPositionX();
            var posy = await obj.GetPositionY();

            if (isactivator)
            {
                State.ActiveObjects.Remove(guid);
                await DecRefCells(posx, posy);
            }

            var cellkey = await obj.GetCell();

            if (cellkey != 0)
            {
                var cell = await GetCell(cellkey);
                await cell.RemoveObject(guid, obj);
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

                var creature = GrainFactory.GetGrain<ICreature>(guid.ToInt64());
                creaturespawns.Add(creature);
                tasks.Add(creature.Create(cre));
            }

            await Task.WhenAll(tasks);

            foreach (var c in creaturespawns)
                tasks.Add(AddObject(c));

            await Task.WhenAll(tasks);
        }

        public async Task UpdateInRangeObject(IObjectImpl obj, List<ObjectGUID> ignoreGuids)
        {
            List<Task> tasks = new List<Task>();
            var posx = await obj.GetPositionX();
            var posy = await obj.GetPositionY();
            var cellx = GetCellX(posx);
            var celly = GetCellY(posy);

            var player = await obj.IsPlayer();

            if (player)
                ServerLog.Debug("Map", "Updating inrange for player");

            for (var x = cellx - 1; x <= cellx + 1; ++x)
            {
                for (var y = celly - 1; y <= celly + 1; ++y)
                {
                    var cell = await GetCellDirect(x, y);

                    if (cell != null)
                        tasks.Add(cell.UpdateInRange(obj, ignoreGuids));
                }
            }

            await Task.WhenAll(tasks);
        }

        public Task OnObjectUpdated(ObjectGUID guid)
        {
            State.UpdatedObjects.Add(guid);
            return TaskDone.Done;
        }

        public Task OnCellActivate(IMapCell cell)
        {
            State.ActiveCells.Add((UInt64) cell.GetPrimaryKeyLong());
            return TaskDone.Done;
        }

        public Task OnCellDeactivate(IMapCell cell)
        {
            State.ActiveCells.Remove((UInt64) cell.GetPrimaryKeyLong());
            return TaskDone.Done;
        }

        public async Task Update()
        {
            SetupUpdateTask();

            List<Task> tasks = new List<Task>();

            foreach (var key in State.ActiveCells)
            {
                var cell = GrainFactory.GetGrain<IMapCell>((Int64) key);
                tasks.Add(cell.Update());
            }

            await Task.WhenAll(tasks);
        }

        protected void SetupUpdateTask()
        {
            UpdateTask = RegisterTimer(o =>
            {
                //Console.WriteLine("*** Map Update Instance {0} ***", State.InstanceID);
                return Update();
            }, null, TimeSpan.FromMilliseconds(MapUpdateInterval), TimeSpan.FromSeconds(-1));
        }

        protected void SetupSaveTask()
        {
            SaveTask = RegisterTimer(o => { return Save(); }, null, TimeSpan.FromMilliseconds(MapSaveInterval),
                TimeSpan.FromSeconds(MapSaveInterval));
        }
    }
}