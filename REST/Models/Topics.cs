using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles information about topics for courses
  ///</summary>.
  ///<param name="TopicId"></param>
  ///<param name="TopicName"></param>
  public class Topics
  {
    [Key]
    public int TopicId { get; set; }
    public string TopicName { get; set; }
    public Topics()
    {
    }
  }
}