﻿using System;
using System.Collections.Generic;
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
        ///

        public int ClientId { get; set; }
        public Clients Clients { get; set; }
       
    
    public string OrderName { get; set; }

    public ICollection<OrderDetails> OrderDetails { get; set; }
    public Orders()
    {
    }
        public Orders(Clients clients, ICollection<OrderDetails> items)
        {
            this.Clients = clients;
            this.OrderDetails = items;
        }
  }

}