using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST.BusinessLayer;
using REST.DataLayer;
using REST.Models;

namespace REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseBL _courseBL;

        public CourseController(ICourseBL courseBL)
        {
            _courseBL = courseBL;

        }

        ///<summary>
        ///Returns all courses as a List
        ///</summary>
        [HttpGet]

        public async Task<IActionResult> GetCourses()
        {
            return Ok(await _courseBL.GetCourses());
        }


        ///<summary>
        ///Returns a single course based on an ID
        ///</summary>
        ///<param name="id"></param>
        [HttpGet("FindCourseById/{CourseId}")]
        public async Task<IActionResult> FindCourseById(int CourseId)
        {
            Courses course = await _courseBL.FindCourseById(CourseId);
            if(course == null) return NotFound();
            return Ok(course);

        }
        /// <summary>
        /// Returns a single course by its name
        /// </summary>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        [HttpGet("FindCourseByName/{CourseName}")]
        public async Task<IActionResult> FindCourseByName(string CourseName)
        {
            Courses course = await _courseBL.FindCourseByName(CourseName);
            if (course == null) return NotFound();
            return Ok(course);


        }

        ///<summary>
        ///Creates a new course based on the course object given
        ///</summary>
        ///<param name="course"></param>
        [HttpPost]
        public async Task<IActionResult> CreateCourse(Courses course)
        {

            return Created("api", await _courseBL.AddCourse(course));

        }

        ///<summary>
        ///update a course based on the course object given
        ///</summary>
        ///<param name="course"></param>
        [HttpPut]
        public async Task<IActionResult> UpdateCourse(Courses course)
        {
            Courses courseToUpdate = await _courseBL.UpdateCourses(course);
            if (courseToUpdate == null) return NotFound();
            return NoContent();
        }

        ///<summary>
        ///Delete a course based on a given ID
        ///</summary>
        ///<param name="id"></param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            Courses course = await _courseBL.DeleteCourseById(id);
            if(course == null) return NotFound();
            return Ok(course);

        }

    }
}
