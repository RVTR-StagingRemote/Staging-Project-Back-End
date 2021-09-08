using Microsoft.EntityFrameworkCore;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
    public class CourseRepo : ICourseRepo
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

        public async Task<Courses> FindCourseById(int CourseId)
        {
            return await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == CourseId);
        }

        public async Task<Courses> FindCourseByName(string CourseName)
        {


            return await _context.Courses.FirstOrDefaultAsync(c => c.CourseName == CourseName);

        }

        public async Task<Courses> UpdateCourses(Courses course)
        {
            _context.Courses.Update(course);
            _context.SaveChangesAsync();

            return course;
        }
    }
}
