using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    ///<summary>
    ///This class handles information and functionality for a Course
    ///</summary>.
    public class Courses
    {
        /// <summary>
        /// Id used to target the course entity
        /// </summary>
        [Key]
        public int CourseId { get; set; }

        /// <summary>
        /// name for the course entity
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// description of the course entity
        /// </summary>
        public string Description { get; set; }
        public Courses()
        {

        }
    }

    public class CoursesValidator : AbstractValidator<Courses>
    {
        public CoursesValidator()
        {
            RuleFor(c => c.CourseName)
                .Length(2, 50)
                .WithMessage("Must be in between 2 and 50 characters");
            RuleFor(c => c.CourseName)
                .NotNull()
                .WithMessage("Name cannot be empty.");
            RuleFor(c => c.Description)
                .Length(2, 50)
                .WithMessage("Must be in between 2 and 50 characters");

        }
    }
}
