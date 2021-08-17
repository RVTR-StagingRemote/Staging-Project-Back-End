using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface ITopicBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<Topics> AddTopic(Topics t);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Topics>> GetTopics();
    }
}
