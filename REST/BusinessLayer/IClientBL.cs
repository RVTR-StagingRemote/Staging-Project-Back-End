using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IClientBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        Task<Clients> AddClient(Clients client);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Clients>> GetClients();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Clients> GetClientsById(int Id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Task<Clients> UpdateClients(Clients client);

    }

}
