namespace SchoolApp.Models.Models
{
    public class FeePayment
    {
        public Guid Id { get; set; }
        public decimal TotalFee { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal PreviousDue { get; set; }
        public decimal Fine { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TotalPaid { get; set; }
        public string ModeOfPayment { get; set; }
        public string PaymentModeDetails { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentDue { get; set; }
        public int AcademicYearMonthId { get; set; }
        public Guid StudentId { get; set; }

        public virtual AcademicYearMonth AcademicYearMonth { get; set; }
        public virtual Student Student { get; set; }
        public virtual List<FeeStructure> FeeStructures { get; set; }
    }
}
