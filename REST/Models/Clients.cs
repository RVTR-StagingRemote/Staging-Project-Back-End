using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

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

    public ICollection<Orders>?  Orders { get; set; }
        public Clients()
    {

    }
  }

  public class ClientsValidator : AbstractValidator<Clients>
  {
    public ClientsValidator()
    {
      RuleFor(c => c.Name)
        .Length(5, 10).WithMessage("Must be inbetween 5 and 10 characters")
        .NotEqual("tyler").WithMessage("No Tylers allowed");

      RuleFor(c => c.Email)
        .EmailAddress().WithMessage("Not a valid email address");
    }
  }
}