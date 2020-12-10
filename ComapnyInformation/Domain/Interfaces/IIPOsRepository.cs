using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Entity;

namespace ComapnyInformation.Domain.Interfaces
{
    public interface IIPOsRepository
    {
        IEnumerable<IPOs> getCompanyIPODetails();
    }
}
