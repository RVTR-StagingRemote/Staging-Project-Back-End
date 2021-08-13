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
        /// <param name="c"></param>
        /// <param name="od"></param>
        /// <returns></returns>
        Task<Orders> PlaceOrder(Clients c, OrderDetails od);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Orders>> GetOrders();
    }
}
