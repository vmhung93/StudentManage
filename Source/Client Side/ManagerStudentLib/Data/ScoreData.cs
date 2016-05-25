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
        
        public static string UpdateScores(UpdateStudentWithScore updateInfo) {
            string url = DataHelper.DATA_SOURCE + "/Scores/UpdateWithCreateScore";
            string jsonData = JsonConvert.SerializeObject(updateInfo);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            return responseData.Message;
        }

        public static List<ScoreType> GetScoreTypes()
        {
            var url = DataHelper.DATA_SOURCE + "/ScoreType";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<ScoreType>>(responseData.JsonData);
            }
            return new List<ScoreType>();
        }

        public static List<StudentClassCourseScore> GetStudentClassCourseScore(string studentName)
        {
            var url = DataHelper.DATA_SOURCE + "/Scores/GetStudentCourseScore";
            string jsonData = JsonConvert.SerializeObject(new { Name = studentName });
            ResponseData responseData = DataHelper.Post(url, jsonData);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<StudentClassCourseScore>>(responseData.JsonData);
            }
            return new List<StudentClassCourseScore>();
        }
    }
}
