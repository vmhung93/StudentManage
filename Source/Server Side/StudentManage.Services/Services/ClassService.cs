﻿using AutoMapper;
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
    public interface IClassService
    {
        ClassDto GetById(Guid classId);

        List<ClassDto> GetAll();

        bool Create(ClassDto classDto);

        bool Update(ClassDto classDto);

        bool Delete(Guid classId);

        ClassInfoDto GetClassInfo();
    }

    public class ClassService : BaseService, IClassService
    {
        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        public bool Create(ClassDto classDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from grade dto to grade entity
                var classEntity = Mapper.Map<Class>(classDto);


                classEntity.HomeroomTeacherId = classDto.HomeroomTeacherId;
                classEntity.CreatedDate = DateTime.Now;
                classEntity.ModifiedDate = DateTime.Now;

                // Add grade to dbContext
                dbContext.Class.Add(classEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update grade status is deleted
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public bool Delete(Guid classId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var _class = dbContext.Class.FirstOrDefault(g => g.Id == classId);

                if (_class == null)
                {
                    return false;
                }

                // Update status from active to deleted
                _class.Status = Common.Status.Deleted;

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
        public List<ClassDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all grade
                var classes = new List<ClassDto>();
                var classEntity = dbContext.Class.ToList();

                if(!classEntity.Any())
                {
                    return null;
                }

                // Mapper from list grade entity to grade dto
                Mapper.Map<List<Class>, List<ClassDto>>(classEntity, classes);

                return classes;
            }
        }

        /// <summary>
        /// Get grade by grade id
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public ClassDto GetById(Guid classId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var classEntity = dbContext.Class.FirstOrDefault(g => g.Id == classId);
                
                if(classEntity == null)
                {
                    return null;
                }

                var classDto = Mapper.Map<ClassDto>(classEntity);

                return classDto;
            }
        }

        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        public bool Update(ClassDto classDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var classEntity = dbContext.Class.FirstOrDefault(g => g.Id == classDto.Id);

                if (classEntity == null)
                {
                    return false;
                }

                classEntity.Name = classDto.Name;
                classEntity.ModifiedDate = DateTime.Now;
                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }


        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public ClassInfoDto GetClassInfo()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var teacherUnavaliable = dbContext.Class.Select(c => c.HomeroomTeacherId).ToList();
                var studentUnavaliable = dbContext.StudentInClass
                    .Where(s =>s.Status != Common.Status.Deleted)
                    .Select(s => s.StudentId).ToList();

                var teacherAvaliable = dbContext.Users
                    .Where(u => !teacherUnavaliable.Contains(u.Id) && u.Role.Level == Common.RoleLevel.Teacher && u.Status == Common.Status.Active)
                    .ToList();
                var studentAvaliable = dbContext.Users
                    .Where(u => !studentUnavaliable.Contains(u.Id) && u.Role.Level == Common.RoleLevel.Student && u.Status == Common.Status.Active)
                    .ToList();
                var grades = dbContext.Grade.ToList();

                var result = new ClassInfoDto()
                {
                    HomeroomTeacherdes = Mapper.Map<List<UserDto>>(teacherAvaliable),
                    Students = Mapper.Map<List<UserDto>>(studentAvaliable),
                    Grades = Mapper.Map<List<GradeDto>>(grades)
                };

                return result;
            }
        }
    }
}