using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Server
{
    public partial class DataStoreManager
    {
        public async Task Load()
        {
            if (Loaded)
                return;
            Loaded = true;
            await LoadConnectionDetails();

            List<Task> loaders = new List<Task>();

            loaders.AddRange(LoadReflection());

            await Task.WhenAll(loaders);
        }

        public List<Task> LoadReflection()
        {
            List<Task> awaitingLoaders = new List<Task>();

            var methods = GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (var m in methods)
            {
                if (m.GetCustomAttribute<DataStoreLoaderAttribute>() == null)
                    continue;

                var ret = m.Invoke(this, new object[] {});
                var retlist = ret as List<Task>;
                if (retlist == null)
                    throw new Exception("DBC loader returned unexpected type (should be List<Task>)");
                awaitingLoaders.AddRange(retlist);
            }

            return awaitingLoaders;
        }
    }
}