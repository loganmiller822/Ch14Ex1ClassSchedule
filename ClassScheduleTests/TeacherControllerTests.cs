namespace ClassScheduleTests;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;
using Microsoft.AspNetCore.Http;

public class TeacherControllerTests
{
    [Fact]
    public void IndexActionMethod_ReturnsAViewResult()
    {
        // Arrange
        var mockRepository = new Mock<IRepository<Teacher>>();
        var controller = new TeacherController(mockRepository.Object);

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }
}