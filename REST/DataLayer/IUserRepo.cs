using REST.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public interface IUserRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        Task<User> AddUser(User u);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <returns>User object</returns>
        Task<User> DoLogin(string email, string pwd);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <returns>User object</returns>
        Task<User> UpdateUser(User u);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Lis tof users</returns>

        Task<List<User>> GetUsers();

        Task<User> FindUserById(int id);
        Task<User> DeleteUserById(int id);

    }
}