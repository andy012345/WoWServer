using Server.RealmServer;
using Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Networking
{
    public enum PacketProcessResult
    {
        Processed,
        RequiresData,
        Error,
    }

    public class PacketProcessor
    {
        public PacketIn CurrentPacket;
        public ServerSocket ClientConnection = null;

        public int DataNeeded = 0;

        public PacketProcessor()
        {
            Reset();
        }

        private void Reset()
        {
            CurrentPacket = new PacketIn();
            DataNeeded = DefaultDataNeeded();
        }

        public virtual int DefaultDataNeeded()
        {
            return 0;
        }

        public void SetSocket(ServerSocket s)
        {
            ClientConnection = s;
        }

        public void ReadHandler(byte[] data, int dataIndex, int dataSize)
        {
            int copyAmount = 0;

            var res = OnReceive(data, dataIndex, dataSize, out copyAmount);

            if (res == PacketProcessResult.Error) //Unknown data on a stream that doesn't have a reported size
            {
                ClientConnection.Dispose();
                return;
            }

            if (res == PacketProcessResult.Processed)
            {
                CurrentPacket.Reset();
                DataNeeded = DefaultDataNeeded();

                var realmProcessor = this as RealmPacketProcessor;
                if (realmProcessor != null)
                    realmProcessor.DecryptPointer = 0;
            }
            dataIndex += copyAmount;

            if (dataIndex < dataSize)
            {
                //we have more data to process
                ReadHandler(data, dataIndex, dataSize);
            }
        }

        private PacketProcessResult OnReceive(byte[] data, int dataIndex, int dataSize, out int copyAmount)
        {
            copyAmount = 0;
            int dataLeft = DataNeeded - (int) CurrentPacket.Length;

            if (dataLeft >= 1)
            {
                if (dataLeft <= (dataSize - dataIndex)) //we have received all we need to continue processing, WOO!
                {
                    CurrentPacket.Write(data, dataIndex, dataLeft);
                    copyAmount = dataLeft;
                    //pass to our handler
                    return HandleProcess();
                }
                else
                {
                    //copy what we can :(
                    CurrentPacket.Write(data, dataIndex, (dataSize - dataIndex));
                    copyAmount = (dataSize - dataIndex);
                    return PacketProcessResult.RequiresData;
                }
            }
            return HandleProcess();
        }

        public virtual PacketProcessResult ProcessData()
        {
            return PacketProcessResult.Processed;
        }

        public virtual void OnConnect(ServerSocket parent = null)
        {
        }

        private PacketProcessResult HandleProcess()
        {
            var oldPosition = CurrentPacket.Position;
            CurrentPacket.Position = 0;

            var retval = ProcessData();

            CurrentPacket.Position = oldPosition;

            return retval;
        }
    }
}