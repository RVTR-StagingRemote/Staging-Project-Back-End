using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface ITopicRepo
    {
        /// <summary>
        /// add new topic in the database
        /// </summary>
        /// <param name="topics"></param>
        /// <returns>Topics object</returns>
        public Task<Topics> AddTopic(Topics topics);

        /// <summary>
        ///  get a list of all topics in database 
        /// </summary>
        /// <returns>topics list</returns>
       public Task<List<Topics>> GetTopics();

        /// <summary>
        /// get a topic by a specific id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Topics object</returns>
        public Task<Topics> GetTopicsById(int Id);

        /// <summary>
        /// updates a topic in the database
        /// </summary>
        /// <param name="t"></param>
        /// <returns>Topics object or null if no topic object exists</returns>
        public Task<Topics> UpdateTopics(Topics t);

        /// <summary>
        /// deletes a topic from the database by topic id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Topics object</returns>
        public Task<Topics> DeleteTopicById(int Id);

        /// <summary>
        /// associate an occupation with a topic
        /// </summary>
        /// <param name="topicId"></param>
        /// <param name="OccupationId"></param>
        /// <returns>OccupationsTopicsJoin object</returns>
        public Task<OccupationsTopicsJoin> AddTopicToOccupation(int topicId, int OccupationId);

    }
}
