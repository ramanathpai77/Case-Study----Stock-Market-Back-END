using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Domain.Interfaces;
using ComapnyInformation.Dtos;
using ComapnyInformation.Entities;

namespace ComapnyInformation.Domain.Repositories
{
    public class IPOsService : IIPOsService
    {
        readonly IIPOsRepository repo;
        public IPOsService(IIPOsRepository repo)
        {
            this.repo = repo;
        }

        public bool AddIPO(IPOs i)
        {
            bool a=repo.AddIPO(i);
            if(a==true)
            {
                return a;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<IPOs> getCompanyIPODetails()
        {
            
            var ipos = repo.getCompanyIPODetails();
            return ipos;
            throw new NotImplementedException();
        }
    }
}
