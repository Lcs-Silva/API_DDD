using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Entities;
using WebApi.Domain.Interfaces.Services.User;

namespace WebApi.Service.Services
{
    public class LoginService : ILoginService
    {
        public Task<object> FindByLogin(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}