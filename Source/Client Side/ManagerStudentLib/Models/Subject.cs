using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class Subject
    {
        public string Name { get; set; }
    }

    public class SubjectInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class SummarySubject
    {
        public ClassInfo Class;
        public List<StudentWithScore> StudentScore;
    }

    public class GetSummarySubject
    {
        public string CourseId;
        public string SemesterId;
    }
}
