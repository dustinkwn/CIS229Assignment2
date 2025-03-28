using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Services
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int service_id { get; set; }

        [Required]
        public string service_name { get; set; }

        public string service_description { get; set; }

        [Required]
        public int service_price { get; set; }

        [ForeignKey("Customer")]
        public int customer_id { get; set; }

        public virtual Customer Customer { get; set; }
    }
}