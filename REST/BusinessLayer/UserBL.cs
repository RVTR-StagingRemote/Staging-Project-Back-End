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
        private readonly IUserRepo _userRepo;
        public UserBL(IUserRepo userrepo)
        {
            _userRepo = userrepo;
        }
        public async Task<User> AddUser(User u)
        {
           return await _userRepo.AddUser(u);
        }

        public async Task<User> DoLogin(string email, string pwd)
        {
            return await _userRepo.DoLogin(email, pwd);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepo.GetUsers();
        }

        public async Task<User> Update(User u)
        {
            return await _userRepo.UpdateUser(u);
        }

        public async Task<User> FindUserById(int id)
        {
            return await _userRepo.FindUserById(id);
        }

        public async Task<User> DeleteUserById(int id)
        {
            return await _userRepo.DeleteUserById(id);
        }
    }
}
