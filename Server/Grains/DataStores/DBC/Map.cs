using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public partial class DataStoreManager
    {
        MapStore _MapStore = new MapStore();

        [DataStoreLoader]
        public List<Task> LoadMapDBCs()
        {
            List<Task> ret = new List<Task>();
            ret.Add(_MapStore.Load("Map.dbc"));
            return ret;
        }

        public Task<MapEntry> GetMapEntry(UInt32 MapID)
        {
            var entry = _MapStore.Get(MapID);
            return Task.FromResult(entry);
        }
    }
}
