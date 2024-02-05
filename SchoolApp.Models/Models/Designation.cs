namespace SchoolApp.Models.Models
{
    public class Designation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DepartmentDesignation> DepartmentDesignations { get; set; }
    }
}
