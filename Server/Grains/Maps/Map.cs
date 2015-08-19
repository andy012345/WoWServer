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



    public class MapCellHandler
    {
        public const float TileSize = 533.33333f;
        public const UInt32 TileCount = 64;

        public const float MinX = -TileCount * TileSize / 2;
        public const float MinY = -TileCount * TileSize / 2;
        public const float MaxX = TileCount * TileSize / 2;
        public const float MaxY = TileCount * TileSize / 2;

        public const UInt32 CellsPerTile = 8;
        public const float CellSize = TileSize * CellsPerTile;
        public const UInt32 CellSizeX = TileCount * CellsPerTile;
        public const UInt32 CellSizeY = TileCount * CellsPerTile;

        MapCell[,] _cells = new MapCell[CellSizeX, CellSizeY];

        public UInt32 GetCellX(float x)
        {
            if (x < MinX || x > MaxX)
                throw new ArgumentException("Position out of range");
            var tile = (MaxX - x) / CellSize;
            return (UInt32)tile;
        }

        public UInt32 GetCellY(float y)
        {
            if (y < MinY || y > MaxY)
                throw new ArgumentException("Position out of range");
            var tile = (MaxY - y) / CellSize;
            return (UInt32)tile;
        }

        public MapCell GetCell(float x, float y)
        {
            var cellx = GetCellX(x);
            var celly = GetCellY(y);

            return _cells[cellx, celly];
        }
    }

    public class MapCell
    {

    }

    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    public class Map : Grain<MapState>, IMap
    {
        Dictionary<ObjectGUID, IObjectImpl> objectMap = new Dictionary<ObjectGUID, IObjectImpl>();
        List<IObjectImpl> activeObjects = new List<IObjectImpl>();
        MapCellHandler _mapCellHandler = new MapCellHandler(); //to look at adding to serialisation

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
            IDataStoreManager datastore = GrainFactory.GetGrain<IDataStoreManager>(0);

            //get all creatures for my map!
            var creatures = await datastore.GetCreatureEntriesByMap(State.MapID);

            //add them to their cells
            foreach (var cre in creatures)
            {
                var cell = _mapCellHandler.GetCell(cre.position_x, cre.position_y);
            }
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
            var guid = await obj.GetGUID();
            objectMap.Add(guid, obj);
            await obj.SetMap(this);

            var isactivator = await obj.IsCellActivator();

            if (isactivator)
            {
                //well he gets updates, duh
                activeObjects.Add(obj);

                //todo: add ref to 3x3 cell around him
            }

            return true;
        }

    }
}
