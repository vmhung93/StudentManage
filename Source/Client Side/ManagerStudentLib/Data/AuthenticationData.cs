using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Models;
namespace ManagerStudentLib.Data
{
    public class AuthenticationData : AbstractData
    {
        public static User Authenticate(string username, string password)
        {
            User user = null;
            try
            {
                //user = JsonConvert.DeserializeObject<User>(GetJsonData("/rest/username/password"));
                //Mockup a json data 
                var jsonUser = "{ \"Username\" : \"Admin\" , \"Role\" : 5,  \"Token\" : \"ABC\"}";
                user = JsonConvert.DeserializeObject<User>(jsonUser);
            }
            catch (DataGetException ex)
            {
                throw (new AuthenticationException(ex));
            }
            return user;
        }
    }
}
