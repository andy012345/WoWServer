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


namespace Server
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string TestGet(string s);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json)]
        string TestPost(string s);

    }

    public class Service : IService
    {
        public string TestGet(string s)
        {
            return "Hi";
        }

        public string TestPost(string s)
        {
            return "Hi2";
        }

    }
}