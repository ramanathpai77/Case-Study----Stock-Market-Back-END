using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Dtos;
using ComapnyInformation.Entities;

namespace ComapnyInformation.Domain.Interfaces
{
    public interface IIPOsService
    {
        IEnumerable<IPOs> getCompanyIPODetails();
        bool AddIPO(IPOs i);
    }
}
