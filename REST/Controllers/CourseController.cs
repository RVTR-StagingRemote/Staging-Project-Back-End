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
    private BatchesDBContext _context;
    private readonly ICourseBL _courseBL;

    public CourseController(ICourseBL courseBL)
    {
            _courseBL = courseBL;
    }
    
    ///<summary>
    ///Returns all courses as a List
    ///</summary>
    [HttpGet]
    public async  Task <IActionResult> Courses()
    {
      return  Ok(await _courseBL.GetCourses());
    }

    ///<summary>
    ///Returns a single course based on an ID
    ///</summary>
    ///<param name="id"></param>
    [HttpGet("{id}")]
    public IActionResult Course(int id)
    {
            throw new  NotImplementedException();
    }

    ///<summary>
    ///Creates a new course based on the course object given
    ///</summary>
    ///<param name="course"></param>
    [HttpPost]
    public async Task<IActionResult> CreateCourse(Courses course)
    {
      

      return Created("api",await _courseBL.AddCourse(course));
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
