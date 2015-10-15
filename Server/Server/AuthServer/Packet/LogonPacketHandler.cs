﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Net;
using Shared;
using Server.Networking;

namespace Server.AuthServer
{
    internal class LogonPacketProcessor : PacketProcessor
    {
        public LogonPacketProcessor() : base()
        {
            dataNeeded = DefaultDataNeeded();
        } //opcode

        private AuthOp opcode;

        public override int DefaultDataNeeded()
        {
            return 1;
        }

        public override PacketProcessResult ProcessData()
        {
            opcode = (AuthOp) currentPacket.ReadByte();

            return ProcessPacket();
        }

        private PacketProcessResult ProcessPacket()
        {
            var handler = AuthServer.Main.LogonPacketHandler.GetHandler(opcode);

            if (handler == null)
            {
                Console.WriteLine("Recieved packet {0} which has no handler", opcode);
                return PacketProcessResult.Error;
            }

            return handler(this);
        }
    }

    public partial class LogonPacketHandler
    {
        private Dictionary<UInt32, Func<PacketProcessor, PacketProcessResult>> PacketHandlers =
            new Dictionary<UInt32, Func<PacketProcessor, PacketProcessResult>>();

        public void Init()
        {
            var type = this.GetType();

            var methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);

            foreach (var method in methods)
            {
                var attrib = method.GetCustomAttribute<PacketHandlerAttribute>();

                if (attrib == null)
                    continue;

                var handlerDelegate =
                    (Func<PacketProcessor, PacketProcessResult>)
                        Delegate.CreateDelegate(typeof (Func<PacketProcessor, PacketProcessResult>), method);

                if (handlerDelegate == null)
                    continue;

                PacketHandlers.Add(attrib.Id, handlerDelegate);
            }
        }

        public Func<PacketProcessor, PacketProcessResult> GetHandler(AuthOp opcode)
        {
            UInt32 op = (UInt32) opcode;

            Func<PacketProcessor, PacketProcessResult> retval = null;
            PacketHandlers.TryGetValue(op, out retval);
            return retval;
        }
    }
}