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

    [HttpGet]
    public IActionResult Courses()
    {
      var courses = _context.Courses.ToList();
      return Ok(courses);
    }

    [HttpGet("{id}")]
    public IActionResult Course(int id)
    {
      var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
      return Ok(course);
    }

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

    [HttpPut]
    public IActionResult Update(Courses course)
    {
      // TODO implement
      throw new NotImplementedException();
    }

    [HttpDelete]
    public IActionResult DeleteCourse(int id)
    {
      // TODO implement
      throw new NotImplementedException();
    }

  }
}
