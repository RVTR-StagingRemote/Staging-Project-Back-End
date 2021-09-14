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
        /// place an order for a given customer
        /// </summary>
        /// <param name="order"></param>
        /// <returns> Orders object</returns>
        public Task<Orders> PlaceOrder(Orders order);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of orders</returns>
        public Task<List<Orders>> GetOrders();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Orders> GetOrdersById(int Id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public Task<Orders> UpdateOrders( Orders order);

        public Task<Orders> DeleteOrderById(int OrderId);

        public Task<List<Orders>> GetOrdersByClientId(int ClientId);
    }
}
