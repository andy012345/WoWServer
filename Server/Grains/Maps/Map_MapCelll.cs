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
    public partial class Map
    {
        public const float TileSize = 533.33333f;
        public const UInt32 TileCount = 64;

        public const float MinX = -TileCount*TileSize/2;
        public const float MinY = -TileCount*TileSize/2;
        public const float MaxX = TileCount*TileSize/2;
        public const float MaxY = TileCount*TileSize/2;

        public const UInt32 CellsPerTile = 8;
        public const float CellSize = TileSize/CellsPerTile;
        public const UInt32 CellSizeX = TileCount*CellsPerTile;
        public const UInt32 CellSizeY = TileCount*CellsPerTile;

        private List<IMapCell> _activeCells = new List<IMapCell>();

        public Task InitMapCells()
        {
            return TaskDone.Done;
        }

        public async Task CreateCell(IMapCell cell)
        {
            List<Task> tasks = new List<Task>();
            var key = (UInt64) cell.GetPrimaryKeyLong();

            var cellx = (key >> 48) & 0xFFFF;
            var celly = (key >> 32) & 0xFFFF;

            await cell.Create(State.InstanceID, (UInt32) cellx, (UInt32) celly);

            if (CreatureEntryByCellKey.ContainsKey(key))
            {
                var creatures = CreatureEntryByCellKey[key];
                tasks.Add(SpawnCreatures(creatures.ToArray()));
            }

            await Task.WhenAll(tasks);
        }

        public UInt64 GetCellKey(float x, float y)
        {
            var cellx = GetCellX(x);
            var celly = GetCellY(y);

            return GetCellKey(cellx, celly);
        }

        public UInt64 GetCellKey(UInt32 cellx, UInt32 celly)
        {
            UInt64 cellx64 = (UInt64) cellx;
            UInt64 celly64 = (UInt64) celly;
            UInt64 instanceid64 = (UInt64) State.InstanceID;
            UInt64 key = (cellx64 << 48) | (celly64 << 32) | instanceid64;
            return key;
        }

        public async Task<IMapCell> GetCell(UInt64 key, bool can_create = false)
        {
            var cell = GrainFactory.GetGrain<IMapCell>((Int64) key);

            var valid = await cell.IsValid();

            if (!valid)
            {
                if (!can_create)
                    return null;
                await CreateCell(cell);
            }

            return cell;
        }

        public UInt32 GetCellX(float x)
        {
            if (x < MinX || x >= MaxX)
                throw new ArgumentException("Position out of range");
            var tile = (MaxX - x)/CellSize;
            return (UInt32) tile;
        }

        public UInt32 GetCellY(float y)
        {
            if (y < MinY || y >= MaxY)
                throw new ArgumentException("Position out of range");
            var tile = (MaxY - y)/CellSize;
            return (UInt32) tile;
        }

        public async Task<IMapCell> GetCell(float x, float y, bool can_create = false)
        {
            var cellx = GetCellX(x);
            var celly = GetCellY(y);

            return await GetCellDirect(cellx, celly, can_create);
        }

        public async Task<IMapCell> GetCellDirect(UInt32 x, UInt32 y, bool can_create = false)
        {
            if (x >= CellSizeX || y >= CellSizeY)
                return null;
            var key = GetCellKey(x, y);
            return await GetCell(key, can_create);
        }
    }
}