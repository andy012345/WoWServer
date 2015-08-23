using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public enum SocketCommands : byte
    {
        DisconnectClient,
        ClientHasDisconnected,
        SetAccount,
        SetPlayer,
        ClearAccount,
        ClearPlayer,
        Unknown
    }

    public class SocketCommand
    {
        public SocketCommands _command = SocketCommands.Unknown;
        public object[] _extraData;

        public SocketCommands GetCommand() { return _command; }
        public object GetData(int field) { return _extraData[field]; }

        public SocketCommand(SocketCommands cmd) { _command = cmd; }
        public SocketCommand(SocketCommands cmd, object[] data) { _command = cmd; _extraData = data; }
    }
}
