using System.ComponentModel.DataAnnotations;

namespace APIWorkGroup.Models
{

    public class Admin_TB
    {

        // -------------- Primary Key ----------------

        [Key]
        public int Admin_id { get; set; }

        // -------------- Primary Key ----------------

        public string? Admin_name { get; set; }
        public string? Admin_username { get; set; }
        public string? Admin_password { get; set; }
        public string? Admin_email { get; set; }
        public string? Admin_address { get; set; }

        // -------------- Foreign Key ----------------

        public int Type_id { get; set; }
        public int Status_id { get; set; }

        // -------------- Foreign Key ----------------
    }
}