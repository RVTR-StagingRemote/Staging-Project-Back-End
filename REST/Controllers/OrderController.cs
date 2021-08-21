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
    public async Task<IActionResult> GetAOrdersById(int id)
    {
            // TODO implement
            Orders order = await _orderBL.GetAOrdersById(id);

            if (order == null) return NotFound();
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
    public async Task< IActionResult> UpdateOrder(Orders order)
    {
            // TODO implement

            await _orderBL.UpdateOrders(order);

            return NoContent();
    }

    ///<summary>
    ///Delete a order based on a given ID
    ///</summary>
    ///<param name="id"></param>
    [HttpDelete]
    public async Task <IActionResult> DeleteOrder(int Id)
    {
            // TODO implement
            

            throw new NotImplementedException();
        }

  }
}
