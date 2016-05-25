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
    public interface ISystemConfigService
    {
        SystemConfigDto GetById(Guid systemConfigId);

        List<SystemConfigDto> GetAll();

        bool Create(SystemConfigDto systemConfigDto);

        bool Update(SystemConfigDto systemConfigDto);

        bool Delete(Guid systemConfigId);

        bool UpdateAll(List<SystemConfigDto> systemConfigs);
    }
    
    public class SystemConfigService : BaseService, ISystemConfigService
    {
        /// <summary>
        /// Create new systemConfigEntity
        /// </summary>
        /// <param name="systemConfigDto"></param>
        /// <returns></returns>
        public bool Create(SystemConfigDto systemConfigDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from systemConfigEntity dto to systemConfigEntity entity
                var systemConfigEntity = Mapper.Map<SystemConfig>(systemConfigDto);

                systemConfigEntity.CreatedDate = DateTime.Now;
                systemConfigEntity.ModifiedDate = DateTime.Now;

                // Add systemConfigEntity to dbContext
                dbContext.SystemConfig.Add(systemConfigEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update systemConfigEntity status is deleted
        /// </summary>
        /// <param name="systemConfigId"></param>
        /// <returns></returns>
        public bool Delete(Guid systemConfigId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get systemConfigEntity by id
                var systemConfigEntity = dbContext.SystemConfig.FirstOrDefault(g => g.Id == systemConfigId);

                if (systemConfigEntity == null)
                {
                    return false;
                }

                // Update status from active to deleted
                systemConfigEntity.ModifiedDate = DateTime.Now;
                systemConfigEntity.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all systemConfigEntity
        /// </summary>
        /// <returns></returns>
        public List<SystemConfigDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all systemConfigEntity
                var result = new List<SystemConfigDto>();
                var systemConfigEntity = dbContext.SystemConfig.ToList();

                if (!systemConfigEntity.Any())
                {
                    return null;
                }

                // Mapper from list systemConfigEntity entity to systemConfigEntity dto
                Mapper.Map<List<SystemConfig>, List<SystemConfigDto>>(systemConfigEntity, result);

                return result;
            }
        }

        /// <summary>
        /// Get systemConfigEntity by systemConfigEntity id
        /// </summary>
        /// <param name="systemConfigId"></param>
        /// <returns></returns>
        public SystemConfigDto GetById(Guid systemConfigId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get systemConfigEntity by id
                var systemConfigEntity = dbContext.SystemConfig.FirstOrDefault(g => g.Id == systemConfigId);

                if (systemConfigEntity == null)
                {
                    return null;
                }

                var systemConfigDto = Mapper.Map<SystemConfigDto>(systemConfigEntity);

                return systemConfigDto;
            }
        }

        /// <summary>
        /// Update systemConfigEntity info
        /// </summary>
        /// <param name="systemConfigDto"></param>
        /// <returns></returns>
        public bool Update(SystemConfigDto systemConfigDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get systemConfigEntity by id
                var systemConfigEntity = dbContext.SystemConfig.FirstOrDefault(g => g.Id == systemConfigDto.Id);

                if (systemConfigEntity == null)
                {
                    return false;
                }

                systemConfigEntity.Name = systemConfigDto.Name;
                systemConfigEntity.Value = systemConfigDto.Value;
                systemConfigEntity.ModifiedDate = DateTime.Now;
                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update systemConfigEntity info
        /// </summary>
        /// <param name="systemConfigDto"></param>
        /// <returns></returns>
        public bool UpdateAll(List<SystemConfigDto> systemConfigs)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                foreach(var sys in systemConfigs)
                {
                    var systemConfigEntity = dbContext.SystemConfig.SingleOrDefault(s => s.Id == sys.Id);
                    if (systemConfigEntity != null)
                    {
                        systemConfigEntity.Name = sys.Name;
                        systemConfigEntity.Value = sys.Value;
                        systemConfigEntity.ModifiedDate = DateTime.Now;
                        dbContext.SaveChanges();
                    }
                }
                result = true;
            }
            return result;
        }
    }
}