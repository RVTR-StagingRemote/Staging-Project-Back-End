using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class UserRepo:IUserRepo
    {
        private readonly BatchesDBContext _context;
        public UserRepo(BatchesDBContext context)
        {
            this._context = context;

        }

        public async Task<User> AddUser(User u)
        {
            await _context.Users.AddAsync(u);
            await _context.SaveChangesAsync();
            return u;
        }

        public  async Task<User> DoLogin(string email, string pwd)
        {
            return await _context.Users.FirstOrDefaultAsync(c =>  c.Email == email&& c.Password == pwd);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.AsNoTracking().Select(u => u).ToListAsync();
        }

        public async Task<User> UpdateUser(User u)
        {
             _context.Users.Update(u);
            await _context.SaveChangesAsync();
            return u;
        }
    }
}
