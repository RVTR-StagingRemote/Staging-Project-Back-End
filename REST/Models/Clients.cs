using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
  ///<summary>
  ///This class handles information and functionality for a Client
  ///</summary>
  public class Clients
  {
    /// <summary>
    /// Id used to target the Client entity
    /// </summary>
    [Key]
    public int ClientId { get; set; }

    /// <summary>
    /// Name of the Client entity
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Address of the Client entity
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// State/Province of the Client entity
    /// </summary>
    public string StateProvince { get; set; }

    /// <summary>
    /// Country of the Client entity
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Phone number of the Client entity
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Email of the Client entity
    /// </summary>
    public string Email { get; set; }
    public Clients()
    {

    }
  }
}