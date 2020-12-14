using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using StockExchange.Controllers;
using StockExchange.DataContext;
using StockExchange.Domain.Interfaces;
using StockExchange.Domain.Repository;
using StockExchange.Domain.Services;
using StockExchange.Entities;

namespace StockExchangeTest
{
    [TestFixture]
    public class StockExchangeControllerTest
    {
        StockExchangeController Se;
        [OneTimeSetUp]
        public void Initialize()
        {
            IConfiguration ObjConfiguration = new ConfigurationBuilder()
                                               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                               .AddJsonFile("appsettings.json")
                                               .Build();
            string str = ObjConfiguration.GetConnectionString("Constr");
            DbContextOptions<SEContext> options = new DbContextOptionsBuilder<SEContext>().UseSqlServer(str).Options;
            SEContext ObjContext = new SEContext(options);
            ISERepository ObjRepository = new SERepository(ObjContext);
           

            ISEServices ObjService = new SEServices(ObjRepository);
            Se = new StockExchangeController(ObjService);
        }
        [Test]
        public void GetStockExchangeTest()
        {
            
            var Result = Se.GetStockExchanges() as ObjectResult;
            Assert.AreEqual(200, Result.StatusCode.Value);
        }
        [Test]
        public void AddStockExchangeTest()
        {

            var Result = Se.GetStockExchanges() as ObjectResult;
            Assert.IsInstanceOf<IEnumerable<StockExchanges>>(Result.Value);
            
        }
        
    }
}
