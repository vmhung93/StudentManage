using AutoMapper;
using StudentManage.Domain.Domain;
using StudentManage.Services.AppicationContract;

namespace StudentManage.Services.Services
{
    public class BaseService
    {
        public BaseService()
        {
            // Register auto mapper

            // Class
            Mapper.CreateMap<Class, ClassDto>();
            Mapper.CreateMap<ClassDto, Class>();

            // Courses
            Mapper.CreateMap<Courses, CoursesDto>();
            Mapper.CreateMap<CoursesDto, Courses>();

            // Grade
            Mapper.CreateMap<Grade, GradeDto>();
            Mapper.CreateMap<GradeDto, Grade>();

            // PositionInClass
            Mapper.CreateMap<PositionInClass, PositionInClassDto>();
            Mapper.CreateMap<PositionInClassDto, PositionInClass>();

            // Role
            Mapper.CreateMap<Role, RoleDto>();
            Mapper.CreateMap<RoleDto, Role>();

            // Scores
            Mapper.CreateMap<Scores, ScoresDto>();
            Mapper.CreateMap<ScoresDto, Scores>();

            // ScoreType
            Mapper.CreateMap<ScoreType, ScoreTypeDto>();
            Mapper.CreateMap<ScoreTypeDto, ScoreType>();

            // Semester
            Mapper.CreateMap<Semester, SemesterDto>();
            Mapper.CreateMap<SemesterDto, Semester>();

            // StudentInClass
            Mapper.CreateMap<StudentInClass, StudentInClassDto>();
            Mapper.CreateMap<StudentInClassDto, StudentInClass>();

            // SystemConfig
            Mapper.CreateMap<SystemConfig, SystemConfigDto>();
            Mapper.CreateMap<SystemConfigDto, SystemConfig>();

            // User
            Mapper.CreateMap<UserDto, User>();
            Mapper.CreateMap<User, UserDto>();

            // UserInfo
            Mapper.CreateMap<UserInfoDto, UserInfo>();
            Mapper.CreateMap<UserInfo, UserInfoDto>();
        }
    }
}