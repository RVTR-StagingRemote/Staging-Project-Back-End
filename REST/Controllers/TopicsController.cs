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
        public async Task<ActionResult> GetTopicsById(int id)
        {
            var topic = await _topicBl.GetTopicsById(id);
            if (topic != null) return Ok(topic);
            else return NotFound();
        }

        // POST api/<TopicsController>
        [HttpPost]
        public async Task<ActionResult> Post(Topics t)
        {
            return Created("api/AddTopics", await _topicBl.AddTopic(t));
        }

        // DELETE api/<TopicsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Topics topic = await _topicBl.DeleteTopicById(id);
            if (topic != null) return Ok(topic);
            else return NotFound();
        }
        /// <summary>
        /// Assoicate a topic and course
        /// </summary>
        /// <param name="topicId"></param>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpPost("{topicId}/{courseId}")]
        public async Task<ActionResult> AddTopicToCourse(int topicId, int courseId)
        {
            var join = await _topicBl.AddTopicToCourse(topicId, courseId);
            if (join.TopicId != 0 && join.CourseId != 0) return Created($"api/Topics/{topicId}/{courseId}", join);
            else return BadRequest();
        }

    }
}
