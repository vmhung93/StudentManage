using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Exceptions
{
    public class DataGetException : Exception
    {
        public string Status { get; set; }
        public string DataGetMessage { get; set; }
        public DataGetException()
        {

        }
        public DataGetException(string status, string message)
        {
            this.Status = status;
            this.DataGetMessage = message;
        }
    }
}
