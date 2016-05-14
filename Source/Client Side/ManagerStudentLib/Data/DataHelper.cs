using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Properties;
using ManagerStudentLib.Models;
using Newtonsoft.Json;
namespace ManagerStudentLib.Data
{
    public class DataHelper
    {
        public static string DATA_SOURCE = "http://" + Settings.Default.HOST + "/" + Settings.Default.DOMAIN;

        public static void SetDataSource(string host, string domain)
        {
            DATA_SOURCE = "http://" + host + "/" + domain;
            Settings.Default.HOST = host;
            Settings.Default.DOMAIN = domain;
            Settings.Default.Save();
        }

        public static string GetHost() 
        {
            return Settings.Default.HOST;
        }

        public static string GetDomain()
        {
            return Settings.Default.DOMAIN;
        }

        public static string GetJsonData(string url)
        {
            return GetJsonData(url, null);
        }

        public static ResponseData PostJsonData(string url, string jsonRequestData)
        {
            return GetResponse(url, HttpMethod.Post, jsonRequestData);
        }

        public static ResponseData PutJsonData(string url, string jsonRequestData)
        {
            return GetResponse(url, HttpMethod.Put, jsonRequestData);
        }
        
        public static string GetJsonData(string url, string jsonRequestData)
        {
            string jsonResponseData = null;
            ResponseData reponse = GetResponse(url, HttpMethod.Get, jsonRequestData);
            if (reponse.Status == 200) {
                jsonResponseData = reponse.JsonData;
            }
            else
            {
                throw new DataGetException(reponse.Status.ToString(), reponse.Message);
            }
         
            return jsonResponseData;
        }

        public static ResponseData GetResponse(string url, HttpMethod method, string jsonRequestData) {
            Task<HttpResponseMessage> httpResponse = null;
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage() {
                    RequestUri = new Uri(url),
                    Method = method
                };
                request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
                if (jsonRequestData != null) 
                {
                    request.Content = new StringContent(jsonRequestData, Encoding.Unicode, "aplication/json");
                }
                httpResponse = httpClient.SendAsync(request);
            }
            var status = httpResponse.Result.StatusCode;
            if (status == System.Net.HttpStatusCode.OK)
            { // OK
                return JsonConvert.DeserializeObject<ResponseData>(httpResponse.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new DataGetException(status.ToString(), httpResponse.Exception.Message);
            }
        }
    }
}
