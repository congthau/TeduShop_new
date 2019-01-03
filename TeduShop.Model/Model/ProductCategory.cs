using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("ProductCategorys")]
    public class ProductCategory: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(256)]
        public string Name { set; get; }
        public int? ParentID { set; get; }
        public string? DisplayOrder { set; get; }
        public bool? HomeFlag { set; get; }
    }
}
