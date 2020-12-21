using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComapnyInformation.DataContext;
using ComapnyInformation.Domain.Interfaces;
using ComapnyInformation.Entities;


namespace ComapnyInformation.Domain.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        readonly DemoContext context;
        public CompanyRepository(DemoContext ctx)
        {
            context = ctx;
        }

        public bool AddCompany(Company c)
        {
            context.Company.Add(c);
            int RowsAdded = context.SaveChanges();
            return RowsAdded > 0;


            throw new NotImplementedException();
        }

        public bool AddStockPrice(StockPrice sp)
        {
            context.StockPrice.Add(sp);
            int RowsAdded = context.SaveChanges();
            return RowsAdded > 0;
            throw new NotImplementedException();
        }

        public IEnumerable<Company>  GetAllCompanies()
        {
           
            var query = from obj in context.Company
                        orderby obj.CName
                        select obj;
            return query.ToList();
        }

        public IEnumerable<Company> GetCompany(string cname)
        {
            var Comp = from obj in context.Company
                       where obj.CName == cname
                       select obj;
            return Comp;
            throw new NotImplementedException();
        }

      

        public IEnumerable<int> GetStockPrice(string stockcode)
        {
            var query = from x in context.Company
                        join y in context.StockPrice
                        on x.CCode equals y.CompanyCode
                        where x.CCode == stockcode
                       
                        select y.CurrentPrice;
            if (query.Count()==0)
            {
                return null;
            }
            int max = query.Max();
            int min = query.Min();
            List<int> l = new List<int>();
            l.Add(max);
            l.Add(min);
            return l;

            
            throw new NotImplementedException();
        }
    }
}
