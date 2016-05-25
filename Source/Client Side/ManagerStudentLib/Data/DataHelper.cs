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
using System.Net;
using System.IO;
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

        public static ResponseData Post(string url, string jsonRequestData)
        {
            return GetResponse(url, HttpMethod.Post, jsonRequestData);
        }

        public static ResponseData Put(string url, string jsonRequestData)
        {
            return GetResponse(url, HttpMethod.Put, jsonRequestData);
        }

        public static ResponseData Get(string url, string jsonRequestData)
        {
            return GetResponse(url, HttpMethod.Get, jsonRequestData);
        }

        public static ResponseData Get(string url)
        {
            return GetResponse(url, HttpMethod.Get, null);
        }

        public static ResponseData GetResponse(string url, HttpMethod method, string jsonRequestData)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.ContentType = "application/json";
                if(ManagerStudentLib.Authentication.AuthenticationService.GetInstance().GetCurrentUser() != null)
                {
                    request.Headers.Add("Token", ManagerStudentLib.Authentication.AuthenticationService.GetInstance().GetCurrentUser().Token);
                }
                request.Method = method.Method;

                if (jsonRequestData != null)
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream(), Encoding.UTF8))
                    {
                        streamWriter.Write(jsonRequestData);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
                request.Timeout = 100000;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {

                    var status = response.StatusCode;
                    if (status == System.Net.HttpStatusCode.OK)
                    { // OK
                        using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                        {
                            String responseString = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<ResponseData>(responseString);
                        }
                    }
                    else
                    {
                        throw new DataGetException(status.ToString(), response.StatusDescription);
                    }

                }
            }
            catch (Exception e)
            {
                throw new DataGetException(e.Message);

            }

        }
    }
}
