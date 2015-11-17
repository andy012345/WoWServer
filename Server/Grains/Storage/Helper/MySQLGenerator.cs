﻿using Orleans;
using Orleans.Concurrency;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Shared;

namespace Server
{
    public class MySQLGenerator
    {
        public static string GenerateInsert(string table_name, IDictionary<string, object> dict,
            List<string> ignored_fields)
        {
            return GenerateInsertOrReplace("insert", table_name, dict, ignored_fields);
        }

        public static string GenerateReplace(string table_name, IDictionary<string, object> dict,
            List<string> ignored_fields)
        {
            return GenerateInsertOrReplace("replace", table_name, dict, ignored_fields);
        }

        public static string GenerateInsert(string table_name, IDictionary<string, object> dict, string ignored_field)
        {
            List<string> ignored_fields = new List<string>();
            ignored_fields.Add(ignored_field);
            return GenerateInsertOrReplace("insert", table_name, dict, ignored_fields);
        }

        public static string GenerateReplace(string table_name, IDictionary<string, object> dict, string ignored_field)
        {
            List<string> ignored_fields = new List<string>();
            ignored_fields.Add(ignored_field);
            return GenerateInsertOrReplace("replace", table_name, dict, ignored_fields);
        }

        public static string GenerateInsertOrReplace(string insert_or_replace, string table_name,
            IDictionary<string, object> dict, List<string> ignored_fields)
        {
            if (dict.Count == 0)
                return "";

            var dict_copy = dict;

            //Remove anything we're ignoring
            foreach (var tmp in ignored_fields)
                dict_copy.Remove(tmp);

            string rtn = string.Format("{0} into `{1}` (", insert_or_replace, table_name);

            foreach (var temp in dict_copy)
            {
                rtn += string.Format("`{0}`, ", MySqlHelper.EscapeString(temp.Key.ToString()));
            }

            //remove the last 2 bytes
            rtn.Substring(0, rtn.Length - 2);
            rtn += ") VALUES (";

            foreach (var temp in dict_copy)
            {
                rtn += string.Format("\"{0}\", ", MySqlHelper.EscapeString(temp.Value.ToString()));
            }

            //remove the last 2 bytes
            rtn.Substring(0, rtn.Length - 2);
            rtn += ");";

            return rtn;
        }

        public static T ToObject<T>(Dictionary<string, object> dict)
        {
            object obj = Activator.CreateInstance(typeof (T));
            var type = typeof (T);

            var tests = type.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (var tmp in dict)
            {
                if (tmp.Value is DBNull)
                    continue; //nothing to see here

                var objField = type.GetField(tmp.Key, BindingFlags.Instance | BindingFlags.Public);

                if (objField != null)
                {
                    var objFieldType = objField.FieldType;
                    try
                    {
                        objField.SetValue(obj, Convert.ChangeType(tmp.Value, objFieldType));
                    }
                    catch (Exception e)
                    {
                        ServerLog.Debug("MySQLHelper", "Exception setting {0} to {1} in {2}, details:\n{3}", tmp.Key, tmp.Value,
                            type.ToString(), e.ToString());
                    }
                }
                else
                {
                    ServerLog.Debug("MySQLHelper", "Cannot set {0} to {1} in type {2} as field does not exist", tmp.Key, tmp.Value,
                        type.ToString());
                }
            }

            return (T) obj;
        }

        public static Dictionary<string, object> ToDictionary<T>(T obj)
        {
            Dictionary<string, object> rtn = new Dictionary<string, object>();

            var infos = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (var tmp in infos)
            {
                rtn.Add(tmp.Name, tmp.GetValue(obj));
            }

            return rtn;
        }
    }
}