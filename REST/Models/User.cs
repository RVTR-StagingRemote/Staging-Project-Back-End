using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    /// <summary>
    /// This class handles information and functionality for a User
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id used to target the User entity
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Email of the User entity
        /// </summary>        
        public string Email { get; set; }
        /// <summary>
        /// Password of the User entity
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Status of the User entity
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Role of the User entity
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Id used for the Client Entity
        /// </summary>
        public int ClientID { get; set; }

    }
}
