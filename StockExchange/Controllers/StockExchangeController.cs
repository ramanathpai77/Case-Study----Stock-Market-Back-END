using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Domain.Interfaces;
using StockExchange.Entities;

namespace StockExchange.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StockExchangeController : Controller
    {
        readonly ISEServices service;
        public StockExchangeController(ISEServices service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetStockExchanges()
        {
            var a=service.GetStockExchanges();
            return Ok(a);
        }
        [HttpPost]
        public IActionResult AddStockExchanges(StockExchanges se)
        {
             service.AddStockExchange(se);
            return Ok();
        }
        [HttpGet("{se}")]
        public IActionResult GetCompanies(int se)
        {
            var a = service.GetCompanies(se);
            return Ok(a);
        }
    }
}
