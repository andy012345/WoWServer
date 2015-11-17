using Orleans;
using Orleans.Runtime;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Collections.Generic;

namespace Orleans.Storage.MySQLDB
{
    using System.Configuration;
    using System.Data.Common;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;
    using Providers;
    using Storage;
    using MySql.Data.MySqlClient;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json;
    using System.Diagnostics;
    using System.Collections.Concurrent;

    /// <summary>
    /// A MySQLDB storage provider.
    /// </summary>
    /// <remarks>
    /// The storage provider should be included in a deployment by adding this line to the Orleans server configuration file:
    /// <Provider Type="Orleans.Storage.MySQLDB.MySQLJSONDBStorageProvider" Name="MySQLJSONDBStore" ConnectionStringName="MySQLDB"/>and this line to any grain that uses it:
    /// [StorageProvider(ProviderName = "MySQLJSONDBStore")]
    /// The name 'MySQLDBStore' is an arbitrary choice.
    /// If no connection string name is provided the provider will use MySQLDB InMemory storage.
    /// </remarks>
    public class MySQLJSONDBStorageProvider : IStorageProvider
    {
        private ConcurrentQueue<MySqlConnection> freeConnectionPool = new ConcurrentQueue<MySqlConnection>();
        private string ConnectString;
        private string Table = "OrleansGrainStorage";
        private bool CustomTable = false;
        private bool Closed = false;

        public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
        {
            Log = providerRuntime.GetLogger(this.GetType().FullName);

            ConnectString = config.Properties["DataConnectionString"];

            if (config.Properties.ContainsKey("Table"))
            {
                Table = config.Properties["Table"];
                CustomTable = true;
            }

            return TaskDone.Done;
        }

        public Logger Log { get; protected set; }

        /// <summary>
        /// Storage provider name
        /// </summary>
        public string Name { get; protected set; }

        public async Task Close()
        {
            Closed = true;

            MySqlConnection con = await GetFreeConnection();

            while (con != null)
            {
                con.Dispose();
                con = await GetFreeConnection();
            }
        }

        public async Task<MySqlConnection> GetFreeConnection()
        {
            MySqlConnection con;
            if (freeConnectionPool.TryDequeue(out con))
                return con;
            return await CreateConnection();
        }

        public Task AddFreeConnection(MySqlConnection con)
        {
            if (Closed)
            {
                con.Dispose();
                return TaskDone.Done;
            }

            freeConnectionPool.Enqueue(con);
            return TaskDone.Done;
        }

        public async Task<MySqlConnection> CreateConnection()
        {
            if (Closed)
                return null;

            var con = new MySqlConnection(ConnectString);
            await con.OpenAsync();

            if (con != null && con.State != System.Data.ConnectionState.Open)
                throw new Exception("MySQLStorage could not open a connection to the database");
            return con;
        }

        public async Task ReadStateAsync(string grainType, GrainReference grainReference, GrainState grainState)
        {
            var con = await GetFreeConnection();

            var table = GetTableName(grainState);
            string keyAsString = GetKey(grainReference);

            string query;

            if (CustomTable)
                query = string.Format("select * from `{0}` where `guid` = \"{1}\";", table,
                    MySqlHelper.EscapeString(keyAsString));
            else
                query = string.Format("select * from `{0}` where `guid` = \"{1}\" AND `type` = \"{2}\";", table,
                    MySqlHelper.EscapeString(keyAsString), MySqlHelper.EscapeString(grainType));

            using (var cmd = new MySqlCommand(query, con))
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        Dictionary<string, object> dict = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; ++i)
                            dict.Add(reader.GetName(i), reader.GetValue(i));

                        if (dict.ContainsKey("data"))
                        {
                            try
                            {
                                var data =
                                    (GrainState)
                                        Newtonsoft.Json.JsonConvert.DeserializeObject(dict["data"].ToString(),
                                            grainState.GetType());
                                grainState.SetAll(data.AsDictionary());
                            }
                            catch
                            {
                                grainState.SetAll(null); /* corruption? */
                            }
                        }
                        else
                            grainState.SetAll(null);
                    }
                }
            }

            await AddFreeConnection(con);
        }

        private string GetTableName(GrainState grainState)
        {
            if (Table != null && Table.Length > 0)
                return Table;
            return grainState.GetType().Name; //use grain name generator if no table provided
        }

        //Ignore exceptions here as we have to use try blocks on orleans code
        [DebuggerStepThrough]
        private static string GetKey(GrainReference grainReference)
        {
            string keyAsString = null;
            string keyExt = null;

            bool success = false;

            try
            {
                keyAsString = grainReference.GetPrimaryKeyLong().ToString();
                success = true;
            }
            catch
            {
                success = false;
            }
            try
            {
                keyAsString = grainReference.GetPrimaryKey().ToString();
                success = true;
            }
            catch
            {
                success = false;
            }
            if (!success)
            {
                keyAsString = grainReference.GetPrimaryKey(out keyExt).ToString();

                if (keyExt.Length > 0) //using string extension to guid, so we use the string!
                    keyAsString = keyExt;
            }

            if (keyAsString == null || keyAsString.Length == 0)
                throw new Exception(string.Format("MySQLStorage could not deduce key for grain reference {0}",
                    grainReference.ToString()));
            return keyAsString;
        }

        public async Task WriteStateAsync(string grainType, GrainReference grainReference, GrainState grainState)
        {
            var con = await GetFreeConnection();
            var table = GetTableName(grainState);
            var key = GetKey(grainReference);

            var data = Newtonsoft.Json.JsonConvert.SerializeObject(grainState, Newtonsoft.Json.Formatting.Indented);

            List<string> queries = new List<string>();
            if (CustomTable)
            {
                queries.Add(string.Format("replace into `{0}` (`guid`, `data`) VALUE (\"{1}\", \"{2}\");", table, key,
                    MySqlHelper.EscapeString(data)));
            }
            else
            {
                queries.Add(string.Format("delete from `{0}` where `guid` =\"{1}\" and `type` = \"{2}\";", table, key,
                    MySqlHelper.EscapeString(grainType)));
                queries.Add(
                    string.Format("insert into `{0}` (`guid`, `type`, `data`) VALUE (\"{1}\", \"{2}\", \"{3}\");", table,
                        key, MySqlHelper.EscapeString(grainType), MySqlHelper.EscapeString(data)));
            }

            foreach (var q in queries)
            {
                MySqlCommand com = new MySqlCommand(q, con);
                Log.Verbose(q);
                await com.ExecuteNonQueryAsync();
                com.Dispose();
            }

            await AddFreeConnection(con);
        }

        public async Task ClearStateAsync(string grainType, GrainReference grainReference, GrainState grainState)
        {
            var con = await GetFreeConnection();
            var table = GetTableName(grainState);
            var key = GetKey(grainReference);

            string query;

            if (CustomTable)
                query = string.Format("delete from `{0}` where `guid` = \"{1}\";", table, MySqlHelper.EscapeString(key));
            else
                query = string.Format("delete from `{0}` where `guid` = \"{1}\" AND `type` = \"{2}\";", table,
                    MySqlHelper.EscapeString(key), MySqlHelper.EscapeString(grainType));

            MySqlCommand com = new MySqlCommand(query, con);
            Log.Verbose(query);
            await com.ExecuteNonQueryAsync();
            com.Dispose();
            await AddFreeConnection(con);
        }
    }
}