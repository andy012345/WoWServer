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
using System.Security.Cryptography;

namespace Server.RealmServer
{
    public class RealmPacketProcessor : PacketProcessor
    {
        public RealmPacketProcessor() : base()
        {
            DataNeeded = DefaultDataNeeded();
        } //opcode

        public RealmOp CurrentOpcode;
        public int DecryptPointer = 0;
        public UInt32 Seed = 0;
        public int RealmID = 0;

        public override void OnConnect(ServerSocket parent = null)
        {
            if (ClientConnection.CurrentSession == null)
                throw new Exception("Realm connection with no session");
            var realmparent = parent as RealmClientSocket;
            if (realmparent == null)
                throw new Exception("Realm connection with non realm parent!");

            ClientConnection.CurrentSession.SetRealmInfo(realmparent.GetRealmSettings());

            Random rnd = new Random();
            Seed = (UInt32) rnd.Next();

            PacketOut p = new PacketOut(RealmOp.SMSG_AUTH_CHALLENGE);
            p.Write((int) 1);
            p.Write(Seed);

            p.Write(0xF3539DA3);
            p.Write(0x6E8547B9);
            p.Write(0x9A6AA2F8);
            p.Write(0xA4F170F4);
            p.Write(0xF3539DA3);
            p.Write(0x6E8547B9);
            p.Write(0x9A6AA2F8);
            p.Write(0xA4F170F4);

            SendPacket(p);
        }

        public void SetupCrypto(BigInteger key)
        {
            byte[] ServerDecryptionKey =
            {
                0xC2, 0xB3, 0x72, 0x3C, 0xC6, 0xAE, 0xD9, 0xB5,
                0x34, 0x3C, 0x53, 0xEE, 0x2F, 0x43, 0x67, 0xCE
            };

            byte[] ServerEncryptionKey =
            {
                0xCC, 0x98, 0xAE, 0x04, 0xE8, 0x97, 0xEA, 0xCA,
                0x12, 0xDD, 0xC0, 0x93, 0x42, 0x91, 0x53, 0x57
            };

            HMACSHA1 decryptHMAC = new HMACSHA1(ServerDecryptionKey);
            HMACSHA1 encryptHMAC = new HMACSHA1(ServerEncryptionKey);

            var decryptHash = decryptHMAC.ComputeHash(key.GetBytes());
            var encryptHash = encryptHMAC.ComputeHash(key.GetBytes());

            const int dropN = 1024; //1000 before WoTLK, 1024 now
            var buf = new byte[dropN];

            ClientConnection.Decrypt = new ARC4(decryptHash);
            ClientConnection.Encrypt = new ARC4(encryptHash);

            ClientConnection.Decrypt.Process(buf, 0, buf.Length);
            ClientConnection.Encrypt.Process(buf, 0, buf.Length);
        }

        public void SendPacket(PacketOut p)
        {
            p.Finalise();
            var parray = p.strm.ToArray();
            ClientConnection.Send(parray, parray.Length);
        }

        public override int DefaultDataNeeded()
        {
            return 6;
        } //shortest is 2 byte size, 4 byte command

        public override PacketProcessResult ProcessData()
        {
            DecryptData(6);
            int sz = CurrentPacket.ReadUInt16BE();

            if ((sz & 0x8000) != 0) //large packet
            {
                DataNeeded = 3; //we need 3 byte size to continue
                if (CurrentPacket.Length < DataNeeded) return PacketProcessResult.RequiresData;

                DecryptData(7);
                CurrentPacket.Position = 3;
                sz = 0;
                sz |= CurrentPacket.GetBuffer()[0] & 0x7F;
                sz <<= 8;
                sz |= CurrentPacket.GetBuffer()[1];
                sz <<= 8;
                sz |= CurrentPacket.GetBuffer()[2];

                DataNeeded = 3 + sz;
                if (CurrentPacket.Length < DataNeeded) return PacketProcessResult.RequiresData;
            }
            else
            {
                DataNeeded = 2 + sz;
                if (CurrentPacket.Length < DataNeeded) return PacketProcessResult.RequiresData;
            }

            CurrentOpcode = (RealmOp) CurrentPacket.ReadUInt32();

            Console.WriteLine("Received Packet {0} Length {1}", CurrentOpcode.ToString(), sz);

            //ok now we need sz + 2 to continue

            return ProcessPacket();
        }

        private void DecryptData(int to)
        {
            if (ClientConnection.Decrypt == null || DecryptPointer >= to)
                return;

            ClientConnection.Decrypt.Process(CurrentPacket.GetBuffer(), DecryptPointer, (to - DecryptPointer));
            DecryptPointer = to;
        }

        private PacketProcessResult ProcessPacket()
        {
            var handler = RealmServer.Main.PacketHandler.GetHandler(CurrentOpcode);

            if (handler == null)
            {
                Console.WriteLine("Recieved packet {0} which has no handler", CurrentOpcode);
                return PacketProcessResult.Processed;
                    //In realm we have known sizes so we mark as processed as multiple packets can come through in one burst, we want to continue reading
            }

            return handler(this);
        }
    }

    public partial class RealmPacketHandler
    {
        private Dictionary<UInt32, Func<PacketProcessor, PacketProcessResult>> PacketHandlers =
            new Dictionary<UInt32, Func<PacketProcessor, PacketProcessResult>>();

        public void Init()
        {
            var type = this.GetType();

            var methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);

            foreach (var method in methods)
            {
                foreach (var attrib in method.GetCustomAttributes<PacketHandlerAttribute>())
                {
                    var handlerDelegate =
                        (Func<PacketProcessor, PacketProcessResult>)
                            Delegate.CreateDelegate(typeof (Func<PacketProcessor, PacketProcessResult>), method);

                    if (handlerDelegate == null)
                        continue;

                    PacketHandlers.Add(attrib.Id, handlerDelegate);
                }
            }
        }

        public Func<PacketProcessor, PacketProcessResult> GetHandler(RealmOp opcode)
        {
            UInt32 op = (UInt32) opcode;

            Func<PacketProcessor, PacketProcessResult> retval = null;
            PacketHandlers.TryGetValue(op, out retval);
            return retval;
        }
    }
}