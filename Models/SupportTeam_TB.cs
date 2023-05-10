using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class SupportTeam_TB
    {
        [Key]
        public int SupportId { get; set; }
        public string? SupporterName { get; set; }
        public string? SupportTeam { get; set; }
        public string? SupporterPhone { get; set; }
        public string? CompanyName { get; set; }
        public string? SupporterEmail { get; set; }
    }
}