namespace SchoolApp.Models.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Division { get; set; }
        public string Stutus { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<ClassSection> ClassSections { get; set; }
    }
}
