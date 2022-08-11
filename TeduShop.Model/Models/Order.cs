using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Tự động tăng
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerMethod { get; set; }

        [Required]
        [MaxLength(256)]
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}