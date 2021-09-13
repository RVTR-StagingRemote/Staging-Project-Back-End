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
    public class TopicsController : ControllerBase
    {
        private readonly ITopicBL _topicBl;
        public TopicsController(ITopicBL topicBl)
        {
            _topicBl = topicBl;

        }
        // GET: api/<TopicsController>
        [HttpGet]
        public async  Task<ActionResult> GetTopics()
        {
            return Ok(await _topicBl.GetTopics());
           
        }

        // GET api/<TopicsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult
            > GetTopicsById(int id)
        {
            return Ok(await _topicBl.GetTopicsById(id));
        }

        // POST api/<TopicsController>
        [HttpPost]
        public async Task<ActionResult> Post(Topics t)
        {
            return Created("api/AddTopics", await _topicBl.AddTopic(t));
        }

        // PUT api/<TopicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TopicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
