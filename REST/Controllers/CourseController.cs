using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST.DataLayer;
using REST.Models;

namespace REST.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CourseController : ControllerBase
  {
    private ICourseRepo _courseRepo;

    public CourseController(ICourseRepo courseRepo)
    {
      _courseRepo = courseRepo;
    }
    
    ///<summary>
    ///Returns all courses as a List
    ///</summary>
    [HttpGet]
    public async Task<IActionResult> Courses()
    {
      var courses = await _courseRepo.GetCourses();
      return Ok(courses);
    }

    ///<summary>
    ///Returns a single course based on an ID
    ///</summary>
    ///<param name="id"></param>
    [HttpGet("{id}")]
    public async Task<IActionResult> Course(int id)
    {
      // var course = _courseRepo.Courses.FirstOrDefault(c => c.CourseId == id);
      // return Ok(course);

       // TODO implement similar logic as above
      throw new NotImplementedException();
    }

    ///<summary>
    ///Creates a new course based on the course object given
    ///</summary>
    ///<param name="course"></param>
    [HttpPost]
    public async Task<IActionResult> CreateCourse(Courses course)
    {
      var newCourse = new Courses {
        CourseName = course.CourseName,
        Description = course.Description
      };

      // TODO: Add error handling in case of failed Db exchanges
      await _courseRepo.AddCourse(course);

      return Ok("Course added!");
    }

    ///<summary>
    ///update a course based on the course object given
    ///</summary>
    ///<param name="course"></param>
    [HttpPut]
    public async Task<IActionResult> Update(Courses course)
    {
      // TODO implement
      throw new NotImplementedException();
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
