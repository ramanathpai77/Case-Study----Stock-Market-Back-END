using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SectorData.Domain.Interfaces;

namespace SectorData.Controllers
{
    [Route("/companybysector")]
    [ApiController]
    public class FindCompaniesController : ControllerBase
    {
       
       
            readonly ISectorService service;
            public FindCompaniesController(ISectorService service)
            {
                this.service = service;
            }

            [HttpGet("{Sname}")]
            public IActionResult GetCompanies(string Sname)
            {
                try
                {
                    var data = service.getCompanies(Sname);
                    return Ok(data);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }

