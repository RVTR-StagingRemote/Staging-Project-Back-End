using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class OccupationBL:IOccupationBL
    {
        private readonly IOccupationRepo _Occupationrepo;
        public OccupationBL(IOccupationRepo Occupationrepo)
        {
            _Occupationrepo = Occupationrepo;
        }

        public async Task<Occupations> AddOccupation(Occupations c)
        {
            return await _Occupationrepo.AddOccupation(c);
        }

        public async Task<Occupations> FindOccupationById(int OccupationID)
        {
            return await _Occupationrepo.FindOccupationById(OccupationID);
        }

        public async Task<Occupations> FindOccupationByName(string OccupationName)
        {
            return await _Occupationrepo.FindOccupationByName(OccupationName);
        }

        public async Task<List<Occupations>> GetOccupations()
        {
            return await _Occupationrepo.GetOccupations();
        }

        public async Task<Occupations> UpdateOccupations(Occupations Occupation)
        {
            return await _Occupationrepo.UpdateOccupations(Occupation);
        }

        public async Task<Occupations> DeleteOccupationById(int OccupationId)
        {
            return await _Occupationrepo.DeleteOccupationById(OccupationId);
        }

        public async Task<List<Occupations>> GetOccupationsByTag(int topicId)
        {
            return await _Occupationrepo.GetOccupationsByTag(topicId);
        }

    }
}
