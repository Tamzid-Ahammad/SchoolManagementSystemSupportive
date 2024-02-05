using SchoolApp.Models.Enums;

namespace SchoolApp.Models.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int PassingMarks { get; set; }
        public ExamStatus Status { get; set; }
        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
    }
}
