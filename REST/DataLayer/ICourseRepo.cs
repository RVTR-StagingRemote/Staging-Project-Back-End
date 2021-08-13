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
        /// add new topic in the database
        /// </summary>
        /// <param name="topics"></param>
        /// <returns>Topics object</returns>
       
    }
}
