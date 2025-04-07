using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int product_id { get; set; }

        [Required]
        public int product_quantity { get; set; }

        [Required]
        public string product_name { get; set; }

        [ForeignKey("Customer")]
        public int customer_id { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
