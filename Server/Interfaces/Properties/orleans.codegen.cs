#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Interfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Server
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IDataStoreManager))]
    internal class OrleansCodeGenDataStoreManagerReference : global::Orleans.Runtime.GrainReference, global::Server.IDataStoreManager
    {
        protected @OrleansCodeGenDataStoreManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenDataStoreManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2116077755;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IDataStoreManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2116077755;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2116077755:
                    switch (@methodId)
                    {
                        case -1601724582:
                            return "GetConnectionString";
                        case -511591145:
                            return "GetPlayerCreateInfo";
                        case 1387734599:
                            return "GetChrClasses";
                        case 1590344148:
                            return "GetChrRaces";
                        case 571002267:
                            return "GetMapEntry";
                        case -1190088203:
                            return "GetCreatureEntriesByMap";
                        case -2102013331:
                            return "GetCreatureEntry";
                        case -1651406328:
                            return "GetCreatureTemplate";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2116077755 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetConnectionString()
        {
            return base.@InvokeMethodAsync<global::System.String>(-1601724582, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PlayerCreateInfo> @GetPlayerCreateInfo(global::System.UInt32 @Class, global::System.UInt32 @Race)
        {
            return base.@InvokeMethodAsync<global::Shared.PlayerCreateInfo>(-511591145, new global::System.Object[]{@Class, @Race});
        }

        public global::System.Threading.Tasks.Task<global::Server.ChrClasses> @GetChrClasses(global::System.UInt32 @Class)
        {
            return base.@InvokeMethodAsync<global::Server.ChrClasses>(1387734599, new global::System.Object[]{@Class});
        }

        public global::System.Threading.Tasks.Task<global::Server.ChrRaces> @GetChrRaces(global::System.UInt32 @Race)
        {
            return base.@InvokeMethodAsync<global::Server.ChrRaces>(1590344148, new global::System.Object[]{@Race});
        }

        public global::System.Threading.Tasks.Task<global::Server.MapEntry> @GetMapEntry(global::System.UInt32 @MapID)
        {
            return base.@InvokeMethodAsync<global::Server.MapEntry>(571002267, new global::System.Object[]{@MapID});
        }

        public global::System.Threading.Tasks.Task<global::Shared.CreatureEntry[]> @GetCreatureEntriesByMap(global::System.UInt32 @MapID)
        {
            return base.@InvokeMethodAsync<global::Shared.CreatureEntry[]>(-1190088203, new global::System.Object[]{@MapID});
        }

        public global::System.Threading.Tasks.Task<global::Shared.CreatureEntry> @GetCreatureEntry(global::System.UInt32 @guid)
        {
            return base.@InvokeMethodAsync<global::Shared.CreatureEntry>(-2102013331, new global::System.Object[]{@guid});
        }

        public global::System.Threading.Tasks.Task<global::Shared.CreatureTemplate> @GetCreatureTemplate(global::System.UInt32 @Entry)
        {
            return base.@InvokeMethodAsync<global::Shared.CreatureTemplate>(-1651406328, new global::System.Object[]{@Entry});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IDataStoreManager", -2116077755, typeof (global::Server.IDataStoreManager)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenDataStoreManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -2116077755:
                        switch (@methodId)
                        {
                            case -1601724582:
                                return ((global::Server.IDataStoreManager)@grain).@GetConnectionString().@Box();
                            case -511591145:
                                return ((global::Server.IDataStoreManager)@grain).@GetPlayerCreateInfo((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case 1387734599:
                                return ((global::Server.IDataStoreManager)@grain).@GetChrClasses((global::System.UInt32)@arguments[0]).@Box();
                            case 1590344148:
                                return ((global::Server.IDataStoreManager)@grain).@GetChrRaces((global::System.UInt32)@arguments[0]).@Box();
                            case 571002267:
                                return ((global::Server.IDataStoreManager)@grain).@GetMapEntry((global::System.UInt32)@arguments[0]).@Box();
                            case -1190088203:
                                return ((global::Server.IDataStoreManager)@grain).@GetCreatureEntriesByMap((global::System.UInt32)@arguments[0]).@Box();
                            case -2102013331:
                                return ((global::Server.IDataStoreManager)@grain).@GetCreatureEntry((global::System.UInt32)@arguments[0]).@Box();
                            case -1651406328:
                                return ((global::Server.IDataStoreManager)@grain).@GetCreatureTemplate((global::System.UInt32)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2116077755 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2116077755;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.PlayerCreateInfo)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_PlayerCreateInfoSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.PlayerCreateInfo).@GetField("class", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.PlayerCreateInfo).@GetField("map", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.PlayerCreateInfo).@GetField("orientation", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.PlayerCreateInfo).@GetField("position_x", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.PlayerCreateInfo).@GetField("position_y", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.PlayerCreateInfo).@GetField("position_z", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.PlayerCreateInfo).@GetField("race", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.PlayerCreateInfo).@GetField("zone", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.PlayerCreateInfo input = ((global::Shared.PlayerCreateInfo)original);
            global::Shared.PlayerCreateInfo result = new global::Shared.PlayerCreateInfo();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field1.@SetValue(result, field1.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field7.@SetValue(result, field7.@GetValue(input));
            field4.@SetValue(result, field4.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            field6.@SetValue(result, field6.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.PlayerCreateInfo input = (global::Shared.PlayerCreateInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.PlayerCreateInfo result = new global::Shared.PlayerCreateInfo();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field1.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field2.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field7.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field4.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field5.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field6.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field0.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field3.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Shared.PlayerCreateInfo)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.PlayerCreateInfo), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_PlayerCreateInfoSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Server.ChrClasses)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenServer_ChrClassesSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Server.ChrClasses).@GetField("CinematicSequence", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Server.ChrClasses).@GetField("Class", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Server.ChrClasses).@GetField("ExpansionRequired", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Server.ChrClasses).@GetField("FemaleName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Server.ChrClasses).@GetField("Flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Server.ChrClasses).@GetField("Name", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Server.ChrClasses).@GetField("NeutralName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Server.DBCRecordBase).@GetField("RecordData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Server.ChrClasses).@GetField("SpellFamily", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Server.DBCRecordBase).@GetField("StringData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Server.ChrClasses).@GetField("powerType", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Server.ChrClasses input = ((global::Server.ChrClasses)original);
            global::Server.ChrClasses result = new global::Server.ChrClasses();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field7.@SetValue(result, field7.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field8.@SetValue(result, field8.@GetValue(input));
            field3.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field3.@GetValue(input)));
            field6.@SetValue(result, field6.@GetValue(input));
            field2.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field2.@GetValue(input)));
            field4.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field4.@GetValue(input)));
            field9.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field9.@GetValue(input)));
            field5.@SetValue(result, field5.@GetValue(input));
            field10.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field10.@GetValue(input)));
            field1.@SetValue(result, field1.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Server.ChrClasses input = (global::Server.ChrClasses)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field10.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Server.ChrClasses result = new global::Server.ChrClasses();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field7.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field0.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field8.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field3.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            field6.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field2.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            field4.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            field9.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field5.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field10.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field1.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Server.ChrClasses)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Server.ChrClasses), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenServer_ChrClassesSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Server.ChrRaces)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenServer_ChrRacesSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Server.ChrRaces).@GetField("CinematicSequence", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Server.ChrRaces).@GetField("ExpensionRequired", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Server.ChrRaces).@GetField("ExplorationData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Server.ChrRaces).@GetField("Faction", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Server.ChrRaces).@GetField("FemaleName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Server.ChrRaces).@GetField("Flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Server.ChrRaces).@GetField("ModelFemale", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Server.ChrRaces).@GetField("ModelMale", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Server.ChrRaces).@GetField("Name", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Server.ChrRaces).@GetField("NeutralName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Server.ChrRaces).@GetField("Race", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Server.DBCRecordBase).@GetField("RecordData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Server.ChrRaces).@GetField("ShortName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field14 = typeof (global::Server.DBCRecordBase).@GetField("StringData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Server.ChrRaces).@GetField("Team", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Server.ChrRaces input = ((global::Server.ChrRaces)original);
            global::Server.ChrRaces result = new global::Server.ChrRaces();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field7.@SetValue(result, field7.@GetValue(input));
            field8.@SetValue(result, field8.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field10.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field10.@GetValue(input)));
            field1.@SetValue(result, field1.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            field4.@SetValue(result, field4.@GetValue(input));
            field9.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field9.@GetValue(input)));
            field11.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field11.@GetValue(input)));
            field0.@SetValue(result, field0.@GetValue(input));
            field13.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field13.@GetValue(input)));
            field12.@SetValue(result, field12.@GetValue(input));
            field14.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field14.@GetValue(input)));
            field6.@SetValue(result, field6.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Server.ChrRaces input = (global::Server.ChrRaces)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field10.@GetValue(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field11.@GetValue(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field13.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field12.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field14.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Server.ChrRaces result = new global::Server.ChrRaces();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field7.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field8.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field3.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field2.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field10.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            field1.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field5.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field4.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field9.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            field11.@SetValue(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            field0.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field13.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field12.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field14.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field6.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Server.ChrRaces)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Server.ChrRaces), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenServer_ChrRacesSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Server.MapEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenServer_MapEntrySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Server.MapEntry).@GetField("EntranceMapID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Server.MapEntry).@GetField("EntranceMapX", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Server.MapEntry).@GetField("EntranceMapY", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Server.MapEntry).@GetField("Flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Server.MapEntry).@GetField("InternalName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Server.MapEntry).@GetField("MapID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Server.DBCRecordBase).@GetField("RecordData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Server.DBCRecordBase).@GetField("StringData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Server.MapEntry).@GetField("Type", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Server.MapEntry input = ((global::Server.MapEntry)original);
            global::Server.MapEntry result = new global::Server.MapEntry();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field4.@SetValue(result, field4.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            field6.@SetValue(result, field6.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            field1.@SetValue(result, field1.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field7.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field7.@GetValue(input)));
            field8.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field8.@GetValue(input)));
            field2.@SetValue(result, field2.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Server.MapEntry input = (global::Server.MapEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::Server.MapType));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Server.MapEntry result = new global::Server.MapEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field4.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field5.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field6.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field3.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field1.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field0.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field7.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field8.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field2.@SetValue(result, (global::Server.MapType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Server.MapType), stream));
            return (global::Server.MapEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Server.MapEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenServer_MapEntrySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.CreatureEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_CreatureEntrySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Shared.CreatureEntry).@GetField("MovementType", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field22 = typeof (global::Shared.CreatureEntry).@GetField("VerifiedBuild", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.CreatureEntry).@GetField("areaId", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field16 = typeof (global::Shared.CreatureEntry).@GetField("curhealth", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field17 = typeof (global::Shared.CreatureEntry).@GetField("curmana", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::Shared.CreatureEntry).@GetField("currentwaypoint", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field21 = typeof (global::Shared.CreatureEntry).@GetField("dynamicflags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Shared.CreatureEntry).@GetField("equipment_id", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.CreatureEntry).@GetField("guid", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.CreatureEntry).@GetField("id", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.CreatureEntry).@GetField("map", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.CreatureEntry).@GetField("modelid", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Shared.CreatureEntry).@GetField("npcflag", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Shared.CreatureEntry).@GetField("orientation", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.CreatureEntry).@GetField("phaseMask", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Shared.CreatureEntry).@GetField("position_x", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Shared.CreatureEntry).@GetField("position_y", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Shared.CreatureEntry).@GetField("position_z", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.CreatureEntry).@GetField("spawnMask", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field14 = typeof (global::Shared.CreatureEntry).@GetField("spawndist", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Shared.CreatureEntry).@GetField("spawntimesecs", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field20 = typeof (global::Shared.CreatureEntry).@GetField("unit_flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.CreatureEntry).@GetField("zoneId", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.CreatureEntry input = ((global::Shared.CreatureEntry)original);
            global::Shared.CreatureEntry result = new global::Shared.CreatureEntry();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field18.@SetValue(result, field18.@GetValue(input));
            field22.@SetValue(result, field22.@GetValue(input));
            field4.@SetValue(result, field4.@GetValue(input));
            field16.@SetValue(result, field16.@GetValue(input));
            field17.@SetValue(result, field17.@GetValue(input));
            field15.@SetValue(result, field15.@GetValue(input));
            field21.@SetValue(result, field21.@GetValue(input));
            field8.@SetValue(result, field8.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field1.@SetValue(result, field1.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field7.@SetValue(result, field7.@GetValue(input));
            field19.@SetValue(result, field19.@GetValue(input));
            field12.@SetValue(result, field12.@GetValue(input));
            field6.@SetValue(result, field6.@GetValue(input));
            field9.@SetValue(result, field9.@GetValue(input));
            field10.@SetValue(result, field10.@GetValue(input));
            field11.@SetValue(result, field11.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            field14.@SetValue(result, field14.@GetValue(input));
            field13.@SetValue(result, field13.@GetValue(input));
            field20.@SetValue(result, field20.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.CreatureEntry input = (global::Shared.CreatureEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field18.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field22.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field16.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field17.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field15.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field21.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field19.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field12.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field10.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field11.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field14.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field13.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field20.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.CreatureEntry result = new global::Shared.CreatureEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field18.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field22.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field4.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field16.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field17.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field15.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field21.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field8.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field0.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field1.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field2.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field7.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field19.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field12.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field6.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field9.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field10.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field11.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field5.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field14.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field13.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field20.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field3.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Shared.CreatureEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.CreatureEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_CreatureEntrySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.CreatureTemplate)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_CreatureTemplateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field60 = typeof (global::Shared.CreatureTemplate).@GetField("AIName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field66 = typeof (global::Shared.CreatureTemplate).@GetField("ArmorModifier", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field24 = typeof (global::Shared.CreatureTemplate).@GetField("BaseAttackTime", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field26 = typeof (global::Shared.CreatureTemplate).@GetField("BaseVariance", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field67 = typeof (global::Shared.CreatureTemplate).@GetField("DamageModifier", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field68 = typeof (global::Shared.CreatureTemplate).@GetField("ExperienceModifier", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field64 = typeof (global::Shared.CreatureTemplate).@GetField("HealthModifier", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field63 = typeof (global::Shared.CreatureTemplate).@GetField("HoverHeight", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Shared.CreatureTemplate).@GetField("IconName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field62 = typeof (global::Shared.CreatureTemplate).@GetField("InhabitType", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.CreatureTemplate).@GetField("KillCredit1", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.CreatureTemplate).@GetField("KillCredit2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field65 = typeof (global::Shared.CreatureTemplate).@GetField("ManaModifier", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field61 = typeof (global::Shared.CreatureTemplate).@GetField("MovementType", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field56 = typeof (global::Shared.CreatureTemplate).@GetField("PetSpellDataId", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field69 = typeof (global::Shared.CreatureTemplate).@GetField("RacialLeader", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field25 = typeof (global::Shared.CreatureTemplate).@GetField("RangeAttackTime", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field27 = typeof (global::Shared.CreatureTemplate).@GetField("RangeVariance", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field71 = typeof (global::Shared.CreatureTemplate).@GetField("RegenHealth", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field74 = typeof (global::Shared.CreatureTemplate).@GetField("ScriptName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field57 = typeof (global::Shared.CreatureTemplate).@GetField("VehicleId", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field75 = typeof (global::Shared.CreatureTemplate).@GetField("VerifiedBuild", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.CreatureTemplate).@GetField("difficulty_entry_1", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.CreatureTemplate).@GetField("difficulty_entry_2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.CreatureTemplate).@GetField("difficulty_entry_3", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field23 = typeof (global::Shared.CreatureTemplate).@GetField("dmgschool", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field31 = typeof (global::Shared.CreatureTemplate).@GetField("dynamicflags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.CreatureTemplate).@GetField("entry", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field16 = typeof (global::Shared.CreatureTemplate).@GetField("exp", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field17 = typeof (global::Shared.CreatureTemplate).@GetField("faction", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field32 = typeof (global::Shared.CreatureTemplate).@GetField("family", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field73 = typeof (global::Shared.CreatureTemplate).@GetField("flags_extra", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Shared.CreatureTemplate).@GetField("gossip_menu_id", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field39 = typeof (global::Shared.CreatureTemplate).@GetField("lootid", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field59 = typeof (global::Shared.CreatureTemplate).@GetField("maxgold", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::Shared.CreatureTemplate).@GetField("maxlevel", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field72 = typeof (global::Shared.CreatureTemplate).@GetField("mechanic_immune_mask", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field58 = typeof (global::Shared.CreatureTemplate).@GetField("mingold", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field14 = typeof (global::Shared.CreatureTemplate).@GetField("minlevel", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.CreatureTemplate).@GetField("modelid1", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.CreatureTemplate).@GetField("modelid2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Shared.CreatureTemplate).@GetField("modelid3", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Shared.CreatureTemplate).@GetField("modelid4", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field70 = typeof (global::Shared.CreatureTemplate).@GetField("movementId", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Shared.CreatureTemplate).@GetField("name", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Shared.CreatureTemplate).@GetField("npcflag", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field40 = typeof (global::Shared.CreatureTemplate).@GetField("pickpocketloot", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field22 = typeof (global::Shared.CreatureTemplate).@GetField("rank", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field42 = typeof (global::Shared.CreatureTemplate).@GetField("resistance1", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field43 = typeof (global::Shared.CreatureTemplate).@GetField("resistance2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field44 = typeof (global::Shared.CreatureTemplate).@GetField("resistance3", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field45 = typeof (global::Shared.CreatureTemplate).@GetField("resistance4", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field46 = typeof (global::Shared.CreatureTemplate).@GetField("resistance5", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field47 = typeof (global::Shared.CreatureTemplate).@GetField("resistance6", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field21 = typeof (global::Shared.CreatureTemplate).@GetField("scale", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field41 = typeof (global::Shared.CreatureTemplate).@GetField("skinloot", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field20 = typeof (global::Shared.CreatureTemplate).@GetField("speed_run", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Shared.CreatureTemplate).@GetField("speed_walk", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field48 = typeof (global::Shared.CreatureTemplate).@GetField("spell1", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field49 = typeof (global::Shared.CreatureTemplate).@GetField("spell2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field50 = typeof (global::Shared.CreatureTemplate).@GetField("spell3", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field51 = typeof (global::Shared.CreatureTemplate).@GetField("spell4", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field52 = typeof (global::Shared.CreatureTemplate).@GetField("spell5", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field53 = typeof (global::Shared.CreatureTemplate).@GetField("spell6", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field54 = typeof (global::Shared.CreatureTemplate).@GetField("spell7", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field55 = typeof (global::Shared.CreatureTemplate).@GetField("spell8", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Shared.CreatureTemplate).@GetField("subname", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field35 = typeof (global::Shared.CreatureTemplate).@GetField("trainer_class", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field36 = typeof (global::Shared.CreatureTemplate).@GetField("trainer_race", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field34 = typeof (global::Shared.CreatureTemplate).@GetField("trainer_spell", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field33 = typeof (global::Shared.CreatureTemplate).@GetField("trainer_type", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field37 = typeof (global::Shared.CreatureTemplate).@GetField("type", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field38 = typeof (global::Shared.CreatureTemplate).@GetField("type_flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field28 = typeof (global::Shared.CreatureTemplate).@GetField("unit_class", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field29 = typeof (global::Shared.CreatureTemplate).@GetField("unit_flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field30 = typeof (global::Shared.CreatureTemplate).@GetField("unit_flags2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.CreatureTemplate input = ((global::Shared.CreatureTemplate)original);
            global::Shared.CreatureTemplate result = new global::Shared.CreatureTemplate();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field60.@SetValue(result, field60.@GetValue(input));
            field66.@SetValue(result, field66.@GetValue(input));
            field24.@SetValue(result, field24.@GetValue(input));
            field26.@SetValue(result, field26.@GetValue(input));
            field67.@SetValue(result, field67.@GetValue(input));
            field68.@SetValue(result, field68.@GetValue(input));
            field64.@SetValue(result, field64.@GetValue(input));
            field63.@SetValue(result, field63.@GetValue(input));
            field12.@SetValue(result, field12.@GetValue(input));
            field62.@SetValue(result, field62.@GetValue(input));
            field4.@SetValue(result, field4.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            field65.@SetValue(result, field65.@GetValue(input));
            field61.@SetValue(result, field61.@GetValue(input));
            field56.@SetValue(result, field56.@GetValue(input));
            field69.@SetValue(result, field69.@GetValue(input));
            field25.@SetValue(result, field25.@GetValue(input));
            field27.@SetValue(result, field27.@GetValue(input));
            field71.@SetValue(result, field71.@GetValue(input));
            field74.@SetValue(result, field74.@GetValue(input));
            field57.@SetValue(result, field57.@GetValue(input));
            field75.@SetValue(result, field75.@GetValue(input));
            field1.@SetValue(result, field1.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            field23.@SetValue(result, field23.@GetValue(input));
            field31.@SetValue(result, field31.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field16.@SetValue(result, field16.@GetValue(input));
            field17.@SetValue(result, field17.@GetValue(input));
            field32.@SetValue(result, field32.@GetValue(input));
            field73.@SetValue(result, field73.@GetValue(input));
            field13.@SetValue(result, field13.@GetValue(input));
            field39.@SetValue(result, field39.@GetValue(input));
            field59.@SetValue(result, field59.@GetValue(input));
            field15.@SetValue(result, field15.@GetValue(input));
            field72.@SetValue(result, field72.@GetValue(input));
            field58.@SetValue(result, field58.@GetValue(input));
            field14.@SetValue(result, field14.@GetValue(input));
            field6.@SetValue(result, field6.@GetValue(input));
            field7.@SetValue(result, field7.@GetValue(input));
            field8.@SetValue(result, field8.@GetValue(input));
            field9.@SetValue(result, field9.@GetValue(input));
            field70.@SetValue(result, field70.@GetValue(input));
            field10.@SetValue(result, field10.@GetValue(input));
            field18.@SetValue(result, field18.@GetValue(input));
            field40.@SetValue(result, field40.@GetValue(input));
            field22.@SetValue(result, field22.@GetValue(input));
            field42.@SetValue(result, field42.@GetValue(input));
            field43.@SetValue(result, field43.@GetValue(input));
            field44.@SetValue(result, field44.@GetValue(input));
            field45.@SetValue(result, field45.@GetValue(input));
            field46.@SetValue(result, field46.@GetValue(input));
            field47.@SetValue(result, field47.@GetValue(input));
            field21.@SetValue(result, field21.@GetValue(input));
            field41.@SetValue(result, field41.@GetValue(input));
            field20.@SetValue(result, field20.@GetValue(input));
            field19.@SetValue(result, field19.@GetValue(input));
            field48.@SetValue(result, field48.@GetValue(input));
            field49.@SetValue(result, field49.@GetValue(input));
            field50.@SetValue(result, field50.@GetValue(input));
            field51.@SetValue(result, field51.@GetValue(input));
            field52.@SetValue(result, field52.@GetValue(input));
            field53.@SetValue(result, field53.@GetValue(input));
            field54.@SetValue(result, field54.@GetValue(input));
            field55.@SetValue(result, field55.@GetValue(input));
            field11.@SetValue(result, field11.@GetValue(input));
            field35.@SetValue(result, field35.@GetValue(input));
            field36.@SetValue(result, field36.@GetValue(input));
            field34.@SetValue(result, field34.@GetValue(input));
            field33.@SetValue(result, field33.@GetValue(input));
            field37.@SetValue(result, field37.@GetValue(input));
            field38.@SetValue(result, field38.@GetValue(input));
            field28.@SetValue(result, field28.@GetValue(input));
            field29.@SetValue(result, field29.@GetValue(input));
            field30.@SetValue(result, field30.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.CreatureTemplate input = (global::Shared.CreatureTemplate)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field60.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field66.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field24.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field26.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field67.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field68.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field64.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field63.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field12.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field62.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field65.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field61.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field56.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field69.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field25.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field27.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field71.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field74.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field57.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field75.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field23.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field31.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field16.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field17.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field32.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field73.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field13.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field39.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field59.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field15.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field72.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field58.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field14.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field70.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field10.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field18.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field40.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field22.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field42.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field43.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field44.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field45.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field46.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field47.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field21.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field41.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field20.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field19.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field48.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field49.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field50.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field51.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field52.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field53.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field54.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field55.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field11.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field35.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field36.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field34.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field33.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field37.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field38.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field28.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field29.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field30.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.CreatureTemplate result = new global::Shared.CreatureTemplate();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field60.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field66.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field24.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field26.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field67.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field68.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field64.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field63.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field12.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field62.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field4.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field5.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field65.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field61.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field56.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field69.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field25.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field27.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field71.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field74.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field57.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field75.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field1.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field2.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field3.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field23.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field31.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field0.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field16.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field17.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field32.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field73.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field13.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field39.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field59.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field15.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field72.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field58.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field14.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field6.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field7.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field8.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field9.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field70.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field10.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field18.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field40.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field22.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field42.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field43.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field44.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field45.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field46.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field47.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field21.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field41.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field20.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field19.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field48.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field49.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field50.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field51.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field52.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field53.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field54.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field55.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field11.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field35.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field36.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field34.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field33.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field37.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field38.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field28.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field29.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field30.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Shared.CreatureTemplate)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.CreatureTemplate), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_CreatureTemplateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IMapCell))]
    internal class OrleansCodeGenMapCellReference : global::Orleans.Runtime.GrainReference, global::Server.IMapCell
    {
        protected @OrleansCodeGenMapCellReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMapCellReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 622146605;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IMapCell";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 622146605;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 622146605:
                    switch (@methodId)
                    {
                        case -155693576:
                            return "Init";
                        case 1709859866:
                            return "AddObject";
                        case -1030340031:
                            return "RemoveObject";
                        case -121618869:
                            return "AddRef";
                        case 1433401269:
                            return "DecRef";
                        case 1582148855:
                            return "SetRefs";
                        case -1356403447:
                            return "Update";
                        case 274234201:
                            return "Create";
                        case -663875885:
                            return "IsValid";
                        case 131698759:
                            return "UpdateInRange";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 622146605 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Init(global::System.UInt32 @cellx, global::System.UInt32 @celly, global::Server.IMap @parent)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-155693576, new global::System.Object[]{@cellx, @celly, @parent is global::Orleans.Grain ? @parent.@AsReference<global::Server.IMap>() : @parent});
        }

        public global::System.Threading.Tasks.Task @AddObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1709859866, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj});
        }

        public global::System.Threading.Tasks.Task @RemoveObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1030340031, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj});
        }

        public global::System.Threading.Tasks.Task @AddRef()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-121618869, null);
        }

        public global::System.Threading.Tasks.Task @DecRef()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1433401269, null);
        }

        public global::System.Threading.Tasks.Task @SetRefs(global::System.Int64 @refs)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1582148855, new global::System.Object[]{@refs});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task @Create(global::System.UInt32 @InstanceID, global::System.UInt32 @cellx, global::System.UInt32 @celly)
        {
            return base.@InvokeMethodAsync<global::System.Object>(274234201, new global::System.Object[]{@InstanceID, @cellx, @celly});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRange(global::Server.IObjectImpl @obj, global::System.Collections.Generic.List<global::Shared.ObjectGUID> @ignoreGuids)
        {
            return base.@InvokeMethodAsync<global::System.Object>(131698759, new global::System.Object[]{@obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @ignoreGuids});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IMapCell", 622146605, typeof (global::Server.IMapCell)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMapCellMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 622146605:
                        switch (@methodId)
                        {
                            case -155693576:
                                return ((global::Server.IMapCell)@grain).@Init((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1], (global::Server.IMap)@arguments[2]).@Box();
                            case 1709859866:
                                return ((global::Server.IMapCell)@grain).@AddObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1]).@Box();
                            case -1030340031:
                                return ((global::Server.IMapCell)@grain).@RemoveObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1]).@Box();
                            case -121618869:
                                return ((global::Server.IMapCell)@grain).@AddRef().@Box();
                            case 1433401269:
                                return ((global::Server.IMapCell)@grain).@DecRef().@Box();
                            case 1582148855:
                                return ((global::Server.IMapCell)@grain).@SetRefs((global::System.Int64)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IMapCell)@grain).@Update().@Box();
                            case 274234201:
                                return ((global::Server.IMapCell)@grain).@Create((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1], (global::System.UInt32)@arguments[2]).@Box();
                            case -663875885:
                                return ((global::Server.IMapCell)@grain).@IsValid().@Box();
                            case 131698759:
                                return ((global::Server.IMapCell)@grain).@UpdateInRange((global::Server.IObjectImpl)@arguments[0], (global::System.Collections.Generic.List<global::Shared.ObjectGUID>)@arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 622146605 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 622146605;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.ObjectGUID)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_ObjectGUIDSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.ObjectGUID).@GetField("_value", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.ObjectGUID input = ((global::Shared.ObjectGUID)original);
            global::Shared.ObjectGUID result = new global::Shared.ObjectGUID();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, field0.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.ObjectGUID input = (global::Shared.ObjectGUID)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.ObjectGUID result = new global::Shared.ObjectGUID();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), stream));
            return (global::Shared.ObjectGUID)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.ObjectGUID), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_ObjectGUIDSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IMap))]
    internal class OrleansCodeGenMapReference : global::Orleans.Runtime.GrainReference, global::Server.IMap
    {
        protected @OrleansCodeGenMapReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMapReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -284495227;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IMap";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -284495227;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -284495227:
                    switch (@methodId)
                    {
                        case -663875885:
                            return "IsValid";
                        case 1796767737:
                            return "GetMapID";
                        case -146106666:
                            return "GetInstanceID";
                        case 274234201:
                            return "Create";
                        case 788538833:
                            return "GetObject";
                        case 482762363:
                            return "AddObject";
                        case -1030340031:
                            return "RemoveObject";
                        case 368343017:
                            return "UpdateInRangeObject";
                        case 1051812713:
                            return "OnCellActivate";
                        case 332960665:
                            return "OnCellDeactivate";
                        case -290715139:
                            return "OnObjectUpdated";
                        case -2049323967:
                            return "OnActivatorMove";
                        case -1562962289:
                            return "SpawnCreatures";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -284495227 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetMapID()
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(1796767737, null);
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetInstanceID()
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-146106666, null);
        }

        public global::System.Threading.Tasks.Task @Create(global::System.UInt32 @MapID, global::System.UInt32 @InstanceID, global::System.UInt32 @RealmID)
        {
            return base.@InvokeMethodAsync<global::System.Object>(274234201, new global::System.Object[]{@MapID, @InstanceID, @RealmID});
        }

        public global::System.Threading.Tasks.Task<global::Server.IObjectImpl> @GetObject(global::Shared.ObjectGUID @guid)
        {
            return base.@InvokeMethodAsync<global::Server.IObjectImpl>(788538833, new global::System.Object[]{@guid});
        }

        public global::System.Threading.Tasks.Task<global::Shared.MapAddResult> @AddObject(global::Server.IObjectImpl @obj)
        {
            return base.@InvokeMethodAsync<global::Shared.MapAddResult>(482762363, new global::System.Object[]{@obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj});
        }

        public global::System.Threading.Tasks.Task @RemoveObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1030340031, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj});
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeObject(global::Server.IObjectImpl @obj, global::System.Collections.Generic.List<global::Shared.ObjectGUID> @ignoreGuids)
        {
            return base.@InvokeMethodAsync<global::System.Object>(368343017, new global::System.Object[]{@obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @ignoreGuids});
        }

        public global::System.Threading.Tasks.Task @OnCellActivate(global::Server.IMapCell @cell)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1051812713, new global::System.Object[]{@cell is global::Orleans.Grain ? @cell.@AsReference<global::Server.IMapCell>() : @cell});
        }

        public global::System.Threading.Tasks.Task @OnCellDeactivate(global::Server.IMapCell @cell)
        {
            return base.@InvokeMethodAsync<global::System.Object>(332960665, new global::System.Object[]{@cell is global::Orleans.Grain ? @cell.@AsReference<global::Server.IMapCell>() : @cell});
        }

        public global::System.Threading.Tasks.Task @OnObjectUpdated(global::Shared.ObjectGUID @guid)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-290715139, new global::System.Object[]{@guid});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @OnActivatorMove(global::Server.IObjectImpl @obj, global::System.Single @oldx, global::System.Single @oldy, global::System.Single @newx, global::System.Single @newy)
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(-2049323967, new global::System.Object[]{@obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @oldx, @oldy, @newx, @newy});
        }

        public global::System.Threading.Tasks.Task @SpawnCreatures(global::Shared.CreatureEntry[] @creatures)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1562962289, new global::System.Object[]{@creatures});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IMap", -284495227, typeof (global::Server.IMap)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMapMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -284495227:
                        switch (@methodId)
                        {
                            case -663875885:
                                return ((global::Server.IMap)@grain).@IsValid().@Box();
                            case 1796767737:
                                return ((global::Server.IMap)@grain).@GetMapID().@Box();
                            case -146106666:
                                return ((global::Server.IMap)@grain).@GetInstanceID().@Box();
                            case 274234201:
                                return ((global::Server.IMap)@grain).@Create((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1], (global::System.UInt32)@arguments[2]).@Box();
                            case 788538833:
                                return ((global::Server.IMap)@grain).@GetObject((global::Shared.ObjectGUID)@arguments[0]).@Box();
                            case 482762363:
                                return ((global::Server.IMap)@grain).@AddObject((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -1030340031:
                                return ((global::Server.IMap)@grain).@RemoveObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1]).@Box();
                            case 368343017:
                                return ((global::Server.IMap)@grain).@UpdateInRangeObject((global::Server.IObjectImpl)@arguments[0], (global::System.Collections.Generic.List<global::Shared.ObjectGUID>)@arguments[1]).@Box();
                            case 1051812713:
                                return ((global::Server.IMap)@grain).@OnCellActivate((global::Server.IMapCell)@arguments[0]).@Box();
                            case 332960665:
                                return ((global::Server.IMap)@grain).@OnCellDeactivate((global::Server.IMapCell)@arguments[0]).@Box();
                            case -290715139:
                                return ((global::Server.IMap)@grain).@OnObjectUpdated((global::Shared.ObjectGUID)@arguments[0]).@Box();
                            case -2049323967:
                                return ((global::Server.IMap)@grain).@OnActivatorMove((global::Server.IObjectImpl)@arguments[0], (global::System.Single)@arguments[1], (global::System.Single)@arguments[2], (global::System.Single)@arguments[3], (global::System.Single)@arguments[4]).@Box();
                            case -1562962289:
                                return ((global::Server.IMap)@grain).@SpawnCreatures((global::Shared.CreatureEntry[])@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -284495227 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -284495227;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IPlayerByNameIndex))]
    internal class OrleansCodeGenPlayerByNameIndexReference : global::Orleans.Runtime.GrainReference, global::Server.IPlayerByNameIndex
    {
        protected @OrleansCodeGenPlayerByNameIndexReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPlayerByNameIndexReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -410311541;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IPlayerByNameIndex";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -410311541 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -410311541:
                    switch (@methodId)
                    {
                        case 970804849:
                            return "SetPlayer";
                        case -574949896:
                            return "GetPlayerGUID";
                        case 880552289:
                            return "GetPlayer";
                        case -1038277770:
                            return "Save";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -410311541 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @SetPlayer(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(970804849, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetPlayerGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-574949896, null);
        }

        public global::System.Threading.Tasks.Task<global::Server.IPlayer> @GetPlayer()
        {
            return base.@InvokeMethodAsync<global::Server.IPlayer>(880552289, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IPlayerByNameIndex", -410311541, typeof (global::Server.IPlayerByNameIndex)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPlayerByNameIndexMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -410311541:
                        switch (@methodId)
                        {
                            case 970804849:
                                return ((global::Server.IPlayerByNameIndex)@grain).@SetPlayer((global::Server.IPlayer)@arguments[0]).@Box();
                            case -574949896:
                                return ((global::Server.IPlayerByNameIndex)@grain).@GetPlayerGUID().@Box();
                            case 880552289:
                                return ((global::Server.IPlayerByNameIndex)@grain).@GetPlayer().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayerByNameIndex)@grain).@Save().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -410311541 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -410311541;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IPlayer))]
    internal class OrleansCodeGenPlayerReference : global::Orleans.Runtime.GrainReference, global::Server.IPlayer
    {
        protected @OrleansCodeGenPlayerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPlayerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1840646871;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IPlayer";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1840646871 || @interfaceId == 1374563470 || @interfaceId == -459325194 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1840646871:
                    switch (@methodId)
                    {
                        case -851262471:
                            return "PlayerCall";
                        case -2036236875:
                            return "Create";
                        case 1472154683:
                            return "BuildEnum";
                        case -190511557:
                            return "Kick";
                        case 1960002325:
                            return "GetAccount";
                        case 112904302:
                            return "OnLogin";
                        case -1922821172:
                            return "Login";
                        case 820464294:
                            return "SendPacket";
                        case 1583044129:
                            return "BuildInitialUpdate";
                        case -640025293:
                            return "Logout";
                        case 1746041143:
                            return "OnLogout";
                        case -1256896228:
                            return "GetName";
                        case -200604686:
                            return "GetRealmID";
                        case -542679141:
                            return "GetRace";
                        case -1388702422:
                            return "GetGender";
                        case -825606002:
                            return "GetClass";
                        case -1181912828:
                            return "MovementUpdate";
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1840646871 + ",methodId=" + @methodId);
                    }

                case 1374563470:
                    switch (@methodId)
                    {
                        case -851262471:
                            return "PlayerCall";
                        case -2036236875:
                            return "Create";
                        case 1472154683:
                            return "BuildEnum";
                        case -190511557:
                            return "Kick";
                        case 1960002325:
                            return "GetAccount";
                        case 112904302:
                            return "OnLogin";
                        case -1922821172:
                            return "Login";
                        case 820464294:
                            return "SendPacket";
                        case 1583044129:
                            return "BuildInitialUpdate";
                        case -640025293:
                            return "Logout";
                        case 1746041143:
                            return "OnLogout";
                        case -1256896228:
                            return "GetName";
                        case -200604686:
                            return "GetRealmID";
                        case -542679141:
                            return "GetRace";
                        case -1388702422:
                            return "GetGender";
                        case -825606002:
                            return "GetClass";
                        case -1181912828:
                            return "MovementUpdate";
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1374563470 + ",methodId=" + @methodId);
                    }

                case -459325194:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @PlayerCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-851262471, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.LoginErrorCode> @Create(global::Shared.PlayerCreateData @info)
        {
            return base.@InvokeMethodAsync<global::Shared.LoginErrorCode>(-2036236875, new global::System.Object[]{@info});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildEnum()
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(1472154683, null);
        }

        public global::System.Threading.Tasks.Task @Kick(global::System.Boolean @remove_from_world)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-190511557, new global::System.Object[]{@remove_from_world});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetAccount()
        {
            return base.@InvokeMethodAsync<global::System.String>(1960002325, null);
        }

        public global::System.Threading.Tasks.Task @OnLogin()
        {
            return base.@InvokeMethodAsync<global::System.Object>(112904302, null);
        }

        public global::System.Threading.Tasks.Task @Login()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1922821172, null);
        }

        public global::System.Threading.Tasks.Task @SendPacket(global::Shared.PacketOut @pkt)
        {
            return base.@InvokeMethodAsync<global::System.Object>(820464294, new global::System.Object[]{@pkt});
        }

        public global::System.Threading.Tasks.Task @BuildInitialUpdate()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1583044129, null);
        }

        public global::System.Threading.Tasks.Task @Logout(global::System.Boolean @instant)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-640025293, new global::System.Object[]{@instant});
        }

        public global::System.Threading.Tasks.Task @OnLogout()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1746041143, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetName()
        {
            return base.@InvokeMethodAsync<global::System.String>(-1256896228, null);
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetRealmID()
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-200604686, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetRace()
        {
            return base.@InvokeMethodAsync<global::System.Byte>(-542679141, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetGender()
        {
            return base.@InvokeMethodAsync<global::System.Byte>(-1388702422, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetClass()
        {
            return base.@InvokeMethodAsync<global::System.Byte>(-825606002, null);
        }

        public global::System.Threading.Tasks.Task @MovementUpdate(global::Shared.RealmOp @opcode, global::Shared.MovementData @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1181912828, new global::System.Object[]{@opcode, @data});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UnitCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(1519937893, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-342467399, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetNativeDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1421261762, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IPlayer", -1840646871, typeof (global::Server.IPlayer)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPlayerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1840646871:
                        switch (@methodId)
                        {
                            case -851262471:
                                return ((global::Server.IPlayer)@grain).@PlayerCall().@Box();
                            case -2036236875:
                                return ((global::Server.IPlayer)@grain).@Create((global::Shared.PlayerCreateData)@arguments[0]).@Box();
                            case 1472154683:
                                return ((global::Server.IPlayer)@grain).@BuildEnum().@Box();
                            case -190511557:
                                return ((global::Server.IPlayer)@grain).@Kick((global::System.Boolean)@arguments[0]).@Box();
                            case 1960002325:
                                return ((global::Server.IPlayer)@grain).@GetAccount().@Box();
                            case 112904302:
                                return ((global::Server.IPlayer)@grain).@OnLogin().@Box();
                            case -1922821172:
                                return ((global::Server.IPlayer)@grain).@Login().@Box();
                            case 820464294:
                                return ((global::Server.IPlayer)@grain).@SendPacket((global::Shared.PacketOut)@arguments[0]).@Box();
                            case 1583044129:
                                return ((global::Server.IPlayer)@grain).@BuildInitialUpdate().@Box();
                            case -640025293:
                                return ((global::Server.IPlayer)@grain).@Logout((global::System.Boolean)@arguments[0]).@Box();
                            case 1746041143:
                                return ((global::Server.IPlayer)@grain).@OnLogout().@Box();
                            case -1256896228:
                                return ((global::Server.IPlayer)@grain).@GetName().@Box();
                            case -200604686:
                                return ((global::Server.IPlayer)@grain).@GetRealmID().@Box();
                            case -542679141:
                                return ((global::Server.IPlayer)@grain).@GetRace().@Box();
                            case -1388702422:
                                return ((global::Server.IPlayer)@grain).@GetGender().@Box();
                            case -825606002:
                                return ((global::Server.IPlayer)@grain).@GetClass().@Box();
                            case -1181912828:
                                return ((global::Server.IPlayer)@grain).@MovementUpdate((global::Shared.RealmOp)@arguments[0], (global::Shared.MovementData)@arguments[1]).@Box();
                            case 1519937893:
                                return ((global::Server.IPlayer)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IPlayer)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IPlayer)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IPlayer)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayer)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayer)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayer)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayer)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayer)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayer)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayer)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayer)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayer)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayer)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayer)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayer)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayer)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayer)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayer)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayer)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayer)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayer)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayer)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayer)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayer)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayer)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayer)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayer)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayer)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayer)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayer)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayer)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayer)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayer)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayer)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayer)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayer)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayer)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayer)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayer)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayer)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayer)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayer)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1840646871 + ",methodId=" + @methodId);
                        }

                    case 1374563470:
                        switch (@methodId)
                        {
                            case -851262471:
                                return ((global::Server.IPlayer)@grain).@PlayerCall().@Box();
                            case -2036236875:
                                return ((global::Server.IPlayer)@grain).@Create((global::Shared.PlayerCreateData)@arguments[0]).@Box();
                            case 1472154683:
                                return ((global::Server.IPlayer)@grain).@BuildEnum().@Box();
                            case -190511557:
                                return ((global::Server.IPlayer)@grain).@Kick((global::System.Boolean)@arguments[0]).@Box();
                            case 1960002325:
                                return ((global::Server.IPlayer)@grain).@GetAccount().@Box();
                            case 112904302:
                                return ((global::Server.IPlayer)@grain).@OnLogin().@Box();
                            case -1922821172:
                                return ((global::Server.IPlayer)@grain).@Login().@Box();
                            case 820464294:
                                return ((global::Server.IPlayer)@grain).@SendPacket((global::Shared.PacketOut)@arguments[0]).@Box();
                            case 1583044129:
                                return ((global::Server.IPlayer)@grain).@BuildInitialUpdate().@Box();
                            case -640025293:
                                return ((global::Server.IPlayer)@grain).@Logout((global::System.Boolean)@arguments[0]).@Box();
                            case 1746041143:
                                return ((global::Server.IPlayer)@grain).@OnLogout().@Box();
                            case -1256896228:
                                return ((global::Server.IPlayer)@grain).@GetName().@Box();
                            case -200604686:
                                return ((global::Server.IPlayer)@grain).@GetRealmID().@Box();
                            case -542679141:
                                return ((global::Server.IPlayer)@grain).@GetRace().@Box();
                            case -1388702422:
                                return ((global::Server.IPlayer)@grain).@GetGender().@Box();
                            case -825606002:
                                return ((global::Server.IPlayer)@grain).@GetClass().@Box();
                            case -1181912828:
                                return ((global::Server.IPlayer)@grain).@MovementUpdate((global::Shared.RealmOp)@arguments[0], (global::Shared.MovementData)@arguments[1]).@Box();
                            case 1519937893:
                                return ((global::Server.IPlayer)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IPlayer)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IPlayer)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IPlayer)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayer)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayer)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayer)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayer)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayer)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayer)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayer)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayer)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayer)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayer)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayer)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayer)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayer)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayer)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayer)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayer)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayer)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayer)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayer)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayer)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayer)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayer)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayer)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayer)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayer)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayer)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayer)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayer)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayer)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayer)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayer)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayer)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayer)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayer)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayer)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayer)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayer)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayer)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayer)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1374563470 + ",methodId=" + @methodId);
                        }

                    case -459325194:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.IPlayer)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IPlayer)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IPlayer)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IPlayer)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayer)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayer)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayer)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayer)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayer)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayer)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayer)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayer)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayer)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayer)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayer)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayer)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayer)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayer)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayer)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayer)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayer)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayer)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayer)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayer)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayer)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayer)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayer)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayer)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayer)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayer)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayer)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayer)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayer)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayer)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayer)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayer)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayer)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayer)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayer)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayer)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayer)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayer)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayer)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IPlayer)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayer)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayer)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayer)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayer)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayer)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayer)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayer)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayer)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayer)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayer)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayer)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayer)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayer)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayer)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayer)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayer)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayer)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayer)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayer)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayer)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayer)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayer)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayer)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayer)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayer)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayer)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayer)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayer)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayer)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayer)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayer)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayer)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayer)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayer)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayer)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayer)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayer)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayer)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayer)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1840646871;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.PlayerCreateData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_PlayerCreateDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.PlayerCreateData).@GetField("AccountName", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.PlayerCreateData).@GetField("CreateData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.PlayerCreateData).@GetField("RealmID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.PlayerCreateData input = ((global::Shared.PlayerCreateData)original);
            global::Shared.PlayerCreateData result = new global::Shared.PlayerCreateData();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field2.@SetValue(result, field2.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field1.@SetValue(result, field1.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.PlayerCreateData input = (global::Shared.PlayerCreateData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.CMSG_CHAR_CREATE));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.PlayerCreateData result = new global::Shared.PlayerCreateData();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field2.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field0.@SetValue(result, (global::Shared.CMSG_CHAR_CREATE)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.CMSG_CHAR_CREATE), stream));
            field1.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Shared.PlayerCreateData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.PlayerCreateData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_PlayerCreateDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.CMSG_CHAR_CREATE)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_CMSG_CHAR_CREATESerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Class", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Face", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("FacialHair", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Gender", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("HairColor", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("HairStyle", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Name", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Outfit", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Race", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.CMSG_CHAR_CREATE).@GetField("Skin", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.CMSG_CHAR_CREATE input = ((global::Shared.CMSG_CHAR_CREATE)original);
            global::Shared.CMSG_CHAR_CREATE result = default (global::Shared.CMSG_CHAR_CREATE);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field1.@SetValue(boxedResult, field1.@GetValue(input));
            field5.@SetValue(boxedResult, field5.@GetValue(input));
            field8.@SetValue(boxedResult, field8.@GetValue(input));
            field3.@SetValue(boxedResult, field3.@GetValue(input));
            field7.@SetValue(boxedResult, field7.@GetValue(input));
            field6.@SetValue(boxedResult, field6.@GetValue(input));
            field0.@SetValue(boxedResult, field0.@GetValue(input));
            field9.@SetValue(boxedResult, field9.@GetValue(input));
            field2.@SetValue(boxedResult, field2.@GetValue(input));
            field4.@SetValue(boxedResult, field4.@GetValue(input));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.CMSG_CHAR_CREATE input = (global::Shared.CMSG_CHAR_CREATE)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Byte));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.CMSG_CHAR_CREATE result = default (global::Shared.CMSG_CHAR_CREATE);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field1.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field5.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field8.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field3.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field7.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field6.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field0.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field9.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field2.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field4.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            return (global::Shared.CMSG_CHAR_CREATE)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.CMSG_CHAR_CREATE), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_CMSG_CHAR_CREATESerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.PacketOut)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_PacketOutSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.PacketOut).@GetField("_strm", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.PacketOut).@GetField("type", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.PacketOut input = ((global::Shared.PacketOut)original);
            global::Shared.PacketOut result = new global::Shared.PacketOut();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, (global::System.IO.MemoryStream)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            field1.@SetValue(result, field1.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.PacketOut input = (global::Shared.PacketOut)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.IO.MemoryStream));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::Shared.PacketType));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.PacketOut result = new global::Shared.PacketOut();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::System.IO.MemoryStream)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.IO.MemoryStream), stream));
            field1.@SetValue(result, (global::Shared.PacketType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.PacketType), stream));
            return (global::Shared.PacketOut)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.PacketOut), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_PacketOutSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.MovementData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_MovementDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Shared.MovementData).@GetField("FallCosine", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field14 = typeof (global::Shared.MovementData).@GetField("FallLateralSpeed", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Shared.MovementData).@GetField("FallSine", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Shared.MovementData).@GetField("FallTime", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Shared.MovementData).@GetField("FallVerticalSpeed", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.MovementData).@GetField("Flags", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.MovementData).@GetField("Flags2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.MovementData).@GetField("GUID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Shared.MovementData).@GetField("MovementDataTransport", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Shared.MovementData).@GetField("Pitch", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.MovementData).@GetField("PositionO", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.MovementData).@GetField("PositionX", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.MovementData).@GetField("PositionY", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.MovementData).@GetField("PositionZ", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::Shared.MovementData).@GetField("SplineElevation", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.MovementData).@GetField("Time", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.MovementData input = ((global::Shared.MovementData)original);
            global::Shared.MovementData result = default (global::Shared.MovementData);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field13.@SetValue(boxedResult, field13.@GetValue(input));
            field14.@SetValue(boxedResult, field14.@GetValue(input));
            field12.@SetValue(boxedResult, field12.@GetValue(input));
            field10.@SetValue(boxedResult, field10.@GetValue(input));
            field11.@SetValue(boxedResult, field11.@GetValue(input));
            field1.@SetValue(boxedResult, field1.@GetValue(input));
            field2.@SetValue(boxedResult, field2.@GetValue(input));
            field0.@SetValue(boxedResult, (global::Shared.PackedGUID)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            field8.@SetValue(boxedResult, (global::Shared.MovementDataTransport)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field8.@GetValue(input)));
            field9.@SetValue(boxedResult, field9.@GetValue(input));
            field6.@SetValue(boxedResult, field6.@GetValue(input));
            field3.@SetValue(boxedResult, field3.@GetValue(input));
            field4.@SetValue(boxedResult, field4.@GetValue(input));
            field5.@SetValue(boxedResult, field5.@GetValue(input));
            field15.@SetValue(boxedResult, field15.@GetValue(input));
            field7.@SetValue(boxedResult, field7.@GetValue(input));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.MovementData input = (global::Shared.MovementData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field13.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field14.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field12.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field10.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field11.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::Shared.MovementFlags));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::Shared.MovementFlags2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.PackedGUID));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::Shared.MovementDataTransport));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field15.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.MovementData result = default (global::Shared.MovementData);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field13.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field14.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field12.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field10.@SetValue(boxedResult, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field11.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field1.@SetValue(boxedResult, (global::Shared.MovementFlags)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.MovementFlags), stream));
            field2.@SetValue(boxedResult, (global::Shared.MovementFlags2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.MovementFlags2), stream));
            field0.@SetValue(boxedResult, (global::Shared.PackedGUID)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.PackedGUID), stream));
            field8.@SetValue(boxedResult, (global::Shared.MovementDataTransport)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.MovementDataTransport), stream));
            field9.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field6.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field3.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field4.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field5.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field15.@SetValue(boxedResult, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field7.@SetValue(boxedResult, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Shared.MovementData)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.MovementData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_MovementDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.MovementDataTransport)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_MovementDataTransportSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.MovementDataTransport).@GetField("TransportGuid", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.MovementDataTransport).@GetField("TransportO", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.MovementDataTransport).@GetField("TransportSeat", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.MovementDataTransport).@GetField("TransportTime", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.MovementDataTransport).@GetField("TransportTime2", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.MovementDataTransport).@GetField("TransportX", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.MovementDataTransport).@GetField("TransportY", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.MovementDataTransport).@GetField("TransportZ", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.MovementDataTransport input = ((global::Shared.MovementDataTransport)original);
            global::Shared.MovementDataTransport result = new global::Shared.MovementDataTransport();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, (global::Shared.PackedGUID)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            field4.@SetValue(result, field4.@GetValue(input));
            field6.@SetValue(result, field6.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            field7.@SetValue(result, field7.@GetValue(input));
            field1.@SetValue(result, field1.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.MovementDataTransport input = (global::Shared.MovementDataTransport)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.PackedGUID));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.Single));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.MovementDataTransport result = new global::Shared.MovementDataTransport();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::Shared.PackedGUID)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.PackedGUID), stream));
            field4.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field6.@SetValue(result, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field5.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field7.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field1.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field2.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            field3.@SetValue(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            return (global::Shared.MovementDataTransport)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.MovementDataTransport), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_MovementDataTransportSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.PackedGUID)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_PackedGUIDSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.PackedGUID).@GetField("guidbytes", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.PackedGUID).@GetField("mask", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.PackedGUID input = ((global::Shared.PackedGUID)original);
            global::Shared.PackedGUID result = new global::Shared.PackedGUID();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field1.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field1.@GetValue(input)));
            field0.@SetValue(result, field0.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.PackedGUID input = (global::Shared.PackedGUID)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.Byte));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.PackedGUID result = new global::Shared.PackedGUID();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field1.@SetValue(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field0.@SetValue(result, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            return (global::Shared.PackedGUID)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.PackedGUID), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_PackedGUIDSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IPlayerImpl))]
    internal class OrleansCodeGenPlayerImplReference : global::Orleans.Runtime.GrainReference, global::Server.IPlayerImpl
    {
        protected @OrleansCodeGenPlayerImplReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPlayerImplReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1374563470;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IPlayerImpl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1374563470 || @interfaceId == -459325194 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1374563470:
                    switch (@methodId)
                    {
                        case -851262471:
                            return "PlayerCall";
                        case -2036236875:
                            return "Create";
                        case 1472154683:
                            return "BuildEnum";
                        case -190511557:
                            return "Kick";
                        case 1960002325:
                            return "GetAccount";
                        case 112904302:
                            return "OnLogin";
                        case -1922821172:
                            return "Login";
                        case 820464294:
                            return "SendPacket";
                        case 1583044129:
                            return "BuildInitialUpdate";
                        case -640025293:
                            return "Logout";
                        case 1746041143:
                            return "OnLogout";
                        case -1256896228:
                            return "GetName";
                        case -200604686:
                            return "GetRealmID";
                        case -542679141:
                            return "GetRace";
                        case -1388702422:
                            return "GetGender";
                        case -825606002:
                            return "GetClass";
                        case -1181912828:
                            return "MovementUpdate";
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1374563470 + ",methodId=" + @methodId);
                    }

                case -459325194:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @PlayerCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-851262471, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.LoginErrorCode> @Create(global::Shared.PlayerCreateData @info)
        {
            return base.@InvokeMethodAsync<global::Shared.LoginErrorCode>(-2036236875, new global::System.Object[]{@info});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildEnum()
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(1472154683, null);
        }

        public global::System.Threading.Tasks.Task @Kick(global::System.Boolean @remove_from_world)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-190511557, new global::System.Object[]{@remove_from_world});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetAccount()
        {
            return base.@InvokeMethodAsync<global::System.String>(1960002325, null);
        }

        public global::System.Threading.Tasks.Task @OnLogin()
        {
            return base.@InvokeMethodAsync<global::System.Object>(112904302, null);
        }

        public global::System.Threading.Tasks.Task @Login()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1922821172, null);
        }

        public global::System.Threading.Tasks.Task @SendPacket(global::Shared.PacketOut @pkt)
        {
            return base.@InvokeMethodAsync<global::System.Object>(820464294, new global::System.Object[]{@pkt});
        }

        public global::System.Threading.Tasks.Task @BuildInitialUpdate()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1583044129, null);
        }

        public global::System.Threading.Tasks.Task @Logout(global::System.Boolean @instant)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-640025293, new global::System.Object[]{@instant});
        }

        public global::System.Threading.Tasks.Task @OnLogout()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1746041143, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetName()
        {
            return base.@InvokeMethodAsync<global::System.String>(-1256896228, null);
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetRealmID()
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-200604686, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetRace()
        {
            return base.@InvokeMethodAsync<global::System.Byte>(-542679141, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetGender()
        {
            return base.@InvokeMethodAsync<global::System.Byte>(-1388702422, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetClass()
        {
            return base.@InvokeMethodAsync<global::System.Byte>(-825606002, null);
        }

        public global::System.Threading.Tasks.Task @MovementUpdate(global::Shared.RealmOp @opcode, global::Shared.MovementData @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1181912828, new global::System.Object[]{@opcode, @data});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UnitCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(1519937893, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-342467399, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetNativeDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1421261762, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IPlayerImpl", 1374563470, typeof (global::Server.IPlayerImpl)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPlayerImplMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1374563470:
                        switch (@methodId)
                        {
                            case -851262471:
                                return ((global::Server.IPlayerImpl)@grain).@PlayerCall().@Box();
                            case -2036236875:
                                return ((global::Server.IPlayerImpl)@grain).@Create((global::Shared.PlayerCreateData)@arguments[0]).@Box();
                            case 1472154683:
                                return ((global::Server.IPlayerImpl)@grain).@BuildEnum().@Box();
                            case -190511557:
                                return ((global::Server.IPlayerImpl)@grain).@Kick((global::System.Boolean)@arguments[0]).@Box();
                            case 1960002325:
                                return ((global::Server.IPlayerImpl)@grain).@GetAccount().@Box();
                            case 112904302:
                                return ((global::Server.IPlayerImpl)@grain).@OnLogin().@Box();
                            case -1922821172:
                                return ((global::Server.IPlayerImpl)@grain).@Login().@Box();
                            case 820464294:
                                return ((global::Server.IPlayerImpl)@grain).@SendPacket((global::Shared.PacketOut)@arguments[0]).@Box();
                            case 1583044129:
                                return ((global::Server.IPlayerImpl)@grain).@BuildInitialUpdate().@Box();
                            case -640025293:
                                return ((global::Server.IPlayerImpl)@grain).@Logout((global::System.Boolean)@arguments[0]).@Box();
                            case 1746041143:
                                return ((global::Server.IPlayerImpl)@grain).@OnLogout().@Box();
                            case -1256896228:
                                return ((global::Server.IPlayerImpl)@grain).@GetName().@Box();
                            case -200604686:
                                return ((global::Server.IPlayerImpl)@grain).@GetRealmID().@Box();
                            case -542679141:
                                return ((global::Server.IPlayerImpl)@grain).@GetRace().@Box();
                            case -1388702422:
                                return ((global::Server.IPlayerImpl)@grain).@GetGender().@Box();
                            case -825606002:
                                return ((global::Server.IPlayerImpl)@grain).@GetClass().@Box();
                            case -1181912828:
                                return ((global::Server.IPlayerImpl)@grain).@MovementUpdate((global::Shared.RealmOp)@arguments[0], (global::Shared.MovementData)@arguments[1]).@Box();
                            case 1519937893:
                                return ((global::Server.IPlayerImpl)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IPlayerImpl)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IPlayerImpl)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IPlayerImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayerImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayerImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayerImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayerImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayerImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayerImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayerImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayerImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayerImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayerImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayerImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayerImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayerImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayerImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayerImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayerImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayerImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayerImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayerImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayerImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayerImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayerImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayerImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayerImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayerImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayerImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayerImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayerImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayerImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayerImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayerImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayerImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayerImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayerImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayerImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayerImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1374563470 + ",methodId=" + @methodId);
                        }

                    case -459325194:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.IPlayerImpl)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IPlayerImpl)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IPlayerImpl)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IPlayerImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayerImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayerImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayerImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayerImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayerImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayerImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayerImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayerImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayerImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayerImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayerImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayerImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayerImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayerImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayerImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayerImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayerImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayerImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayerImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayerImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayerImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayerImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayerImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayerImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayerImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayerImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayerImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayerImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayerImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayerImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayerImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayerImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayerImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayerImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayerImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayerImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IPlayerImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IPlayerImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IPlayerImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IPlayerImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IPlayerImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IPlayerImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IPlayerImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IPlayerImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IPlayerImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IPlayerImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IPlayerImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IPlayerImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IPlayerImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IPlayerImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IPlayerImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IPlayerImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IPlayerImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IPlayerImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IPlayerImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IPlayerImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IPlayerImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IPlayerImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IPlayerImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IPlayerImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IPlayerImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IPlayerImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IPlayerImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IPlayerImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IPlayerImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IPlayerImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IPlayerImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IPlayerImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IPlayerImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IPlayerImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IPlayerImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IPlayerImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IPlayerImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IPlayerImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1374563470;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IObject))]
    internal class OrleansCodeGenObjectReference : global::Orleans.Runtime.GrainReference, global::Server.IObject
    {
        protected @OrleansCodeGenObjectReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenObjectReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -167405501;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IObject";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -167405501 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -167405501:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -167405501 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IObject", -167405501, typeof (global::Server.IObject)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenObjectMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -167405501:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IObject)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IObject)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IObject)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IObject)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IObject)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IObject)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IObject)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IObject)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IObject)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IObject)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IObject)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IObject)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IObject)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IObject)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IObject)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IObject)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IObject)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IObject)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IObject)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IObject)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IObject)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IObject)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IObject)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IObject)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IObject)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IObject)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IObject)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IObject)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IObject)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IObject)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IObject)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IObject)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IObject)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IObject)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IObject)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IObject)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IObject)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IObject)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IObject)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IObject)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -167405501 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IObject)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IObject)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IObject)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IObject)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IObject)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IObject)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IObject)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IObject)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IObject)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IObject)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IObject)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IObject)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IObject)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IObject)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IObject)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IObject)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IObject)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IObject)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IObject)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IObject)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IObject)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IObject)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IObject)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IObject)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IObject)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IObject)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IObject)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IObject)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IObject)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IObject)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IObject)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IObject)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IObject)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IObject)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IObject)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IObject)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IObject)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IObject)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IObject)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IObject)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -167405501;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IObjectImpl))]
    internal class OrleansCodeGenObjectImplReference : global::Orleans.Runtime.GrainReference, global::Server.IObjectImpl
    {
        protected @OrleansCodeGenObjectImplReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenObjectImplReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1962518542;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IObjectImpl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IObjectImpl", 1962518542, typeof (global::Server.IObjectImpl)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenObjectImplMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IObjectImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IObjectImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IObjectImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IObjectImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IObjectImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IObjectImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IObjectImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IObjectImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IObjectImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IObjectImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IObjectImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IObjectImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IObjectImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IObjectImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IObjectImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IObjectImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IObjectImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IObjectImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IObjectImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IObjectImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IObjectImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IObjectImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IObjectImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IObjectImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IObjectImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IObjectImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IObjectImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IObjectImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IObjectImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IObjectImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IObjectImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IObjectImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IObjectImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IObjectImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IObjectImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IObjectImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IObjectImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IObjectImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IObjectImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IObjectImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1962518542;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IBaseObjectImpl))]
    internal class OrleansCodeGenBaseObjectImplReference : global::Orleans.Runtime.GrainReference, global::Server.IBaseObjectImpl
    {
        protected @OrleansCodeGenBaseObjectImplReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenBaseObjectImplReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 436426678;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IBaseObjectImpl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IBaseObjectImpl", 436426678, typeof (global::Server.IBaseObjectImpl)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenBaseObjectImplMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 436426678;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.ICreature))]
    internal class OrleansCodeGenCreatureReference : global::Orleans.Runtime.GrainReference, global::Server.ICreature
    {
        protected @OrleansCodeGenCreatureReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCreatureReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1097649859;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.ICreature";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1097649859 || @interfaceId == -2139656788 || @interfaceId == -459325194 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1097649859:
                    switch (@methodId)
                    {
                        case 934435978:
                            return "Create";
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1097649859 + ",methodId=" + @methodId);
                    }

                case -2139656788:
                    switch (@methodId)
                    {
                        case 934435978:
                            return "Create";
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2139656788 + ",methodId=" + @methodId);
                    }

                case -459325194:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Create(global::Shared.CreatureEntry @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(934435978, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UnitCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(1519937893, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-342467399, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetNativeDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1421261762, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.ICreature", -1097649859, typeof (global::Server.ICreature)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCreatureMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1097649859:
                        switch (@methodId)
                        {
                            case 934435978:
                                return ((global::Server.ICreature)@grain).@Create((global::Shared.CreatureEntry)@arguments[0]).@Box();
                            case 1519937893:
                                return ((global::Server.ICreature)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.ICreature)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.ICreature)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.ICreature)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreature)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreature)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreature)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreature)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreature)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreature)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreature)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreature)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreature)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreature)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreature)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreature)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreature)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreature)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreature)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreature)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreature)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreature)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreature)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreature)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreature)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreature)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreature)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreature)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreature)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreature)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreature)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreature)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreature)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreature)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreature)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreature)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreature)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreature)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreature)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreature)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreature)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreature)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreature)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1097649859 + ",methodId=" + @methodId);
                        }

                    case -2139656788:
                        switch (@methodId)
                        {
                            case 934435978:
                                return ((global::Server.ICreature)@grain).@Create((global::Shared.CreatureEntry)@arguments[0]).@Box();
                            case 1519937893:
                                return ((global::Server.ICreature)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.ICreature)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.ICreature)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.ICreature)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreature)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreature)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreature)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreature)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreature)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreature)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreature)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreature)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreature)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreature)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreature)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreature)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreature)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreature)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreature)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreature)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreature)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreature)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreature)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreature)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreature)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreature)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreature)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreature)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreature)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreature)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreature)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreature)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreature)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreature)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreature)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreature)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreature)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreature)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreature)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreature)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreature)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreature)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreature)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2139656788 + ",methodId=" + @methodId);
                        }

                    case -459325194:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.ICreature)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.ICreature)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.ICreature)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.ICreature)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreature)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreature)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreature)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreature)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreature)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreature)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreature)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreature)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreature)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreature)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreature)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreature)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreature)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreature)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreature)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreature)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreature)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreature)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreature)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreature)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreature)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreature)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreature)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreature)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreature)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreature)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreature)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreature)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreature)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreature)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreature)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreature)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreature)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreature)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreature)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreature)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreature)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreature)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreature)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.ICreature)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreature)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreature)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreature)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreature)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreature)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreature)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreature)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreature)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreature)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreature)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreature)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreature)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreature)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreature)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreature)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreature)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreature)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreature)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreature)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreature)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreature)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreature)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreature)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreature)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreature)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreature)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreature)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreature)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreature)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreature)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreature)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreature)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreature)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreature)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreature)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreature)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreature)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreature)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreature)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1097649859;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.ICreatureImpl))]
    internal class OrleansCodeGenCreatureImplReference : global::Orleans.Runtime.GrainReference, global::Server.ICreatureImpl
    {
        protected @OrleansCodeGenCreatureImplReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCreatureImplReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2139656788;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.ICreatureImpl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2139656788 || @interfaceId == -459325194 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2139656788:
                    switch (@methodId)
                    {
                        case 934435978:
                            return "Create";
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2139656788 + ",methodId=" + @methodId);
                    }

                case -459325194:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Create(global::Shared.CreatureEntry @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(934435978, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UnitCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(1519937893, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-342467399, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetNativeDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1421261762, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.ICreatureImpl", -2139656788, typeof (global::Server.ICreatureImpl)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCreatureImplMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -2139656788:
                        switch (@methodId)
                        {
                            case 934435978:
                                return ((global::Server.ICreatureImpl)@grain).@Create((global::Shared.CreatureEntry)@arguments[0]).@Box();
                            case 1519937893:
                                return ((global::Server.ICreatureImpl)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.ICreatureImpl)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.ICreatureImpl)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.ICreatureImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreatureImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreatureImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreatureImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreatureImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreatureImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreatureImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreatureImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreatureImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreatureImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreatureImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreatureImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreatureImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreatureImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreatureImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreatureImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreatureImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreatureImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreatureImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreatureImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreatureImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreatureImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreatureImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreatureImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreatureImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreatureImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreatureImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreatureImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreatureImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreatureImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreatureImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreatureImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreatureImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreatureImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreatureImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreatureImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreatureImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2139656788 + ",methodId=" + @methodId);
                        }

                    case -459325194:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.ICreatureImpl)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.ICreatureImpl)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.ICreatureImpl)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.ICreatureImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreatureImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreatureImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreatureImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreatureImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreatureImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreatureImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreatureImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreatureImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreatureImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreatureImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreatureImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreatureImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreatureImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreatureImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreatureImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreatureImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreatureImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreatureImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreatureImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreatureImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreatureImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreatureImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreatureImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreatureImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreatureImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreatureImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreatureImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreatureImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreatureImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreatureImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreatureImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreatureImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreatureImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreatureImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreatureImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreatureImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.ICreatureImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.ICreatureImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.ICreatureImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.ICreatureImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.ICreatureImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.ICreatureImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.ICreatureImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.ICreatureImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.ICreatureImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.ICreatureImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.ICreatureImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.ICreatureImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.ICreatureImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.ICreatureImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.ICreatureImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.ICreatureImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.ICreatureImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.ICreatureImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.ICreatureImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.ICreatureImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.ICreatureImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.ICreatureImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.ICreatureImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.ICreatureImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.ICreatureImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.ICreatureImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.ICreatureImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.ICreatureImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.ICreatureImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.ICreatureImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.ICreatureImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.ICreatureImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.ICreatureImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.ICreatureImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.ICreatureImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.ICreatureImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.ICreatureImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.ICreatureImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2139656788;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IUnit))]
    internal class OrleansCodeGenUnitReference : global::Orleans.Runtime.GrainReference, global::Server.IUnit
    {
        protected @OrleansCodeGenUnitReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenUnitReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1237625140;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IUnit";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1237625140 || @interfaceId == -459325194 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1237625140:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1237625140 + ",methodId=" + @methodId);
                    }

                case -459325194:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UnitCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(1519937893, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-342467399, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetNativeDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1421261762, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IUnit", 1237625140, typeof (global::Server.IUnit)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenUnitMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1237625140:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.IUnit)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IUnit)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IUnit)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IUnit)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IUnit)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IUnit)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IUnit)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IUnit)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IUnit)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IUnit)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IUnit)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IUnit)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IUnit)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IUnit)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IUnit)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IUnit)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IUnit)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IUnit)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IUnit)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IUnit)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IUnit)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IUnit)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IUnit)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IUnit)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IUnit)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IUnit)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IUnit)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IUnit)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IUnit)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IUnit)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IUnit)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IUnit)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IUnit)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IUnit)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IUnit)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IUnit)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IUnit)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IUnit)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IUnit)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IUnit)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IUnit)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IUnit)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IUnit)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1237625140 + ",methodId=" + @methodId);
                        }

                    case -459325194:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.IUnit)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IUnit)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IUnit)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IUnit)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IUnit)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IUnit)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IUnit)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IUnit)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IUnit)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IUnit)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IUnit)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IUnit)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IUnit)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IUnit)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IUnit)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IUnit)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IUnit)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IUnit)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IUnit)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IUnit)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IUnit)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IUnit)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IUnit)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IUnit)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IUnit)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IUnit)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IUnit)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IUnit)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IUnit)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IUnit)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IUnit)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IUnit)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IUnit)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IUnit)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IUnit)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IUnit)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IUnit)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IUnit)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IUnit)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IUnit)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IUnit)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IUnit)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IUnit)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IUnit)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IUnit)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IUnit)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IUnit)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IUnit)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IUnit)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IUnit)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IUnit)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IUnit)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IUnit)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IUnit)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IUnit)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IUnit)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IUnit)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IUnit)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IUnit)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IUnit)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IUnit)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IUnit)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IUnit)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IUnit)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IUnit)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IUnit)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IUnit)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IUnit)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IUnit)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IUnit)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IUnit)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IUnit)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IUnit)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IUnit)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IUnit)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IUnit)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IUnit)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IUnit)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IUnit)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IUnit)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IUnit)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IUnit)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IUnit)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1237625140;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IUnitImpl))]
    internal class OrleansCodeGenUnitImplReference : global::Orleans.Runtime.GrainReference, global::Server.IUnitImpl
    {
        protected @OrleansCodeGenUnitImplReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenUnitImplReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -459325194;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IUnitImpl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -459325194 || @interfaceId == 1962518542 || @interfaceId == 436426678;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -459325194:
                    switch (@methodId)
                    {
                        case 1519937893:
                            return "UnitCall";
                        case -342467399:
                            return "GetDisplayID";
                        case 1421261762:
                            return "GetNativeDisplayID";
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                    }

                case 1962518542:
                    switch (@methodId)
                    {
                        case 911766124:
                            return "VirtualCall";
                        case -509390599:
                            return "ObjectCall";
                        case -1038277770:
                            return "Save";
                        case -663875885:
                            return "IsValid";
                        case -1893154936:
                            return "GetGUID";
                        case 1822423030:
                            return "GetPackedGUID";
                        case 166514075:
                            return "GetPositionX";
                        case 437724131:
                            return "GetPositionY";
                        case 1183954579:
                            return "GetPositionZ";
                        case 1856558624:
                            return "GetOrientation";
                        case 48269821:
                            return "UpdateInRangeSet";
                        case 1415061848:
                            return "RemoveInRangeObject";
                        case -1175709360:
                            return "AddInRangeObject";
                        case -314520557:
                            return "CanSee";
                        case -596183580:
                            return "BuildCreateUpdateFor";
                        case -684828005:
                            return "BuildValuesUpdateFor";
                        case -1356403447:
                            return "Update";
                        case 1183483657:
                            return "GetByte";
                        case -557202625:
                            return "GetUInt32";
                        case 1044973385:
                            return "GetFloat";
                        case -1336362613:
                            return "SetByte";
                        case -1928648525:
                            return "SetUInt32";
                        case -21267500:
                            return "SetInt32";
                        case 995425448:
                            return "SetFloat";
                        case 1125137820:
                            return "SetUInt64";
                        case -1935978507:
                            return "SetGUID";
                        case -2063265882:
                            return "GetMap";
                        case -536678569:
                            return "IsOnMap";
                        case 2124193760:
                            return "SetMap";
                        case 533658636:
                            return "SetCell";
                        case 1105280656:
                            return "GetCell";
                        case 939583700:
                            return "ClearMap";
                        case -1893562941:
                            return "IsCellActivator";
                        case -1523856837:
                            return "IsPlayer";
                        case 1951711301:
                            return "IsUnit";
                        case -927314476:
                            return "IsCreature";
                        case 1612767703:
                            return "IsPet";
                        case -313953098:
                            return "IsVehicle";
                        case 1810721655:
                            return "IsTransport";
                        case -235749357:
                            return "IsGameObject";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                    }

                case 436426678:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UnitCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(1519937893, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-342467399, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetNativeDisplayID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1421261762, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @VirtualCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(911766124, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @ObjectCall()
        {
            return base.@InvokeMethodAsync<global::System.String>(-509390599, null);
        }

        public global::System.Threading.Tasks.Task @Save()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1038277770, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GetGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-1893154936, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.PackedGUID> @GetPackedGUID()
        {
            return base.@InvokeMethodAsync<global::Shared.PackedGUID>(1822423030, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionX()
        {
            return base.@InvokeMethodAsync<global::System.Single>(166514075, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionY()
        {
            return base.@InvokeMethodAsync<global::System.Single>(437724131, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetPositionZ()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1183954579, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetOrientation()
        {
            return base.@InvokeMethodAsync<global::System.Single>(1856558624, null);
        }

        public global::System.Threading.Tasks.Task @UpdateInRangeSet()
        {
            return base.@InvokeMethodAsync<global::System.Object>(48269821, null);
        }

        public global::System.Threading.Tasks.Task @RemoveInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @remove_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1415061848, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @remove_other});
        }

        public global::System.Threading.Tasks.Task @AddInRangeObject(global::Shared.ObjectGUID @guid, global::Server.IObjectImpl @obj, global::System.Boolean @add_other)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1175709360, new global::System.Object[]{@guid, @obj is global::Orleans.Grain ? @obj.@AsReference<global::Server.IObjectImpl>() : @obj, @add_other});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @CanSee(global::Server.IObjectImpl @other)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-314520557, new global::System.Object[]{@other is global::Orleans.Grain ? @other.@AsReference<global::Server.IObjectImpl>() : @other});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildCreateUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-596183580, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task<global::Shared.PacketOut> @BuildValuesUpdateFor(global::Server.IPlayer @plr)
        {
            return base.@InvokeMethodAsync<global::Shared.PacketOut>(-684828005, new global::System.Object[]{@plr is global::Orleans.Grain ? @plr.@AsReference<global::Server.IPlayer>() : @plr});
        }

        public global::System.Threading.Tasks.Task @Update()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1356403447, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Byte> @GetByte(global::System.Object @field, global::System.Int32 @index)
        {
            return base.@InvokeMethodAsync<global::System.Byte>(1183483657, new global::System.Object[]{@field, @index});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GetUInt32(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-557202625, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task<global::System.Single> @GetFloat(global::System.Object @field)
        {
            return base.@InvokeMethodAsync<global::System.Single>(1044973385, new global::System.Object[]{@field});
        }

        public global::System.Threading.Tasks.Task @SetByte(global::System.Object @field, global::System.Int32 @index, global::System.Byte @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1336362613, new global::System.Object[]{@field, @index, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt32(global::System.Object @field, global::System.UInt32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1928648525, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetInt32(global::System.Object @field, global::System.Int32 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-21267500, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetFloat(global::System.Object @field, global::System.Single @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(995425448, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetUInt64(global::System.Object @field, global::System.UInt64 @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1125137820, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task @SetGUID(global::System.Object @field, global::Shared.ObjectGUID @val)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1935978507, new global::System.Object[]{@field, @val});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap()
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-2063265882, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsOnMap()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-536678569, null);
        }

        public global::System.Threading.Tasks.Task @SetMap(global::Server.IMap @map)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2124193760, new global::System.Object[]{@map is global::Orleans.Grain ? @map.@AsReference<global::Server.IMap>() : @map});
        }

        public global::System.Threading.Tasks.Task @SetCell(global::System.UInt64 @cellkey)
        {
            return base.@InvokeMethodAsync<global::System.Object>(533658636, new global::System.Object[]{@cellkey});
        }

        public global::System.Threading.Tasks.Task<global::System.UInt64> @GetCell()
        {
            return base.@InvokeMethodAsync<global::System.UInt64>(1105280656, null);
        }

        public global::System.Threading.Tasks.Task @ClearMap()
        {
            return base.@InvokeMethodAsync<global::System.Object>(939583700, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCellActivator()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1893562941, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPlayer()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1523856837, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsUnit()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1951711301, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsCreature()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-927314476, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsPet()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1612767703, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsVehicle()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-313953098, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsTransport()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1810721655, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsGameObject()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-235749357, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IUnitImpl", -459325194, typeof (global::Server.IUnitImpl)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenUnitImplMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -459325194:
                        switch (@methodId)
                        {
                            case 1519937893:
                                return ((global::Server.IUnitImpl)@grain).@UnitCall().@Box();
                            case -342467399:
                                return ((global::Server.IUnitImpl)@grain).@GetDisplayID().@Box();
                            case 1421261762:
                                return ((global::Server.IUnitImpl)@grain).@GetNativeDisplayID().@Box();
                            case 911766124:
                                return ((global::Server.IUnitImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IUnitImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IUnitImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IUnitImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IUnitImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IUnitImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IUnitImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IUnitImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IUnitImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IUnitImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IUnitImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IUnitImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IUnitImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IUnitImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IUnitImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IUnitImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IUnitImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IUnitImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IUnitImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IUnitImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IUnitImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IUnitImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IUnitImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IUnitImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IUnitImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IUnitImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IUnitImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IUnitImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IUnitImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IUnitImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IUnitImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IUnitImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IUnitImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IUnitImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IUnitImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IUnitImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IUnitImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IUnitImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IUnitImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IUnitImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -459325194 + ",methodId=" + @methodId);
                        }

                    case 1962518542:
                        switch (@methodId)
                        {
                            case 911766124:
                                return ((global::Server.IUnitImpl)@grain).@VirtualCall().@Box();
                            case -509390599:
                                return ((global::Server.IUnitImpl)@grain).@ObjectCall().@Box();
                            case -1038277770:
                                return ((global::Server.IUnitImpl)@grain).@Save().@Box();
                            case -663875885:
                                return ((global::Server.IUnitImpl)@grain).@IsValid().@Box();
                            case -1893154936:
                                return ((global::Server.IUnitImpl)@grain).@GetGUID().@Box();
                            case 1822423030:
                                return ((global::Server.IUnitImpl)@grain).@GetPackedGUID().@Box();
                            case 166514075:
                                return ((global::Server.IUnitImpl)@grain).@GetPositionX().@Box();
                            case 437724131:
                                return ((global::Server.IUnitImpl)@grain).@GetPositionY().@Box();
                            case 1183954579:
                                return ((global::Server.IUnitImpl)@grain).@GetPositionZ().@Box();
                            case 1856558624:
                                return ((global::Server.IUnitImpl)@grain).@GetOrientation().@Box();
                            case 48269821:
                                return ((global::Server.IUnitImpl)@grain).@UpdateInRangeSet().@Box();
                            case 1415061848:
                                return ((global::Server.IUnitImpl)@grain).@RemoveInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -1175709360:
                                return ((global::Server.IUnitImpl)@grain).@AddInRangeObject((global::Shared.ObjectGUID)@arguments[0], (global::Server.IObjectImpl)@arguments[1], (global::System.Boolean)@arguments[2]).@Box();
                            case -314520557:
                                return ((global::Server.IUnitImpl)@grain).@CanSee((global::Server.IObjectImpl)@arguments[0]).@Box();
                            case -596183580:
                                return ((global::Server.IUnitImpl)@grain).@BuildCreateUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -684828005:
                                return ((global::Server.IUnitImpl)@grain).@BuildValuesUpdateFor((global::Server.IPlayer)@arguments[0]).@Box();
                            case -1356403447:
                                return ((global::Server.IUnitImpl)@grain).@Update().@Box();
                            case 1183483657:
                                return ((global::Server.IUnitImpl)@grain).@GetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case -557202625:
                                return ((global::Server.IUnitImpl)@grain).@GetUInt32((global::System.Object)@arguments[0]).@Box();
                            case 1044973385:
                                return ((global::Server.IUnitImpl)@grain).@GetFloat((global::System.Object)@arguments[0]).@Box();
                            case -1336362613:
                                return ((global::Server.IUnitImpl)@grain).@SetByte((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1], (global::System.Byte)@arguments[2]).@Box();
                            case -1928648525:
                                return ((global::Server.IUnitImpl)@grain).@SetUInt32((global::System.Object)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -21267500:
                                return ((global::Server.IUnitImpl)@grain).@SetInt32((global::System.Object)@arguments[0], (global::System.Int32)@arguments[1]).@Box();
                            case 995425448:
                                return ((global::Server.IUnitImpl)@grain).@SetFloat((global::System.Object)@arguments[0], (global::System.Single)@arguments[1]).@Box();
                            case 1125137820:
                                return ((global::Server.IUnitImpl)@grain).@SetUInt64((global::System.Object)@arguments[0], (global::System.UInt64)@arguments[1]).@Box();
                            case -1935978507:
                                return ((global::Server.IUnitImpl)@grain).@SetGUID((global::System.Object)@arguments[0], (global::Shared.ObjectGUID)@arguments[1]).@Box();
                            case -2063265882:
                                return ((global::Server.IUnitImpl)@grain).@GetMap().@Box();
                            case -536678569:
                                return ((global::Server.IUnitImpl)@grain).@IsOnMap().@Box();
                            case 2124193760:
                                return ((global::Server.IUnitImpl)@grain).@SetMap((global::Server.IMap)@arguments[0]).@Box();
                            case 533658636:
                                return ((global::Server.IUnitImpl)@grain).@SetCell((global::System.UInt64)@arguments[0]).@Box();
                            case 1105280656:
                                return ((global::Server.IUnitImpl)@grain).@GetCell().@Box();
                            case 939583700:
                                return ((global::Server.IUnitImpl)@grain).@ClearMap().@Box();
                            case -1893562941:
                                return ((global::Server.IUnitImpl)@grain).@IsCellActivator().@Box();
                            case -1523856837:
                                return ((global::Server.IUnitImpl)@grain).@IsPlayer().@Box();
                            case 1951711301:
                                return ((global::Server.IUnitImpl)@grain).@IsUnit().@Box();
                            case -927314476:
                                return ((global::Server.IUnitImpl)@grain).@IsCreature().@Box();
                            case 1612767703:
                                return ((global::Server.IUnitImpl)@grain).@IsPet().@Box();
                            case -313953098:
                                return ((global::Server.IUnitImpl)@grain).@IsVehicle().@Box();
                            case 1810721655:
                                return ((global::Server.IUnitImpl)@grain).@IsTransport().@Box();
                            case -235749357:
                                return ((global::Server.IUnitImpl)@grain).@IsGameObject().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1962518542 + ",methodId=" + @methodId);
                        }

                    case 436426678:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 436426678 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -459325194;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IRealmManager))]
    internal class OrleansCodeGenRealmManagerReference : global::Orleans.Runtime.GrainReference, global::Server.IRealmManager
    {
        protected @OrleansCodeGenRealmManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenRealmManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 742203874;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IRealmManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 742203874;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 742203874:
                    switch (@methodId)
                    {
                        case -637421897:
                            return "GetRealm";
                        case -951231375:
                            return "GetRealmName";
                        case -1749235508:
                            return "RemoveRealm";
                        case -130435026:
                            return "AddRealm";
                        case 170842919:
                            return "GetRealms";
                        case 574707288:
                            return "PingRealm";
                        case 1380451899:
                            return "SetRealmOffline";
                        case -764093020:
                            return "GetMap";
                        case -1781421754:
                            return "GetMap";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 742203874 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Shared.Realm> @GetRealm(global::System.Int32 @id)
        {
            return base.@InvokeMethodAsync<global::Shared.Realm>(-637421897, new global::System.Object[]{@id});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetRealmName(global::System.Int32 @id)
        {
            return base.@InvokeMethodAsync<global::System.String>(-951231375, new global::System.Object[]{@id});
        }

        public global::System.Threading.Tasks.Task @RemoveRealm(global::System.Int32 @id)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1749235508, new global::System.Object[]{@id});
        }

        public global::System.Threading.Tasks.Task @AddRealm(global::Shared.RealmSettings @r)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-130435026, new global::System.Object[]{@r});
        }

        public global::System.Threading.Tasks.Task<global::Shared.Realm[]> @GetRealms(global::System.Int32 @AccountLevel)
        {
            return base.@InvokeMethodAsync<global::Shared.Realm[]>(170842919, new global::System.Object[]{@AccountLevel});
        }

        public global::System.Threading.Tasks.Task @PingRealm(global::System.Int32 @id)
        {
            return base.@InvokeMethodAsync<global::System.Object>(574707288, new global::System.Object[]{@id});
        }

        public global::System.Threading.Tasks.Task @SetRealmOffline(global::System.Int32 @id)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1380451899, new global::System.Object[]{@id});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap(global::System.UInt32 @MapId, global::System.UInt32 @InstanceID, global::System.UInt32 @RealmID)
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-764093020, new global::System.Object[]{@MapId, @InstanceID, @RealmID});
        }

        public global::System.Threading.Tasks.Task<global::Server.IMap> @GetMap(global::System.UInt32 @MapId, global::System.UInt32 @RealmID)
        {
            return base.@InvokeMethodAsync<global::Server.IMap>(-1781421754, new global::System.Object[]{@MapId, @RealmID});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IRealmManager", 742203874, typeof (global::Server.IRealmManager)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenRealmManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 742203874:
                        switch (@methodId)
                        {
                            case -637421897:
                                return ((global::Server.IRealmManager)@grain).@GetRealm((global::System.Int32)@arguments[0]).@Box();
                            case -951231375:
                                return ((global::Server.IRealmManager)@grain).@GetRealmName((global::System.Int32)@arguments[0]).@Box();
                            case -1749235508:
                                return ((global::Server.IRealmManager)@grain).@RemoveRealm((global::System.Int32)@arguments[0]).@Box();
                            case -130435026:
                                return ((global::Server.IRealmManager)@grain).@AddRealm((global::Shared.RealmSettings)@arguments[0]).@Box();
                            case 170842919:
                                return ((global::Server.IRealmManager)@grain).@GetRealms((global::System.Int32)@arguments[0]).@Box();
                            case 574707288:
                                return ((global::Server.IRealmManager)@grain).@PingRealm((global::System.Int32)@arguments[0]).@Box();
                            case 1380451899:
                                return ((global::Server.IRealmManager)@grain).@SetRealmOffline((global::System.Int32)@arguments[0]).@Box();
                            case -764093020:
                                return ((global::Server.IRealmManager)@grain).@GetMap((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1], (global::System.UInt32)@arguments[2]).@Box();
                            case -1781421754:
                                return ((global::Server.IRealmManager)@grain).@GetMap((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 742203874 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 742203874;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.Realm)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_RealmSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.Realm).@GetField("RealmSettings", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.Realm).@GetField("RealmStatus", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.Realm input = ((global::Shared.Realm)original);
            global::Shared.Realm result = new global::Shared.Realm();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, (global::Shared.RealmSettings)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            field1.@SetValue(result, (global::Shared.RealmStatus)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field1.@GetValue(input)));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.Realm input = (global::Shared.Realm)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.RealmSettings));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::Shared.RealmStatus));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.Realm result = new global::Shared.Realm();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::Shared.RealmSettings)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.RealmSettings), stream));
            field1.@SetValue(result, (global::Shared.RealmStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.RealmStatus), stream));
            return (global::Shared.Realm)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.Realm), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_RealmSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.RealmStatus)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_RealmStatusSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.RealmStatus).@GetField("CurrentPlayers", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.RealmStatus).@GetField("LastPing", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.RealmStatus).@GetField("LastPingUT", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.RealmStatus input = ((global::Shared.RealmStatus)original);
            global::Shared.RealmStatus result = new global::Shared.RealmStatus();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, field0.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field1.@SetValue(result, field1.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.RealmStatus input = (global::Shared.RealmStatus)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.RealmStatus result = new global::Shared.RealmStatus();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field2.@SetValue(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            field1.@SetValue(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Shared.RealmStatus)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.RealmStatus), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_RealmStatusSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.RealmSettings)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_RealmSettingsSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.RealmSettings).@GetField("Address", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.RealmSettings).@GetField("Cat", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.RealmSettings).@GetField("ID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.RealmSettings).@GetField("Lol", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.RealmSettings).@GetField("MaxPlayers", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.RealmSettings).@GetField("Name", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Shared.RealmSettings).@GetField("Port", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.RealmSettings).@GetField("RealmID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.RealmSettings).@GetField("RequiredAccountLevel", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.RealmSettings input = ((global::Shared.RealmSettings)original);
            global::Shared.RealmSettings result = new global::Shared.RealmSettings();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field1.@SetValue(result, field1.@GetValue(input));
            field7.@SetValue(result, field7.@GetValue(input));
            field0.@SetValue(result, field0.@GetValue(input));
            field3.@SetValue(result, field3.@GetValue(input));
            field6.@SetValue(result, field6.@GetValue(input));
            field2.@SetValue(result, field2.@GetValue(input));
            field8.@SetValue(result, field8.@GetValue(input));
            field4.@SetValue(result, field4.@GetValue(input));
            field5.@SetValue(result, field5.@GetValue(input));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.RealmSettings input = (global::Shared.RealmSettings)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.UInt16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.RealmSettings result = new global::Shared.RealmSettings();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field1.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field7.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field0.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field3.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field6.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field2.@SetValue(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field8.@SetValue(result, (global::System.UInt16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt16), stream));
            field4.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field5.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Shared.RealmSettings)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.RealmSettings), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_RealmSettingsSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.ICreator))]
    internal class OrleansCodeGenCreatorReference : global::Orleans.Runtime.GrainReference, global::Server.ICreator
    {
        protected @OrleansCodeGenCreatorReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCreatorReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1083887352;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.ICreator";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1083887352;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1083887352:
                    switch (@methodId)
                    {
                        case -511475103:
                            return "GenerateInstanceID";
                        case 962302109:
                            return "GenerateGUID";
                        case -498054261:
                            return "GenerateCreatureGUID";
                        case -1489183713:
                            return "CreatePlayer";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1083887352 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.UInt32> @GenerateInstanceID()
        {
            return base.@InvokeMethodAsync<global::System.UInt32>(-511475103, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GenerateGUID(global::Shared.ObjectType @objectType)
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(962302109, new global::System.Object[]{@objectType});
        }

        public global::System.Threading.Tasks.Task<global::Shared.ObjectGUID> @GenerateCreatureGUID(global::System.UInt32 @Entry)
        {
            return base.@InvokeMethodAsync<global::Shared.ObjectGUID>(-498054261, new global::System.Object[]{@Entry});
        }

        public global::System.Threading.Tasks.Task<global::System.Tuple<global::Shared.LoginErrorCode, global::Server.IPlayer>> @CreatePlayer(global::Shared.PlayerCreateData @info)
        {
            return base.@InvokeMethodAsync<global::System.Tuple<global::Shared.LoginErrorCode, global::Server.IPlayer>>(-1489183713, new global::System.Object[]{@info});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.ICreator", -1083887352, typeof (global::Server.ICreator)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCreatorMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -1083887352:
                        switch (@methodId)
                        {
                            case -511475103:
                                return ((global::Server.ICreator)@grain).@GenerateInstanceID().@Box();
                            case 962302109:
                                return ((global::Server.ICreator)@grain).@GenerateGUID((global::Shared.ObjectType)@arguments[0]).@Box();
                            case -498054261:
                                return ((global::Server.ICreator)@grain).@GenerateCreatureGUID((global::System.UInt32)@arguments[0]).@Box();
                            case -1489183713:
                                return ((global::Server.ICreator)@grain).@CreatePlayer((global::Shared.PlayerCreateData)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1083887352 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1083887352;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.IAccount))]
    internal class OrleansCodeGenAccountReference : global::Orleans.Runtime.GrainReference, global::Server.IAccount
    {
        protected @OrleansCodeGenAccountReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenAccountReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -688083232;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.IAccount";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -688083232 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -688083232:
                    switch (@methodId)
                    {
                        case -1041284210:
                            return "Destroy";
                        case 1391356785:
                            return "Authenticate";
                        case -2074345984:
                            return "CreateAccount";
                        case -555567538:
                            return "SetPassword";
                        case -1288502433:
                            return "GetPassword";
                        case -752136790:
                            return "GetPasswordPlain";
                        case -663875885:
                            return "IsValid";
                        case 309252343:
                            return "AddSession";
                        case -1423570004:
                            return "RemoveSession";
                        case 1371286109:
                            return "GetAuthSession";
                        case -1106931492:
                            return "GetRealmSession";
                        case -1007635377:
                            return "SendPacketRealm";
                        case 862002919:
                            return "SendPacketAuth";
                        case 12719627:
                            return "SendAccountDataTimes";
                        case 2060811694:
                            return "UpdateAccountData";
                        case 833613103:
                            return "SendAccountData";
                        case 1560354665:
                            return "SendCharEnum";
                        case -549773541:
                            return "CreatePlayer";
                        case 1875409470:
                            return "PlayerLogin";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -688083232 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Destroy()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1041284210, null);
        }

        public global::System.Threading.Tasks.Task<global::Server.AccountAuthResponse> @Authenticate(global::System.String @password)
        {
            return base.@InvokeMethodAsync<global::Server.AccountAuthResponse>(1391356785, new global::System.Object[]{@password});
        }

        public global::System.Threading.Tasks.Task<global::Server.AccountCreateResponse> @CreateAccount(global::System.String @password)
        {
            return base.@InvokeMethodAsync<global::Server.AccountCreateResponse>(-2074345984, new global::System.Object[]{@password});
        }

        public global::System.Threading.Tasks.Task @SetPassword(global::System.String @password)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-555567538, new global::System.Object[]{@password});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetPassword()
        {
            return base.@InvokeMethodAsync<global::System.String>(-1288502433, null);
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetPasswordPlain()
        {
            return base.@InvokeMethodAsync<global::System.String>(-752136790, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @IsValid()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-663875885, null);
        }

        public global::System.Threading.Tasks.Task @AddSession(global::Server.ISession @s)
        {
            return base.@InvokeMethodAsync<global::System.Object>(309252343, new global::System.Object[]{@s is global::Orleans.Grain ? @s.@AsReference<global::Server.ISession>() : @s});
        }

        public global::System.Threading.Tasks.Task @RemoveSession(global::Server.ISession @s, global::System.Boolean @disconnect)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1423570004, new global::System.Object[]{@s is global::Orleans.Grain ? @s.@AsReference<global::Server.ISession>() : @s, @disconnect});
        }

        public global::System.Threading.Tasks.Task<global::Server.ISession> @GetAuthSession()
        {
            return base.@InvokeMethodAsync<global::Server.ISession>(1371286109, null);
        }

        public global::System.Threading.Tasks.Task<global::Server.ISession> @GetRealmSession()
        {
            return base.@InvokeMethodAsync<global::Server.ISession>(-1106931492, null);
        }

        public global::System.Threading.Tasks.Task @SendPacketRealm(global::Shared.PacketOut @p)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1007635377, new global::System.Object[]{@p});
        }

        public global::System.Threading.Tasks.Task @SendPacketAuth(global::Shared.PacketOut @p)
        {
            return base.@InvokeMethodAsync<global::System.Object>(862002919, new global::System.Object[]{@p});
        }

        public global::System.Threading.Tasks.Task @SendAccountDataTimes(global::System.UInt32 @mask)
        {
            return base.@InvokeMethodAsync<global::System.Object>(12719627, new global::System.Object[]{@mask});
        }

        public global::System.Threading.Tasks.Task @UpdateAccountData(global::System.UInt32 @id, global::System.UInt32 @time, global::System.UInt32 @size, global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2060811694, new global::System.Object[]{@id, @time, @size, @data});
        }

        public global::System.Threading.Tasks.Task @SendAccountData(global::System.UInt32 @id)
        {
            return base.@InvokeMethodAsync<global::System.Object>(833613103, new global::System.Object[]{@id});
        }

        public global::System.Threading.Tasks.Task @SendCharEnum(global::System.Int32 @RealmID)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1560354665, new global::System.Object[]{@RealmID});
        }

        public global::System.Threading.Tasks.Task @CreatePlayer(global::Shared.CMSG_CHAR_CREATE @create)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-549773541, new global::System.Object[]{@create});
        }

        public global::System.Threading.Tasks.Task @PlayerLogin(global::Shared.CMSG_PLAYER_LOGIN @pkt)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1875409470, new global::System.Object[]{@pkt});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.IAccount", -688083232, typeof (global::Server.IAccount)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenAccountMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case -688083232:
                        switch (@methodId)
                        {
                            case -1041284210:
                                return ((global::Server.IAccount)@grain).@Destroy().@Box();
                            case 1391356785:
                                return ((global::Server.IAccount)@grain).@Authenticate((global::System.String)@arguments[0]).@Box();
                            case -2074345984:
                                return ((global::Server.IAccount)@grain).@CreateAccount((global::System.String)@arguments[0]).@Box();
                            case -555567538:
                                return ((global::Server.IAccount)@grain).@SetPassword((global::System.String)@arguments[0]).@Box();
                            case -1288502433:
                                return ((global::Server.IAccount)@grain).@GetPassword().@Box();
                            case -752136790:
                                return ((global::Server.IAccount)@grain).@GetPasswordPlain().@Box();
                            case -663875885:
                                return ((global::Server.IAccount)@grain).@IsValid().@Box();
                            case 309252343:
                                return ((global::Server.IAccount)@grain).@AddSession((global::Server.ISession)@arguments[0]).@Box();
                            case -1423570004:
                                return ((global::Server.IAccount)@grain).@RemoveSession((global::Server.ISession)@arguments[0], (global::System.Boolean)@arguments[1]).@Box();
                            case 1371286109:
                                return ((global::Server.IAccount)@grain).@GetAuthSession().@Box();
                            case -1106931492:
                                return ((global::Server.IAccount)@grain).@GetRealmSession().@Box();
                            case -1007635377:
                                return ((global::Server.IAccount)@grain).@SendPacketRealm((global::Shared.PacketOut)@arguments[0]).@Box();
                            case 862002919:
                                return ((global::Server.IAccount)@grain).@SendPacketAuth((global::Shared.PacketOut)@arguments[0]).@Box();
                            case 12719627:
                                return ((global::Server.IAccount)@grain).@SendAccountDataTimes((global::System.UInt32)@arguments[0]).@Box();
                            case 2060811694:
                                return ((global::Server.IAccount)@grain).@UpdateAccountData((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1], (global::System.UInt32)@arguments[2], (global::System.Byte[])@arguments[3]).@Box();
                            case 833613103:
                                return ((global::Server.IAccount)@grain).@SendAccountData((global::System.UInt32)@arguments[0]).@Box();
                            case 1560354665:
                                return ((global::Server.IAccount)@grain).@SendCharEnum((global::System.Int32)@arguments[0]).@Box();
                            case -549773541:
                                return ((global::Server.IAccount)@grain).@CreatePlayer((global::Shared.CMSG_CHAR_CREATE)@arguments[0]).@Box();
                            case 1875409470:
                                return ((global::Server.IAccount)@grain).@PlayerLogin((global::Shared.CMSG_PLAYER_LOGIN)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -688083232 + ",methodId=" + @methodId);
                        }

                    case -1277021679:
                        switch (@methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -688083232;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.CMSG_PLAYER_LOGIN)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_CMSG_PLAYER_LOGINSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.CMSG_PLAYER_LOGIN).@GetField("GUID", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.CMSG_PLAYER_LOGIN input = ((global::Shared.CMSG_PLAYER_LOGIN)original);
            global::Shared.CMSG_PLAYER_LOGIN result = default (global::Shared.CMSG_PLAYER_LOGIN);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field0.@SetValue(boxedResult, (global::Shared.ObjectGUID)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.CMSG_PLAYER_LOGIN input = (global::Shared.CMSG_PLAYER_LOGIN)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.ObjectGUID));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.CMSG_PLAYER_LOGIN result = default (global::Shared.CMSG_PLAYER_LOGIN);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field0.@SetValue(boxedResult, (global::Shared.ObjectGUID)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.ObjectGUID), stream));
            return (global::Shared.CMSG_PLAYER_LOGIN)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.CMSG_PLAYER_LOGIN), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_CMSG_PLAYER_LOGINSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Server.ISession))]
    internal class OrleansCodeGenSessionReference : global::Orleans.Runtime.GrainReference, global::Server.ISession
    {
        protected @OrleansCodeGenSessionReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenSessionReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 130958639;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Server.ISession";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 130958639;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 130958639:
                    switch (@methodId)
                    {
                        case 715203915:
                            return "OnLogonChallenge";
                        case -174724446:
                            return "OnLogonProof";
                        case 105167316:
                            return "OnRealmList";
                        case 1161933625:
                            return "SetSessionType";
                        case 343949440:
                            return "GetSessionType";
                        case -1836674149:
                            return "Disconnect";
                        case 1465496855:
                            return "GetSessionKey";
                        case -1927915602:
                            return "GetSessionStream";
                        case 522799231:
                            return "HandleAuthSession";
                        case -963939677:
                            return "OnSocketDisconnect";
                        case -1036537128:
                            return "GetSessionKeyFromAuthAccount";
                        case 10551987:
                            return "SetRealmInfo";
                        case -200604686:
                            return "GetRealmID";
                        case 820464294:
                            return "SendPacket";
                        case 1136236795:
                            return "HandleReadyForAccountDataTimes";
                        case 857067198:
                            return "HandleUpdateAccountData";
                        case -1656015275:
                            return "HandleRequestAccountData";
                        case -1842798826:
                            return "HandleCharEnum";
                        case -2128356724:
                            return "HandleCharCreate";
                        case 321629405:
                            return "HandlePlayerLogin";
                        case 535312199:
                            return "HandleNameQuery";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 130958639 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @OnLogonChallenge(global::Shared.AuthLogonChallenge @challenge)
        {
            return base.@InvokeMethodAsync<global::System.Object>(715203915, new global::System.Object[]{@challenge});
        }

        public global::System.Threading.Tasks.Task @OnLogonProof(global::Shared.AuthLogonProof @proof)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-174724446, new global::System.Object[]{@proof});
        }

        public global::System.Threading.Tasks.Task @OnRealmList()
        {
            return base.@InvokeMethodAsync<global::System.Object>(105167316, null);
        }

        public global::System.Threading.Tasks.Task @SetSessionType(global::Shared.SessionType @type)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1161933625, new global::System.Object[]{@type});
        }

        public global::System.Threading.Tasks.Task<global::Shared.SessionType> @GetSessionType()
        {
            return base.@InvokeMethodAsync<global::Shared.SessionType>(343949440, null);
        }

        public global::System.Threading.Tasks.Task @Disconnect()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1836674149, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.BigInteger> @GetSessionKey()
        {
            return base.@InvokeMethodAsync<global::Shared.BigInteger>(1465496855, null);
        }

        public global::System.Threading.Tasks.Task<global::Shared.SessionStream> @GetSessionStream()
        {
            return base.@InvokeMethodAsync<global::Shared.SessionStream>(-1927915602, null);
        }

        public global::System.Threading.Tasks.Task @HandleAuthSession(global::Shared.CMSG_AUTH_SESSION @auth, global::System.UInt32 @ServerSeed)
        {
            return base.@InvokeMethodAsync<global::System.Object>(522799231, new global::System.Object[]{@auth, @ServerSeed});
        }

        public global::System.Threading.Tasks.Task @OnSocketDisconnect()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-963939677, null);
        }

        public global::System.Threading.Tasks.Task @GetSessionKeyFromAuthAccount(global::System.String @AccountName)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1036537128, new global::System.Object[]{@AccountName});
        }

        public global::System.Threading.Tasks.Task @SetRealmInfo(global::Shared.RealmSettings @settings)
        {
            return base.@InvokeMethodAsync<global::System.Object>(10551987, new global::System.Object[]{@settings});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetRealmID()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-200604686, null);
        }

        public global::System.Threading.Tasks.Task @SendPacket(global::Shared.PacketOut @p)
        {
            return base.@InvokeMethodAsync<global::System.Object>(820464294, new global::System.Object[]{@p});
        }

        public global::System.Threading.Tasks.Task @HandleReadyForAccountDataTimes()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1136236795, null);
        }

        public global::System.Threading.Tasks.Task @HandleUpdateAccountData(global::System.UInt32 @type, global::System.UInt32 @time, global::System.UInt32 @size, global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(857067198, new global::System.Object[]{@type, @time, @size, @data});
        }

        public global::System.Threading.Tasks.Task @HandleRequestAccountData(global::System.UInt32 @type)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1656015275, new global::System.Object[]{@type});
        }

        public global::System.Threading.Tasks.Task @HandleCharEnum()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1842798826, null);
        }

        public global::System.Threading.Tasks.Task @HandleCharCreate(global::Shared.CMSG_CHAR_CREATE @create)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2128356724, new global::System.Object[]{@create});
        }

        public global::System.Threading.Tasks.Task @HandlePlayerLogin(global::Shared.CMSG_PLAYER_LOGIN @pkt)
        {
            return base.@InvokeMethodAsync<global::System.Object>(321629405, new global::System.Object[]{@pkt});
        }

        public global::System.Threading.Tasks.Task @HandleNameQuery(global::Shared.CMSG_NAME_QUERY @pkt)
        {
            return base.@InvokeMethodAsync<global::System.Object>(535312199, new global::System.Object[]{@pkt});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Server.ISession", 130958639, typeof (global::Server.ISession)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenSessionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 130958639:
                        switch (@methodId)
                        {
                            case 715203915:
                                return ((global::Server.ISession)@grain).@OnLogonChallenge((global::Shared.AuthLogonChallenge)@arguments[0]).@Box();
                            case -174724446:
                                return ((global::Server.ISession)@grain).@OnLogonProof((global::Shared.AuthLogonProof)@arguments[0]).@Box();
                            case 105167316:
                                return ((global::Server.ISession)@grain).@OnRealmList().@Box();
                            case 1161933625:
                                return ((global::Server.ISession)@grain).@SetSessionType((global::Shared.SessionType)@arguments[0]).@Box();
                            case 343949440:
                                return ((global::Server.ISession)@grain).@GetSessionType().@Box();
                            case -1836674149:
                                return ((global::Server.ISession)@grain).@Disconnect().@Box();
                            case 1465496855:
                                return ((global::Server.ISession)@grain).@GetSessionKey().@Box();
                            case -1927915602:
                                return ((global::Server.ISession)@grain).@GetSessionStream().@Box();
                            case 522799231:
                                return ((global::Server.ISession)@grain).@HandleAuthSession((global::Shared.CMSG_AUTH_SESSION)@arguments[0], (global::System.UInt32)@arguments[1]).@Box();
                            case -963939677:
                                return ((global::Server.ISession)@grain).@OnSocketDisconnect().@Box();
                            case -1036537128:
                                return ((global::Server.ISession)@grain).@GetSessionKeyFromAuthAccount((global::System.String)@arguments[0]).@Box();
                            case 10551987:
                                return ((global::Server.ISession)@grain).@SetRealmInfo((global::Shared.RealmSettings)@arguments[0]).@Box();
                            case -200604686:
                                return ((global::Server.ISession)@grain).@GetRealmID().@Box();
                            case 820464294:
                                return ((global::Server.ISession)@grain).@SendPacket((global::Shared.PacketOut)@arguments[0]).@Box();
                            case 1136236795:
                                return ((global::Server.ISession)@grain).@HandleReadyForAccountDataTimes().@Box();
                            case 857067198:
                                return ((global::Server.ISession)@grain).@HandleUpdateAccountData((global::System.UInt32)@arguments[0], (global::System.UInt32)@arguments[1], (global::System.UInt32)@arguments[2], (global::System.Byte[])@arguments[3]).@Box();
                            case -1656015275:
                                return ((global::Server.ISession)@grain).@HandleRequestAccountData((global::System.UInt32)@arguments[0]).@Box();
                            case -1842798826:
                                return ((global::Server.ISession)@grain).@HandleCharEnum().@Box();
                            case -2128356724:
                                return ((global::Server.ISession)@grain).@HandleCharCreate((global::Shared.CMSG_CHAR_CREATE)@arguments[0]).@Box();
                            case 321629405:
                                return ((global::Server.ISession)@grain).@HandlePlayerLogin((global::Shared.CMSG_PLAYER_LOGIN)@arguments[0]).@Box();
                            case 535312199:
                                return ((global::Server.ISession)@grain).@HandleNameQuery((global::Shared.CMSG_NAME_QUERY)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 130958639 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 130958639;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.AuthLogonChallenge)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_AuthLogonChallengeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Shared.AuthLogonChallenge).@GetField("account", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Shared.AuthLogonChallenge).@GetField("category", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.AuthLogonChallenge).@GetField("client", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.AuthLogonChallenge).@GetField("client_build", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.AuthLogonChallenge).@GetField("client_major", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.AuthLogonChallenge).@GetField("client_minor", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.AuthLogonChallenge).@GetField("client_revision", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Shared.AuthLogonChallenge).@GetField("ipaddr", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Shared.AuthLogonChallenge).@GetField("locale", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Shared.AuthLogonChallenge).@GetField("os", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Shared.AuthLogonChallenge).@GetField("processor", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.AuthLogonChallenge input = ((global::Shared.AuthLogonChallenge)original);
            global::Shared.AuthLogonChallenge result = default (global::Shared.AuthLogonChallenge);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field10.@SetValue(boxedResult, field10.@GetValue(input));
            field8.@SetValue(boxedResult, field8.@GetValue(input));
            field0.@SetValue(boxedResult, field0.@GetValue(input));
            field4.@SetValue(boxedResult, field4.@GetValue(input));
            field1.@SetValue(boxedResult, field1.@GetValue(input));
            field2.@SetValue(boxedResult, field2.@GetValue(input));
            field3.@SetValue(boxedResult, field3.@GetValue(input));
            field9.@SetValue(boxedResult, (global::System.Net.IPAddress)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field9.@GetValue(input)));
            field7.@SetValue(boxedResult, field7.@GetValue(input));
            field6.@SetValue(boxedResult, field6.@GetValue(input));
            field5.@SetValue(boxedResult, field5.@GetValue(input));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.AuthLogonChallenge input = (global::Shared.AuthLogonChallenge)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field10.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field8.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.UInt16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field9.@GetValue(input), stream, typeof (global::System.Net.IPAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field7.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field6.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field5.@GetValue(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.AuthLogonChallenge result = default (global::Shared.AuthLogonChallenge);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field10.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field8.@SetValue(boxedResult, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field0.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field4.@SetValue(boxedResult, (global::System.UInt16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt16), stream));
            field1.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field2.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field3.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field9.@SetValue(boxedResult, (global::System.Net.IPAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.IPAddress), stream));
            field7.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field6.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field5.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Shared.AuthLogonChallenge)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.AuthLogonChallenge), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_AuthLogonChallengeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.AuthLogonProof)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_AuthLogonProofSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.AuthLogonProof).@GetField("A", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.AuthLogonProof).@GetField("M1", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.AuthLogonProof).@GetField("crchash", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.AuthLogonProof).@GetField("number_of_keys", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.AuthLogonProof).@GetField("unk", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.AuthLogonProof input = ((global::Shared.AuthLogonProof)original);
            global::Shared.AuthLogonProof result = default (global::Shared.AuthLogonProof);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field0.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            field1.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field1.@GetValue(input)));
            field2.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field2.@GetValue(input)));
            field3.@SetValue(boxedResult, field3.@GetValue(input));
            field4.@SetValue(boxedResult, field4.@GetValue(input));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.AuthLogonProof input = (global::Shared.AuthLogonProof)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.Byte));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Byte));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.AuthLogonProof result = default (global::Shared.AuthLogonProof);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field0.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field1.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field2.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field3.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            field4.@SetValue(boxedResult, (global::System.Byte)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte), stream));
            return (global::Shared.AuthLogonProof)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.AuthLogonProof), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_AuthLogonProofSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.BigInteger)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_BigIntegerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.BigInteger).@GetField("data", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.BigInteger).@GetField("dataLength", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.BigInteger).@GetField("info", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.BigInteger input = ((global::Shared.BigInteger)original);
            global::Shared.BigInteger result = new global::Shared.BigInteger();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, (global::System.UInt32[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            field1.@SetValue(result, field1.@GetValue(input));
            field2.@SetValue(result, (global::System.Runtime.Serialization.SerializationInfo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field2.@GetValue(input)));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.BigInteger input = (global::Shared.BigInteger)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::System.Runtime.Serialization.SerializationInfo));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.BigInteger result = new global::Shared.BigInteger();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::System.UInt32[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32[]), stream));
            field1.@SetValue(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            field2.@SetValue(result, (global::System.Runtime.Serialization.SerializationInfo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Runtime.Serialization.SerializationInfo), stream));
            return (global::Shared.BigInteger)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.BigInteger), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_BigIntegerSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.SessionStream)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_SessionStreamSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.SessionStream).@GetField("CommandStream", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.SessionStream).@GetField("PacketStream", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.SessionStream input = ((global::Shared.SessionStream)original);
            global::Shared.SessionStream result = new global::Shared.SessionStream();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field1.@SetValue(result, (global::Orleans.Streams.IAsyncStream<global::Shared.SocketCommand>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field1.@GetValue(input)));
            field0.@SetValue(result, (global::Orleans.Streams.IAsyncStream<global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.SessionStream input = (global::Shared.SessionStream)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::Orleans.Streams.IAsyncStream<global::Shared.SocketCommand>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Orleans.Streams.IAsyncStream<global::System.Byte[]>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.SessionStream result = new global::Shared.SessionStream();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field1.@SetValue(result, (global::Orleans.Streams.IAsyncStream<global::Shared.SocketCommand>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IAsyncStream<global::Shared.SocketCommand>), stream));
            field0.@SetValue(result, (global::Orleans.Streams.IAsyncStream<global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IAsyncStream<global::System.Byte[]>), stream));
            return (global::Shared.SessionStream)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.SessionStream), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_SessionStreamSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.SocketCommand)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_SocketCommandSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.SocketCommand).@GetField("_command", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.SocketCommand).@GetField("_extraData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.SocketCommand input = ((global::Shared.SocketCommand)original);
            global::Shared.SocketCommand result = (global::Shared.SocketCommand)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Shared.SocketCommand));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            field0.@SetValue(result, field0.@GetValue(input));
            field1.@SetValue(result, (global::System.Object[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field1.@GetValue(input)));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.SocketCommand input = (global::Shared.SocketCommand)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.SocketCommands));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.Object[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.SocketCommand result = (global::Shared.SocketCommand)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Shared.SocketCommand));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            field0.@SetValue(result, (global::Shared.SocketCommands)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.SocketCommands), stream));
            field1.@SetValue(result, (global::System.Object[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object[]), stream));
            return (global::Shared.SocketCommand)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.SocketCommand), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_SocketCommandSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.CMSG_AUTH_SESSION)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_CMSG_AUTH_SESSIONSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Shared.CMSG_AUTH_SESSION).@GetField("Account", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Shared.CMSG_AUTH_SESSION).@GetField("AddonData", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.CMSG_AUTH_SESSION).@GetField("Build", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Shared.CMSG_AUTH_SESSION).@GetField("Digest", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Shared.CMSG_AUTH_SESSION).@GetField("Seed", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.CMSG_AUTH_SESSION input = ((global::Shared.CMSG_AUTH_SESSION)original);
            global::Shared.CMSG_AUTH_SESSION result = default (global::Shared.CMSG_AUTH_SESSION);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field3.@SetValue(boxedResult, field3.@GetValue(input));
            field4.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field4.@GetValue(input)));
            field0.@SetValue(boxedResult, field0.@GetValue(input));
            field2.@SetValue(boxedResult, (global::Shared.BigInteger)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field2.@GetValue(input)));
            field1.@SetValue(boxedResult, field1.@GetValue(input));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.CMSG_AUTH_SESSION input = (global::Shared.CMSG_AUTH_SESSION)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field3.@GetValue(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field4.@GetValue(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field2.@GetValue(input), stream, typeof (global::Shared.BigInteger));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field1.@GetValue(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.CMSG_AUTH_SESSION result = default (global::Shared.CMSG_AUTH_SESSION);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field3.@SetValue(boxedResult, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            field4.@SetValue(boxedResult, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            field0.@SetValue(boxedResult, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            field2.@SetValue(boxedResult, (global::Shared.BigInteger)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.BigInteger), stream));
            field1.@SetValue(boxedResult, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Shared.CMSG_AUTH_SESSION)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.CMSG_AUTH_SESSION), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_CMSG_AUTH_SESSIONSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Shared.CMSG_NAME_QUERY)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenShared_CMSG_NAME_QUERYSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Shared.CMSG_NAME_QUERY).@GetField("guid", (System.@Reflection.@BindingFlags.@Public | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Instance));
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Shared.CMSG_NAME_QUERY input = ((global::Shared.CMSG_NAME_QUERY)original);
            global::Shared.CMSG_NAME_QUERY result = default (global::Shared.CMSG_NAME_QUERY);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, boxedResult);
            field0.@SetValue(boxedResult, (global::Shared.ObjectGUID)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(field0.@GetValue(input)));
            return boxedResult;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Shared.CMSG_NAME_QUERY input = (global::Shared.CMSG_NAME_QUERY)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(field0.@GetValue(input), stream, typeof (global::Shared.ObjectGUID));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Shared.CMSG_NAME_QUERY result = default (global::Shared.CMSG_NAME_QUERY);
            global::System.Object boxedResult = result;
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(boxedResult);
            field0.@SetValue(boxedResult, (global::Shared.ObjectGUID)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Shared.ObjectGUID), stream));
            return (global::Shared.CMSG_NAME_QUERY)boxedResult;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Shared.CMSG_NAME_QUERY), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenShared_CMSG_NAME_QUERYSerializer()
        {
            Register();
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
