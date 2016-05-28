using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class SubjectData
    {
        public static string AddSubject(CreateSubject subject)
        {
            string url = DataHelper.DATA_SOURCE + "/Courses";
            string jsonData = JsonConvert.SerializeObject(subject);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            return responseData.Message;
        }

        public static string UpdateSubject(SubjectInfo subject)
        {
            string url = DataHelper.DATA_SOURCE + "/Courses";
            string jsonData = JsonConvert.SerializeObject(subject);
            ResponseData responseData = DataHelper.Put(url, jsonData);
            return responseData.Message;
        }

        public static string DeleteSubject(SubjectInfo subject)
        {
            string url = DataHelper.DATA_SOURCE + "/DeleteCourses";
            string jsonData = JsonConvert.SerializeObject(subject);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            return responseData.Message;
        }

        public static List<SubjectInfo> GetListSubject()
        {
            string url = DataHelper.DATA_SOURCE + "/Courses";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<SubjectInfo>>(responseData.JsonData);
            }
            return new List<SubjectInfo>();
        }

        public static List<SummarySubject> GetSummarySubject(GetSummarySubject summary)
        {
            string url = DataHelper.DATA_SOURCE + "/Courses/SummaryCourse";
            string jsonData = JsonConvert.SerializeObject(summary);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<SummarySubject>>(responseData.JsonData);
            }
            return new List<SummarySubject>();
        }
    }

}
