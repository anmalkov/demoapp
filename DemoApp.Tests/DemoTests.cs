using System;
using DemoApp.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoApp.Tests
{
    [TestClass]
    public class DemoTests
    {
        [TestMethod]
        public void Index_ActionResult_should_be_not_null()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About_ActionResult_should_be_not_null()
        {
            var controller = new HomeController();

            var result = controller.About();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact_ActionResult_should_be_not_null()
        {
            var controller = new HomeController();

            var result = controller.Contact();

            Assert.IsNotNull(result);
        }
    }
}
