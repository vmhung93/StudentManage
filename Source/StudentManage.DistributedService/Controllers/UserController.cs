using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpPost]
        [Route("api/Login")]
        public UserDto Login(UserDto userDto)
        {
            try
            {
                var userService = new UserService();

                var result = userService.Login(userDto.UserName, userDto.Password);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}