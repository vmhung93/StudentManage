using StudentManage.Common;
using StudentManage.DistributedService.Authorization;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    [CustomAuthorize]
    public class StudentInClassController : BaseApiController
    {
        private IStudentInClassService StudentInClassService;

        public StudentInClassController(IStudentInClassService studentInClassService)
        {
            this.StudentInClassService = studentInClassService;
        }

        /// <summary>
        /// Create new studentInClass
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StudentInClass")]
        public IHttpActionResult Create(StudentInClassDto studentInClassDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = StudentInClassService.Create(studentInClassDto);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.CreateDataSuccessfully
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.CreateDataUnsuccessfully
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// Update studentInClass info
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/StudentInClass")]
        public IHttpActionResult Update(StudentInClassDto studentInClassDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = StudentInClassService.Update(studentInClassDto);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.UpdateSuccessful
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.UpdateUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// Delete studentInClass info
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteStudentInClass")]
        public IHttpActionResult Delete(BaseDto studentInClassDto)
        {
            try
            {
                if (studentInClassDto == null || studentInClassDto.Id == null || studentInClassDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = StudentInClassService.Delete(studentInClassDto.Id);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.DeleteSuccessful
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.DeleteUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetAll studentInClass info
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/StudentInClass")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<StudentInClassDto> result = StudentInClassService.GetAll();

                if (result.Count != 0)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = result
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.GetDataUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById studentInClass info
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/StudentInClass/{studentInClassId}")]
        public IHttpActionResult GetById(Guid studentInClassId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                StudentInClassDto result = StudentInClassService.GetById(studentInClassId);

                if (result != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = result
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.GetDataUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// Create new class
        /// </summary>
        /// <param name="classWithStudentDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StudentInClass/CreateClassWithStudent")]
        public IHttpActionResult CreateClassWithStudent(ClassWithStudentDto classWithStudentDto)
        {
            try
            {
                bool result = StudentInClassService.CreateClassWithStudent(classWithStudentDto);

                if (result == true)
                {
                    var dataJSon = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.CreateDataSuccessfully
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.CreateDataUnsuccessfully
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById class info
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/StudentInClass/GetClassStudentInfo/{classId}")]
        public IHttpActionResult GetClassStudentInfo(Guid classId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                ClassStudentInfoDto result = StudentInClassService.GetClassStudentInfo(classId);

                if (result != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.GetDataUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById class info
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StudentInClass/UpdateClassWithStudents")]
        public IHttpActionResult UpdateClassWithStudents(UpdateClassWithStudentsDto classWithStudentsDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var result = StudentInClassService.UpdateClassWithStudents(classWithStudentsDto);

                if (result == true)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.UpdateSuccessful
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.UpdateUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById class info
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StudentInClass/CreateStudentInClass")]
        public IHttpActionResult CreateStudentInClass(CreateStudentInClassDto createStudentInClassDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                if (StudentInClassService.CheckEmailIsExist(createStudentInClassDto.Student.UserInfo.Email))
                {
                    return Json(new
                    {
                        Status = 198,
                        Message = ResponseMessages.EmailAlreadyExist
                    });
                }

                var result = StudentInClassService.CreateStudentInClass(createStudentInClassDto);

                if (result == true)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.CreateDataSuccessfully
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.CreateDataUnsuccessfully
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }
    }
}