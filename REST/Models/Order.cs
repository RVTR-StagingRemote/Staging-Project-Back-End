using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OccupationId { get; set; }
        public int ClientId { get; set; }
        public int AssociateCount { get; set; }
        public DateTime DateNeeded { get; set; }
        // this for 1 to 1 relationship between occupations table and orders table
        public virtual Occupation Occupation { get; set; }

        public Order()
        {
        }

    }
    public class OrdersValidator : AbstractValidator<Order>
    {
        public OrdersValidator()
        {
            RuleFor(o => o.OrderId)
                .NotNull()
                .WithMessage("Must include an order ID.");
            RuleFor(o => o.OccupationId)
                .NotNull()
                .WithMessage("Must include a Occupation ID.");
            RuleFor(o => o.ClientId)
                .NotNull()
                .WithMessage("Must include client ID.");
            RuleFor(o => o.AssociateCount)
                .GreaterThan(0)
                .WithMessage("Associate count must be more than 0.");
            RuleFor(o => o.AssociateCount)
                .NotNull()
                .WithMessage("Must include an associate count.");
            RuleFor(o => o.DateNeeded)
                .GreaterThan(DateTime.Now)
                .WithMessage("Date needed must be later than current date.");
        }
    }
}