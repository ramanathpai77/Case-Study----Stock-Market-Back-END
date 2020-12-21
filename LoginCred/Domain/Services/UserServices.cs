using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginCred.Domain.Interfaces;
using LoginCred.Entities;

namespace LoginCred.Domain.Services
{
    public class UserServices :IUserServices
    {
        readonly IUserRepository repo;
        public UserServices(IUserRepository repo)
        {
            this.repo = repo;
        }

        public string login(Credentials model)
        {
            var a = repo.login(model);
            return a;
            throw new NotImplementedException();
        }

        public bool SignUP(User s)
        {
            var a= repo.SignUP(s);
            return a;
            throw new NotImplementedException();
        }
    }
}
