using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Exceptions
{
    public class AuthenticationException : DataGetException
    {
        public DataGetException DataGetEx { get; set; }
        public AuthenticationException(DataGetException ex)
        {
            DataGetEx = ex;
        }
    }
}
