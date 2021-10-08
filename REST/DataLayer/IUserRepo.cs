using REST.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public interface IUserRepo
    {
        /// <summary>
        /// add a new user to the database
        /// </summary>
        /// <param name="u"></param>
        /// <returns>User object</returns>
        Task<User> AddUser(User u);

        /// <summary>
        /// finds the user with matching email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <returns>User object</returns>
        Task<User> DoLogin(string email, string pwd);

        /// <summary>
        /// updates a user's info in the database
        /// </summary>
        /// <param name="u"></param>
        /// <returns>User object</returns>
        Task<User> UpdateUser(User u);

        /// <summary>
        /// gets a list of all users in database
        /// </summary>
        /// <returns>List of users</returns>
        Task<List<User>> GetUsers();

        /// <summary>
        /// finds a user by user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User object</returns>
        Task<User> FindUserById(int id);

        /// <summary>
        /// deletes a user from the database by user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User object</returns>
        Task<User> DeleteUserById(int id);

    }
}