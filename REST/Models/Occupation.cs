using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    public class Occupation
    {
        [Key]
        [ForeignKey("Order")]
        public int OccupationId { get; set; }
        public string OccupationName { get; set; }
        public string Description { get; set; }
        // this for 1 to 1 relationship between occupations table and orders table
        public virtual Order Order { get; set; }
        public Occupation()
        {
        }
    }

    public class OccupationsValidator : AbstractValidator<Occupation>
    {
        public OccupationsValidator()
        {
            RuleFor(c => c.OccupationName)
                .Length(2, 50)
                .WithMessage("Must be in between 2 and 50 characters");
            RuleFor(c => c.Description)
                .Length(2, 50)
                .WithMessage("Must be in between 2 and 50 characters");
        }
    }
}
