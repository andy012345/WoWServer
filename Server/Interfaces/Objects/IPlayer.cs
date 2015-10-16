using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System;
using Server;
using Shared;

namespace Server
{
    public interface IPlayerByNameIndex : IGrainWithStringKey
    {
        Task<bool> SetPlayer(IPlayer plr);
        Task<ObjectGUID> GetPlayerGUID();
        Task<IPlayer> GetPlayer();
        Task Save();
    }

    public interface IPlayer : IPlayerImpl
    {
    }

    public interface IPlayerImpl : IUnitImpl
    {
        // Task<string> VirtualCall();
        Task<string> PlayerCall();
        Task<LoginErrorCode> Create(PlayerCreateData info);
        Task<PacketOut> BuildEnum();
        Task Kick(bool remove_from_world = false);
        Task<string> GetAccount();
        Task OnLogin();
        Task Login();

        Task SendPacket(PacketOut pkt);

        Task BuildInitialUpdate();

        Task Logout(bool instant = false);
        Task OnLogout();

        Task<string> GetName();
        Task<UInt32> GetRealmID();

        Task<byte> GetRace();
        Task<byte> GetGender();
        Task<byte> GetClass();

        Task MovementUpdate(RealmOp opcode, MovementData data);
    }
}