using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface IRepository
    {
        /// <summary>
        /// add new client in the Database
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Clients</returns>
        public Task<Clients> AddClient(Clients client);

        /// <summary>
        /// return list of clients
        /// </summary>
        /// <returns></returns>
        public Task<List<Clients>> GetClients();

        /// <summary>
        /// add new course in the database
        /// </summary>
        /// <param name="course"></param>
        /// <returns>Courses</returns>
        public Task<Courses> AddCourse(Courses course);

        /// <summary>
        ///  
        /// </summary>
        /// <returns>course list</returns>
        public Task<List<Courses>> GetCourses();

        /// <summary>
        /// add new topic in the database
        /// </summary>
        /// <param name="topics"></param>
        /// <returns>Topics object</returns>
        public Task<Topics> AddTopic(Topics topics);

        /// <summary>
        ///   
        /// </summary>
        /// <returns>topics list</returns>
       public Task<List<Topics>> GetTopics();

        /// <summary>
        /// place order for a given costumer
        /// </summary>
        /// <param name="client"></param>
        /// <param name="orderDetails"></param>
        /// <returns>Orders object</returns>
        public Task<Orders> PlaceOrder(Clients client, OrderDetails orderDetails);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of orders</returns>
        public Task<List<Orders>> GetAOrders();
    }
}
