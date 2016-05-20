using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class GradeController : BaseApiController
    {
        private IGradeService GradeService;

        public GradeController(IGradeService gradeService)
        {
            this.GradeService = gradeService;
        }

        /// <summary>
        /// create new user
        /// </summary>
        /// <param name="gradedto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/grade")]
        public IHttpActionResult create(GradeDto gradeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = GradeService.Create(gradeDto);

                if (result)
                {
                    return Json(new
                    {
                        status = HttpStatusCode.OK,
                        message = ResponseMessages.CreateUserSuccessfully
                    });
                }
                
                return Json(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = ResponseMessages.InternalServerError
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = HttpStatusCode.InternalServerError,
                    message = ResponseMessages.InternalServerError,
                    error = ex.ToString()
                });
            }
        }
    }
}