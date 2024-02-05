using SchoolApp.Models.Enums;

namespace SchoolApp.Models.Models
{
    public class Admission
    {
        public int Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus Status { get; set; }
        public int RollNumber { get; set; }
        public int StudentId { get; set; }
        public int ClassSectionId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ClassSection ClassSection { get; set; }
        public virtual Student Student { get; set; }
    }
}
