using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Entities;

namespace StockExchange.Domain.Interfaces
{
   public interface ISERepository
    {
        public bool AddStockExchange(StockExchanges se);
        public IEnumerable<StockExchanges> GetStockExchanges();
        public IEnumerable<Company> GetCompanies(int Seid);
    }
}
