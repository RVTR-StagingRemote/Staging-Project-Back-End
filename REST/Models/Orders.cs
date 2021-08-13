using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles the relationship between orders and Clients
  ///</summary>.
  public class Orders
  {
    ///<summary>
    ///Id used to target the Order Entity
    ///</summary>
    [Key]
    public int OrderId { get; set; }

    ///<summary>
    ///Id used for the Client Entity
    ///</summary>
    public int ClientId { get; set; }
    public Orders()
    {
    }
  }

}