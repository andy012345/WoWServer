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
        public static void Debug(string from, string format, params object[] arg)
        {
            //var CurrentForeground = Console.ForegroundColor;
            //var CurrentBackground = Console.BackgroundColor;

           // Console.ForegroundColor = ConsoleColor.Cyan;

            DateTime now = DateTime.Now;
            string formatted = string.Format("[{0}:{1}:{2}] [{3}]: ", now.Hour.ToString("D2"), now.Minute.ToString("D2"), now.Second.ToString("D2"), from) +
                               string.Format(format, arg);
            Console.WriteLine(formatted);

            //Console.ForegroundColor = CurrentForeground;
            //Console.ForegroundColor = CurrentBackground;
        }
    }
}