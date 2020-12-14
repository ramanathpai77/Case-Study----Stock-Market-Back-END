using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComapnyInformation.Entities;


namespace ComapnyInformation.DataContext
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }
        public DbSet<Company> Company { get; set; }

        public DbSet<IPOs> IPOs { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<StockExchange> StockExchange { get; set; }
        public DbSet<StockPrice> StockPrice { get; set; }



    }
}
