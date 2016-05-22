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
    public interface IPositionInClassService
    {
        PositionInClassDto GetById(Guid positionInClassId);

        List<PositionInClassDto> GetAll();

        bool Create(PositionInClassDto positionInClassDto);

        bool Update(PositionInClassDto positionInClassDto);

        bool Delete(Guid positionInClassId);
    }
    
    public class PositionInClassService : BaseService, IPositionInClassService
    {
        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        public bool Create(PositionInClassDto positionInClassDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from grade dto to grade entity
                var positionInClassEntity = Mapper.Map<PositionInClass>(positionInClassDto);

                positionInClassEntity.CreatedDate = DateTime.Now;
                positionInClassEntity.ModifiedDate = DateTime.Now;

                // Add grade to dbContext
                dbContext.PositionInClass.Add(positionInClassEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update grade status is deleted
        /// </summary>
        /// <param name="positionInClassId"></param>
        /// <returns></returns>
        public bool Delete(Guid positionInClassId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var coefficient = dbContext.PositionInClass.FirstOrDefault(g => g.Id == positionInClassId);

                if (positionInClassId == null)
                {
                    return false;
                }

                // Update status from active to deleted
                coefficient.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all grade
        /// </summary>
        /// <returns></returns>
        public List<PositionInClassDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all grade
                var positionInClasses = new List<PositionInClassDto>();
                var positionInClassEntity = dbContext.PositionInClass.ToList();

                if (!positionInClassEntity.Any())
                {
                    return null;
                }

                // Mapper from list grade entity to grade dto
                Mapper.Map<List<PositionInClass>, List<PositionInClassDto>>(positionInClassEntity, positionInClasses);

                return positionInClasses;
            }
        }

        /// <summary>
        /// Get grade by grade id
        /// </summary>
        /// <param name="positionInClassId"></param>
        /// <returns></returns>
        public PositionInClassDto GetById(Guid positionInClassId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var positionInClassEntity = dbContext.PositionInClass.FirstOrDefault(g => g.Id == positionInClassId);

                if (positionInClassEntity == null)
                {
                    return null;
                }

                var coefficient = Mapper.Map<PositionInClassDto>(positionInClassEntity);

                return coefficient;
            }
        }

        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        public bool Update(PositionInClassDto positionInClassDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var positionInClassEntity = dbContext.PositionInClass.FirstOrDefault(g => g.Id == positionInClassDto.Id);

                if (positionInClassEntity == null)
                {
                    return false;
                }

                positionInClassEntity.Name = positionInClassDto.Name;
                positionInClassEntity.ModifiedDate = DateTime.Now;
                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }
    }
}