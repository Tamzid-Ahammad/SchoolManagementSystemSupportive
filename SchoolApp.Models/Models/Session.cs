namespace SchoolApp.Models.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
