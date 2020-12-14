using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Domain.Interfaces;
using StockExchange.Entities;

namespace StockExchange.Domain.Services
{
    public class SEServices : ISEServices
    {
        readonly ISERepository repo;
        public SEServices(ISERepository repo)
        {
            this.repo = repo;
        }
        public bool AddStockExchange(StockExchanges se)
        {
            var a = repo.AddStockExchange(se);
            if (a == true)
            {
                return a;
            }
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies(int Seid)
        {
            var a = repo.GetCompanies(Seid);
            return a;
            throw new NotImplementedException();
        }

        public IEnumerable<StockExchanges> GetStockExchanges()
        {
            var a = repo.GetStockExchanges();
            return a;
            throw new NotImplementedException();
        }
    }
}
