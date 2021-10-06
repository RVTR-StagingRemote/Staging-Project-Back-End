﻿using System;
using System.ComponentModel.DataAnnotations;

namespace REST.Models
{
    ///<summary>
    ///This class handles the relationship between courses and their topics
    ///</summary>.
    public class CoursesTopicsJoin
    {
        /// <summary>
        /// Id used to target the join entity
        /// </summary>
        [Key]
        public int JoinId { get; set; }

        /// <summary>
        /// Id for the course entity
        /// </summary>
        public int CoursesId { get; set; }
        public Courses Courses { get; set; }

        /// <summary>
        /// Id for the Topics entity
        /// </summary>
        public int TopicsId { get; set; }
        public Topics Topics { get; set; }
        public CoursesTopicsJoin()
        {
        }
    }
}


