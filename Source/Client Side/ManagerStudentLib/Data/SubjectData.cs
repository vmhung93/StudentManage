using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class SubjectData : AbstractData
    {
        public static Diem GetDiem()
        {
            var stringJson = "{\"Danh sach\":[{\"Ten mon hoc\":\"ly\",\"Diem so\":9},{\"Ten mon hoc\":\"toan\",\"Diem so\":10}]}";
            var diem = JsonConvert.DeserializeObject<Diem>(stringJson);
            return diem;
        }
    }

    public class Diem {
        public MonHoc[] danhsach {get;set;}
    }
    public class MonHoc {
        public string TenMonHoc;
        public int diem;
    }
}
