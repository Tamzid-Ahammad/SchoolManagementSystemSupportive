namespace SchoolApp.Models.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClassSection> ClassSections { get; set; }
    }
}
