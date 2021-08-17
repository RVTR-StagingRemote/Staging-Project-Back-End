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
    public async Task<IActionResult> Orders()
    {      
      return Ok(await _orderBL.GetOrders());
    }

    ///<summary>
    ///Returns a single order based on an ID
    ///</summary>
    ///<param name="id"></param>
    [HttpGet("{id}")]
    public IActionResult Order(int id)
    {
      // TODO implement
      throw new NotImplementedException();
    }

    ///<summary>
    ///Creates a new order based on the order object given
    ///</summary>
    ///<param name="order"></param>
    [HttpPost]
    public async Task<IActionResult> CreateOrder(Clients c,OrderDetails od)
    {
      return Created("api", await _orderBL.PlaceOrder(c,od));
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
