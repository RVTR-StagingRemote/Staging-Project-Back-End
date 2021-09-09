using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST.BusinessLayer;
using REST.DataLayer;
using REST.Models;

namespace REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderBL _orderBL;
        public OrderController(IOrderBL orderBL)
        {
            _orderBL = orderBL;
        }

        ///<summary>
        ///Returns all orders as a List
        ///</summary>
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            return Ok(await _orderBL.GetOrders());
        }

        ///<summary>
        ///Returns a single order based on an ID
        ///</summary>
        ///<param name="id"></param>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrdersById(int id)
        {
            Orders order = await _orderBL.GetOrdersById(id);
            if(order == null) return NotFound();
            return Ok(order);
        }

        ///<summary>
        ///Creates a new order based on the order object given
        ///</summary>
        ///<param name="clients"></param>
        ///<param name="orderDetails"></param>
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Orders order)
        {
            return Created("api", await _orderBL.PlaceOrder(order));
        }

        ///<summary>
        ///update a order based on the order object given
        ///</summary>
        ///<param name="order"></param>
        [HttpPut]
        public async Task<IActionResult> UpdateOrder(Orders order)
        {
            Orders orderToUpdate = await _orderBL.UpdateOrders(order);
            if (orderToUpdate == null) return NotFound();
            return NoContent();
        }

        ///<summary>
        ///Delete a order based on a given ID
        ///</summary>
        ///<param name="id"></param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            Orders order = await _orderBL.DeleteOrderById(id);
            if(order == null) return NotFound();
            return Ok(order);
        }

    }
}
