using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Orleans.Streams;
using Shared;
using Server.AuthServer;
using Server.RealmServer;

namespace Server.Networking
{
    public class SocketPacketObserver : IAsyncObserver<byte[]>
    {
        private ServerSocket sock;

        public SocketPacketObserver(ServerSocket s)
        {
            sock = s;
        }

        public Task OnCompletedAsync()
        {
            return TaskDone.Done;
        }

        public Task OnErrorAsync(Exception ex)
        {
            return TaskDone.Done;
        }

        public Task OnNextAsync(byte[] item, StreamSequenceToken token)
        {
            if (sock != null)
                sock.Send(item);
            return TaskDone.Done;
        }
    }

    public class SocketCommandObserver : IAsyncObserver<SocketCommand>
    {
        private ServerSocket sock;

        public SocketCommandObserver(ServerSocket s)
        {
            sock = s;
        }

        public Task OnCompletedAsync()
        {
            throw new NotImplementedException();
        }

        public Task OnErrorAsync(Exception ex)
        {
            throw new NotImplementedException();
        }

        public Task OnNextAsync(SocketCommand item, StreamSequenceToken token)
        {
            switch (item.GetCommand())
            {
                case SocketCommands.DisconnectClient:
                    {
                        sock.Dispose();
                    }
                    break;
                case SocketCommands.SetAccount:
                    {
                        sock.CurrentAccount = (IAccount)item.GetData(0);
                    }
                    break;
                case SocketCommands.SetPlayer:
                    {
                        sock.CurrentPlayer = (IPlayer)item.GetData(0);
                    }
                    break;
                case SocketCommands.ClearAccount:
                    {
                        sock.CurrentAccount = null;
                    }
                    break;
                case SocketCommands.ClearPlayer:
                    {
                        sock.CurrentPlayer = null;
                    }
                    break;
            }

            return TaskDone.Done;
        }
    }

    public class ServerSocket : IDisposable
    {
        private Socket _sock = null;
        private SocketPermission _permissions = null;

        private PacketProcessor _processor = null;
        private SocketPacketObserver _packetObserver = null;
        private StreamSubscriptionHandle<byte[]> _packetObserverHandle = null;

        private SocketCommandObserver _commandObserver = null;
        private StreamSubscriptionHandle<SocketCommand> _commandObserverHandle = null;

        public ARC4 Decrypt = null;
        public ARC4 Encrypt = null;

        //cached data
        public ISession CurrentSession = null;
        public IAccount CurrentAccount = null;
        public IPlayer CurrentPlayer = null;

        public ServerSocket()
        {
        }

        public ServerSocket(AddressFamily addressFamily, SocketType sockType, ProtocolType protoType)
        {
            /*

            These should always be for the server:
            addressFamily = InterNetwork
            sockType = Stream
            protoType = Tcp

            */
            _sock = new Socket(addressFamily, sockType, protoType);
            _sock.NoDelay = true;
        }

        public ServerSocket(Socket s)
        {
            _sock = s;
            _sock.NoDelay = true;
        }

        public void CreateSession()
        {
            CurrentSession = Orleans.GrainClient.GrainFactory.GetGrain<ISession>(Guid.NewGuid());
                //create a unique session for this socket

            if (CurrentSession == null)
                throw new Exception("Socket failed to create orleans session");

            if (_processor != null)
            {
                if (_processor is LogonPacketProcessor)
                    CurrentSession.SetSessionType(SessionType.AuthSession);
                if (_processor is RealmPacketProcessor)
                    CurrentSession.SetSessionType(SessionType.RealmSession);
            }

            var provider = Orleans.GrainClient.GetStreamProvider("PacketStream");

            if (provider == null)
                throw new Exception("Socket: failed to get PacketStream provider");

            var packetstream = provider.GetStream<byte[]>(CurrentSession.GetPrimaryKey(), "SessionPacketStream");
            var commandstream = provider.GetStream<SocketCommand>(CurrentSession.GetPrimaryKey(), "SessionCommandStream");

            if (packetstream == null)
                throw new Exception("Socket: failed to get packetstream");
            if (commandstream == null)
                throw new Exception("Socket: failed to get commandstream");

            _packetObserver = new SocketPacketObserver(this);
            _packetObserverHandle = packetstream.SubscribeAsync(_packetObserver).Result;
            _commandObserver = new SocketCommandObserver(this);
            _commandObserverHandle = commandstream.SubscribeAsync(_commandObserver).Result;
        }


        public void Send(byte[] buffer)
        {
            Send(buffer, buffer.Length);
        }

        public void Send(byte[] buffer, int bufferSize)
        {
            //TODO: Move so not generic code but realm only code
            if (Encrypt != null && bufferSize >= 4)
                Encrypt.Process(buffer, 0, 4);

            SocketAsyncEventArgs ev = new SocketAsyncEventArgs();
            ev.SetBuffer(buffer, 0, bufferSize);
            ev.Completed += AsyncSendEvent;

            if (!_sock.SendAsync(ev))
                OnSend(ev);
        }

        private void AsyncSendEvent(object sender, SocketAsyncEventArgs e)
        {
            OnSend(e);
        }

        private void OnSend(SocketAsyncEventArgs e)
        {
            if (e.SocketError != SocketError.Success)
                Console.WriteLine("Socket Error {0}", e.SocketError.ToString());
        }

        public void Read(int bufferSize = 8192, byte[] reusebuffer = null)
        {
            SocketAsyncEventArgs ev = new SocketAsyncEventArgs();
            byte[] buf = reusebuffer;
            if (buf == null)
                buf = new byte[bufferSize];
            ev.SetBuffer(buf, 0, bufferSize);
            ev.Completed += AsyncReadEvent;

            if (!_sock.ReceiveAsync(ev))
                OnReceive(ev);
        }

        private void AsyncReadEvent(object sender, SocketAsyncEventArgs e)
        {
            OnReceive(e);
        }

        private void OnReceive(SocketAsyncEventArgs e)
        {
            if (e.BytesTransferred == 0 || e.SocketError != SocketError.Success) //disconnected
            {
                Dispose();
                return;
            }

            if (_processor != null)
                _processor.ReadHandler(e.Buffer, 0, e.BytesTransferred);

            Read(e.Buffer.Length, e.Buffer); //reuse buffers
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _sock.Dispose();
                _sock = null;
                _processor = null;

                if (CurrentSession != null)
                {
                    CurrentSession.OnSocketDisconnect();
                    CurrentSession = null;
                }

                if (_packetObserverHandle != null)
                    _packetObserverHandle.UnsubscribeAsync().Wait();
                if (_commandObserverHandle != null)
                    _commandObserverHandle.UnsubscribeAsync().Wait();
            }
        }

        public void Bind(UInt16 port)
        {
            SetupPermissions();
            _sock.Bind(new IPEndPoint(IPAddress.Any, port));
        }

        public void Listen(int backlog)
        {
            _sock.Listen(backlog);
        }

        public void Accept()
        {
            SocketAsyncEventArgs ev = new SocketAsyncEventArgs();
            ev.Completed += AcceptAsyncEvent;

            if (!_sock.AcceptAsync(ev))
                OnAccept(ev);
        }

        private void AcceptAsyncEvent(object sender, SocketAsyncEventArgs e)
        {
            OnAccept(e);
        }

        private void OnAccept(SocketAsyncEventArgs e)
        {
            if (e.SocketError != SocketError.Success)
                return;

            var newsocket = e.AcceptSocket;

            if (newsocket != null)
            {
                ServerSocket sck = new ServerSocket(newsocket);
                //inherit my packet processor
                sck.SetProcessor((PacketProcessor) Activator.CreateInstance(_processor.GetType()));
                sck._processor.ClientConnection = sck;
                sck.CreateSession();

                sck.OnConnect(this);
                sck.Read();
            }

            Accept();
        }

        public void SetupPermissions()
        {
            _permissions = new SocketPermission(NetworkAccess.Accept,
                TransportType.Tcp, "", SocketPermission.AllPorts);
        }

        public void SetProcessor(PacketProcessor p)
        {
            _processor = p;
            p.SetSocket(this);
        }

        private void OnConnect(ServerSocket parent = null)
        {
            if (_processor != null)
                _processor.OnConnect(parent);
        }
    }
}