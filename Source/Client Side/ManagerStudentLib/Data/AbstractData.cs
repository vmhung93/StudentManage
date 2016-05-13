using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ManagerStudentApp.Exceptions;
namespace ManagerStudentLib.Data
{
    public abstract class AbstractData
    {
        protected static string GetJsonData(string url)
        {
            var jsonData = "{ }";
            Task<HttpResponseMessage> http = null;
            using (var httpClient = new HttpClient())
            {
                http = httpClient.GetAsync(url);
            }
            var status = http.Result.StatusCode;
            if (status == System.Net.HttpStatusCode.OK)
            { // OK
                jsonData = http.Result.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw (new DataGetException(System.Net.HttpStatusCode.OK.ToString()));
            }
            return jsonData;
        }
    }
}
