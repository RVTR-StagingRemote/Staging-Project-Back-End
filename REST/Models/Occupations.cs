using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    ///<summary>
    ///This class handles information and functionality for a Occupation
    ///</summary>.
    public class Occupations
    {
        /// <summary>
        /// Id used to target the Occupation entity
        /// </summary>
        [Key]
        public int OccupationId { get; set; }

        /// <summary>
        /// name for the Occupation entity
        /// </summary>
        public string OccupationName { get; set; }

        /// <summary>
        /// description of the Occupation entity
        /// </summary>
        public string Description { get; set; }

        public ICollection<OccupationsTopicsJoin> OccupationsTopicsJoins { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

        public Occupations()
        {

        }
    }

    public class OccupationsValidator : AbstractValidator<Occupations>
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
