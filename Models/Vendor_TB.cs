using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class Vendor_TB
    {
        [Key]
        public int VendorId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorLocation { get; set; }
        public string? VendorEmail { get; set; }
        public string? VendorPhone { get; set; }
        public string? VendorCompanyName { get; set; }

    }
}