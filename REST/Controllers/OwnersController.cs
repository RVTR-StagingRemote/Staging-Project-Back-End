using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST.BusinessLayer;
using REST.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase{
        private readonly IOwnerBL _ownerBL;
        public OwnersController(IOwnerBL ownerBL)
        {
            _ownerBL = ownerBL;
        }

        // get Owners
        [HttpGet]
        public async Task<IActionResult> GetOwnersAsync(){
            List<Owner> owners = await _ownerBL.GetOwnersAsync();
            if(owners == null)
            {
                return NotFound();
            }else{
                return Ok(owners);
            }
            
        }

        // get Owner{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOwnerByIdAsync(int id){
            Owner owner = await _ownerBL.GetOwnerByIdAsync(id);
            if(owner == null)
            {
                return NotFound();
            }else{
                return Ok(owner);
            }
        }

        // post Owner
        [HttpPost]
        public async Task<IActionResult> PostOwnerAsync([FromBody] Owner owner){
            if(owner == null)
            {
                throw new System.ArgumentNullException(nameof(owner));
            }
            Owner newOwner = await _ownerBL.AddOwnerAsync(owner);
            return CreatedAtAction(nameof(GetOwnerByIdAsync), new { id = newOwner.OwnerId }, newOwner);
        }

        // put Owner
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOwnerAsync(int id, [FromBody] Owner owner){
            if(owner == null)
            {
                throw new System.ArgumentNullException(nameof(owner));
            }
            Owner updatedOwner = await _ownerBL.UpdateOwnerAsync(owner);
            if(updatedOwner == null)
            {
                return NotFound();
            }
            return Ok(updatedOwner);
        }

        // delete Owner
        [HttpDelete("{id}")]
        public  async Task<IActionResult> DeleteOwnerByIdAsync(int id){
            string result = await _ownerBL.DeleteOwnerByIdAsync(id);
            if(result == "Owner deleted")
            {
                return Ok(result);
            }
            return NotFound($"No user with id {id} found");
        }
        

    }
}