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
    public class Need
    {
        [Key]
        public int Id { get; set; }
        public Company Company {get; set; }
        public Occupation Role {get; set; }
        public Order OrderMet {get; set; }

        public Need()
        {
        }
    }

    public class NeedValidator : AbstractValidator<Need>
    {
        public NeedValidator()
        {
            RuleFor(c => c.Name)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.Email)
              .EmailAddress()
              .WithMessage("Not a valid email address");
            RuleFor(c => c.Street)
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.City)
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