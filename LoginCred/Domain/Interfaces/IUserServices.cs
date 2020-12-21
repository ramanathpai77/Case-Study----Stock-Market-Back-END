using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginCred.Entities;

namespace LoginCred.Domain.Interfaces
{
   public  interface IUserServices
    {
        public bool SignUP(User s);
        public string login(Credentials model);
    }
}
