namespace SchoolApp.Models.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
