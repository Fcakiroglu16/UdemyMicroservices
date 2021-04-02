using FreeCourse.Web.Models;
using FreeCourse.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public class UserService : IUserService
    {
        public Task<UserViewModel> GetUser()
        {
            throw new NotImplementedException();
        }
    }
}