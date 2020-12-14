using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginCred.DataContext;
using LoginCred.Domain.Interfaces
using LoginCred.Entities;

namespace LoginCred.Domain.Repository
{
    public class UserRepository:IUserRepository
    {
        readonly UserContext context;
        public UserRepository (UserContext context)
        {
            this.context = context;
        }

        public bool login(int id, string pass)
        {

            throw new NotImplementedException();
        }

        public bool SignUP(User s)
        {
            context.User.Add(s);
            int rows = context.SaveChanges();
            return rows > 0;
            throw new NotImplementedException();
        }
    }
}
