using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Common.External_Lib
{
    public static class GenerateBadgeId
    {
        public static string Generate(RoleLevel role, int value)
        {
            string result = "";
            switch(role)
            {
                case RoleLevel.Education_Staff:
                    result = "E";
                    break;
                case RoleLevel.Principal:
                    result = "P";
                    break;
                case RoleLevel.Student:
                    result = "S";
                    break;
                case RoleLevel.Teacher:
                    result = "T";
                    break;
            }
            result += DateTime.Now.Year.ToString().Substring(DateTime.Now.ToString().Length - 2);
            string temp = DateTime.Now.Month.ToString();
            if(temp.Length < 2)
            {
                temp = "0" + temp;
            }
            result += temp;
            temp = Convert.ToString(value);
            while (temp.Length <3)
            {
                temp = "0" + temp;
            }
            result += temp;
            return result;
        }
        public static int DeGenerate(string id)
        {
            return Convert.ToInt32(id.Substring(5));
        }
    }
}
