using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace REST.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime DOB { get; set; }

        public string EmployeeType { get; set; }

        public string Degree { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }
    }
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FullName)
                .Length(2, 50)
                .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(e => e.DOB)
                .LessThan(DateTime.Now)
                .WithMessage("Cannot be a future date.");
            RuleFor(e => e.DOB)
                .NotNull()
                .WithMessage("Cannot be null.");
            RuleFor(e => e.EmployeeType)
                .Length(2, 50)
                .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(e => e.Degree) // can degree be empty?
                .Length(2, 50)
                .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(e => e.StateId)
                .NotNull()
                .WithMessage("Cannot be null");
        }
    }
}
