using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles the information of an order
  ///</summary>.
  public class OrderDetails
  {
    ///<summary>
    ///Id used to target the OrderDetails Entity
    ///</summary>
    [Key]
    public int DetailsId { get; set; }

    ///<summary>
    ///Id used for the Course entity
    ///</summary>
    public int CourseId { get; set; }

    ///<summary>
    ///Id used for the Order Entity
    ///</summary>
    public int OrderId { get; set; }

    ///<summary>
    ///Number of associates requested
    ///</summary>
    public int AssociateCount { get; set; }

    ///<summary>
    ///Date the request should be filled by
    ///</summary>
    public DateTime DateNeeded { get; set; }
    public OrderDetails()
    {
    }
  }
}
