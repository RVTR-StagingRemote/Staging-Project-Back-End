using REST.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IUserBL
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
        /// <returns></returns>
        Task<User> DoLogin(string email, string pwd);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetUsers();

        Task<User> Update(User u);

        Task<User> FindUserById(int id);
        Task<User> DeleteUserById(int id);

    }
}