using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
        // not sure where to place this method 
        // public ActionResult Index()
        // {
        //     return new EmptyResult();
        // }
        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            //Arrange
            HomeController controller = new HomeController();
            ViewResult indexView = controller.Index() as ViewResult;
            // can be refactored to the below
            // ViewResult indexView = new HomeController().Index() as ViewResult;


            //Act
            ViewResult result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Item>));
            // the above should pass, needs to be "fixed" to fail first
        }
    }
}