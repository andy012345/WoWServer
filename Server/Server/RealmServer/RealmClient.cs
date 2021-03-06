﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Orleans.Streams;
using Shared;


namespace Server.RealmServer
{
    public class RealmClient : IDisposable
    {
        private RealmSettings settings = null;
        private RealmClientSocket sock = null;

        public RealmClient(RealmSettings realmsettings)
        {
            settings = realmsettings;
        }

        public void Run()
        {
            Init();
            var realm_manager = Orleans.GrainClient.GrainFactory.GetGrain<IRealmManager>(0);
            realm_manager.AddRealm(settings);

            sock = new RealmClientSocket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.SetRealmSettings(settings);
            sock.SetProcessor(new RealmPacketProcessor());

            sock.Bind(settings.Port);
            sock.Listen(50);
            sock.Accept();

            //make sure the realm client is pinging the server so it doesn't get marked offline!
            sock.PingRunner();
        }

        public void Init()
        {
        }


        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (sock != null)
                    sock.Dispose();
            }
        }
    }
}