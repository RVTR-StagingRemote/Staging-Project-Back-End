using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IOrderBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ClientId"></param>
        /// <param name="OrderItems"></param>
        /// <returns></returns>
        Task<Orders> PlaceOrder(Orders order);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Orders>> GetOrders();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
         Task<Orders> GetOrdersById(int Id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public Task<Orders> UpdateOrders(Orders order);

        public Task<Orders> DeleteOrderById(int OrderId);
    }
}
