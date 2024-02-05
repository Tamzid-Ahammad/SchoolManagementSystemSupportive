namespace SchoolApp.Models.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Routine> TeacherRoutines { get; set; }
        public virtual ICollection<Routine> AlternativeTeacherRoutines { get; set; }
    }
}
