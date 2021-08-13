using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST.DataLayer;
using REST.Models;

namespace REST.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class OrderController : ControllerBase
  {
    private BatchesDBContext _context;

    public OrderController(BatchesDBContext context)
    {
      _context = context;
    }
    
    ///<summary>
    ///Returns all orders as a List
    ///</summary>
    [HttpGet]
    public IActionResult Orders()
    {
      var orders = _context.Orders.ToList();
      return Ok(orders);
    }

    ///<summary>
    ///Returns a single order based on an ID
    ///</summary>
    ///<param name="id"></param>
    [HttpGet("{id}")]
    public IActionResult Order(int id)
    {
      var order = _context.Orders.FirstOrDefault(c => c.OrderId == id);
      return Ok(order);
    }

    ///<summary>
    ///Creates a new order based on the order object given
    ///</summary>
    ///<param name="order"></param>
    [HttpPost]
    public IActionResult CreateOrder(Orders order)
    {
      var newOrder = new Orders {
        ClientId = order.ClientId
      };

      _context.Orders.Add(newOrder);
      _context.SaveChanges();

      return Ok("Order added!");
    }

    ///<summary>
    ///update a order based on the order object given
    ///</summary>
    ///<param name="order"></param>
    [HttpPut]
    public IActionResult Update(Orders order)
    {
      // TODO implement
      throw new NotImplementedException();
    }

    ///<summary>
    ///Delete a order based on a given ID
    ///</summary>
    ///<param name="id"></param>
    [HttpDelete]
    public IActionResult DeleteOrder(int id)
    {
      // TODO implement
      throw new NotImplementedException();
    }

  }
}
