using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class ClientBL:IClientBL
    {
        private readonly IClientRepo _clientRepo;
        public ClientBL(IClientRepo clientrepo) {
            _clientRepo = clientrepo;
        }

        public async Task<Clients> AddClient(Clients client)
        {
            return await _clientRepo.AddClient(client);
        }

        public async Task<List<Clients>> GetClients()
        {
            return await _clientRepo.GetClients();
        }
    }
}
