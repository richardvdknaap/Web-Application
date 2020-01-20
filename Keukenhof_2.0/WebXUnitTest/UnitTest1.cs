using Keukenhof_2._0.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace WebXUnitTest
{
    public class UnitTest1
    {
        private HomeController _homeController;
        
        public UnitTest1()
        {
            _homeController = new HomeController();
        }

        [Fact]
        public void IndexActionReturnsIndexView()
        {
            var result = _homeController.Index() as ViewResult;
            Assert.Equal("Index", result.ViewName);
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
