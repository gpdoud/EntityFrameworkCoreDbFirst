using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCoreDbFirst.Models {
    
    public class Orderline {

        public int Id { get; set; }
        [StringLength(30), Required]
        public string Product { get; set; }
        [StringLength(50), Required]
        public string Description { get; set; }
        public int Quantity { get; set; } = 1;
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
