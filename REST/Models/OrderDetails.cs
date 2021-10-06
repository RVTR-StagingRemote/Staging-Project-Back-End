using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    ///<summary>
    ///This class handles the information of an order
    ///</summary>.
    public class OrderDetails
    {
        ///<summary>
        ///Id used to target the OrderDetails Entity
        ///</summary>
        [Key]
        public int DetailsId { get; set; }

        ///<summary>
        ///Id used for the Course entity
        ///</summary>
        public int CourseId { get; set; }

        ///<summary>
        ///Id used for the Order Entity
        ///</summary>
        public int OrderId { get; set; }

        ///<summary>
        ///Number of associates requested
        ///</summary>
        public int AssociateCount { get; set; }

        ///<summary>
        ///Date the request should be filled by
        ///</summary>
        public DateTime DateNeeded { get; set; }
        public OrderDetails()
        {
        }
    }

    public class OrderDetailsValidator : AbstractValidator<OrderDetails>
    {
        public OrderDetailsValidator()
        {
            RuleFor(o => o.CourseId)
                .NotNull()
                .WithMessage("Must include a course ID.");
            RuleFor(o => o.OrderId)
                .NotNull()
                .WithMessage("Must include an order ID.");
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
