using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class ClientRepo : IClientRepo
    {
        private readonly BatchesDBContext _context;
        public ClientRepo(BatchesDBContext context)
        {
            _context = context;
        }
        public async Task<Clients> AddClient(Clients client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();

            return client;
        }


        public async Task<List<Clients>> GetClients()
        {
            return await _context.Clients.AsNoTracking().Select(cl => cl).ToListAsync();
        }

        public Task<Clients> GetClientsById(int Id)
        {
            return _context.Clients.FirstOrDefaultAsync(c => c.ClientId == Id);
        }

        public async Task<Clients> UpdateClients(Clients client)
        {
            Clients clientToUpdate = await _context.Clients.FirstOrDefaultAsync(c => c.ClientId == client.ClientId);
            if (clientToUpdate != null)
            {
                _context.Clients.Update(clientToUpdate);
                await _context.SaveChangesAsync();
            }

            return clientToUpdate;

        }

        public async Task<Clients> DeleteClientById(int ClientId)
        {
            Clients client = await _context.Clients.FirstOrDefaultAsync(c => c.ClientId == ClientId);
            if(client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }

            return client;
        }
    }
}
