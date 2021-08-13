using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles the relationship between courses and their topics
  ///</summary>.
  ///<param name="JoinId"></param>
  ///<param name="CourseId"></param>
  ///<param name="TopicId"></param>
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


