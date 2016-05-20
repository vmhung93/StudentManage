using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class PositionInClassController : BaseApiController
    {
        private IPositionInClassService PositionInClassService;

        public PositionInClassController(IPositionInClassService positionInClassService)
        {
            this.PositionInClassService = positionInClassService;
        }

        /// <summary>
        /// Create new positionInClass
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/PositionInClass")]
        public IHttpActionResult Create(PositionInClassDto positionInClassDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = PositionInClassService.Create(positionInClassDto);

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
        /// Update positionInClass info
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/PositionInClass")]
        public IHttpActionResult Update(PositionInClassDto positionInClassDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = PositionInClassService.Update(positionInClassDto);

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
        /// Delete positionInClass info
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/PositionInClass")]
        public IHttpActionResult Delete(Guid positionInClassId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = PositionInClassService.Delete(positionInClassId);

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
        /// GetAll positionInClass info
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/PositionInClass")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<PositionInClassDto> result = PositionInClassService.GetAll();

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
        /// GetById positionInClass info
        /// </summary>
        /// <param name="positionInClassDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/PositionInClass")]
        public IHttpActionResult GetById(Guid positionInClassId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                PositionInClassDto result = PositionInClassService.GetById(positionInClassId);

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