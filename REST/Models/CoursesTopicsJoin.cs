using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  public class CoursesTopicsJoin
  {
    [Key]
    public int JoinId { get; set; }
    public int CourseId { get; set; }
    public int TopicId { get; set; }
    public CoursesTopicsJoin()
    {
    }
  }
}


