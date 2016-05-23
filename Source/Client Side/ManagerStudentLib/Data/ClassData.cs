using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class ClassData
    {
        public static string SUB_DOMAIN = "Class";
        public static PreLoadAddClassInfo GetInfoForAddClass()
        {
            string url = DataHelper.DATA_SOURCE + "/" + SUB_DOMAIN + "/GetInfoForCreateClass";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<PreLoadAddClassInfo>(responseData.JsonData);
            }
            return new PreLoadAddClassInfo();
        }

        public static string AddClass(ClassInfoWithStudentIds classInfo)
        {
            string url = DataHelper.DATA_SOURCE + "/StudentInClass/CreateClassWithStudent";
            string jsonData = JsonConvert.SerializeObject(classInfo);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            return responseData.Message;
        }

        public static string UpdateClass(UpdateClassInfoWithStudentIds classInfo)
        {
            string url = DataHelper.DATA_SOURCE + "/StudentInClass/UpdateClassWithStudents";
            string jsonData = JsonConvert.SerializeObject(classInfo);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            return responseData.Message;
        }

        public static List<ClassInfo> GetListClasses()
        {
            string url = DataHelper.DATA_SOURCE + "/" + SUB_DOMAIN;
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<ClassInfo>>(responseData.JsonData);
            }
            return new List<ClassInfo>();
        }

        public static ClassInfoWithStudents GetInfoClassWithStudents(string classId)
        {
            string url = DataHelper.DATA_SOURCE + "/StudentInClass/GetClassStudentInfo/" + classId;
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<ClassInfoWithStudents>(responseData.JsonData);
            }
            return null;
        }
    }
}
