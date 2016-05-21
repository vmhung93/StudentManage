using AutoMapper;
using StudentManage.Domain.DbContext;
using StudentManage.Domain.Domain;
using StudentManage.Services.AppicationContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Services.Services
{
    public interface IUserInfoService
    {
        UserInfoDto GetById(Guid userInfoId);

        List<UserInfoDto> GetAll();

        bool Create(UserInfoDto userInfoDto);

        bool Update(UserInfoDto userInfoDto);

        bool Delete(Guid userInfoId);
    }
    
    public class UserInfoService : BaseService, IUserInfoService
    {
        /// <summary>
        /// Create new userInfo
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        public bool Create(UserInfoDto userInfoDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from userInfo dto to userInfo entity
                var userInfoEntity = Mapper.Map<UserInfo>(userInfoDto);

                // Add userInfo to dbContext
                dbContext.UserInfo.Add(userInfoEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update userInfo status is deleted
        /// </summary>
        /// <param name="userInfoId"></param>
        /// <returns></returns>
        public bool Delete(Guid userInfoId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get userInfo by id
                var userInfo = dbContext.UserInfo.FirstOrDefault(g => g.Id == userInfoId);

                if (userInfo == null)
                {
                    return false;
                }

                // Update status from active to deleted
                userInfo.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all userInfo
        /// </summary>
        /// <returns></returns>
        public List<UserInfoDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all userInfo
                var userInfos = new List<UserInfoDto>();
                var userInfoEntity = dbContext.UserInfo.ToList();

                if (!userInfoEntity.Any())
                {
                    return null;
                }

                // Mapper from list userInfo entity to userInfo dto
                Mapper.Map<List<UserInfo>, List<UserInfoDto>>(userInfoEntity, userInfos);

                return userInfos;
            }
        }

        /// <summary>
        /// Get userInfo by userInfo id
        /// </summary>
        /// <param name="userInfoId"></param>
        /// <returns></returns>
        public UserInfoDto GetById(Guid userInfoId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get userInfo by id
                var userInfoEntity = dbContext.UserInfo.FirstOrDefault(g => g.Id == userInfoId);

                if (userInfoEntity == null)
                {
                    return null;
                }

                var userInfo = Mapper.Map<UserInfoDto>(userInfoEntity);

                return userInfo;
            }
        }

        /// <summary>
        /// Update userInfo info
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        public bool Update(UserInfoDto userInfoDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get userInfo by id
                var userInfoEntity = dbContext.UserInfo.FirstOrDefault(g => g.Id == userInfoDto.Id);

                if (userInfoEntity == null)
                {
                    return false;
                }

                userInfoEntity.Name = userInfoDto.Name;
                userInfoEntity.Email = userInfoDto.Email;
                userInfoEntity.Adress = userInfoDto.Adress;
                userInfoEntity.DateOfBirth = userInfoDto.DateOfBirth;
                userInfoEntity.Gender = userInfoDto.Gender;

                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }
    }
}