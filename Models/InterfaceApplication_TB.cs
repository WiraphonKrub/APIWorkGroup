using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class InterfaceApplication_TB
    {
        [Key]
        public int IAppId { get; set; }
        public string? IAppName { get; set; }
        public string? IAppDetails { get; set; }
        public string? IAppGroup { get; set; }
        public string? IIpAddress { get; set; }
        public string? IType { get; set; }
    }
}