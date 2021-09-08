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

            return Ok(await _courseBL.FindCourseById(CourseId));

        }

        [HttpGet("FindCourseByName/{CourseName}")]
        public async Task<IActionResult> FindCourseByName(string CourseName)
        {

            return Ok(await _courseBL.FindCourseByName(CourseName));


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
            Courses CourseUpdated = await _courseBL.UpdateCourses(course);
            if (CourseUpdated == null) return BadRequest();
            return NoContent();
        }

        ///<summary>
        ///Delete a course based on a given ID
        ///</summary>
        ///<param name="id"></param>
        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            // TODO implement
            throw new NotImplementedException();
        }

    }
}
