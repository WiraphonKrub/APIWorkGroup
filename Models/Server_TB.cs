using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class Server_TB
    {
        [Key]
        public int ServerId { get; set; }
        public string? ServerName { get; set; }
        public string? ServerDescription { get; set; }
        public string? IpAddress { get; set; }
        public string? OperatingSystem { get; set; }
        public string? Cpu { get; set; }
        public int Memory { get; set; }
        public int Storage { get; set; }
        public string? Location { get; set; }
        public string? Notes { get; set; }
    }
}