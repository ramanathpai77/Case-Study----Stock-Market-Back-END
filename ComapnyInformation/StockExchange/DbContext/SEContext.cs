using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Entities;
using Microsoft.EntityFrameworkCore;

namespace StockExchange.DataContext
{
    public class SEContext : DbContext
    {
        public SEContext(DbContextOptions<SEContext> options) : base(options)
        {

        }
        public DbSet<Company> Company { get; set; }
        public DbSet<StockExchanges> StockExchanges { get; set; }
    }
}
