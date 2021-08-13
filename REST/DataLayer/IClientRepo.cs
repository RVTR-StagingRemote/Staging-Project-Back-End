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
    }
}
