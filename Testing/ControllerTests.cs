using System;
using Xunit;

namespace Testing
{
    public class ControllerTests
    {
        [Fact]
        public void GetReturnsCourses()
        {
            var mockRepo = new Mock<ICourseRepository>();
        }
    }
}