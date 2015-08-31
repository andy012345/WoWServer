using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Orleans.Streams;
using Shared;
using System.Collections;


namespace Server
{
    public partial class Session
    {
        public async Task HandleNameQuery(CMSG_NAME_QUERY pkt)
        {
            var player = GrainFactory.GetGrain<IPlayer>(pkt.guid.ToInt64());
            var valid = await player.IsValid();

            var guid_packed = new PackedGUID(pkt.guid);

            PacketOut p = new PacketOut(RealmOp.SMSG_NAME_QUERY_RESPONSE);
            p.Write(guid_packed);

            if (!valid)
            {
                p.Write((byte)1); //unknown
                await SendPacket(p);
                return;
            }

            p.Write((byte)0); //known
            p.WriteCString(await player.GetName());

            var realmid = await player.GetRealmID();

            if (realmid != await GetRealmID()) //player is on a different realm to this session, append their realm name
            {
                var realm_manager = GrainFactory.GetGrain<IRealmManager>(0);
                p.WriteCString(await realm_manager.GetRealmName((int)realmid));
            }
            else
                p.Write((byte)0); //null string aka same realm aka dont show anything extra

            p.Write(await player.GetRace());
            p.Write(await player.GetGender());
            p.Write(await player.GetClass());
            p.Write((byte)0); //isNameDeclined

            await SendPacket(p);
        }
    }
}
