using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface ITopicBL
    {
        Task<Topics> AddTopic(Topics t);

        Task<List<Topics>> GetTopics();
    }
}
