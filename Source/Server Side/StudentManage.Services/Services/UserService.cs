using AutoMapper;
using StudentManage.Common;
using StudentManage.Common.External_Lib;
using StudentManage.Domain.DbContext;
using StudentManage.Domain.Domain;
using StudentManage.Services.AppicationContract;
using System;
using System.Linq;

namespace StudentManage.Services.Services
{
    public interface IUserService
    {
        bool Create(UserDto userDto);

        bool CheckTokenIsValid(Guid token);

        bool Delete(Guid userId);

        UserDto GetUserByToken(Guid token);

        UserDto Login(string userName, string password);

        bool UpdateUserInfo(UserDto userDto);
    }

    public class UserService : BaseService, IUserService
    {
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public bool Create(UserDto userDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get user role
                var currentUserRole = dbContext.Role.FirstOrDefault(r => r.Id == userDto.RoleId);
                if (currentUserRole == null)
                {
                    return false;
                }

                // Using Mapper to map from user dto to user entity
                var userEntity = Mapper.Map<User>(userDto);

                // Generate user access token
                userEntity.AccessToken = Guid.NewGuid();
                userEntity.ExpiredToken = DateTime.Now.AddDays(AppSettings.AccessTokenExpireTime);

                userEntity.CreatedDate = DateTime.Now;
                userEntity.ModifiedDate = DateTime.Now;

                // Add user to dbContext
                dbContext.Users.Add(userEntity);
                dbContext.SaveChanges();

                // Generate badge id
                userEntity.BadgeId = GenerateBadgeId.Generate(currentUserRole.Level, userEntity.UserCode);

                // Hash password
                userEntity.Password = Security.HashPassword(userEntity.BadgeId, userEntity.Password);

                // Update user name is badge id
                userEntity.UserName = userEntity.BadgeId;

                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Check token is valid or not
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool CheckTokenIsValid(Guid token)
        {
            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Check token is valid
                bool isValid = dbContext.Users.Any(u => u.AccessToken == token && DateTime.Now.CompareTo(u.ExpiredToken) <= 0);

                return isValid;
            }
        }

        /// <summary>
        /// Update user status is deleted
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Delete(Guid userId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get user by id
                var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);

                if (user == null)
                {
                    return false;
                }

                // Update user status is deleted
                user.Status = Common.Status.Deleted;
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        public UserDto GetUserByToken(Guid token)
        {
            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                var user = dbContext.Users.FirstOrDefault(u => u.AccessToken == token && DateTime.Now.CompareTo(u.ExpiredToken) <= 0);

                if (user == null)
                {
                    return null;
                }

                var userDto = Mapper.Map<UserDto>(user);
                return userDto;
            }
        }

        public UserDto Login(string userName, string password)
        {
            StudentManageDbContext dbcontext = new StudentManageDbContext();

            //var result = dbcontext.Users.ToList();
            return new UserDto();
        }

        /// <summary>
        /// Update user info
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(UserDto userDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get user by id
                var user = dbContext.Users.FirstOrDefault(u => u.Id == userDto.Id);

                if (user == null)
                {
                    return false;
                }

                // Update user info
                user.UserInfo.Name = userDto.UserInfo.Name;
                user.UserInfo.Adress = userDto.UserInfo.Adress;
                user.UserInfo.DateOfBirth = userDto.UserInfo.DateOfBirth;
                user.UserInfo.Email = userDto.UserInfo.Email;
                user.UserInfo.Gender = userDto.UserInfo.Gender;

                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }
    }
}