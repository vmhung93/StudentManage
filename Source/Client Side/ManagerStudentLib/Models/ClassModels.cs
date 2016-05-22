using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{

    public class PreLoadAddClassInfo
    {
        public List<User> HomeroomTeacherdes { get; set; }
        public List<User> Students { get; set; }
        public List<Grade> grades { get; set; }
    }

    public class ClassInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GradeId { get; set; }
        public Grade Grade { get; set; }
        public string HomeroomTeacherId { get; set; }
        public User HomeroomTeacher { get; set; }
        public string CreatedBy { get; set; }
    }

    public class Grade {
        public string Id {get;set;}
        public string Name {get;set;}
    }

    public class ClassInfoWithStudentIds
    {
        public ClassInfo Class { get; set; }
        public List<string> StudentIds { get; set; }
        
    }
    public class ClassInfoWithStudents
    {
        public ClassInfo Class { get; set; }
        public List<User> Students { get; set; }

    }

    public class UpdateClassInfoWithStudentIds
    {
        public ClassInfo Class { get; set; }
        public List<string> AddStudentIds { get; set; }
        public List<string> SubstractStudentIds { get; set; }
    }
}
