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
        [PacketHandler(RealmOp.CMSG_AUTH_SESSION)]
        public static PacketProcessResult HandleAuthSession(PacketProcessor p)
        {
            CMSG_AUTH_SESSION auth = new CMSG_AUTH_SESSION();
            UInt32 unk, unk2, unk3, unk4, unk5;
            UInt64 unk6;

            auth.Build = p.CurrentPacket.ReadUInt32();
            unk = p.CurrentPacket.ReadUInt32();
            auth.Account = p.CurrentPacket.ReadCString();
            unk2 = p.CurrentPacket.ReadUInt32();

            auth.Seed = p.CurrentPacket.ReadUInt32();
            unk3 = p.CurrentPacket.ReadUInt32();
            unk4 = p.CurrentPacket.ReadUInt32();
            unk5 = p.CurrentPacket.ReadUInt32();
            unk6 = p.CurrentPacket.ReadUInt64();
            auth.Digest = p.CurrentPacket.ReadBigInteger(20);

            var decompressedDataSize = p.CurrentPacket.ReadInt32();
            var compressedData = p.CurrentPacket.ReadBytes((int) (p.CurrentPacket.Length - p.CurrentPacket.Position));
                //read remaining array
            auth.AddonData = Shared.ZLib.Decompress(compressedData);

            var realmprocessor = p as RealmPacketProcessor;

            //get the encryption keys first because errors are encrypted too
            p.ClientConnection.CurrentSession.GetSessionKeyFromAuthAccount(auth.Account).Wait();
            realmprocessor.SetupCrypto(p.ClientConnection.CurrentSession.GetSessionKey().Result);
            p.ClientConnection.CurrentSession.HandleAuthSession(auth, realmprocessor.Seed);

            return PacketProcessResult.Processed;
        }
    }
}