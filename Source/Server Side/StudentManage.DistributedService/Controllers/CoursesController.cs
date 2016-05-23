using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class CoursesController : BaseApiController
    {
        private ICoursesService CoursesService;

        public CoursesController(ICoursesService coursesService)
        {
            this.CoursesService = coursesService;
        }

        /// <summary>
        /// Create new courses
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Courses")]
        public IHttpActionResult Create(CoursesDto coursesDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = CoursesService.Create(coursesDto);

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
        /// Update courses info
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Courses")]
        public IHttpActionResult Update(CoursesDto coursesDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = CoursesService.Update(coursesDto);

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
        /// Delete courses info
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteCourses")]
        public IHttpActionResult Delete(BaseDto coursesDto)
        {
            try
            {
                if (coursesDto == null || coursesDto.Id == null || coursesDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = CoursesService.Delete(coursesDto.Id);

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
        /// GetAll courses info
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Courses")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<CoursesDto> result = CoursesService.GetAll();

                if (result.Count != 0)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.DeleteSuccessful,
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
        /// GetById courses info
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Courses")]
        public IHttpActionResult GetById(Guid coursesId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                CoursesDto result = CoursesService.GetById(coursesId);

                if (result != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
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