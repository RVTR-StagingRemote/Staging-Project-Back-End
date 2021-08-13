using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.BusinessLayer
{
    public interface ICourseBL
    {
        Task<Courses> AddCourse(Courses course);

        Task<List<Courses>> GetCourses();
    }
}
