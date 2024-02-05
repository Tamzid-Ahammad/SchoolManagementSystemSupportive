namespace SchoolApp.Models.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public virtual int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
