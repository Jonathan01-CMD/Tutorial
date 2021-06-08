using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial.Models
{
    public class Grades
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
