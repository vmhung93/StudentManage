using StudentManage.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace StudentManage.DistributedService.Authorization
{
    public class CustomAuthorize : System.Web.Http.AuthorizeAttribute
    {
        private bool requireAuthentication = true;

        public bool RequireAuthentication
        {
            get
            {
                return requireAuthentication;
            }

            set
            {
                requireAuthentication = value;
            }
        }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (Authenticate(actionContext) || !RequireAuthentication)
            {
                return;
            }
            else
            {
                HandleUnauthorizedRequest(actionContext);
            }
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var unauthorizedMessage = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            unauthorizedMessage.Headers.Add("WWW-Authenticate", "Basic");
            throw new HttpResponseException(unauthorizedMessage);
        }

        private bool Authenticate(HttpActionContext actionContext)
        {
            bool isValid = false;
            if (actionContext.Request.Headers.Contains("Token"))
            {
                try
                {
                    var tokens = actionContext.Request.Headers.GetValues("Token").ToList<string>();
                    Guid token = Guid.Parse(tokens.First());

                    // Check valid token
                    var UserService = new UserService();
                    isValid = UserService.CheckTokenIsValid(token);
                }
                catch
                {
                    return false;
                }
            }

            return isValid;
        }
    }
}