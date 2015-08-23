﻿using Server.Networking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Server.AuthServer
{
    public class Main
    {
        public static LogonPacketHandler LogonPacketHandler = new LogonPacketHandler();

        public static ServerSocket MainSocket = null;
        public static bool Running = false;

        public static void Run()
        {
            if (System.IO.File.Exists("Config-Auth.xml") == false)
                return;

            TextReader configReader = File.OpenText("Config-Auth.xml");

            if (configReader == null)
                throw new Exception("Unable to open Config-Auth.xml");

            var doc = new XmlDocument();
            var xmlReader = XmlReader.Create(configReader);

            doc.Load(xmlReader);

            var els = doc.GetElementsByTagName("AuthServer");

            if (els.Count == 0)
                throw new Exception("Config-Auth.xml does not contain element AuthServer");

            var el = els[0] as XmlElement;

            string port = el.GetAttribute("Port");

            if (port == null)
                throw new Exception("Config-Auth.xml does not define AuthServer port");

            string listenbacklog = el.GetAttribute("ListenBacklog");

            //just some test setup for now
            LogonPacketHandler.Init();


            MainSocket = new Networking.ServerSocket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            MainSocket.SetProcessor(new LogonPacketProcessor());
            MainSocket.Bind(ushort.Parse(port));
            MainSocket.Listen(listenbacklog == null ? 50 : int.Parse(listenbacklog));
            MainSocket.Accept();

            Running = true;
        }

        public static void Stop()
        {
            if (!Running)
                return;

            if (MainSocket != null)
                MainSocket.Dispose();

            Running = false;
        }
    }
}
