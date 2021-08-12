using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{

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