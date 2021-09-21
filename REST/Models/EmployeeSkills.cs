using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class EmployeeSkills
    {
        [Key]
        public int Id { get; set; }

        public int TopicsJoinId { get; set; }
        public CoursesTopicsJoin CoursesTopicsJoin { get; set; }
        public int EmplyeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
    }
}
