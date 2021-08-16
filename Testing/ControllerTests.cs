using System;
using Moq;
using REST.DataLayer;
using Xunit;

namespace Testing
{
    public class ControllerTests
    {
        [Fact]
        public void GetReturnsCourses()
        {
            var mockRepo = new Mock<ICourseRepo>();
        }
    }
}