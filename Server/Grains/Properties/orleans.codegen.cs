//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Server
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Orleans;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    using Shared;
    using Orleans.Runtime;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.AccountGrain")]
    public class AccountGrainState : global::Orleans.GrainState, AccountState
    {
        

            public AccountFlags @Flags { get; set; }

            public String @Password { get; set; }

            public String @PasswordPlain { get; set; }

            public AccountData @Data { get; set; }

            public PlayerCharacterListEntry[] @CharacterList { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Flags", out value)) @Flags = (AccountFlags) value;
                if (values.TryGetValue("Password", out value)) @Password = (String) value;
                if (values.TryGetValue("PasswordPlain", out value)) @PasswordPlain = (String) value;
                if (values.TryGetValue("Data", out value)) @Data = (AccountData) value;
                if (values.TryGetValue("CharacterList", out value)) @CharacterList = (PlayerCharacterListEntry[]) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("AccountGrainState( Flags={0} Password={1} PasswordPlain={2} Data={3} CharacterList={4} )", @Flags, @Password, @PasswordPlain, @Data, @CharacterList);
            }
        
        public AccountGrainState() : 
                base("Server.AccountGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Flags"] = this.Flags;
            result["Password"] = this.Password;
            result["PasswordPlain"] = this.PasswordPlain;
            result["Data"] = this.Data;
            result["CharacterList"] = this.CharacterList;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Flags = default(AccountFlags);
            this.Password = default(String);
            this.PasswordPlain = default(String);
            this.Data = new AccountData();
            this.CharacterList = default(PlayerCharacterListEntry[]);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            AccountGrainState input = ((AccountGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            AccountGrainState input = ((AccountGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            AccountGrainState result = new AccountGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.UnitImpl")]
    public class UnitImplState : global::Orleans.GrainState, UnitData
    {
        

            public Int32 @object_test { get; set; }

            public Int32 @unit_test { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("object_test", out value)) @object_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("unit_test", out value)) @unit_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
            }

            public override System.String ToString()
            {
                return System.String.Format("UnitImplState( object_test={0} unit_test={1} )", @object_test, @unit_test);
            }
        
        public UnitImplState() : 
                base("Server.UnitImpl")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["object_test"] = this.object_test;
            result["unit_test"] = this.unit_test;
            return result;
        }
        
        private void InitStateFields()
        {
            this.object_test = default(Int32);
            this.unit_test = default(Int32);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            UnitImplState input = ((UnitImplState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            UnitImplState input = ((UnitImplState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            UnitImplState result = new UnitImplState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.Player")]
    public class PlayerState : global::Orleans.GrainState, PlayerData
    {
        

            public Int32 @unit_test { get; set; }

            public Int32 @object_test { get; set; }

            public Int32 @player_test { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("unit_test", out value)) @unit_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("object_test", out value)) @object_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("player_test", out value)) @player_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
            }

            public override System.String ToString()
            {
                return System.String.Format("PlayerState( unit_test={0} object_test={1} player_test={2} )", @unit_test, @object_test, @player_test);
            }
        
        public PlayerState() : 
                base("Server.Player")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["unit_test"] = this.unit_test;
            result["object_test"] = this.object_test;
            result["player_test"] = this.player_test;
            return result;
        }
        
        private void InitStateFields()
        {
            this.unit_test = default(Int32);
            this.object_test = default(Int32);
            this.player_test = default(Int32);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            PlayerState input = ((PlayerState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            PlayerState input = ((PlayerState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            PlayerState result = new PlayerState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.PlayerImpl")]
    public class PlayerImplState : global::Orleans.GrainState, PlayerData
    {
        

            public Int32 @unit_test { get; set; }

            public Int32 @object_test { get; set; }

            public Int32 @player_test { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("unit_test", out value)) @unit_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("object_test", out value)) @object_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("player_test", out value)) @player_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
            }

            public override System.String ToString()
            {
                return System.String.Format("PlayerImplState( unit_test={0} object_test={1} player_test={2} )", @unit_test, @object_test, @player_test);
            }
        
        public PlayerImplState() : 
                base("Server.PlayerImpl")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["unit_test"] = this.unit_test;
            result["object_test"] = this.object_test;
            result["player_test"] = this.player_test;
            return result;
        }
        
        private void InitStateFields()
        {
            this.unit_test = default(Int32);
            this.object_test = default(Int32);
            this.player_test = default(Int32);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            PlayerImplState input = ((PlayerImplState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            PlayerImplState input = ((PlayerImplState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            PlayerImplState result = new PlayerImplState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.ObjectImpl")]
    public class ObjectImplState : global::Orleans.GrainState, ObjectData
    {
        

            public Int32 @object_test { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("object_test", out value)) @object_test = value is Int64 ? (Int32)(Int64)value : (Int32)value;
            }

            public override System.String ToString()
            {
                return System.String.Format("ObjectImplState( object_test={0} )", @object_test);
            }
        
        public ObjectImplState() : 
                base("Server.ObjectImpl")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["object_test"] = this.object_test;
            return result;
        }
        
        private void InitStateFields()
        {
            this.object_test = default(Int32);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            ObjectImplState input = ((ObjectImplState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            ObjectImplState input = ((ObjectImplState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            ObjectImplState result = new ObjectImplState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.RealmManager")]
    public class RealmManagerState : global::Orleans.GrainState, RealManagerState
    {
        

            public Dictionary<Int32,Realm> @RealmMap { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("RealmMap", out value)) @RealmMap = (Dictionary<Int32,Realm>) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("RealmManagerState( RealmMap={0} )", @RealmMap);
            }
        
        public RealmManagerState() : 
                base("Server.RealmManager")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["RealmMap"] = this.RealmMap;
            return result;
        }
        
        private void InitStateFields()
        {
            this.RealmMap = new Dictionary<Int32,Realm>();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            RealmManagerState input = ((RealmManagerState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            RealmManagerState input = ((RealmManagerState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            RealmManagerState result = new RealmManagerState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.9.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Server.Session")]
    public class SessionState : global::Orleans.GrainState, SessionData
    {
        

            public Byte[] @SessionKey { get; set; }

            public IAccountGrain @Account { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("SessionKey", out value)) @SessionKey = (Byte[]) value;
                if (values.TryGetValue("Account", out value)) @Account = (IAccountGrain) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("SessionState( SessionKey={0} Account={1} )", @SessionKey, @Account);
            }
        
        public SessionState() : 
                base("Server.Session")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["SessionKey"] = this.SessionKey;
            result["Account"] = this.Account;
            return result;
        }
        
        private void InitStateFields()
        {
            this.SessionKey = default(Byte[]);
            this.Account = default(IAccountGrain);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            SessionState input = ((SessionState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            SessionState input = ((SessionState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            SessionState result = new SessionState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
