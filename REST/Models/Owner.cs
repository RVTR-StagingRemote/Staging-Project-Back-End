using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    ///<summary>
    ///This class handles information and functionality for an Owner
    ///</summary>
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public Owner() { }
    }

    public class OwnersValidator : AbstractValidator<Owner>
    {
        public OwnersValidator()
        {
            RuleFor(u => u.UserId)
              .NotNull()
              .WithMessage("Musthave a User Id");
        }
    }
}
