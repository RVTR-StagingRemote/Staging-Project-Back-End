using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using REST.BusinessLayer;
using REST.Controllers;
using REST.DataLayer;
using REST.Models;
using Xunit;

namespace Testing
{
    public class ControllerTests
    {
        [Fact]
        public void GetReturnsCourses()
        {
            var mockRepo = new Mock<ICourseBL>();
            mockRepo.Setup(x => x.GetCourses()).ReturnsAsync(new List<Courses>());

            var controller = new CourseController(mockRepo.Object);
            var response = controller.Courses();
            var result = response.Result;
            

            Assert.IsType<OkObjectResult>(result);
        }
    }
}