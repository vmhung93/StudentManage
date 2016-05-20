using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class ClassController : BaseApiController
    {
        private IClassService ClassService;

        public ClassController(IClassService classService)
        {
            this.ClassService = classService;
        }

        /// <summary>
        /// Create new class
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Class")]
        public IHttpActionResult Create(ClassDto classDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ClassService.Create(classDto);

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
        /// Update class info
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Class")]
        public IHttpActionResult Update(ClassDto classDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ClassService.Update(classDto);

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
        /// Delete class info
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Class")]
        public IHttpActionResult Delete(Guid classId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ClassService.Delete(classId);

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
        /// GetAll class info
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Class")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<ClassDto> result = ClassService.GetAll();

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
        /// GetById class info
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Class")]
        public IHttpActionResult GetById(Guid classId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                ClassDto result = ClassService.GetById(classId);

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