using System.ComponentModel.DataAnnotations;

namespace University.ViewModel
{
    public class StudentDeleteViewModel
    {
        public int Id { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public ICollection<EnrollmentViewModel> EnrollmentsVm { get; set; }
    }
}
