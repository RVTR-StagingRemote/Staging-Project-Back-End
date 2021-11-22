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
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public Client()
        {
        }
    }

    public class ClientsValidator : AbstractValidator<Client>
    {
        public ClientsValidator()
        {
            RuleFor(c => c.CompanyName)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
        }
    }
}