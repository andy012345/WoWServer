using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain orleansHostDomain = null;

            if (System.IO.File.Exists("Config-Server.xml"))
            {
                Console.WriteLine("Starting orleans server...");

                orleansHostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
                {
                    AppDomainInitializer = InitSilo,
                    AppDomainInitializerArguments = args,
                });
            }

            if (System.IO.File.Exists("Config-Client.xml"))
            {
                Console.WriteLine("Starting orleans client...");
                Orleans.GrainClient.Initialize("Config-Client.xml");

                if (!Orleans.GrainClient.IsInitialized)
                    throw new Exception("Could not initialise orleans client");

                var factory = Orleans.GrainClient.GrainFactory;


                //woo test code
                IAccount test = factory.GetGrain<IAccount>("TESTACCOUNT");
                test.CreateAccount("test").Wait();
                test.SetPassword("Test");
                test = factory.GetGrain<IAccount>("TEST");
                test.CreateAccount("test").Wait();
                test.SetPassword("Test");
            }

            WebService.Run();
            AuthServer.Main.Run();
            RealmServer.Main.Run();

            Console.ReadLine();


            WebService.Stop();
            AuthServer.Main.Stop();
            RealmServer.Main.Stop();

            if (Orleans.GrainClient.IsInitialized)
                Orleans.GrainClient.Uninitialize();

            if (orleansHostDomain != null)
                orleansHostDomain.DoCallBack(ShutdownSilo);
        }

        static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Stop();
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
