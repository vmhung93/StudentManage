using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace StudentManage.DistributedService.Controllers
{
    public class BaseApiController : ApiController
    {
        public UserDto CurrentUser { get; private set; }

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);

            if (controllerContext.Request.Headers.Contains("Token"))
            {
                try
                {
                    var tokens = controllerContext.Request.Headers.GetValues("Token").ToList<string>();
                    Guid token = Guid.Parse(tokens.First());

                    // Get current user
                    var userService = new UserService();
                    CurrentUser = userService.GetUserByToken(token);

                    if (CurrentUser == null)
                    {
                        return;
                    }
                    else
                    {
                        // Store to cache
                        Common.CacheManage.Set("current_user", CurrentUser);
                    }
                }
                catch
                {
                    return;
                }
            }

            return;
        }
    }
}