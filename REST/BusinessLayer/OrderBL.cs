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
        private readonly IClientBL _clientRepo;
        public OrderBL(IOrderRepo orderRepo, IClientBL clientRepo)
        {
            _orderRepo = orderRepo;
            _clientRepo = clientRepo;
        }

        public async Task<Orders> PlaceOrder(Orders order)
        {
            //Clients cl = await _clientRepo.GetClientsById(ClientId);
            //Orders order = new Orders();
            order.OrderName = buildCode();
            //order.Clients = cl;
            //order.OrderDetails = OrderItems;
            return await _orderRepo.PlaceOrder(order);
        }

        public static string buildCode()
       {
           string temp = DateTime.Now.ToString();
           return temp.Substring(0, 17).Replace("/", "").Replace(":", "").Replace(" ", "");
       }

        public async Task<List<Orders>> GetOrders()
        {
            return await _orderRepo.GetAOrders();
        }

        public async Task<Orders> GetAOrdersById(int Id)
        {
            return await _orderRepo.GetAOrdersById(Id);
        }
    }
}
