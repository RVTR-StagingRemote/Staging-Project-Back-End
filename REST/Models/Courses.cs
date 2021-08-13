using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles information and functionality for a Course
  ///</summary>.
  ///<param name="CourseId"></param>
  ///<param name="CourseName"></param>
  ///<param name="Description"></param>
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
