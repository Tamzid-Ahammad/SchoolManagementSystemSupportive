using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models.Models
{
    public class AcademicYear
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Display(Name = "Academic Year")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")]
        public DateTime Year { get; set; }

        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<AcademicYearMonth> AcademicYearMonths { get; set; }
    }
}
