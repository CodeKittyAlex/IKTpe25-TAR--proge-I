using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace University.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        [Column(TypeName ="money")]
        public decimal budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? InstructorId { get; set; }
        public Instructor Administrator { get; set; }
        public ICollection<Course> courses { get; set; }
    }
}
