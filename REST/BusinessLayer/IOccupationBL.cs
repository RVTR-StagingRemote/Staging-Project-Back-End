using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface IOccupationBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Occupation"></param>
        /// <returns></returns>
        Task<Occupations> AddOccupation(Occupations Occupation);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Occupations>> GetOccupations();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OccupationID"></param>
        /// <returns></returns>
        Task<Occupations> FindOccupationById(int OccupationID);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OccupationName"></param>
        /// <returns></returns>
        Task<Occupations> FindOccupationByName(string OccupationName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Occupation"></param>
        /// <returns></returns>
        public Task<Occupations> UpdateOccupations(Occupations Occupation);

        public Task<Occupations> DeleteOccupationById(int OccupationId);

        public Task<List<Occupations>> GetOccupationsByTag(int topicId);

    }
}
