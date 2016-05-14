using ManagerStudentLib.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class User
    {
        public string FullName { get; set; }
        [JsonProperty("Role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserRole Role { get; set; }
        public string Token { get; set; }
    }
}
