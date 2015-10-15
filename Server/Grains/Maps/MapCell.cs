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
    public class MapCellState : GrainState
    {
        public UInt32 InstanceID { get; set; }
        public UInt32 CellX { get; set; }
        public UInt32 CellY { get; set; }
        public List<ObjectGUID> Objects { get; set; }
        public Int64 Refs { get; set; }

        public bool Exists { get; set; }
    }

    [StorageProvider(ProviderName = "Default")]
    public class MapCell : Grain<MapCellState>, IMapCell
    {
        protected Dictionary<ObjectGUID, IObjectImpl> _objectCache = new Dictionary<ObjectGUID, IObjectImpl>();

        public async override Task OnActivateAsync()
        {
            if (State.Objects == null)
                State.Objects = new List<ObjectGUID>();

            foreach (var guid in State.Objects)
            {
                var obj = ObjectRetriever.GetObject(GrainFactory, guid);
                _objectCache.Add(guid, obj);
            }

            await base.OnActivateAsync();
        }

        public async override Task OnDeactivateAsync()
        {
            await Save();
            await base.OnDeactivateAsync();
        }

        public async Task Save()
        {
            var valid = await IsValid();
            if (!valid)
                return;
            await WriteStateAsync();
        }

        public async Task Init(UInt32 cellx, UInt32 celly, IMap parent)
        {
            State.InstanceID = await parent.GetInstanceID();
        }

        public Task<bool> IsValid() { return Task.FromResult(_IsValid()); }
        protected bool _IsValid() { return State.Exists; }

        public Task Create(UInt32 InstanceID, UInt32 cellx, UInt32 celly)
        {
            State.InstanceID = InstanceID;
            State.CellX = cellx;
            State.CellY = celly;
            State.Exists = true;

            return TaskDone.Done;
        }

        protected IMap _GetMap()
        {
            if (!_IsValid())
                return null;
            return GrainFactory.GetGrain<IMap>((Int64)State.InstanceID);
        }

        public async Task AddObject(ObjectGUID guid, IObjectImpl obj)
        {
            State.Objects.Add(guid);
            _objectCache.Add(guid, obj);
            await obj.SetCell((UInt64)this.GetPrimaryKeyLong());
        }

        public async Task RemoveObject(ObjectGUID guid, IObjectImpl obj)
        {
            State.Objects.Remove(guid);
            _objectCache.Remove(guid);
            await obj.SetCell(0);
        }

        public async Task AddRef() { State.Refs += 1; if (State.Refs == 1) await Activate(); }
        public async Task DecRef() { State.Refs -= 1; if (State.Refs == 0) await Deactivate(); }

        async Task Activate()
        {
            var map = _GetMap();

            if (map == null)
                throw new Exception("Attempting to activate a cell which has no map");

            await map.OnCellActivate(this);
        }

        public async Task Deactivate()
        {
            var map = _GetMap();

            if (map == null)
                throw new Exception("Attempting to activate a cell which has no map");

            await map.OnCellActivate(this);
        }

        public async Task Update()
        {
            List<Task> tasks = new List<Task>();
            foreach (var o in _objectCache)
            {
                tasks.Add(o.Value.Update());
            }
            await Task.WhenAll(tasks);
        }

        public async Task UpdateInRange(IObjectImpl obj)
        {
            List<Task> tasks = new List<Task>();

            foreach (var o in _objectCache)
            {
                var cansee = await obj.CanSee(o.Value);

                if (cansee)
                    tasks.Add(obj.AddInRangeObject(o.Key, o.Value));
            }

            await Task.WhenAll(tasks);
        }
    }
}