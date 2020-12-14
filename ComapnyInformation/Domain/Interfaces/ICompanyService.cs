using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Dtos;
using ComapnyInformation.Entities;

namespace ComapnyInformation.Domain.Interfaces
{
    public interface ICompanyService
    {
        
        IEnumerable<Company> GetAllCompanies();
        IEnumerable<Company> GetCompany(string cname);
        public IEnumerable<int> GetStockPrice(string stockcode,int se, DateTime fromdate, DateTime todate );

        public bool AddCompany(Company c);
        public bool AddStockPrice(StockPrice sp);

    }
}
