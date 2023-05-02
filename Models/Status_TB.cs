using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIWorkGroup.Models
{
    public class Status_TB
    {
        [Key]
        public int Status_id { get; set; }
        public string? Status_name { get; set; }

    }
}