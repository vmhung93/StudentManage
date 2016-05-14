using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Exceptions
{
    public class AuthenticationException : Exception
    {
        public DataGetException DataGetException { get; set; }
        public AuthenticationException(DataGetException ex)
        {
            DataGetException = ex;
        }
    }
}
