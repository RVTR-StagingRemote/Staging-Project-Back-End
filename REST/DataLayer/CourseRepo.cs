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
            Courses courseToUpdate = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == course.CourseId);
            if(courseToUpdate != null)
            {
                _context.Courses.Update(courseToUpdate);
                await _context.SaveChangesAsync();
            }

            return courseToUpdate;
        }

        public async Task<Courses> DeleteCourseById(int CourseId)
        {
            Courses course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == CourseId);
            if(course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }

            return course;
        }

        public Task<Courses> getCourseByTag(Topics t)
        {
            throw new NotImplementedException();
        }
    }
}
