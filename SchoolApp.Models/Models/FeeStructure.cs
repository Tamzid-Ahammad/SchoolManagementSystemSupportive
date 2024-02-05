namespace SchoolApp.Models.Models
{
    public class FeeStructure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public int FeeTypeId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual FeeType FeeType { get; set; }

    }
}
