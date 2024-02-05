using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AttendanceDate { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [DataType(DataType.Time)]
        public DateTime AttendanceTime { get; set; }
        public bool IsPresent { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }



    }
}
