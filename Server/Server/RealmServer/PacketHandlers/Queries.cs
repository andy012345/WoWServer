using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Net;
using Shared;
using Server.Networking;
using System.IO.Compression;

namespace Server.RealmServer
{
    public partial class RealmPacketHandler
    {
        [PacketHandler(RealmOp.CMSG_NAME_QUERY)]
        public static PacketProcessResult HandleNameQuery(PacketProcessor p)
        {
            CMSG_NAME_QUERY data = new CMSG_NAME_QUERY();
            data.Read(p.currentPacket);

            p.sock.session.HandleNameQuery(data);

            return PacketProcessResult.Processed;
        }

    }
}
