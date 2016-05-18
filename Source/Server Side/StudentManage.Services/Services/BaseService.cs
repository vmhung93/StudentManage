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

            // User
            Mapper.CreateMap<UserDto, User>();
            Mapper.CreateMap<User, UserDto>();

            // UserInfo
            Mapper.CreateMap<UserInfoDto, UserInfo>();
            Mapper.CreateMap<UserInfo, UserInfoDto>();

            // Role
            Mapper.CreateMap<Role, RoleDto>();
            Mapper.CreateMap<RoleDto, Role>();

            // Grade
            Mapper.CreateMap<Grade, GradeDto>();
            Mapper.CreateMap<GradeDto, Grade>();
        }
    }
}