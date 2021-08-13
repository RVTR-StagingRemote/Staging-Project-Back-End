using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public class OrderRepo:ICourseRepo
    {
        private readonly BatchesDBContext _context;
        public OrderRepo(BatchesDBContext context)
        {
            _context = context;
        }


        public Task<Orders> PlaceOrder(Clients client, OrderDetails orderDetails)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Orders>> GetAOrders()
        {
            return await _context.Orders.AsNoTracking().Select(order => order).ToListAsync();
        }



    }
}
