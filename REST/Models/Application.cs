using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using FluentValidation;

namespace REST.Models
{
    ///<summary>
    ///This class handles information and functionality for a Client
    ///</summary>
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        [ForeignKey("ApplicantOccupation")]
        public int ApplicantOccupationId { get; set; }
        public ApplicantOccupation ApplicantOccupation { get; set; }

        [ForeignKey("Need")]
        public int NeedId { get; set; }
        public Need Need { get; set; }
        public DateTime DateOfApplication { get; set; }
        public int Status { get; set; }

        public Application()
        {
        }
    }
}