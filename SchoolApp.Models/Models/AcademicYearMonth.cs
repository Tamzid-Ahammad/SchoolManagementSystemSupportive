using Microsoft.SqlServer.Management.Smo;
namespace SchoolApp.Models.Models
{
    public class AcademicYearMonth
    {
        public int Id { get; set; }
        public Month Month { get; set; }
        public int AcademicYearId { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ICollection<FeePayment> FeePayments { get; set; }
    }
}
