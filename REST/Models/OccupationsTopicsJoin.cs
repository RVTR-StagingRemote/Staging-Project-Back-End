using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
    ///<summary>
    ///This class handles the relationship between Occupations and their topics
    ///</summary>.
    public class OccupationsTopicsJoin
    {
        /// <summary>
        /// Id used to target the join entity
        /// </summary>
        [Key]
        public int JoinId { get; set; }

        /// <summary>
        /// Id for the Occupation entity
        /// </summary>
        public int OccupationsId { get; set; }
        public Occupations Occupations { get; set; }

        /// <summary>
        /// Id for the Topics entity
        /// </summary>
        public int TopicsId { get; set; }
        public Topics Topics { get; set; }
        public OccupationsTopicsJoin()
        {
        }
    }
}


