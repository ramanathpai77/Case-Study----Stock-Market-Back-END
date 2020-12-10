using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Dtos

namespace ComapnyInformation.Domain.Interfaces
{
    interface IIPOsService
    {
        IEnumerable<IPOsDto> getCompanyIPODetails();
    }
}
