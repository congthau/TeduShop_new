using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Content { get; set; }
    }
}
