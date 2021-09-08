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
        public async Task<IActionResult> GetClients()
        {
            return Ok(await _clientBL.GetClients());
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            return Ok(await _clientBL.GetClientsById(id));
        }

        // POST api/<ClientController>
        [HttpPost()]
        public async Task<IActionResult> Post(Clients client)
        {

            return Created("api/AddClient", await _clientBL.AddClient(client));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        // PUT api/<ClientController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Clients client)
        {
            await _clientBL.UpdateClients(client);
            return NoContent();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
