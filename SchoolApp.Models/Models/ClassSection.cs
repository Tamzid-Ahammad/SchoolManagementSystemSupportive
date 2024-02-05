namespace SchoolApp.Models.Models
{
    public class ClassSection
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
    }
}
