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
    private BatchesDBContext _context;

    public CourseController(BatchesDBContext context)
    {
      _context = context;
    }
    
    ///<summary>
    ///Returns all courses as a List
    ///</summary>
    [HttpGet]
    public IActionResult Courses()
    {
      var courses = _context.Courses.ToList();
      return Ok(courses);
    }

    ///<summary>
    ///Returns a single course based on an ID
    ///</summary>
    ///<param name="id"></param>
    [HttpGet("{id}")]
    public IActionResult Course(int id)
    {
      var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
      return Ok(course);
    }

    ///<summary>
    ///Creates a new course based on the course object given
    ///</summary>
    ///<param name="course"></param>
    [HttpPost]
    public IActionResult CreateCourse(Courses course)
    {
      var newCourse = new Courses {
        CourseName = course.CourseName,
        Description = course.Description
      };

      _context.Courses.Add(newCourse);
      _context.SaveChanges();

      return Ok("Course added!");
    }

    ///<summary>
    ///update a course based on the course object given
    ///</summary>
    ///<param name="course"></param>
    [HttpPut]
    public IActionResult Update(Courses course)
    {
      // TODO implement
      throw new NotImplementedException();
    }

    ///<summary>
    ///Delete a course based on a given ID
    ///</summary>
    ///<param name="id"></param>
    [HttpDelete]
    public IActionResult DeleteCourse(int id)
    {
      // TODO implement
      throw new NotImplementedException();
    }

  }
}
