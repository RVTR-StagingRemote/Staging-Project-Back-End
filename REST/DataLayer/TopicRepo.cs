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

        public async Task<Topics> UpdateTopics(Topics topic)
        {
            if (_context.Topics.Where(t => t.TopicId == topic.TopicId).Select(x => x).Count() == 1) // id exists
            {
                _context.Topics.Update(topic);
                await _context.SaveChangesAsync();
                return topic;
            }
            return null;
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

        public async Task<OccupationsTopicsJoin> AddTopicToOccupation(int topicId, int OccupationId)
        {
            OccupationsTopicsJoin join = new OccupationsTopicsJoin();

            OccupationsTopicsJoin alreadyExists = await _context.OccupationsTopicsJoins.FirstOrDefaultAsync(a => a.TopicsId == topicId && a.OccupationsId == OccupationId);

            if (alreadyExists == null)
            {
                Topics topic = await _context.Topics.FirstOrDefaultAsync(t => t.TopicId == topicId);
                Occupations Occupation = await _context.Occupations.FirstOrDefaultAsync(c => c.OccupationId == OccupationId);

                if (topic != null && Occupation != null)
                {
                    join.TopicsId = topic.TopicId;
                    join.OccupationsId = Occupation.OccupationId;
                    _context.OccupationsTopicsJoins.Add(join);
                    await _context.SaveChangesAsync();
                }
            }

            return join;

        }
    }
}
