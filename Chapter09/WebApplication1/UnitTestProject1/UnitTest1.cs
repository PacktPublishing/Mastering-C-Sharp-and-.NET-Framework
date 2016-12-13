using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHomeController()
        {
            HomeController ctl = new HomeController();
            ViewResult res = ctl.About() as ViewResult;
            Assert.AreEqual("About PACKT Publishing",
              (dynamic) res.Model.ToString());
        }
    }
}
