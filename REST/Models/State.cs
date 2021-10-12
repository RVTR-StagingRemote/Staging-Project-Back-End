using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    /// <summary>
    /// This class handles information and functionality for a State
    /// </summary>
    public class State
    {
        /// <summary>
        /// Id used to target the State entity
        /// </summary>
        [Key]
        public int StateId { get; set; }
        /// <summary>
        /// name for the State entity
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// code for the State entity
        /// </summary>
        public string Code { get; set; }

        
    }
}
