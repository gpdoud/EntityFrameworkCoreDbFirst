using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCoreDbFirst.Models {
    
    public class Customer {

        public int Id { get; set; }
        [StringLength(30), Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;
        [StringLength(15), Required]
        public string State { get; set; } 

    }
}
