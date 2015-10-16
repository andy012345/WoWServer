using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [Flags]
    public enum MovementFlags
    {
        MOVEMENTFLAG_NONE = 0x00000000,
        MOVEMENTFLAG_FORWARD = 0x00000001,
        MOVEMENTFLAG_BACKWARD = 0x00000002,
        MOVEMENTFLAG_STRAFE_LEFT = 0x00000004,
        MOVEMENTFLAG_STRAFE_RIGHT = 0x00000008,
        MOVEMENTFLAG_LEFT = 0x00000010,
        MOVEMENTFLAG_RIGHT = 0x00000020,
        MOVEMENTFLAG_PITCH_UP = 0x00000040,
        MOVEMENTFLAG_PITCH_DOWN = 0x00000080,
        MOVEMENTFLAG_WALKING = 0x00000100,               // Walking
        MOVEMENTFLAG_ONTRANSPORT = 0x00000200,               // Used for flying on some creatures
        MOVEMENTFLAG_DISABLE_GRAVITY = 0x00000400,               // Former MOVEMENTFLAG_LEVITATING. This is used when walking is not possible.
        MOVEMENTFLAG_ROOT = 0x00000800,               // Must not be set along with MOVEMENTFLAG_MASK_MOVING
        MOVEMENTFLAG_FALLING = 0x00001000,               // damage dealt on that type of falling
        MOVEMENTFLAG_FALLING_FAR = 0x00002000,
        MOVEMENTFLAG_PENDING_STOP = 0x00004000,
        MOVEMENTFLAG_PENDING_STRAFE_STOP = 0x00008000,
        MOVEMENTFLAG_PENDING_FORWARD = 0x00010000,
        MOVEMENTFLAG_PENDING_BACKWARD = 0x00020000,
        MOVEMENTFLAG_PENDING_STRAFE_LEFT = 0x00040000,
        MOVEMENTFLAG_PENDING_STRAFE_RIGHT = 0x00080000,
        MOVEMENTFLAG_PENDING_ROOT = 0x00100000,
        MOVEMENTFLAG_SWIMMING = 0x00200000,               // appears with fly flag also
        MOVEMENTFLAG_ASCENDING = 0x00400000,               // press "space" when flying
        MOVEMENTFLAG_DESCENDING = 0x00800000,
        MOVEMENTFLAG_CAN_FLY = 0x01000000,               // Appears when unit can fly AND also walk
        MOVEMENTFLAG_FLYING = 0x02000000,               // unit is actually flying. pretty sure this is only used for players. creatures use disable_gravity
        MOVEMENTFLAG_SPLINE_ELEVATION = 0x04000000,               // used for flight paths
        MOVEMENTFLAG_SPLINE_ENABLED = 0x08000000,               // used for flight paths
        MOVEMENTFLAG_WATERWALKING = 0x10000000,               // prevent unit from falling through water
        MOVEMENTFLAG_FALLING_SLOW = 0x20000000,               // active rogue safe fall spell (passive)
        MOVEMENTFLAG_HOVER = 0x40000000,               // hover, cannot jump

        /// @todo Check if PITCH_UP and PITCH_DOWN really belong here..
        MOVEMENTFLAG_MASK_MOVING =
            MOVEMENTFLAG_FORWARD | MOVEMENTFLAG_BACKWARD | MOVEMENTFLAG_STRAFE_LEFT | MOVEMENTFLAG_STRAFE_RIGHT |
            MOVEMENTFLAG_PITCH_UP | MOVEMENTFLAG_PITCH_DOWN | MOVEMENTFLAG_FALLING | MOVEMENTFLAG_FALLING_FAR | MOVEMENTFLAG_ASCENDING | MOVEMENTFLAG_DESCENDING |
            MOVEMENTFLAG_SPLINE_ELEVATION,

        MOVEMENTFLAG_MASK_TURNING =
            MOVEMENTFLAG_LEFT | MOVEMENTFLAG_RIGHT,

        MOVEMENTFLAG_MASK_MOVING_FLY =
            MOVEMENTFLAG_FLYING | MOVEMENTFLAG_ASCENDING | MOVEMENTFLAG_DESCENDING,

        /// @todo if needed: add more flags to this masks that are exclusive to players
        MOVEMENTFLAG_MASK_PLAYER_ONLY =
            MOVEMENTFLAG_FLYING,

        /// Movement flags that have change status opcodes associated for players
        MOVEMENTFLAG_MASK_HAS_PLAYER_STATUS_OPCODE = MOVEMENTFLAG_DISABLE_GRAVITY | MOVEMENTFLAG_ROOT |
            MOVEMENTFLAG_CAN_FLY | MOVEMENTFLAG_WATERWALKING | MOVEMENTFLAG_FALLING_SLOW | MOVEMENTFLAG_HOVER
    };

    [Flags]
    public enum MovementFlags2
    {
        MOVEMENTFLAG2_NONE = 0x00000000,
        MOVEMENTFLAG2_NO_STRAFE = 0x00000001,
        MOVEMENTFLAG2_NO_JUMPING = 0x00000002,
        MOVEMENTFLAG2_UNK3 = 0x00000004,        // Overrides various clientside checks
        MOVEMENTFLAG2_FULL_SPEED_TURNING = 0x00000008,
        MOVEMENTFLAG2_FULL_SPEED_PITCHING = 0x00000010,
        MOVEMENTFLAG2_ALWAYS_ALLOW_PITCHING = 0x00000020,
        MOVEMENTFLAG2_UNK7 = 0x00000040,
        MOVEMENTFLAG2_UNK8 = 0x00000080,
        MOVEMENTFLAG2_UNK9 = 0x00000100,
        MOVEMENTFLAG2_UNK10 = 0x00000200,
        MOVEMENTFLAG2_INTERPOLATED_MOVEMENT = 0x00000400,
        MOVEMENTFLAG2_INTERPOLATED_TURNING = 0x00000800,
        MOVEMENTFLAG2_INTERPOLATED_PITCHING = 0x00001000,
        MOVEMENTFLAG2_UNK14 = 0x00002000,
        MOVEMENTFLAG2_UNK15 = 0x00004000,
        MOVEMENTFLAG2_UNK16 = 0x00008000
    };


    public struct MovementData
    {
        public PackedGUID GUID;
        public MovementFlags Flags;
        public MovementFlags2 Flags2;
        public float PositionX;
        public float PositionY;
        public float PositionZ;
        public float PositionO;
        public UInt32 Time;

        //transport data
        public MovementDataTransport MovementDataTransport;

        public float Pitch;
        public UInt32 FallTime;
        public float FallVerticalSpeed;
        public float FallSine;
        public float FallCosine;
        public float FallLateralSpeed;
        public float SplineElevation;


        public void Read(PacketIn p)
        {
            GUID = p.ReadPackedGUID();

            Flags = (MovementFlags)p.ReadUInt32();
            Flags2 = (MovementFlags2)p.ReadUInt16();
            Time = p.ReadUInt32();

            PositionX = p.ReadSingle();
            PositionY = p.ReadSingle();
            PositionZ = p.ReadSingle();
            PositionO = p.ReadSingle();

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_ONTRANSPORT))
            {
                if (MovementDataTransport == null)
                    MovementDataTransport = new MovementDataTransport();

                MovementDataTransport.TransportGuid = p.ReadPackedGUID();
                MovementDataTransport.TransportX = p.ReadSingle();
                MovementDataTransport.TransportY = p.ReadSingle();
                MovementDataTransport.TransportZ = p.ReadSingle();
                MovementDataTransport.TransportO = p.ReadSingle();
                MovementDataTransport.TransportTime = p.ReadUInt32();
                MovementDataTransport.TransportSeat = p.ReadByte();

                if (Flags2.HasFlag(MovementFlags2.MOVEMENTFLAG2_INTERPOLATED_MOVEMENT))
                    MovementDataTransport.TransportTime2 = p.ReadUInt32();
            }

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_SWIMMING | MovementFlags.MOVEMENTFLAG_FLYING) ||
                Flags2.HasFlag(MovementFlags2.MOVEMENTFLAG2_ALWAYS_ALLOW_PITCHING))
                Pitch = p.ReadSingle();

            FallTime = p.ReadUInt32();

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_FALLING))
            {
                FallVerticalSpeed = p.ReadSingle();
                FallSine = p.ReadSingle();
                FallCosine = p.ReadSingle();
                FallLateralSpeed = p.ReadSingle();
            }

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_SPLINE_ELEVATION))
                SplineElevation = p.ReadSingle();
        }

        public void Write(PacketOut p)
        {
            p.Write(GUID);
            p.Write((UInt32)Flags);
            p.Write((UInt16)Flags2);
            p.Write(Time);
            p.Write(PositionX);
            p.Write(PositionY);
            p.Write(PositionZ);
            p.Write(PositionO);

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_ONTRANSPORT))
            {
                if (MovementDataTransport == null)
                    MovementDataTransport = new MovementDataTransport();

                p.Write(MovementDataTransport.TransportGuid);
                p.Write(MovementDataTransport.TransportX);
                p.Write(MovementDataTransport.TransportY);
                p.Write(MovementDataTransport.TransportZ);
                p.Write(MovementDataTransport.TransportO);
                p.Write(MovementDataTransport.TransportTime);
                p.Write(MovementDataTransport.TransportSeat);

                if (Flags2.HasFlag(MovementFlags2.MOVEMENTFLAG2_INTERPOLATED_MOVEMENT))
                    p.Write(MovementDataTransport.TransportTime2);
            }

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_SWIMMING | MovementFlags.MOVEMENTFLAG_FLYING) ||
    Flags2.HasFlag(MovementFlags2.MOVEMENTFLAG2_ALWAYS_ALLOW_PITCHING))
                p.Write(Pitch);

            p.Write(FallTime);

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_FALLING))
            {
                p.Write(FallVerticalSpeed);
                p.Write(FallSine);
                p.Write(FallCosine);
                p.Write(FallLateralSpeed);
            }

            if (Flags.HasFlag(MovementFlags.MOVEMENTFLAG_SPLINE_ELEVATION))
                p.Write(SplineElevation);

        }
    }
}