using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KitchenPlan.Controllers;
using System.Web.Mvc;

namespace KitchenPlan.Test
{

    [TestClass]
    public class MeControllerTests
    {

        [TestMethod]
        public void Bio_Should_Return_A_View_With_A_Title()
        {
            //Arrange
            var cntrl = new MeController();

            //Act
            var result = cntrl.Bio();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var view = result as ViewResult;
            Assert.AreEqual("About Me", view.ViewBag.Title);
        }
        [TestMethod]
        public void Headshot_Should_Return_A_View_With_A_Title()
        {
            //Arrange
            var cntrl = new MeController();

            //Act
            var result = cntrl.Headshot();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var view = result as ViewResult;
            Assert.AreEqual("About Me", view.ViewBag.Title);
        }
    }
}
