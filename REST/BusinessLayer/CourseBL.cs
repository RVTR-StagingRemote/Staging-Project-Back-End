using REST.DataLayer;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public class CourseBL:ICourseBL
    {
        private readonly ICourseRepo _courserepo;
        public CourseBL(ICourseRepo courserepo)
        {
            _courserepo = courserepo;
        }

        public async Task<Courses> AddCourse(Courses c)
        {
            return await _courserepo.AddCourse(c);
        }

        public async Task<Courses> FindCourseById(int CourseID)
        {
            return await _courserepo.FindCourseById(CourseID);
        }

        public async Task<Courses> FindCourseByName(string CourseName)
        {
            return await _courserepo.FindCourseByName(CourseName);
        }

        public async Task<List<Courses>> GetCourses()
        {
            return await _courserepo.GetCourses();
        }

        public async Task<Courses> UpdateCourses(Courses course)
        {
            return await _courserepo.UpdateCourses(course);
        }
    }
}
