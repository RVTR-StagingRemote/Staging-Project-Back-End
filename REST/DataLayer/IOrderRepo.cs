﻿using REST.Models;
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
        /// get a list of all orders in the database
        /// </summary>
        /// <returns>list of orders</returns>
        public Task<List<Orders>> GetOrders();

        /// <summary>
        /// get an order from the database by order id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Orders object</returns>
        public Task<Orders> GetOrdersById(int Id);

        /// <summary>
        /// updates an order in the database
        /// </summary>
        /// <param name="order"></param>
        /// <returns>updates an order in database or null if no such object exists</returns>
        public Task<Orders> UpdateOrders( Orders order);

        /// <summary>
        /// deletes an order from the database by order id
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns>Orders object</returns>
        public Task<Orders> DeleteOrderById(int OrderId);

        /// <summary>
        /// get all orders place by a specific client by client id
        /// </summary>
        /// <param name="ClientId"></param>
        /// <returns>list of orders</returns>
        public Task<List<Orders>> GetOrdersByClientId(int ClientId);
    }
}
