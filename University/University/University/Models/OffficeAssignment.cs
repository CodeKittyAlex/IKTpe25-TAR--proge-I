using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class OffficeAssignment
    {
        //kui soovite konkreetselt välja tuua, et InstructorId on nii OffficeAssignment
        //peamine võti kui ka võõrvõti, siis saate kasutada [key] ja [ForeignKey] atribuute:
        [Key]
        public int InstructorId { get; set; }

        public string Location { get; set; } = string.Empty;

        public Instructor instructor { get; set; }
    }
}
