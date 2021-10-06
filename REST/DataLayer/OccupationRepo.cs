using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class OccupationRepo : IOccupationRepo
    {
        private readonly BatchesDBContext _context;
        public OccupationRepo(BatchesDBContext context)
        {
            _context = context;
        }


        public async Task<List<Occupations>> GetOccupations()
        {
            return await _context.Occupations.AsNoTracking().Select(c => c).ToListAsync();
        }

        public async Task<Occupations> AddOccupation(Occupations Occupation)
        {
            await _context.Occupations.AddAsync(Occupation);
            await _context.SaveChangesAsync();
            return Occupation;
        }

        public async Task<Occupations> FindOccupationById(int OccupationId)
        {
            return await _context.Occupations.FirstOrDefaultAsync(c => c.OccupationId == OccupationId);
        }

        public async Task<Occupations> FindOccupationByName(string OccupationName)
        {


            return await _context.Occupations.FirstOrDefaultAsync(c => c.OccupationName == OccupationName);

        }

        public async Task<Occupations> UpdateOccupations(Occupations Occupation)
        {
            Occupations OccupationToUpdate = await _context.Occupations.FirstOrDefaultAsync(c => c.OccupationId == Occupation.OccupationId);
            if(OccupationToUpdate != null)
            {
                _context.Occupations.Update(OccupationToUpdate);
                await _context.SaveChangesAsync();
            }

            return OccupationToUpdate;
        }

        public async Task<Occupations> DeleteOccupationById(int OccupationId)
        {
            Occupations Occupation = await _context.Occupations.FirstOrDefaultAsync(c => c.OccupationId == OccupationId);
            if(Occupation != null)
            {
                _context.Occupations.Remove(Occupation);
                await _context.SaveChangesAsync();
            }

            return Occupation;
        }

        public async Task<List<Occupations>> GetOccupationsByTag(int topicId)
        {
            var list = await _context.OccupationsTopicsJoins.AsNoTracking().Select(c => c).Where(t => t.TopicsId == topicId).ToListAsync();

            List<Occupations> Occupations = new List<Occupations>();
            foreach (var x in list)
            {
                var Occupation = await FindOccupationById(x.OccupationsId);
                Occupations.Add(Occupation);
            }

            return Occupations;
        }
    }
}
