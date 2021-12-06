using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IOwnerBL
    {
        Task<List<Owner>> GetOwnersAsync();
        Task<Owner> GetOwnerByIdAsync(int id);
        Task<Owner> AddOwnerAsync(Owner owner);
        Task<Owner> UpdateOwnerAsync(Owner owner);
        Task<string> DeleteOwnerByIdAsync(int id);
    }
}