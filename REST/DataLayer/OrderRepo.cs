﻿using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class OrderRepo : IOrderRepo
    {
        private readonly BatchesDBContext _context;
        public OrderRepo(BatchesDBContext context)
        {
            _context = context;
        }

        public async Task<List<Orders>> GetOrders()
        {
            return await _context.Orders.AsNoTracking().Select(order => order).ToListAsync();
        }

        public async Task<Orders> PlaceOrder(Orders order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return order;
        }

        public async Task<Orders> GetOrdersById(int Id)
        {
            return await _context.Orders.AsNoTracking().Include(o => o.OrderDetails).SingleOrDefaultAsync(o => o.OrderId == Id);
        }

        public async Task<Orders> UpdateOrders(Orders order)
        {
            if (_context.Orders.Where(o => o.OrderId == order.OrderId).Select(x => x).Count() == 1) // id exists
            {
                _context.Orders.Update(order);
                await _context.SaveChangesAsync();
                return order;
            }
            return null;
        }

        public async Task<Orders> DeleteOrderById(int OrderId)
        {
            Orders order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == OrderId);
            OrderDetails orderDetails = _context.OrderDetails.FirstOrDefault(o => o.DetailsId == OrderId);
            if(order != null)
            {
                if (orderDetails != null)
                    _context.OrderDetails.Remove(orderDetails);
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }

            return order;
        }

        public async Task<List<Orders>> GetOrdersByClientId(int ClientId)
        {
            return await _context.Orders.AsNoTracking().Include(o => o.OrderDetails).Select(order => order).Where(o => o.ClientId == ClientId).ToListAsync();
        }

    }
}
