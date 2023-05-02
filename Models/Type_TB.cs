using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class Type_TB
    {
        [Key]
        public int Type_id { get; set; }
        public string? Type_name { get; set; }
    }
}