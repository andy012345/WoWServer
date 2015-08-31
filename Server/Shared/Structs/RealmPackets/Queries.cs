using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public struct CMSG_NAME_QUERY
    {
        public ObjectGUID guid;

        public void Read(PacketIn p)
        {
            guid = p.ReadGUID();
        }
    }
}
