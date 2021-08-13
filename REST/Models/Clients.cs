using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles information and functionality for a Client
  ///</summary>
  ///<param name="ClientId"></param>
  ///<param name="Name"></param>
  ///<param name="Address"></param>
  ///<param name="StateProvince"></param>
  ///<param name="Country"></param>
  ///<param name="Phone"></param>
  ///<param name="Email"></param>
  public class Clients
  {
    [Key]
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