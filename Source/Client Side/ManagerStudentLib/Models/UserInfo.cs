using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class UserInfo
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [JsonProperty("Gender")]
        public Boolean Male { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
