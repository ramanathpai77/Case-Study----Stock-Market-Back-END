using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Dtos;

namespace ComapnyInformation.Domain.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetCompanies();
        CompanyDto GetCompany(string cname);
        int GetStockPrice(string stockcode);


    }
}
