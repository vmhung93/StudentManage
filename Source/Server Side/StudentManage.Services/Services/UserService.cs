using StudentManage.Domain;
using StudentManage.Domain.DbContext;
using StudentManage.Services.AppicationContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Services.Services
{
    public interface IUserService
    {
        UserDto Login(string userName, string password);
    }

    public class UserService : IUserService
    {
        public UserDto Login(string userName, string password)
        {
            StudentManageDbContext dbcontext = new StudentManageDbContext();

            var result = dbcontext.Users.ToList();
            return new UserDto();
        }
    }
}