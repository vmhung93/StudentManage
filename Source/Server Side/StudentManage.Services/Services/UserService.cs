using AutoMapper;
using StudentManage.Domain.DbContext;
using StudentManage.Domain.Domain;
using StudentManage.Services.AppicationContract;
using System;
using System.Linq;

namespace StudentManage.Services.Services
{
    public interface IUserService
    {
        UserDto Login(string userName, string password);

        bool Create(UserDto userDto);

        bool UpdateUserInfo(UserDto userDto);

        bool Delete(Guid userId);
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
                // Using Mapper to map from user dto to user entity
                var userEntity = Mapper.Map<User>(userDto);

                // Generate user access token
                userEntity.AccessToken = Guid.NewGuid();
                userEntity.CreatedDate = DateTime.Now;
                userEntity.ModifiedDate = DateTime.Now;
                userEntity.Status = Common.Status.Active;

                // Add user to dbContext
                dbContext.Users.Add(userEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
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

        public UserDto Login(string userName, string password)
        {
            StudentManageDbContext dbcontext = new StudentManageDbContext();

            //var result = dbcontext.Users.ToList();
            return new UserDto();
        }

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