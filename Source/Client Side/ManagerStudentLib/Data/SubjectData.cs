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
        public static Diem GetDiem()
        {
            var stringJson = "{\"Danh sach\":[{\"Ten mon hoc\":\"ly\",\"Diem so\":9},{\"Ten mon hoc\":\"toan\",\"Diem so\":10}]}";
            var diem = JsonConvert.DeserializeObject<Diem>(stringJson);
            return diem;
        }

        public static string AddSubject(Subject subject)
        {
            string url = DataHelper.DATA_SOURCE + "/Courses";
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
    }

    public class Diem {
        public MonHoc[] danhsach {get;set;}
    }
    public class MonHoc {
        public string TenMonHoc;
        public int diem;
    }

}
