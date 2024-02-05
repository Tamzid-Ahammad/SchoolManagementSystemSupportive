using SchoolApp.Models.Enums;

namespace SchoolApp.Models.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? ParentId { get; set; }
        public StudentStatus Status { get; set; }
        public Guid UserId { get; set; }

        public virtual Parent Parent { get; set; }
        public ApplicationUser User { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
        public virtual ICollection<FeePayment> FeePayments { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
    }
}
