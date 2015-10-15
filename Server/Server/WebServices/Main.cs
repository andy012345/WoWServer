using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.IO;
using Orleans;
using Orleans.Runtime;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.ServiceModel.Channels;

namespace Server
{
    internal class WebService
    {
        public object Json { get; private set; }

        public static bool Running = false;
        public static List<WebServiceHost> hosts = new List<WebServiceHost>();
        public static List<ServiceEndpoint> endpoints = new List<ServiceEndpoint>();

        public static void Run()
        {
            //return;
            if (System.IO.File.Exists("Config-Web.xml"))
            {
                if (!System.IO.File.Exists("Config-Client.xml"))
                    throw new InvalidOperationException("WebService cannot start without client support");

                WebServiceHost host;
                ServiceEndpoint endpoint;

                //start web server :)
                host = new WebServiceHost(typeof (Service), new Uri("http://localhost.com:9000/"));
                    //todo: move to config
                endpoint = host.AddServiceEndpoint(typeof (IService), new WebHttpBinding(), "service");
                host.Open();
                hosts.Add(host);
                endpoints.Add(endpoint);

                host = new WebServiceHost(typeof (AccountService), new Uri("http://localhost.com:9000/"));
                    //todo: move to config
                endpoint = host.AddServiceEndpoint(typeof (IAccountService), new WebHttpBinding(), "account");
                host.Open();
                hosts.Add(host);
                endpoints.Add(endpoint);

                Running = true;
            }
        }

        public static void Stop()
        {
            if (!Running)
                return;

            foreach (var h in hosts)
                h.Close();
            hosts.Clear();
            endpoints.Clear();

            Running = false;
        }

        public static HttpResponseMessage ToJSON(object responseModel)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            JavaScriptSerializer s = new JavaScriptSerializer();

            string jsonClient = s.Serialize(responseModel);
            byte[] resultBytes = Encoding.UTF8.GetBytes(jsonClient);
            response.Content = new StreamContent(new MemoryStream(resultBytes));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

            return response;
        }

        public static Message JSONMessage(object response)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();

            string jsonClient = s.Serialize(response);

            return WebOperationContext.Current.CreateTextResponse(jsonClient, "text/plain", Encoding.UTF8);
        }
    }
}