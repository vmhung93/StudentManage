using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class ScoreData
    {
        public static List<StudentWithScore> GetStudentWithScores(LoadScoreInfo loadScoreInfo)
        {
            var url = DataHelper.DATA_SOURCE + "/Scores/GetScoreByClassCourseSemester";
            var jsonData = JsonConvert.SerializeObject(loadScoreInfo);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<StudentWithScore>>(responseData.JsonData);
            }
            return new List<StudentWithScore>();
        }
    }
}
