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
            StringBuilder result = new StringBuilder();

            // First character define user role
            switch (role)
            {
                case RoleLevel.Education_Staff:
                    result.Append("E");
                    break;

                case RoleLevel.Principal:
                    result.Append("P");
                    break;

                case RoleLevel.Student:
                    result.Append("S");
                    break;

                case RoleLevel.Teacher:
                    result.Append("T");
                    break;
            }

            // Year
            result.Append(DateTime.Now.Year.ToString().Substring(DateTime.Now.Year.ToString().Length - 2));

            // Month
            string month = DateTime.Now.Month.ToString("00");
            result.Append(month);

            // User code
            string userCode = value.ToString("000");
            result.Append(userCode);

            return result.ToString();
        }

        public static int DeGenerate(string id)
        {
            return Convert.ToInt32(id.Substring(5));
        }
    }
}