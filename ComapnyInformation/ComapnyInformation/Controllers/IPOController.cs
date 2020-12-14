using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComapnyInformation.Entities;
using ComapnyInformation.Domain.Interfaces;

namespace ComapnyInformation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IPOController : Controller
    {
        readonly IIPOsService service;
        public IPOController (IIPOsService service)
        {
            this.service = service;
        }
        public IActionResult GetAllIpos()
        {
            var ipos = service.getCompanyIPODetails();
            return Ok(ipos);
        }
        [HttpPost]
        public IActionResult AddIpos(IPOs i)
        {
            service.AddIPO(i);
            
            return Ok();
        }

    }
}
