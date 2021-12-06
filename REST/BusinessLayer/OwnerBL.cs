using System.Collections.Generic;
using System.Threading.Tasks;
using REST.DataLayer;
using REST.Models;

namespace REST.BusinessLayer
{
    public class OwnerBL : IOwnerBL
    {
        private readonly IOwnerRepo _ownerRepo;

        public OwnerBL(IOwnerRepo ownerRepo)
        {
            _ownerRepo = ownerRepo;
        }

/// <summary>
/// Creates an owner. Currently having issues making an owner because of applicant resume
///  causing convering error form JSON to byte[].
/// </summary>
/// <param name="owner"></param>
/// <returns>Owner owner</returns>
        public async Task<Owner> AddOwnerAsync(Owner owner)
        {
            Owner ownerResult = await _ownerRepo.CreateOwnerAsync(owner);
            if(ownerResult == null)
            {
                return null;
            }
            else
            {
                return ownerResult;
            }
        }

/// <summary>
/// Deletes owner by passing OwnerId.
/// </summary>
/// <param name="id"></param>
/// <returns>string validated or error</returns>
        public async Task<string> DeleteOwnerByIdAsync(int id)
        {
            string result = await _ownerRepo.DeleteOwnerByIdAsync(id);
            if(result == "Owner deleted")
            {
                return "Owner deleted";
            }
            else
            {
                return $"Owner not deleted: {result}";
            }
        }

/// <summary>
/// Gets all list of all owners.
/// </summary>
/// <returns>List<Owner> owner</returns>
        public async Task<List<Owner>> GetOwnersAsync()
        {
            List<Owner> ownersResult = await _ownerRepo.GetOwnersAsync();
            return ownersResult;
        }

/// <summary>
/// Gets single owner by passing OwnerId.
/// </summary>
/// <param name="id"></param>
/// <returns>Owner owner</returns>
        public async Task<Owner> GetOwnerByIdAsync(int id)
        {
            Owner ownerResult = await _ownerRepo.GetOwnerByIdAsync(id);
            return ownerResult;
        }

/// <summary>
/// Updates owner applicaions.
/// </summary>
/// <param name="owner"></param>
/// <returns>Owner owner</returns>
        public async Task<Owner> UpdateOwnerAsync(Owner owner)
        {
            Owner updatedOwner = await _ownerRepo.UpdateOwnerAsync(owner);
            return updatedOwner;
        }
    }
}