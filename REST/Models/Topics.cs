using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles information about Topics for Courses
  ///</summary>
  public class Topics
  {
    ///<summary>
    ///Id used to target the Topics Entity
    ///</summary>
    [Key]
    public int TopicId { get; set; }

    ///<summary>
    ///Name of topics entity
    ///</summary>
    public string TopicName { get; set; }
    public Topics()
    {
    }
  }
}