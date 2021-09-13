using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface IClientRepo
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
         /// 
         /// </summary>
         /// <param name="client"></param>
         /// <returns></returns>
        public Task<Clients> UpdateClients(Clients client);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Clients> GetClientsById(int id);

        public Task<Clients> DeleteClientById(int ClientId);
    }
}
