using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CBA.Store.Web;
using CBA.Store.Web.Controllers;

namespace CBA.Store.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _controller;

        [TestInitialize]
        public void SetupForTest()
        {
            _controller = new HomeController();
        }

        [TestMethod]
        public void Index()
        {
            ViewResult result = _controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
