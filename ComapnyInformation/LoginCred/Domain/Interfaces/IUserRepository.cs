using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginCred.Entities;

namespace LoginCred.Domain.Interfaces
{
   public interface IUserRepository
    {
        public bool SignUP(User s);
        public bool login(int id,string pass);
    }
}
