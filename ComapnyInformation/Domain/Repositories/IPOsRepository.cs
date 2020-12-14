using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.DataContext;
using ComapnyInformation.Domain.Interfaces;
using ComapnyInformation.Entities;

namespace ComapnyInformation.Domain.Repositories
{
    public class IPOsRepository : IIPOsRepository
    {
        readonly DemoContext context;
        public IPOsRepository (DemoContext context)
        {
            this.context = context;
        }

        public bool AddIPO(IPOs i)
        {
            try
            {
                context.IPOs.Add(i);
                int RowsAdded = context.SaveChanges();
                return RowsAdded > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }

        public  IEnumerable<IPOs> getCompanyIPODetails()
        {
            var query = from obj in context.IPOs
                        orderby obj.CName
                        select obj;
            return query.ToList();

            throw new NotImplementedException();
        }
    }
}
