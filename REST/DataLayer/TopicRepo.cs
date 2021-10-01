using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class TopicRepo : ITopicRepo
    {
        private readonly BatchesDBContext _context;
        public TopicRepo(BatchesDBContext context)
        {
            _context = context;
        }



        public async Task<Topics> AddTopic(Topics topics)
        {
            await _context.Topics.AddAsync(topics);
            await _context.SaveChangesAsync();
            return topics;
        }



        public async Task<List<Topics>> GetTopics()
        {
            return await _context.Topics.AsNoTracking().Select(tp => tp).ToListAsync();
        }

        public Task<Topics> GetTopicsById(int Id)
        {
            return _context.Topics.FirstOrDefaultAsync(c => c.TopicId == Id);
        }

        public async Task<Topics> UpdateTopics(Topics t)
        {
            _context.Topics.Update(t);
            await _context.SaveChangesAsync();

            return t;
        }

        public async Task<Topics> DeleteTopicById(int Id)
        {
            Topics topic = await _context.Topics.FirstOrDefaultAsync(t => t.TopicId == Id);
            if (topic != null)
            {
                _context.Topics.Remove(topic);
                await _context.SaveChangesAsync();
            }
            return topic;
        }

        public async Task<CoursesTopicsJoin> AddTopicToCourse(int topicId, int courseId)
        {
            CoursesTopicsJoin join = new CoursesTopicsJoin();

            CoursesTopicsJoin alreadyExists = await _context.CoursesTopicsJoins.FirstOrDefaultAsync(a => a.TopicId == topicId && a.CourseId == courseId);

            if (alreadyExists == null)
            {
                Topics topic = await _context.Topics.FirstOrDefaultAsync(t => t.TopicId == topicId);
                Courses course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == courseId);

                if (topic != null && course != null)
                {
                    join.TopicId = topic.TopicId;
                    join.CourseId = course.CourseId;
                    _context.CoursesTopicsJoins.Add(join);
                    await _context.SaveChangesAsync();
                }
            }

            return join;

        }
    }
}
