using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemberManager;
using MemberManager.Controllers;
using FluentAssertions;

namespace MemberManager.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            result.Should().NotBe(null);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
