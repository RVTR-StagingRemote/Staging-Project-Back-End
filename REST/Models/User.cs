using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace REST.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
           
        public string Email { get; set; }

        public string Password { get; set; }

        public bool Status { get; set; }

        public string Role { get; set; }

    }

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("Not a valid email address");
            RuleFor(u => u.Password)
                .Length(6, 50)
                .WithMessage("Must be in between 6 and 50 characters");
            RuleFor(u => u.Status)
                .NotNull()
                .WithMessage("Must include status");
            RuleFor(u => u.Role)
                .Length(2, 50)
                .WithMessage("Must be in between 2 and 50 characters");
        }
    }
}
