using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared
{
    public static class ServerLog
    {
        public static void Debug(string format, params object[] arg)
        {
            DateTime now = DateTime.Now;
            string formatted = string.Format("[{0}:{1}:{2}] DEBUG: ", now.Hour, now.Minute, now.Second) + string.Format(format, arg);
            Console.WriteLine(formatted);
           // await Task.Factory.StartNew(() => { Console.WriteLine(formatted); });
        }
    }

}