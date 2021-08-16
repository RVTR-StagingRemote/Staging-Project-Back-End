using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.DataLayer
{
   public interface ICourseRepo
    {
      
        public Task<Courses> AddCourse(Courses course);

        /// <summary>
        ///  
        /// </summary>
        /// <returns>course list</returns>
        public Task<List<Courses>> GetCourses();

        /// <summary>
        /// find course by CourseId
        /// </summary>
        /// <param name="CourseId"></param>
        /// <returns>Courses object</returns>
        public Task<Courses> FindCourseById(int CourseId);
        /// <summary>
        /// get course by it's name
        /// </summary>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        public Task<Courses> FindCourseByName(string CourseName);

    }
}
