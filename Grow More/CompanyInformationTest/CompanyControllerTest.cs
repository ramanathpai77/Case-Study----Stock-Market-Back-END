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
    class CompanyControllerTest
    {
        CompanyController comp;
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
            ICompanyRepository ObjRepository = new CompanyRepository(ObjContext);


            ICompanyService ObjService = new CompanyService(ObjRepository);
            comp = new CompanyController(ObjService);

        }
        [Test]
        public void GetCompanyTest()
        {

            var Result = comp.GetCompanies() as ObjectResult;
            Assert.AreEqual(200, Result.StatusCode.Value);
        }
        [Test]
        public void GetCompanyTest_comp()
        {

            var Result = comp.GetCompanies() as ObjectResult;
            Assert.IsInstanceOf<IEnumerable<Company>>(Result.Value);

        }
    }
}
