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
    public interface ICoefficientService
    {
        CoefficientDto GetById(Guid coefficientId);

        List<CoefficientDto> GetAll();

        bool Create(CoefficientDto coefficientDto);

        bool Update(CoefficientDto coefficientDto);

        bool Delete(Guid coefficientId);
    }
    
    public class CoefficientService : BaseService, ICoefficientService
    {
        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        public bool Create(CoefficientDto coefficientDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from grade dto to grade entity
                var coefficientEntity = Mapper.Map<Class>(coefficientDto);

                coefficientEntity.CreatedDate = DateTime.Now;
                coefficientEntity.ModifiedDate = DateTime.Now;

                // Add grade to dbContext
                dbContext.Class.Add(coefficientEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update grade status is deleted
        /// </summary>
        /// <param name="coefficientId"></param>
        /// <returns></returns>
        public bool Delete(Guid coefficientId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var coefficient = dbContext.Coefficient.FirstOrDefault(g => g.Id == coefficientId);

                if (coefficientId == null)
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
        public List<CoefficientDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all grade
                var coefficientes = new List<CoefficientDto>();
                var coefficientEntity = dbContext.Coefficient.ToList();

                if (!coefficientEntity.Any())
                {
                    return null;
                }

                // Mapper from list grade entity to grade dto
                Mapper.Map<List<Coefficient>, List<CoefficientDto>>(coefficientEntity, coefficientes);

                return coefficientes;
            }
        }

        /// <summary>
        /// Get grade by grade id
        /// </summary>
        /// <param name="coefficientId"></param>
        /// <returns></returns>
        public CoefficientDto GetById(Guid coefficientId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var coefficientEntity = dbContext.Coefficient.FirstOrDefault(g => g.Id == coefficientId);

                if (coefficientEntity == null)
                {
                    return null;
                }

                var coefficient = Mapper.Map<CoefficientDto>(coefficientEntity);

                return coefficient;
            }
        }

        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        public bool Update(CoefficientDto coefficientDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var coefficientEntity = dbContext.Class.FirstOrDefault(g => g.Id == coefficientDto.Id);

                if (coefficientEntity == null)
                {
                    return false;
                }

                coefficientEntity.Name = coefficientDto.Name;
                coefficientEntity.ModifiedDate = DateTime.Now;

                result = true;
            }

            return result;
        }
    }
}