﻿using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class TopicBL : ITopicBL
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

        public async Task<Topics> GetTopicsById(int Id)
        {
            return await _topicRepo.GetTopicsById(Id);
        }

        public async Task<Topics> UpdateTopic(Topics t)
        {
            return await _topicRepo.UpdateTopics(t);
        }

        public async Task<Topics> DeleteTopicById(int Id)
        {
            return await _topicRepo.DeleteTopicById(Id);
        }

        public async Task<CoursesTopicsJoin> AddTopicToCourse(int topicId, int courseId)
        {
            return await _topicRepo.AddTopicToCourse(topicId, courseId);
        }
    }
}
