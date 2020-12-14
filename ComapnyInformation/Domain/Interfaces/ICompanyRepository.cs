using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Entities;

namespace ComapnyInformation.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        public IEnumerable<Company> GetAllCompanies();
        public IEnumerable<Company> GetCompany(string cname);
        
        public  IEnumerable<int> GetStockPrice(string stockcode,int SE,DateTime fromdate,DateTime todate);
        public bool AddCompany(Company c);
        public bool AddStockPrice(StockPrice sp);


    }
}
