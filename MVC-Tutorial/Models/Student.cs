using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // THIS CLASS OF PROPERTIES IS CALLED WHEN THE STUDENT CLASS IS CALLED

        //[enrollment properties]
        public int ID { get; set; }
            //[Primary Key]
            //default is an ID of some form. i.e. [***ID]

        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //THE PROPERTIES IN THE ENROLLEMNT CLASS IS CALLED HERE.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}