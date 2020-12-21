using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ComapnyInformation.Domain.Interfaces;
using ComapnyInformation.Entities;

namespace ComapnyInformation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        readonly ICompanyService service;
        
        public CompanyController(ICompanyService _service)
        {
            service = _service;
        }
        [HttpGet]
        public IActionResult GetCompanies()
        {
            var Comp = service.GetAllCompanies();
            return Ok( Comp );
            throw new Exception();
        }
        [HttpGet("{comp}")]

        public IActionResult GetCompany(string comp)
        {
            var Comp = service.GetCompany(comp);
            return Ok(Comp);
            throw new Exception();
        }
       
        [HttpGet("StockPrice/{ccode}")]
        public IActionResult GetStockPrice(string ccode)
        {
            var q = service.GetStockPrice(ccode);
            return Ok(q);
        }
        [HttpPost]
        public IActionResult AddCompany(Company C)
        {
            var a = service.AddCompany(C);
            return Ok();
        }
        [HttpPost("StockPrice")]
        public IActionResult AddStockPrice(StockPrice sp)
        {
            var a=service.AddStockPrice(sp);

            return Ok();
        }
    }
}
