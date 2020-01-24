using Keukenhof.Data;
using Keukenhof.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WebXUnitTest
{
    public class WebUnitDBTest : Controller
    {
        private readonly ApplicationDbContext _context;

        public WebUnitDBTest(ApplicationDbContext context)
        {
            _context = context;
        }

        [Fact]
        public void TestDB()
        {
            ApplicationDbContext context = GetInMemoryDBWithData();


        }

        private ApplicationDbContext GetInMemoryDBWithData()
        {
            ApplicationDbContext context = GetNewInMemoryDB();
            context.Add(new Event { Id = 1, Naam = "Een event", Beschrijving = "Een heel leuke event", Datum = new DateTime(2020, 5, 5, 10, 0, 0) });
            context.Add(new Event { Id = 2, Naam = "Een andere event", Beschrijving = "Een andere leuke event", Datum = new DateTime(2020, 5, 6, 10, 0, 0) });
            context.SaveChanges();
            return context;
        }


        private ApplicationDbContext GetNewInMemoryDB()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}
