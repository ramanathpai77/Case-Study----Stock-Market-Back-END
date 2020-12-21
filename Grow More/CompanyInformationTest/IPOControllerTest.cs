using System;
using System.Collections.Generic;
using System.Text;
using ComapnyInformation.Controllers;
using ComapnyInformation.DataContext;
using ComapnyInformation.Domain.Interfaces;
using ComapnyInformation.Domain.Repositories;
using ComapnyInformation.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace CompanyInformationTest
{
    [TestFixture]
    class IPOControllerTest
    {

        IPOController comp;
        [OneTimeSetUp]
        public void Initialize()
        {
            IConfiguration ObjConfiguration = new ConfigurationBuilder()
                                                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                                .AddJsonFile("appsettings.json")
                                                .Build();
            string str = ObjConfiguration.GetConnectionString("Constr");
            DbContextOptions<DemoContext> options = new DbContextOptionsBuilder<DemoContext>().UseSqlServer(str).Options;
            DemoContext ObjContext = new DemoContext(options);
            IIPOsRepository ObjRepository = new IPOsRepository(ObjContext);


            IIPOsService ObjService = new IPOsService(ObjRepository);
            comp = new IPOController(ObjService);

        }
        [Test]
        public void GetCompanyTest()
        {

            var Result = comp.GetAllIpos() as ObjectResult;
            Assert.AreEqual(200, Result.StatusCode.Value);
        }
        [Test]
        public void GetCompanyTest_comp()
        {

            var Result = comp.GetAllIpos() as ObjectResult;
            Assert.IsInstanceOf<IEnumerable<IPOs>>(Result.Value);

        }
    }
}
