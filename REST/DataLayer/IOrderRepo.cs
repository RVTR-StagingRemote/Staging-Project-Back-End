using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface IOrderRepo
    {
      
       

        /// <summary>
        /// place order for a given costumer
        /// </summary>
        /// <param name="client"></param>
        /// <param name="orderDetails"></param>
        /// <returns>Orders object</returns>
        public Task<Orders> PlaceOrder(Clients client, OrderDetails orderDetails);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of orders</returns>
        public Task<List<Orders>> GetAOrders();
    }
}
