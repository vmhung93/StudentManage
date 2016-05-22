using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class User
    {
        public int UserCode { get; set; }
        public string UserName { get; set; }
        public UserInfo UserInfo { get; set; }
        public string Id { get; set; }
    }
}
