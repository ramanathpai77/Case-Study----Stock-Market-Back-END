using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SectorData.Domain.Interfaces;
using SectorData.Entities;

namespace SectorData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        readonly ISectorService service;
        public SectorController(ISectorService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetSectors()
        {
            try
            {
                var data = service.getAllSectors();
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult AddSector(Sector sec)
            {
            bool a=service.AddSectors(sec);
            if (a==true)
            { return Ok(); }
            throw new Exception();
            }

        
    }
}
