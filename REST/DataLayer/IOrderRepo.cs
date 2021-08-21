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
        /// place order for a given costumer
        /// </summary>
        /// <param name="client"></param>
        /// <param name="OrderItems"></param>
        /// <returns>Orders object</returns>
        public Task<Orders> PlaceOrder(Orders order);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of orders</returns>
        public Task<List<Orders>> GetAOrders();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Orders> GetAOrdersById(int Id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public Task<Orders> UpdateOrders( Orders order);
    }
}
