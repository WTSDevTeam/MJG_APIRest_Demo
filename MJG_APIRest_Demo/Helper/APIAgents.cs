using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Data;
using RestSharp;

namespace MJG_APIRest_Demo.Helper
{
    public class APIAgents
    {

        public static HttpStatusCode HttpPost(string inUrl, Dictionary<string, string> inValue, ref string ioContent)
        {
            ioContent = "";
            var client = new RestClient(inUrl);
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("cache-control", "no-cache");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(inValue); // uses JsonSerializer
            var response = client.Execute(request);
            ioContent = response.Content;
            return response.StatusCode;
        }
        public static HttpStatusCode HttpGet(string inUrl, ref string ioContent)
        {
            ioContent = "";
            var client = new RestClient(inUrl);
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("cache-control", "no-cache");
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            ioContent = response.Content;
            return response.StatusCode;
        }

    }
}
