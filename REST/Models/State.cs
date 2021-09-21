using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace REST.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        
    }

    public class StateValidator : AbstractValidator<State>
    {
        public StateValidator()
        {
            RuleFor(s => s.Name)
                .Length(2,50)
                .WithMessage("Must be inbetween 2 and 50 characters");
            RuleFor(s => s.Code)
                .Length(2, 50)
                .WithMessage("Must be inbetween 2 and 50 characters");
        }
    }
}
