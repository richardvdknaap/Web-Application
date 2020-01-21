using Keukenhof.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace WebXUnitTest
{
    public class WebUnitTest
    {
        [Fact]
        public void TestIfIndexIsViewResult()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            Console.ReadKey(true);
        }

        [Fact]
        public void TestIfIndexIsNotRedirect()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();

            var viewResult = Assert.IsType<RedirectResult>(result);
            Console.ReadKey(true);
        }

        [Fact]
        public void TestIfHetParkIsView()
        {
            HetParkController hetParkController = new HetParkController();
            var result = hetParkController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            Console.ReadKey(true);
        }

        [Fact]
        public void TestIfHetParkIsNotRedirect()
        {
            HetParkController hetParkController = new HetParkController();
            var result = hetParkController.Index();

            var viewResult = Assert.IsType<RedirectResult>(result);
            Console.ReadKey(true);
        }
    }
}
