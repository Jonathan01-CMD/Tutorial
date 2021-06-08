using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float Height { get; set; }
        public float Weigth { get; set; }

        public StudentAddress Address { get; set; }
        public int GradeId { get; set; }
        public Grades Grade { get; set; }

    }

    
}
