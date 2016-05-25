using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Common.External_Lib
{
    public class DisplayAttribute : Attribute
    {
        private string displayName;

        public DisplayAttribute(string displayName)
        {
            this.displayName = displayName;
        }

        public string DisplayName
        {
            get { return this.displayName; }
        }
    }

    public static class EnumDescriptionExtensions
    {
        public static string GetDisplayName(this Enum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());

            DisplayAttribute[] attributes = (DisplayAttribute[])fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false);

            if (attributes.Length > 0)
            {
                return attributes[0].DisplayName;
            }

            return String.Empty;
        }

        public static string GetDescription(this Enum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return @enum.ToString();
        }
    }
}