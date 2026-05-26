using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Models;

namespace University.ViewModel
{
    public class CoursesIndexViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "number")]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
    }
}
