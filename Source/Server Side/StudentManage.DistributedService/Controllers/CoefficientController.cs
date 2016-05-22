using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class CoefficientController : BaseApiController
    {
        private ICoefficientService CoefficientService;

        public CoefficientController(ICoefficientService coefficientService)
        {
            this.CoefficientService = coefficientService;
        }

        /// <summary>
        /// Create new coefficient
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Coefficient")]
        public IHttpActionResult Create(CoefficientDto coefficientDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = CoefficientService.Create(coefficientDto);

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
        /// Update coefficient info
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Coefficient")]
        public IHttpActionResult Update(CoefficientDto coefficientDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = CoefficientService.Update(coefficientDto);

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
        /// Delete coefficient info
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteCoefficient")]
        public IHttpActionResult Delete(BaseDto coefficientDto)
        {
            try
            {
                if (coefficientDto == null || coefficientDto.Id == null || coefficientDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = CoefficientService.Delete(coefficientDto.Id);

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
        /// GetAll coefficient info
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Coefficient")]
        public IHttpActionResult Get()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<CoefficientDto> result = CoefficientService.GetAll();

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
        /// GetById coefficient info
        /// </summary>
        /// <param name="coefficientDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Coefficient/{coefficientId}")]
        public IHttpActionResult Get(Guid coefficientId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                CoefficientDto result = CoefficientService.GetById(coefficientId);

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