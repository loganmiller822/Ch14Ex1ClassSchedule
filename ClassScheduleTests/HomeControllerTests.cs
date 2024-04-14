using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ClassSchedule.Controllers;
using ClassSchedule.Models;

namespace ClassScheduleTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var mockUnitOfWork = new Mock<IClassScheduleUnitOfWork>();
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var controller = new HomeController(mockUnitOfWork.Object, mockHttpContextAccessor.Object);

            var result = controller.Index(0);

            Assert.IsType<ViewResult>(result);
        }
    }
}
