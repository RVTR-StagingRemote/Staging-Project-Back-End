using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface IOccupationRepo
    {
      
        public Task<Occupations> AddOccupation(Occupations Occupation);

        /// <summary>
        ///  
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
        /// <returns></returns>
        public Task<Occupations> FindOccupationByName(string OccupationName);

       /// <summary>
       /// 
       /// </summary>
       /// <param name="Occupation"></param>
       /// <returns></returns>
        public Task<Occupations> UpdateOccupations(Occupations Occupation);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OccupationId"></param>
        /// <returns></returns>
        public Task<Occupations> DeleteOccupationById(int OccupationId);

        public Task<List<Occupations>> GetOccupationsByTag(int topicId);

    }
}
