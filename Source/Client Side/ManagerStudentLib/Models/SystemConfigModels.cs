using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public enum SystemConfigEnum
    {
        MinAge, 
        MaxAge,
        MaxNumberInClass,
        PassScore
    }

    public class SystemConfig
    {
        public string Id { get; set; }
        [JsonProperty("Name")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SystemConfigEnum Name { get; set; }
        public string Value { get; set; }
    }
}
