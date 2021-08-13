using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles the information of an order
  ///</summary>.
  ///<param name="DetailsId"></param>
  ///<param name="CourseId"></param>
  ///<param name="OrderId"></param>
  ///<param name="AssociateCount"></param>
  ///<param name="DateNeeded"></param>
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
