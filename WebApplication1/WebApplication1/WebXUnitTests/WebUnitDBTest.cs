using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
using WebApplication1.Controllers;

namespace WebXUnitTest
{
    public class WebUnitDBTest : Controller
    {

        private string databaseName;

        private readonly ApplicationDbContext _context;

        public WebUnitDBTest(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [Fact]
        public void TestIfEventsIndexIsView()
        {
            EventsController eventsController = new EventsController(_context);

            var result = eventsController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        private ApplicationDbContext GetInMemoryDBWithData()
        {
            ApplicationDbContext context = GetNewInMemoryDB(true);
            context.Add(new Event { Id = 1, Naam = "Een event", Beschrijving = "Een heel leuke event", Datum = new DateTime(2020, 5, 5, 10, 0, 0) });
            context.Add(new Event { Id = 2, Naam = "Een andere event", Beschrijving = "Een andere leuke event", Datum = new DateTime(2020, 5, 6, 10, 0, 0) });
            context.SaveChanges();
            return GetNewInMemoryDB(false);
        }


        private ApplicationDbContext GetNewInMemoryDB(bool NewDb)
        {
            if (NewDb) this.databaseName = Guid.NewGuid().ToString();


            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}
