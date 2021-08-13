using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class RepoDB : IRepository
    {
        private readonly BatchesDBContext _context;
        public RepoDB(BatchesDBContext context) {
            _context = context;
        }
        public async Task<Clients> AddClient(Clients client)
        {
           await _context.Clients.AddAsync(client);
           await  _context.SaveChangesAsync();

            return client;
        }

        public async Task<Courses> AddCourse(Courses course)
        {
            await _context.Courses.AddAsync(course);
            await  _context.SaveChangesAsync();
            return course;
        }

        public Task<Orders> PlaceOrder(Clients client, OrderDetails orderDetails)
        {
            throw new NotImplementedException();
        }

        public async  Task<Topics> AddTopic(Topics topics)
        {
            await _context.Topics.AddAsync(topics);
           await  _context.SaveChangesAsync();
            return topics;
        }

        public async Task<List<Orders>> GetAOrders()
        {
            return await _context.Orders.AsNoTracking().Select(order => order).ToListAsync();
        }

        public async Task<List<Clients>> GetClients()
        {
            return await _context.Clients.AsNoTracking().Select(cl => cl).ToListAsync();
        }

        public async Task<List<Courses>> GetCourses()
        {
            return await _context.Courses.AsNoTracking().Select(c => c).ToListAsync();
        }

        public async Task<List<Topics>> GetTopics()
        {
            return await _context.Topics.AsNoTracking().Select(tp => tp).ToListAsync();
        }
    }
}
