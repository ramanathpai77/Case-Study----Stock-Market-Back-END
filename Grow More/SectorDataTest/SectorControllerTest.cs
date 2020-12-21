using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using SectorData.Controllers;
using SectorData.DataContext;
using SectorData.Domain.Interfaces;
using SectorData.Domain.Repository;
using SectorData.Domain.Services;
using SectorData.Entities;

namespace SectorDataTest
{
    [TestFixture]
    public class SectorControllerTest
    {
        SectorController sector;
        [OneTimeSetUp]
        public void Initialize()
        {
           IConfiguration ObjConfiguration = new ConfigurationBuilder()
                                               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                               .AddJsonFile("appsettings.json")
                                               .Build();
            string str = ObjConfiguration.GetConnectionString("Constr");
            DbContextOptions<SectorContext> options = new DbContextOptionsBuilder<SectorContext>().UseSqlServer(str).Options;
            SectorContext ObjContext = new SectorContext(options);
            ISectorRepository ObjRepository = new SectorRepository(ObjContext);


            ISectorService ObjService = new SectorService(ObjRepository);
           sector = new SectorController(ObjService);
        }
        [Test]
        public void GetSectorTest()
        {

            var Result = sector.GetSectors() as ObjectResult;
            Assert.AreEqual(200, Result.StatusCode.Value);
        }
        [Test]
        public void SectoreTest_sector()
        {

            var Result = sector.GetSectors() as ObjectResult;
            Assert.IsInstanceOf<IEnumerable<Sector>>(Result.Value);

        }

    }
}
