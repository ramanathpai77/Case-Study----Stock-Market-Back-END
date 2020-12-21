using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginCred.DataContext;
using LoginCred.Domain.Interfaces;
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

        public string login(Credentials c)
        {

            var query = from x in context.User
                        select new{x.UserName, x.PassWord, x.UserType};
            query.ToList();
            foreach (var q in query)
            {
                if(c.UserName==q.UserName && c.Password==q.PassWord)
                {
                    if(q.UserType=="admin")
                    {
                        return "admin";
                    }
                    else
                    {
                        return "customer";
                    }
                }
                
            }
            
            
                return "Invalid";
            
            
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
