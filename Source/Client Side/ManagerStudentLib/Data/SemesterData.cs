using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class SemesterData
    {
        public static List<SemesterInfo> GetListSemester()
        {
            string url = DataHelper.DATA_SOURCE + "/Semester";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<SemesterInfo>>(responseData.JsonData);
            }
            return new List<SemesterInfo>();
        }
    }
}
