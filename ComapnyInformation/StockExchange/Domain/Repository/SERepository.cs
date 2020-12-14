using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.DataContext;
using StockExchange.Domain.Interfaces;
using StockExchange.Entities;

namespace StockExchange.Domain.Repository
{
    public class SERepository : ISERepository
    {
        readonly SEContext context;
        public SERepository(SEContext context)
        {
            this.context = context;
        }
        public bool AddStockExchange(StockExchanges se)
        {
            context.StockExchanges.Add(se);
            int rows = context.SaveChanges();
            return rows > 0;
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies(int Seid)
        {
            var query = from x in context.StockExchanges
                        join y in context.Company on
                        x.SEId equals y.SEId
                        where x.SEId == Seid
                        select y;
            return query.ToList();

            throw new NotImplementedException();
        }

        public IEnumerable<StockExchanges> GetStockExchanges()
        {
            var query = from obj in context.StockExchanges
                        select obj;
              return query.ToList();
            throw new NotImplementedException();
        }
    }
}
