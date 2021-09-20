using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime DOB { get; set; }

        public string EmployeeType { get; set; }

        public string Degree { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }
    }
}
