namespace SchoolApp.Models.Models
{
    public class Routine
    {
        public int Id { get; set; }
        public int ClassSectionId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid? AlternativeTeacherId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ClassSection ClassSection { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Teacher AlternativeTeacher { get; set; }
    }
}
