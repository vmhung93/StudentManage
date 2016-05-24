using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class GradeData
    {
        public static List<GradeInfo> GetListGrade()
        {
            string url = DataHelper.DATA_SOURCE + "/Grade";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<GradeInfo>>(responseData.JsonData);
            }
            return new List<GradeInfo>();
        }
    }
}
