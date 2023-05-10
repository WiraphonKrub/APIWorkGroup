using System.ComponentModel.DataAnnotations;
using APIWorkGroup.Models;
namespace APIWorkGroup.Models
{
    public class Platform_TB
    {
        [Key]
        public int PlatformId { get; set; }
        public string? PlatformName { get; set; }

        public SubPlatform_TB SubPlatform_TB { get; set; }
    }
}