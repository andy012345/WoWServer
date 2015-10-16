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
        [PacketHandler(RealmOp.CMSG_CHAR_ENUM)]
        public static PacketProcessResult HandleCharEnum(PacketProcessor p)
        {
            p.ClientConnection.CurrentSession.HandleCharEnum();

            return PacketProcessResult.Processed;
        }


        [PacketHandler(RealmOp.CMSG_CHAR_CREATE)]
        public static PacketProcessResult HandleCharCreate(PacketProcessor p)
        {
            CMSG_CHAR_CREATE create = new CMSG_CHAR_CREATE();
            create.Read(p.CurrentPacket);

            p.ClientConnection.CurrentSession.HandleCharCreate(create);

            return PacketProcessResult.Processed;
        }

        [PacketHandler(RealmOp.CMSG_PLAYER_LOGIN)]
        public static PacketProcessResult HandlePlayerLogin(PacketProcessor p)
        {
            CMSG_PLAYER_LOGIN pkt = new CMSG_PLAYER_LOGIN();
            pkt.Read(p.CurrentPacket);

            p.ClientConnection.CurrentSession.HandlePlayerLogin(pkt);

            return PacketProcessResult.Processed;
        }

        [PacketHandler(RealmOp.CMSG_LOGOUT_REQUEST)]
        public static PacketProcessResult HandleLogoutRequest(PacketProcessor p)
        {
            var player = p.ClientConnection.CurrentPlayer;
            if (player == null)
                return PacketProcessResult.Processed;

            player.Logout(true).Wait();

            return PacketProcessResult.Processed;
        }
    }
}
