using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkCoreDbFirst.Models {
    
    public class Order {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        [StringLength(80), Required]
        public string Description { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
