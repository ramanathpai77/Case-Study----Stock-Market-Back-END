using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SectorData.DataContext;
using SectorData.Domain.Interfaces;
using SectorData.Entities;

namespace SectorData.Domain.Repository
{
    public class SectorRepository : ISectorRepository
    {
        readonly SectorContext context;
        public SectorRepository(SectorContext context)
        {
            this.context = context;
        }
        public IEnumerable<Sector> getAllSectors()
        {
            var query = from obj in context.Sector
                        orderby obj.SectorName
                        select obj;
            
            return query.ToList();
           
            throw new NotImplementedException();
        }
        public bool AddSectors(Sector s)
        {
            context.Sector.Add(s);
            int RowsAdded = context.SaveChanges();
            return RowsAdded > 0;
        }

        public IEnumerable< Company> getCompanies(string name)
        {
           
            var query=from x in context.Sector
                      join y in context.Company
                      on x.SectorId equals y.SectorId
                      where x.SectorName == name
                      select y;
            return query.ToList();
            throw new NotImplementedException();
        }

    }
}
