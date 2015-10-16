using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Server.Networking;

namespace Server.AuthServer
{
    public partial class LogonPacketHandler
    {
        [PacketHandler(AuthOp.REALM_LIST)]
        public static PacketProcessResult HandleRealmList(PacketProcessor p)
        {
            p.DataNeeded = 5;
            if (p.CurrentPacket.Length < p.DataNeeded) return PacketProcessResult.RequiresData;
            if (p.ClientConnection != null && p.ClientConnection.CurrentSession != null)
                p.ClientConnection.CurrentSession.OnRealmList();
            return PacketProcessResult.Processed;
        }
    }
}