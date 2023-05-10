using APIWorkGroup.Models;
using System.ComponentModel.DataAnnotations;
namespace APIWorkGroup.Models
{
    public class Type_TB
    {
        [Key]
        public int TypeId { get; set; }
        public string? TypeName { get; set; }


        public MALISIB_TB MALISIB_TB { get; set; }
    }
}