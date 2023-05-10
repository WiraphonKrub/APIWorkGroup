using System.ComponentModel.DataAnnotations;
using APIWorkGroup.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWorkGroup.Models
{
    public class SubPlatform_TB
    {
        [Key]
        public int SubPlatformId { get; set; }
        public string? SubPlatformName { get; set; }


        public ICollection<Platform_TB> Platform_TBs { get; set; }

    }
}