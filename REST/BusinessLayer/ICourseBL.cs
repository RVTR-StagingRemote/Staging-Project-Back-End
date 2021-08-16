using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface ICourseBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        Task<Courses> AddCourse(Courses course);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Courses>> GetCourses();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CourseID"></param>
        /// <returns></returns>
        Task<Courses> FindCourseById(int CourseID);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        Task<Courses> FindCourseByName(string CourseName);
    }
}
