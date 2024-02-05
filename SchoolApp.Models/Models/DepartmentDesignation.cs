namespace SchoolApp.Models.Models
{
    public class DepartmentDesignation
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
