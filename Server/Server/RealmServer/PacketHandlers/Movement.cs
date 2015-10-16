using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        [PacketHandler(RealmOp.MSG_MOVE_START_FORWARD)]
        [PacketHandler(RealmOp.MSG_MOVE_START_BACKWARD)]
        [PacketHandler(RealmOp.MSG_MOVE_STOP)]
        [PacketHandler(RealmOp.MSG_MOVE_START_STRAFE_LEFT)]
        [PacketHandler(RealmOp.MSG_MOVE_START_STRAFE_RIGHT)]
        [PacketHandler(RealmOp.MSG_MOVE_STOP_STRAFE)]
        [PacketHandler(RealmOp.MSG_MOVE_JUMP)]
        [PacketHandler(RealmOp.MSG_MOVE_START_TURN_LEFT)]
        [PacketHandler(RealmOp.MSG_MOVE_START_TURN_RIGHT)]
        [PacketHandler(RealmOp.MSG_MOVE_STOP_TURN)]
        [PacketHandler(RealmOp.MSG_MOVE_START_PITCH_UP)]
        [PacketHandler(RealmOp.MSG_MOVE_START_PITCH_DOWN)]
        [PacketHandler(RealmOp.MSG_MOVE_STOP_PITCH)]
        [PacketHandler(RealmOp.MSG_MOVE_SET_RUN_MODE)]
        [PacketHandler(RealmOp.MSG_MOVE_SET_WALK_MODE)]
        [PacketHandler(RealmOp.MSG_MOVE_FALL_LAND)]
        [PacketHandler(RealmOp.MSG_MOVE_START_SWIM)]
        [PacketHandler(RealmOp.MSG_MOVE_STOP_SWIM)]
        [PacketHandler(RealmOp.MSG_MOVE_SET_FACING)]
        [PacketHandler(RealmOp.MSG_MOVE_SET_PITCH)]
        [PacketHandler(RealmOp.MSG_MOVE_HEARTBEAT)]
        [PacketHandler(RealmOp.CMSG_MOVE_FALL_RESET)]
        [PacketHandler(RealmOp.CMSG_MOVE_SET_FLY)]
        [PacketHandler(RealmOp.MSG_MOVE_START_ASCEND)]
        [PacketHandler(RealmOp.MSG_MOVE_STOP_ASCEND)]
        [PacketHandler(RealmOp.CMSG_MOVE_CHNG_TRANSPORT)]
        [PacketHandler(RealmOp.MSG_MOVE_START_DESCEND)]

        public static PacketProcessResult HandleMovement(PacketProcessor p)
        {
            if (p.sock._player == null) //should never happen but if someone messes with code...
                return PacketProcessResult.Processed;

            Debug.Assert(p is RealmPacketProcessor);

            var RealmProcessor = p as RealmPacketProcessor;
            MovementData data = new MovementData();

            data.Read(p.currentPacket);

            p.sock._player.MovementUpdate(RealmProcessor.CurrentOpcode, data);

            return PacketProcessResult.Processed;
        }
    }
}