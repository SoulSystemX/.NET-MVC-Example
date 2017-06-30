using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityOfSunderland.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } //foreign key 
        public int StudentID { get; set; } //foreign key 
        public Grade? Grade { get; set; } //nullable

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}