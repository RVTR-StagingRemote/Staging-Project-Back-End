using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        
    }
}
