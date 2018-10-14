using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}