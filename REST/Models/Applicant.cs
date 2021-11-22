using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    ///<summary>
    ///This class handles information and functionality for an Applicant
    ///</summary>
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        public byte[] Resume { get; set; }
        public string AboutMe { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationLevel { get; set; }
        public string EducationField { get; set; }
        public string EmploymentStatus { get; set; }
        //public string Skills { get; set; }
        public ICollection<string> Skills { get; set; }

        public Applicant()
        {
        }
    }

    public class ApplicantsValidator : AbstractValidator<Applicant>
    {
        public ApplicantsValidator()
        {
            RuleFor(c => c.AboutMe)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.FirstName)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.LastName)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.EducationLevel)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.EducationField)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(c => c.EmploymentStatus)
              .NotNull()
              .Length(2, 50)
              .WithMessage("Must be inbetween 2 and 50 characters");
        }
    }
}
