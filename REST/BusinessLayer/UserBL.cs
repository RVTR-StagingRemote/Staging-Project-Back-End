using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class UserBL : IUserBL
    {
        private readonly IUserRepo userRepo;
        public Task<User> AddUser(User u)
        {
           return userRepo.AddUser(u);
        }

        public Task<User> DoLogin(string email, string pwd)
        {
            return userRepo.DoLogin(email, pwd);
        }

        public Task<List<User>> GetUsers()
        {
            return userRepo.GetUsers();
        }

        public Task<User> Update(User u)
        {
            return userRepo.UpdateUser(u);
        }
    }
}
