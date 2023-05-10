using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class MALISIB_TB
    {
        [Key]
        public int MALISUBId { get; set; }
        public string? AgreementNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Cost { get; set; }
        public string? Contact { get; set; }


        public ICollection<Type_TB> Type_TBs { get; set; }
    }
}