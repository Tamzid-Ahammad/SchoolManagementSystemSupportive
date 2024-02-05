namespace SchoolApp.Models.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string GuardianEmail { get; set; }
        public Guid? FatherId { get; set; }
        public Guid? MotherId { get; set; }

        public ApplicationUser Father { get; set; }
        public ApplicationUser Mother { get; set; }
        public virtual List<Student> refStudents { get; set; } = new List<Student>();
    }
}
