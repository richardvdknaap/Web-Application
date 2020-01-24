using WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace WebXUnitTest
{
    public class WebUnitTest
    {

        [Fact]
        public void TestIfAccessibilityIndexIsView()
        {
            AccessibilityController accessibilityController = new AccessibilityController();
            var result = accessibilityController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestIfAccessibilityIndexIsRedirect()
        {
            AccessibilityController accessibilityController = new AccessibilityController();
            var result = accessibilityController.Index();

            var viewResult = Assert.IsType<RedirectResult>(result);
        }

        [Fact]
        public void TestIfHomeIndexIsViewResult()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestHomeAbout()
        {
            HomeController homeController = new HomeController();
            var result = homeController.About();

            var viewResult = Assert.IsType<ViewResult>(result);

            var message = viewResult.ViewData["Message"];
            Assert.Equal("Your application description page.", message);
        }

        [Fact]
        public void TestHomeContact()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Contact();

            var viewResult = Assert.IsType<ViewResult>(result);

            var message = viewResult.ViewData["Message"];
            Assert.Equal("Your contact page.", message);
        }

        [Fact]
        public void TestHomePrivacy()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Privacy();

            var viewResult = Assert.IsType<ViewResult>(result);

            var message = viewResult.ViewData["Title"];
            Assert.Equal("Privacy Policy", message);
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
