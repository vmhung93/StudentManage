using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class ScoreInfo
    {
        public string Id { get; set; }

        public string StudentId { get; set; }

        public string CourseId { get; set; }

        public string ScoreTypeId { get; set; }

        public ScoreType ScoreType { get; set; }

        public string SemesterId { get; set; }

        public decimal Score { get; set; }
    }

    public class AddScoreInfo
    {
        public string StudentId { get; set; }

        public string CourseId { get; set; }

        public string ScoreTypeId { get; set; }

        public ScoreType ScoreType { get; set; }

        public string SemesterId { get; set; }

        public decimal Score { get; set; }
    }

    public class ScoreType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Coefficient { get; set; }
    }

    public class StudentWithScore
    {
        public User Student { get; set; }
        public List<ScoreInfo> ListScore { get; set; }
    }

    public class UpdateStudentWithScore
    {
        public List<AddScoreInfo> ScoresAdd;
        public List<ScoreInfo> ScoresUpdate;
        public List<string> ScoresDelete;
    }

    public class LoadScoreInfo
    {
        public string ClassId { get; set; }
        public string CourseId { get; set; }
        public string SemesterId { get; set; }
    }

    public class SemesterCourse
    {
        public SemesterInfo Semester { get; set; }
        public List<CourseScore> CourseScores { get; set; }
    }

    public class StudentClassCourseScore
    {
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public List<SemesterCourse> SemesterCourses { get; set; }
    }
}
