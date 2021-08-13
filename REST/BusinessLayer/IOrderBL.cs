using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IOrderBL
    {
        Task<Orders> PlaceOrder(Clients c, OrderDetails od);

        Task<List<Orders>> GetOrders();
    }
}
