using System.ComponentModel.DataAnnotations;

namespace University.ViewModel
{
    public class EnrollmentDateGroupViewModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime? EnrolmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
