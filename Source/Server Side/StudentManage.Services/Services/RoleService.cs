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
    public interface IRoleService
    {
        RoleDto GetById(Guid roleId);

        List<RoleDto> GetAll();

        bool Create(RoleDto roleDto);

        bool Update(RoleDto roleDto);

        bool Delete(Guid roleId);
    }
    
    public class RoleService : BaseService, IRoleService
    {
        /// <summary>
        /// Create new role
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        public bool Create(RoleDto roleDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from role dto to role entity
                var roleEntity = Mapper.Map<Role>(roleDto);

                roleEntity.CreatedDate = DateTime.Now;
                roleEntity.ModifiedDate = DateTime.Now;

                // Add role to dbContext
                dbContext.Role.Add(roleEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update role status is deleted
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public bool Delete(Guid roleId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get role by id
                var role = dbContext.Role.FirstOrDefault(g => g.Id == roleId);

                if (role == null)
                {
                    return false;
                }

                // Update status from active to deleted
                role.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all role
        /// </summary>
        /// <returns></returns>
        public List<RoleDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all role
                var roles = new List<RoleDto>();
                var roleEntity = dbContext.Role.ToList();

                if (!roleEntity.Any())
                {
                    return null;
                }

                // Mapper from list role entity to role dto
                Mapper.Map<List<Role>, List<RoleDto>>(roleEntity, roles);

                return roles;
            }
        }

        /// <summary>
        /// Get role by role id
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public RoleDto GetById(Guid roleId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get role by id
                var roleEntity = dbContext.Role.FirstOrDefault(g => g.Id == roleId);

                if (roleEntity == null)
                {
                    return null;
                }

                var role = Mapper.Map<RoleDto>(roleEntity);

                return role;
            }
        }

        /// <summary>
        /// Update role info
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        public bool Update(RoleDto roleDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get role by id
                var roleEntity = dbContext.Role.FirstOrDefault(g => g.Id == roleDto.Id);

                if (roleEntity == null)
                {
                    return false;
                }

                roleEntity.Name = roleDto.Name;
                roleEntity.ModifiedDate = DateTime.Now;

                result = true;
            }

            return result;
        }
    }
}