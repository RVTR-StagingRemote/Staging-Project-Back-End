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
        Mock<ICourseBL> mockRepo;
        public ControllerTests()
        {
            mockRepo = new Mock<ICourseBL>();
        }

        [Fact]
        public void GetCoursesReturnsOkObjectResult()
        {
            mockRepo.Setup(x => x.GetCourses()).ReturnsAsync(new List<Courses>());
            var controller = new CourseController(mockRepo.Object);

            var response = controller.Courses();
            var result = response.Result;

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void FindCourseByIdReturnsOk()
        {
            mockRepo.Setup(x => x.FindCourseById(It.IsAny<int>())).ReturnsAsync(new Courses(){CourseId = 1,Description = "Test Course",CourseName = "Test"});
            var controller = new CourseController(mockRepo.Object);

            var response = controller.FindCourseById(1);
            var result = response.Result;

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void FindCourseByNameReturnsOk()
        {
            mockRepo.Setup(x => x.FindCourseByName("Test")).ReturnsAsync(new Courses(){CourseId = 1,Description = "Test Course",CourseName = "Test"});
            var controller = new CourseController(mockRepo.Object);

            var response = controller.FindCourseByName("Test");
            var result = response.Result;

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddCourseReturnsCreated()
        {
            Courses course = new Courses(){CourseId = 1,CourseName = "Test", Description = "Test Course"};
            mockRepo.Setup(x => x.AddCourse(It.IsAny<Courses>()));
            var controller = new CourseController(mockRepo.Object);

            var response = controller.CreateCourse(course);
            var result = response.Result;

            Assert.IsType<CreatedResult>(result);
        }

    }
}