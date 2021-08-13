using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class TopicBL:ITopicBL
    {
        private readonly ITopicRepo _topicRepo;
        public TopicBL(ITopicRepo topicRepo)
        {
            _topicRepo = topicRepo;
        }

        public async Task<Topics> AddTopic(Topics t)
        {
            return await _topicRepo.AddTopic(t);
        }

        public async Task<List<Topics>> GetTopics()
        {
            return await _topicRepo.GetTopics();
        }
    }
}
