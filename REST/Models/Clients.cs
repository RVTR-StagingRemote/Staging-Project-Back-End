﻿using System;

namespace REST.Models
{

  public class Clients
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Clients()
    {

    }
  }
}