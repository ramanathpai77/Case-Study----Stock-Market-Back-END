using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.Dtos;
using AutoMapper;
using ComapnyInformation.Entities;
using ComapnyInformation.Domain.Interfaces;


namespace ComapnyInformation.Domain.Repositories
{
    public class CompanyService : ICompanyService
    {
        readonly ICompanyRepository repository;
        readonly IMapper mapper;
        public CompanyService (ICompanyRepository repository )
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public bool AddCompany(Company c)
        {
            var a = repository.AddCompany(c);
            if(a==true){
                return a;
            }
            
            throw new NotImplementedException();
        }

        public bool AddStockPrice(StockPrice sp)
        {
            var a = repository.AddStockPrice(sp);
            if (a == true) {
                return a;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            var companies = repository.GetAllCompanies();
            return companies;
            var dtos = mapper.Map<IEnumerable<CompanyDto>>(companies);
            
        }

        public IEnumerable<Company> GetCompany(string cname)
        {
            var company = repository.GetCompany(cname);
           
            return company;
            throw new NotImplementedException();
        }

       

        public IEnumerable<int> GetStockPrice(string stockcode, int se,DateTime fromdate, DateTime todate)
        {
            var q = repository.GetStockPrice(stockcode, se, fromdate, todate);
            return q;
            throw new NotImplementedException();
        }
    }
}
