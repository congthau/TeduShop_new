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
    [Table("Orders")]
    public class Order: Auditable
    {
        [Key]
        public int ID { set; get; }
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [MaxLength(256)]
        public string CustomerAdress { set; get; }
        [MaxLength(256)]
        public string CustomerMail { set; get; }
        public int CustomerMobil { set; get; }
        [MaxLength(256)]
        public string CustomerMessage { set; get; }
        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        public bool PaymentStatus { set; get; }
    }
}
