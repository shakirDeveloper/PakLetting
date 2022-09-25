using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PakLetting.Web;
using PakLetting.Web.Controllers;
using PakLetting.BLL.SeekerManager;
using PakLetting.Model.SeekerModels;

namespace PakLetting.Web.Tests.Controllers
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
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddSeeker()
        {
            // Arrange
            HomeController controller = new HomeController();

            SaveSeekerManager newSeeker = new SaveSeekerManager();
            Seeker seeker = newSeeker.SaveSeeker(new Guid(), "shakir", "123456789", "shakir@gmail.com", Convert.ToDateTime("1/1/2001"), "test discription");

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void UpdateSeeker()
        {
            // Arrange
            HomeController controller = new HomeController();

            SaveSeekerManager updateSeeker = new SaveSeekerManager();
            Seeker seeker = updateSeeker.SaveSeeker(2,new Guid(), "hero", "+353831974743", "shakir@gmail.com", Convert.ToDateTime("1/1/1986"), "test discription");

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetSeeker()
        {
            // Arrange
            HomeController controller = new HomeController();

            GetSeekerManager getSeeker = new GetSeekerManager();
            ICollection<Seeker> seeker = getSeeker.GetAllCreator();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteSeeker()
        {
            // Arrange
            HomeController controller = new HomeController();

            DeleteSeekerManager deleteSeeker = new DeleteSeekerManager();
            bool isDeleted = deleteSeeker.DeleteSeeker(3);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
