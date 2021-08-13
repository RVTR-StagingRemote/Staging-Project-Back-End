using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IClientBL
    {
        Task<Clients> AddClient(Clients client);

        Task<List<Clients>> GetClients();

    }

}
