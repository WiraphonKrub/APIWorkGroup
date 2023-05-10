using System.ComponentModel.DataAnnotations;

namespace APIWorkGroup.Models
{
    public class OCIO_TB
    {
        [Key]
        public int OCIOId { get; set; }
        public string? OCIOName { get; set; }
        public string? OCIOTeam { get; set; }
        public string? OCIOPhone { get; set; }
        public string? OCIOCompanyName { get; set; }
    }
}