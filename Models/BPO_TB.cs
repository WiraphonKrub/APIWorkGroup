using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class BPO_TB
    {
        [Key]
        public int BPOId { get; set; }
        public string? BPOName { get; set; }
        public string? BPOTeam { get; set; }
        public string? BPOContactPhone { get; set; }
        public string? BPOCompanyName { get; set; }
        public string? BPOEmail { get; set; }
    }
}