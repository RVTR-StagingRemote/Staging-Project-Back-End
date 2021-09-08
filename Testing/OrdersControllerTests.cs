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
    public class OrdersControllerTests
    {
        Mock<IOrderBL> mockRepo;
        public OrdersControllerTests()
        {
            mockRepo = new Mock<IOrderBL>();
        }

        [Fact]
        public void GetOrdersReturnsOkObjectResult()
        {
            mockRepo.Setup(x => x.GetOrders()).ReturnsAsync(new List<Orders>());
            var controller = new OrderController(mockRepo.Object);

            var response = controller.GetOrders();
            var result = response.Result;

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void CreateOrderReturnsCreatedResult()
        {
            mockRepo.Setup(x => x.PlaceOrder(It.IsAny<Orders>())).ReturnsAsync(new Orders());
            var controller = new OrderController(mockRepo.Object);

            var response = controller.CreateOrder(new Orders());
            var result = response.Result;

            Assert.IsType<CreatedResult>(result);
        }
    }
}