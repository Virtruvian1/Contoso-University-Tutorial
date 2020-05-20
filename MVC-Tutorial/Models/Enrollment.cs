namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {//THESE PROPERTIES ARE PASSED INTO STUDENT.CS WHEN ICOLLECTION<ENUMERABLE> IS CALLED


        //This file connects to the user side to take in data and move it to the Student class to be deciphered and stored in the database. Technically the data that is stored here is like cache because it doesn't go deeper and can be reached faster.

        //[Database Properties]
        public int EnrollmentID { get; set; }
            //[Primary Key]

        public int CourseID { get; set; }
        public int StudentID { get; set; }
            //[Foreign Key]

        public Grade? Grade { get; set; }
            //[The grade property is an enum (as listed at the top of the file)]
            //The '?' means that the value can be null, null is different in '0' as it is not addes in the calculations.  

        public Course Course { get; set; }
        public Student Student { get; set; }

        //[End of Database Properties]
    }
}