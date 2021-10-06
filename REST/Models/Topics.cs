using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    ///<summary>
    ///This class handles information about Topics for Occupations
    ///</summary>
    public class Topics
    {
        ///<summary>
        ///Id used to target the Topics Entity
        ///</summary>
        [Key]
        public int TopicId { get; set; }

        ///<summary>
        ///Name of topics entity
        ///</summary>
        public string TopicName { get; set; }
        public ICollection<OccupationsTopicsJoin> OccupationsTopicsJoins { get; set; }
        public Topics()
        {
        }
    }
    
    public class TopicsValidator :AbstractValidator<Topics>
    {
        public TopicsValidator()
        {
            RuleFor(t => t.TopicId)
                .NotNull()
                .WithMessage("Must include topic ID.");
            RuleFor(t => t.TopicName)
                .NotNull()
                .WithMessage("Must include Topic Name.");
            RuleFor(t => t.TopicName)
                .Length(2,50)
                .WithMessage("Must be inbetween 2 and 50 characters");
        }
    }
}