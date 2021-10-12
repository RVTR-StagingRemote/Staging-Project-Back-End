﻿using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface IOccupationRepo
    {
        /// <summary>
        /// add a new new occupation to the database
        /// </summary>
        /// <param name="Occupation"></param>
        /// <returns>Occupations object</returns>
        public Task<Occupations> AddOccupation(Occupations Occupation);

        /// <summary>
        /// get a list of all occupations in the database
        /// </summary>
        /// <returns>Occupation list</returns>
        public Task<List<Occupations>> GetOccupations();

        /// <summary>
        /// find Occupation by OccupationId
        /// </summary>
        /// <param name="OccupationId"></param>
        /// <returns>Occupations object</returns>
        public Task<Occupations> FindOccupationById(int OccupationId);

        /// <summary>
        /// get Occupation by it's name
        /// </summary>
        /// <param name="OccupationName"></param>
        /// <returns>Occupations object</returns>
        public Task<Occupations> FindOccupationByName(string OccupationName);

       /// <summary>
       /// update an occupation in the database
       /// </summary>
       /// <param name="Occupation"></param>
       /// <returns>Occupation object or null if no object found</returns>
        public Task<Occupations> UpdateOccupations(Occupations Occupation);

        /// <summary>
        /// delete an occupation from the database by occupation id
        /// </summary>
        /// <param name="OccupationId"></param>
        /// <returns>Occupation object</returns>
        public Task<Occupations> DeleteOccupationById(int OccupationId);

        /// <summary>
        /// get all occupations assoicated with a certian topic 
        /// </summary>
        /// <param name="topicId"></param>
        /// <returns>list of occupations</returns>
        public Task<List<Occupations>> GetOccupationsByTag(int topicId);

    }
}
