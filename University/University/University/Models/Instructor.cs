using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //mis on ICollection
        //suur list (Defines methods to manipulate generic collections.)
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        //miks siin ei kasutata ICollection, vaid lihtsalt OffficeAssignment
        //ei ole vaja listi
        public OffficeAssignment OffficeAssignments { get; set; }
    }
}

