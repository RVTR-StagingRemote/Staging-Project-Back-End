﻿using REST.Models;
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
        ///   
        /// </summary>
        /// <returns>topics list</returns>
       public Task<List<Topics>> GetTopics();

        /// <summary>
        /// place order for a given costumer
        /// </summary>
        /// <param name="client"></param>
        /// <param name="orderDetails"></param>
        /// <returns>Orders object</returns>
       
    }
}