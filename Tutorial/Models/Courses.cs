using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
