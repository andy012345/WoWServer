using System.Threading.Tasks;
using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Linq;
using Shared;

namespace Server
{
    enum GTable
    {
        RecordsPerLevel = 100,
        Ratings = 32,
    }

    public class GTCombatRatingsEntry : DBCStore<GameTableEntry>
    {
        public GameTableEntry Get(UInt32 Class, UInt32 Level)
        {
            if (Level >= (UInt32)GTable.RecordsPerLevel) Level = (UInt32)GTable.RecordsPerLevel;
            return Get((int)((Class - 1) * (Level - 1)));
        }
    }

    public class GameTableEntry : DBCRecordBase
    {
        public float value;

        public override int Read()
        {
            value = GetFloat(0); return -1;
        }
    }
}
