using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class RoleController : BaseApiController
    {
        private IRoleService RoleService;

        public RoleController(IRoleService roleService)
        {
            this.RoleService = roleService;
        }

        /// <summary>
        /// Create new role
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Role")]
        public IHttpActionResult Create(RoleDto roleDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = RoleService.Create(roleDto);

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
        /// Update role info
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Role")]
        public IHttpActionResult Update(RoleDto roleDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = RoleService.Update(roleDto);

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
        /// Delete role info
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteRole")]
        public IHttpActionResult Delete(BaseDto roleDto)
        {
            try
            {
                if (roleDto == null || roleDto.Id == null || roleDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = RoleService.Delete(roleDto.Id);

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
        /// GetAll role info
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Role")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<RoleDto> result = RoleService.GetAll();

                if (result.Count != 0)
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
        /// GetById role info
        /// </summary>
        /// <param name="roleDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Role/{roleId}")]
        public IHttpActionResult GetById(Guid roleId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                RoleDto result = RoleService.GetById(roleId);

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
    }
}