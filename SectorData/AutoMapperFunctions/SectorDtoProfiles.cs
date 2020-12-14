using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SectorData.Dtos;
using SectorData.Entities;


namespace SectorData.AutoMapperFunctions
{
    public class SectorDtoProfiles :Profile
    {
        public SectorDtoProfiles()
        {
            CreateMap <Sector, SectorDto>().ReverseMap();
        }

    }
}
