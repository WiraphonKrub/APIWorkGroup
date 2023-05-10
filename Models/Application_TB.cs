using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class Application_TB
    {
        [Key]
        public int AppCode { get; set; }
        public string? AppName { get; set; }
        public string? AppDetails { get; set; }
        public string? AppGroup { get; set; }
        public decimal Price { get; set; }
        public string? AppType { get; set; }
        public string? Url_In { get; set; }
        public string? Url_PUB { get; set; }
        public bool Mobile { get; set; }
        public DateTime Golive { get; set; }
        public string? InstallerPath { get; set; }
    }
}