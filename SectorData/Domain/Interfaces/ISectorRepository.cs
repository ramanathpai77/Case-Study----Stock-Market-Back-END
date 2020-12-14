using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SectorData.Entities;

namespace SectorData.Domain.Interfaces
{
    public interface ISectorRepository
    {
        public IEnumerable<Company> getCompanies(string name);
        public IEnumerable<Sector> getAllSectors();
        public bool AddSectors(Sector s);
    }
}
