using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{

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