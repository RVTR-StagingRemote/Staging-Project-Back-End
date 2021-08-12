using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{

  public class Courses
  {
    [Key]
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public Courses()
    {

    }
  }
}
