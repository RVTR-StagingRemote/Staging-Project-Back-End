using Microsoft.AspNetCore.Mvc;
using REST.BusinessLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase      
    {
        private readonly IClientBL _clientBL;
        public ClientController(IClientBL clientBL) { _clientBL = clientBL; }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            return Ok(await _clientBL.GetClientsById(id));
        }

        // POST api/<ClientController>
        [HttpPost()]
        public async  Task<IActionResult> Post([FromBody] Clients client)
        {
       
            return Created("api/AddClient",await _clientBL.AddClient(client));
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
