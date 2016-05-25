using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public enum UserRole
    {
        ADMINSTRATOR = 5,
        EDUCATION_STAFF = 4,
        PRINCIPAL = 3,
        TEACHER = 2,
        STUDENT = 1
    }

    public class RoleInfo
    {
        public string Id { get; set; }
        [JsonProperty("Level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserRole Level { get; set; }
        public string Name { get; set; }
    }
}
