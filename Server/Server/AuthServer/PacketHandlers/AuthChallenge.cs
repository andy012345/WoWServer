using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Shared;
using Server.Networking;

namespace Server.AuthServer
{
    public partial class LogonPacketHandler
    {
        [PacketHandler(AuthOp.AUTH_LOGON_CHALLENGE)]
        public static PacketProcessResult HandleLogonAuthChallenge(PacketProcessor p)
        {
            if (p.CurrentPacket.Length < 4)
            {
                p.DataNeeded = 4; //1 opcode, 1 version, 2 data_size
                return PacketProcessResult.RequiresData;
            }

            byte proto_version = p.CurrentPacket.ReadByte();
            UInt16 data_size = p.CurrentPacket.ReadUInt16();

            if (p.CurrentPacket.Length < 4 + data_size)
            {
                p.DataNeeded = 4 + data_size; //1 opcode, 1 version, 2 data_size, data_size data
                return PacketProcessResult.RequiresData;
            }

            AuthLogonChallenge challenge = new AuthLogonChallenge();

            challenge.client = p.CurrentPacket.ReadFourCC();
            challenge.client_major = p.CurrentPacket.ReadByte();
            challenge.client_minor = p.CurrentPacket.ReadByte();
            challenge.client_revision = p.CurrentPacket.ReadByte();
            challenge.client_build = p.CurrentPacket.ReadUInt16();
            challenge.processor = p.CurrentPacket.ReadFourCC();
            challenge.os = p.CurrentPacket.ReadFourCC();
            challenge.locale = p.CurrentPacket.ReadFourCC();
            challenge.category = p.CurrentPacket.ReadInt32();
            challenge.ipaddr = new IPAddress(p.CurrentPacket.ReadBytes(4));
            challenge.account = p.CurrentPacket.ReadString();

            if (p.ClientConnection != null && p.ClientConnection.CurrentSession != null)
                p.ClientConnection.CurrentSession.OnLogonChallenge(challenge);

            return PacketProcessResult.Processed;
        }
    }
}