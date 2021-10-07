using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class UserRepo : IUserRepo
    {
        private readonly BatchesDBContext _context;
        public UserRepo(BatchesDBContext context)
        {
            _context = context;

        }

        public async Task<User> AddUser(User u)
        {
            await _context.Users.AddAsync(u);
            await _context.SaveChangesAsync();
            return u;
        }

        public async Task<User> DoLogin(string email, string pwd)
        {
            return await _context.Users.FirstOrDefaultAsync(c => c.Email == email && c.Password == pwd);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.AsNoTracking().Select(u => u).ToListAsync();
        }

        public async Task<User> UpdateUser(User user)
        {
            if (_context.Users.Where(u => u.Id == user.Id).Select(x => x).Count() == 1) // id exists
            {
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return user;
            }
            return null;
        }

        public async Task<User> FindUserById(int id)
        {
            return await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<User> DeleteUserById(int id)
        {
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }
    }
}
