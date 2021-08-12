using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{

  public class OrderDetails
  {
    [Key]
    public int DetailsId { get; set; }
    public int CourseId { get; set; }
    public int OrderId { get; set; }
    public int AssociateCount { get; set; }
    public DateTime DateNeeded { get; set; }
    public OrderDetails()
    {
    }
  }
}
