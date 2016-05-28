using AutoMapper;
using StudentManage.Common;
using StudentManage.Domain.Domain;
using StudentManage.Services.AppicationContract;
using System;

namespace StudentManage.Services.Services
{
    public class BaseService
    {
        public BaseService()
        {
            // Register auto mapper
            Mapper.Initialize(cfg =>
            {
                // Class
                cfg.CreateMap<Class, ClassDto>();
                cfg.CreateMap<ClassDto, Class>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Courses
                cfg.CreateMap<Courses, CoursesDto>();
                cfg.CreateMap<CoursesDto, Courses>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Grade
                cfg.CreateMap<Grade, GradeDto>();
                cfg.CreateMap<GradeDto, Grade>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Position in class
                cfg.CreateMap<PositionInClass, PositionInClassDto>();
                cfg.CreateMap<PositionInClassDto, PositionInClass>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Role
                cfg.CreateMap<Role, RoleDto>();
                cfg.CreateMap<RoleDto, Role>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Score
                cfg.CreateMap<Scores, ScoresDto>();
                cfg.CreateMap<ScoresDto, Scores>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Score type
                cfg.CreateMap<ScoreType, ScoreTypeDto>();
                cfg.CreateMap<ScoreTypeDto, ScoreType>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Semester
                cfg.CreateMap<Semester, SemesterDto>();
                cfg.CreateMap<SemesterDto, Semester>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // Student in class
                cfg.CreateMap<StudentInClass, StudentInClassDto>();
                cfg.CreateMap<StudentInClassDto, StudentInClass>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // System configuration
                cfg.CreateMap<SystemConfig, SystemConfigDto>();
                cfg.CreateMap<SystemConfigDto, SystemConfig>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // User
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserDto, User>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

                // User info
                cfg.CreateMap<UserInfo, UserInfoDto>();
                cfg.CreateMap<UserInfoDto, UserInfo>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => GetCurrentUserId().Value))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));
            });
        }

        private Guid? GetCurrentUserId()
        {
            var currentUser = (UserDto)CacheManage.Get("current_user");

            if (currentUser != null)
            {
                return currentUser.Id;
            }

            return null;
        }
    }
}