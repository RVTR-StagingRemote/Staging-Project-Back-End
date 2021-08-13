using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public class CourseRepo:ICourseRepo
    {
        private readonly BatchesDBContext _context;
        public CourseRepo(BatchesDBContext context)
        {
            _context = context;
        }


        public async Task<List<Courses>> GetCourses()
        {
            return await _context.Courses.AsNoTracking().Select(c => c).ToListAsync();
        }

        public async Task<Courses> AddCourse(Courses course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return course;
        }
    }
}
