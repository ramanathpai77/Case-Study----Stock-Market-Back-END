using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SectorData.Domain.Interfaces;
using SectorData.Entities;

namespace SectorData.Domain.Services
{
    public class SectorService : ISectorService
    {
        readonly ISectorRepository repo;
        readonly IMapper mapper;
        public SectorService(ISectorRepository repo)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public bool AddSectors(Sector s)
        {
// var obj = mapper.Map<Sector>(s);
            bool ans = repo.AddSectors(s);
            return ans;

            throw new NotImplementedException();
        }

        public IEnumerable<Sector> getAllSectors()
        {
            var sec = repo.getAllSectors();
            return sec;
           
        }

        public IEnumerable<Company> getCompanies(string name)
        {
            var obj = repo.getCompanies(name);
            return obj;

            throw new NotImplementedException();
        }
    }
}
