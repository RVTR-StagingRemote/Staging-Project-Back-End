using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class OrderBL:IOrderBL
    {
        private readonly IOrderRepo _orderRepo;
        public OrderBL(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public async Task<Orders> PlaceOrder(Clients c, OrderDetails od)
        {
            return await _orderRepo.PlaceOrder(c,od);
        }

        public async Task<List<Orders>> GetOrders()
        {
            return await _orderRepo.GetAOrders();
        }
    }
}
