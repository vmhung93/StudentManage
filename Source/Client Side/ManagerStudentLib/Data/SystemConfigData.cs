using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class SystemConfigData
    {
        public static List<SystemConfig> GetAllSystemConfigs()
        {
            string url = DataHelper.DATA_SOURCE + "/SystemConfig";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<SystemConfig>>(responseData.JsonData);
            }
            return new List<SystemConfig>();
        }

        public static string UpdateSystemConfigs(List<SystemConfig> configs) 
        {
            string url = DataHelper.DATA_SOURCE + "/SystemConfig/UpdateAll";
            string jsonData = JsonConvert.SerializeObject(configs);
            ResponseData response = DataHelper.Post(url, jsonData);
            return response.Message;
        }

        public static string InitData()
        {
            string url = DataHelper.DATA_SOURCE + "/InitiateDatabase";
            ResponseData response = DataHelper.Get(url);
            return JsonConvert.SerializeObject(response.JsonData);
        }
    }
}
