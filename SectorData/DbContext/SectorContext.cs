using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SectorData.Entities;
namespace SectorData.DataContext
{
    public class SectorContext : DbContext
    {
        public SectorContext(DbContextOptions<SectorContext> options) : base(options)
        {

        }
        public DbSet<Company> Company { get; set; }

        public DbSet<Sector> Sector { get; set; }


    }
}
