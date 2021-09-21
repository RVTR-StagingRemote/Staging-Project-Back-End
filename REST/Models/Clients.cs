using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
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
    /// <summary>
    /// 
    /// </summary>
    public ICollection<Orders>?  Orders { get; set; }
    public int StateId { get; set; }

    public State State { get; set; }
        public Clients()
    {

    }
  }

  public class ClientsValidator : AbstractValidator<Clients>
  {
    public ClientsValidator()
    {
      RuleFor(c => c.Name)
        .Length(2, 50)
        .WithMessage("Must be inbetween 2 and 50 characters");
      RuleFor(c => c.Email)
        .EmailAddress()
        .WithMessage("Not a valid email address");
      RuleFor(c => c.Address) 
        .Length(2, 50)
        .WithMessage("Must be inbetween 2 and 50 characters");
      RuleFor(c => c.StateProvince)
        .Length(2, 50)
        .WithMessage("Must be inbetween 2 and 50 characters");
      RuleFor(c => c.Country)
        .NotNull()
        .Length(2, 50)
        .WithMessage("Must be inbetween 2 and 50 characters");
      
      RuleFor(c => c.Phone)
        .Must(IsValidPhoneNumber)
        .WithMessage("Not a valid phone number");
    }

    private bool IsValidPhoneNumber(string Phone)
    {
      return Regex.Match(Phone, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$").Success;
    }
  }
}