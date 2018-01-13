using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGPWeb;
using AGPWeb.Controllers;

namespace AGPWeb.Tests.Controllers
{
    [TestClass]
    public class ProjectControllerTest
    {
        public void Title()
        {
            //Arrange
            ProjectController controller = new ProjectController();

            //Act
            ViewResult result = controller.Title() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
