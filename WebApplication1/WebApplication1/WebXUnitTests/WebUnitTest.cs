using WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace WebXUnitTest
{
    public class WebUnitTest
    {
        [Fact]
        public void TestIfHomeIndexIsViewResult()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestIfHomeIndexIsRedirect()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();

            var viewResult = Assert.IsType<RedirectResult>(result);
        }

        [Fact]
        public void TestIfInfoIndexIsView()
        {
            InfoController infoController = new InfoController();
            var result = infoController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestIfInfoIndexIsRedirect()
        {
            InfoController infoController = new InfoController();
            var result = infoController.Index();

            var viewResult = Assert.IsType<RedirectResult>(result);
        }
    }
}
