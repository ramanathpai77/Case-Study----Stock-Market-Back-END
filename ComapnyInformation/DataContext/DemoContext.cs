using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComapnyInformation.Entity;
namespace ComapnyInformation.DataContext
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }

        public DbSet<IPOs> IPOS { get; set; }

     
    }
}
