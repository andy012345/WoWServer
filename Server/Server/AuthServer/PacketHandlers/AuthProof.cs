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
        [PacketHandler(AuthOp.AUTH_LOGON_PROOF)]
        public static PacketProcessResult HandleLogonAuthProof(PacketProcessor p)
        {
            p.DataNeeded = 75; //1 op, 32 A, 20 M1, 20 crc_hash, 1 number_of_keys, 1 unk
            if (p.CurrentPacket.Length < p.DataNeeded) return PacketProcessResult.RequiresData;

            AuthLogonProof proof = new AuthLogonProof();

            proof.A = p.CurrentPacket.ReadBytes(32);
            proof.M1 = p.CurrentPacket.ReadBytes(20);
            proof.crchash = p.CurrentPacket.ReadBytes(20);
            proof.number_of_keys = p.CurrentPacket.ReadByte();
            proof.unk = p.CurrentPacket.ReadByte();

            if (p.ClientConnection != null && p.ClientConnection.CurrentSession != null)
                p.ClientConnection.CurrentSession.OnLogonProof(proof);

            return PacketProcessResult.Processed;
        }
    }
}