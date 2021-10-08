﻿using REST.Models;
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
        /// <returns>Client object</returns>
        public Task<Clients> AddClient(Clients client);

        /// <summary>
        /// get all the clients in the database
        /// </summary>
        /// <returns>List of clients</returns>
        public Task<List<Clients>> GetClients();

         /// <summary>
         /// updates a client's info in the database
         /// </summary>
         /// <param name="client"></param>
         /// <returns>Clients object or null if no object found</returns>
        public Task<Clients> UpdateClients(Clients client);

        /// <summary>
        /// get a client by client id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Client object</returns>
        public Task<Clients> GetClientsById(int id);

        /// <summary>
        /// remove a client from the data base by client id
        /// </summary>
        /// <param name="ClientId"></param>
        /// <returns>Client object</returns>
        public Task<Clients> DeleteClientById(int ClientId);
    }
}
