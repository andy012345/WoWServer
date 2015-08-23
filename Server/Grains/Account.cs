using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;
using Orleans.Storage;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using Shared;

namespace Server
{
    public class AccountData
    {
        public byte[][] Data = new byte[8][];
        public UInt32[] TimeStamp = new UInt32[8];
        public UInt32[] Size = new UInt32[8]; //Decompressed size of data
    }

    public class PlayerCharacterListEntry
    {
        public ObjectGUID Player = null;
        public int CharacterSlot = 0;
        public int RealmID = 0;
    }

    public class  AccountState : GrainState
    {
        public AccountFlags Flags { get; set; }

        public string Password { get; set; }
        public string PasswordPlain { get; set; }

        //Account Data, I think this is for the UI config or something. Whatever.
        AccountData _Data = new AccountData();
        List<PlayerCharacterListEntry> _CharacterList = new List<PlayerCharacterListEntry>();
        public AccountData Data { get { return _Data; } set { _Data = value; } }
        public List<PlayerCharacterListEntry> CharacterList { get { return _CharacterList; } set { _CharacterList = value; } }

        ObjectGUID _activePlayer = new ObjectGUID(0);
        public ObjectGUID ActivePlayer { get { return _activePlayer; } set { _activePlayer = value; } }
    }

    public enum AccountFlags
    {
        AccountFlagNone = 0,
        AccountNotValid = 1,
    }

    [Reentrant]
    [StorageProvider(ProviderName = "Default")]
    public class AccountGrain : Grain<AccountState>, IAccount
    {
        List<ISession> ActiveSessions = new List<ISession>();
        ISession AuthSession;
        ISession RealmSession;
        SessionStream AuthSessionStream = null;
        SessionStream RealmSessionStream = null;
        int RealmSessionRealmID = 0;

        public override async Task OnActivateAsync()
        {
            await base.OnActivateAsync();

            if (State.Password == null || State.Password.Length == 0)
                State.Flags |= AccountFlags.AccountNotValid;

            if (State.Data == null)
                State.Data = new AccountData();
        }

        void Save()
        {
            if ((State.Flags & AccountFlags.AccountNotValid) == AccountFlags.AccountNotValid)
                return;
            WriteStateAsync();
        }

        bool IntIsValid()
        {
            if ((State.Flags & AccountFlags.AccountNotValid) == AccountFlags.AccountNotValid)
                return false;
            return true;
        }

        public Task<bool> IsValid()
        {
            return Task.FromResult(IntIsValid());
        }

        public Task Destroy() { DeactivateOnIdle(); return TaskDone.Done; }

        public Task<AccountCreateResponse> CreateAccount(string password)
        {
            if ((State.Flags & AccountFlags.AccountNotValid) != AccountFlags.AccountNotValid)
                return Task.FromResult(AccountCreateResponse.AccountCreateDataAlreadyExists);

            State.Flags &= ~AccountFlags.AccountNotValid;
            SetPassword(password);

            return Task.FromResult(AccountCreateResponse.AccountCreateOk);
        }

        public Task SetPassword(string password)
        {
            //encrypt wow style
            string account = this.GetPrimaryKeyString();
            string upper_account = account.ToUpper();
            string upper_password = password.ToUpper();

            string password_string = upper_account + ":" + upper_password;

            State.Password = Shared.SHA.HashString(password_string);
            State.PasswordPlain = password;


            Save();

            return TaskDone.Done;
        }

        public Task<string> GetPassword() { return Task.FromResult(State.Password); }
        public Task<string> GetPasswordPlain() { return Task.FromResult(State.PasswordPlain); }

        public Task<AccountAuthResponse> Authenticate(string password)
        {
            if ((State.Flags & AccountFlags.AccountNotValid) != 0)
                return Task.FromResult(AccountAuthResponse.AccountAuthNotValid);

            string account = this.GetPrimaryKeyString();
            string upper_account = account.ToUpper();
            string upper_password = password.ToUpper();

            string password_string = upper_account + ":" + upper_password;

            string password_hash = Shared.SHA.HashString(password_string);

            if (password_hash != State.Password)
                return Task.FromResult(AccountAuthResponse.AccountAuthNoMatch);

            return Task.FromResult(AccountAuthResponse.AccountAuthOk);
        }

        public async Task AddSession(ISession s)
        {
            var type = await s.GetSessionType();

            var stream = await s.GetSessionStream();
            if (stream != null && stream.CommandStream != null)
                await stream.CommandStream.OnNextAsync(new SocketCommand(SocketCommands.SetAccount, new object[] { this.AsReference<IAccount>() }));

            switch (type)
            {
                case SessionType.AuthSession:
                    {
                        if (AuthSession != s)
                        {
                            if (AuthSession != null)
                                await RemoveSession(AuthSession, true);
                            if (RealmSession != null)
                                await RemoveSession(RealmSession, true);
                        }
                        AuthSession = s;
                        if (AuthSession != null)
                            AuthSessionStream = await AuthSession.GetSessionStream();
                    } break;
                case SessionType.RealmSession:
                    {
                        if (RealmSession != null && s != RealmSession)
                            await RemoveSession(RealmSession, true);
                        RealmSession = s;
                        if (RealmSession != null)
                        {
                            RealmSessionStream = await RealmSession.GetSessionStream();
                            RealmSessionRealmID = await RealmSession.GetRealmID();
                        }
                    }
                    break;
            }

            ActiveSessions.Add(s);
        }

        public async Task RemoveSession(ISession s, bool disconnect = false)
        {
            var type = await s.GetSessionType();
            switch (type)
            {
                case SessionType.AuthSession:
                    {
                        AuthSession = null;
                        AuthSessionStream = null;
                    }
                    break;
                case SessionType.RealmSession:
                    {
                        RealmSession = null;
                        RealmSessionStream = null;
                    }
                    break;
            }

            ActiveSessions.Remove(s);

            if (disconnect)
                await s.Disconnect();
        }

        public Task<ISession> GetAuthSession() { return Task.FromResult(AuthSession); }
        public Task<ISession> GetRealmSession() { return Task.FromResult(RealmSession); }

        public async Task SendPacketRealm(PacketOut p)
        {
            if (RealmSessionStream == null)
                return;
            p.Finalise();
            await RealmSessionStream.PacketStream.OnNextAsync(p.strm.ToArray());
        }
        public async Task SendPacketAuth(PacketOut p)
        {
            if (AuthSessionStream == null)
                return;
            p.Finalise();
            await AuthSessionStream.PacketStream.OnNextAsync(p.strm.ToArray());
        }

        public Task UpdateAccountData(UInt32 id, UInt32 time, UInt32 size, byte[] data)
        {
            if (id >= 8)
                throw new ArgumentException("id cannot be >= 8");

            State.Data.TimeStamp[id] = time;
            State.Data.Size[id] = size;
            State.Data.Data[id] = data;
            return TaskDone.Done;
        }

        public async Task SendAccountData(UInt32 id)
        {
            if (id >= 8)
                throw new ArgumentException("SendAccountData attempted to use out of range index");

            PacketOut p = new PacketOut(RealmOp.SMSG_UPDATE_ACCOUNT_DATA);
            var guid = (UInt64)0; //TODO: replace with active character if they are there!

            p.Write(guid);
            p.Write(id);

            if (State.Data == null || State.Data.TimeStamp == null || State.Data.Size == null || State.Data.Data == null)
            {
                p.Write((int)0); //time
                p.Write((int)0); //size
            }
            else
            {
                p.Write(State.Data.TimeStamp[id]);
                p.Write(State.Data.Size[id]);
                p.Write(State.Data.Data[id]);
            }

            await SendPacketRealm(p);
        }

        public async Task SendAccountDataTimes(UInt32 mask)
        {
            PacketOut p = new PacketOut(RealmOp.SMSG_ACCOUNT_DATA_TIMES);
            p.Write(Time.GetUnixTime());
            p.Write((byte)1);
            p.Write(mask);

            for (int i = 0; i < 8; ++i)
            {
                if ((mask & (1 << i)) != 0)
                {
                    if (State.Data == null || State.Data.TimeStamp == null)
                        p.Write((int)0);
                    else
                        p.Write(State.Data.TimeStamp[i]);
                }
            }

            await SendPacketRealm(p);
        }

        public async Task SendCharEnum(int RealmID = 0)
        {
            var chars = GetCharacters(RealmID);

            PacketOut p = new PacketOut(RealmOp.SMSG_CHAR_ENUM);

            if (chars == null)
                p.Write((byte)0); //nothing to see here
            else
            {
                p.Write((byte)chars.Length);
                foreach (var c in chars)
                {
                    var plr = GrainFactory.GetGrain<IPlayer>(c.Player.ToInt64());
                    var bytes = await plr.BuildEnum();
                    p.Write(bytes);
                }
            }

            await SendPacketRealm(p);
        }

        PlayerCharacterListEntry[] GetCharacters(int realm)
        {
            if (State.CharacterList == null)
                return null;
            return State.CharacterList.Where(chr => chr.RealmID == realm).ToArray();
        }

        PlayerCharacterListEntry GetCharListEntryForPlayer(IPlayer player)
        {
            if (State.CharacterList == null)
                return null;
            return State.CharacterList.Where(chr => chr.Player == player.GetGUID().Result).FirstOrDefault();
        }

        public async Task CreatePlayer(CMSG_CHAR_CREATE create)
        {
            IDataStoreManager datastore = GrainFactory.GetGrain<IDataStoreManager>(0);

            var createinfo = await datastore.GetPlayerCreateInfo(create.Class, create.Race);

            if (createinfo == null)
            {
                await SendCharCreateReply(LoginErrorCode.CHAR_CREATE_ERROR);
                return;
            }

            var plrnameindex = GrainFactory.GetGrain<IPlayerByNameIndex>(create.Name);
            var guidnameindex = await plrnameindex.GetPlayerGUID();
            if (guidnameindex != 0)
            {
                await SendCharCreateReply(LoginErrorCode.CHAR_CREATE_NAME_IN_USE);
                return;
            }

            var chrclass = await datastore.GetChrClasses(create.Class);
            var chrrace = await datastore.GetChrRaces(create.Race);

            if (chrclass == null || chrrace == null)
            {
                await SendCharCreateReply(LoginErrorCode.CHAR_CREATE_ERROR);
                return;
            }

            var chars = GetCharacters(RealmSessionRealmID);
            if (chars != null && chars.Length >= 10) //todo: add max
            {
                await SendCharCreateReply(LoginErrorCode.CHAR_CREATE_SERVER_LIMIT);
                return;
            }

            var creator = GrainFactory.GetGrain<ICreator>(0);

            //OK LETS CREATE
            PlayerCreateData info = new PlayerCreateData();
            info.CreateData = create;
            info.RealmID = RealmSessionRealmID;
            info.AccountName = this.GetPrimaryKeyString();

            var create_response = await creator.CreatePlayer(info);

            if (create_response.Item1 != LoginErrorCode.CHAR_CREATE_SUCCESS)
            {
                await SendCharCreateReply(create_response.Item1);
                return;

            }
            await plrnameindex.SetPlayer(create_response.Item2);

            await SendCharCreateReply(LoginErrorCode.CHAR_CREATE_SUCCESS);

            await CreateCharacterListEntryForPlayer(info, create_response.Item2);
        }

        public async Task SendCharCreateReply(LoginErrorCode code)
        {
            PacketOut p = new PacketOut(RealmOp.SMSG_CHAR_CREATE);
            p.Write((byte)code);
            await SendPacketRealm(p);
        }

        public async Task CreateCharacterListEntryForPlayer(PlayerCreateData info, IPlayer plr)
        {
            if (State.CharacterList == null)
                State.CharacterList = new List<PlayerCharacterListEntry>();

            var chars = GetCharacters(info.RealmID);
            

            PlayerCharacterListEntry entry = new PlayerCharacterListEntry();
            entry.Player = await plr.GetGUID();
            entry.RealmID = info.RealmID;

            foreach (var c in chars)
                entry.CharacterSlot = c.CharacterSlot + 1;

            State.CharacterList.Add(entry);

            Save();            
        }

        public async Task KickActivePlayer()
        {
            if (State.ActivePlayer == 0)
                return; //no active player :(
            // todo: remove old player
            var old_player = GrainFactory.GetGrain<IPlayer>(State.ActivePlayer.ToInt64());
            if (await old_player.IsValid())
                await old_player.Kick();

            State.ActivePlayer = 0;
        }

        public async Task PlayerLogin(CMSG_PLAYER_LOGIN pkt)
        {
            if (State.ActivePlayer != 0)
                await KickActivePlayer();

            var player = GrainFactory.GetGrain<IPlayer>(pkt.GUID.ToInt64());
            var valid = await player.IsValid();
            var player_account = await player.GetAccount();

            //just a quick sanity check for edited packets
            if (!valid || player_account != this.GetPrimaryKeyString())
                return;

            await player.Login();
        }
    }
}
