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
    public class ApplicantOccupation
    {
        [Key]
        public int ApplicantOccupationId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        public Applicant Applicant {get; set; }
        public string JobTitle { get; set; }
        public int YearsExperience { get; set; }
        public bool OpenMarket { get; set; }

        public ApplicantOccupation()
        {
        }
    }
}