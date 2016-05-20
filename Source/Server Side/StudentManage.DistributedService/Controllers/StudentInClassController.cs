using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
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
                        Message = ResponseMessages.CreateUserSuccessfully
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.InternalServerError
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
        [Route("api/StudentInClass")]
        public IHttpActionResult Delete(Guid studentInClassId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = StudentInClassService.Delete(studentInClassId);

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
        [HttpPost]
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
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = result
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
        /// GetById studentInClass info
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StudentInClass")]
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
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = result
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
    }
}