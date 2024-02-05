using SchoolApp.Models.Enums;

namespace SchoolApp.Models.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Guid UserId { get; set; }
        public int DepartmentDesignationId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual DepartmentDesignation DepartmentDesignation { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
