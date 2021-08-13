using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles information and functionality for a Course
  ///</summary>.
  public class Courses
  {
    /// <summary>
    /// Id used to target the course entity
    /// </summary>
    [Key]
    public int CourseId { get; set; }

    /// <summary>
    /// name for the course entity
    /// </summary>
    public string CourseName { get; set; }

    /// <summary>
    /// description of the course entity
    /// </summary>
    public string Description { get; set; }
    public Courses()
    {

    }
  }
}
