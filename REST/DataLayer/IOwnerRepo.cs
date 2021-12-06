using System.Collections.Generic;
using System.Threading.Tasks;
using REST.Models;

namespace REST.DataLayer
{
    public interface IOwnerRepo{
        
        public Task<Owner> GetOwnerByIdAsync(int ownerId);

        public Task<List<Owner>> GetOwnersAsync();

        public Task<Owner> CreateOwnerAsync(Owner owner);

        public Task<Owner> UpdateOwnerAsync(Owner owner);

        public Task<string> DeleteOwnerByIdAsync(int ownerId);

    }
}