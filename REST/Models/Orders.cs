using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles the relationship between orders and Clients
  ///</summary>.
  ///<param name="OrderId"></param>
  ///<param name="ClientId"></param>
  public class Orders
  {    
   [Key]
    public int OrderId { get; set; }
    public int ClientId { get; set; }
    public Orders()
    {
    }
  }

}