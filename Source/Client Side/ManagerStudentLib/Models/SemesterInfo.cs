using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class SemesterInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CourseScore
    {
        public Course Course { get; set; }
        public List<ScoreInfo> Scores { get; set; }
    }

    public class StudentCourse
    {
        public User Student { get; set; }
        public List<CourseScore> CourseScores { get; set; }
    }

    public class SummarySemester
    {
        public ClassInfo Class { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
