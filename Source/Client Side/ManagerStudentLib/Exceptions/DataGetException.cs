using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Exceptions
{
    public class DataGetException : Exception
    {
        protected string status { get; set; }

        public DataGetException()
        {

        }
        public DataGetException(string status)
        {
            this.status = status;
        }
    }
}
