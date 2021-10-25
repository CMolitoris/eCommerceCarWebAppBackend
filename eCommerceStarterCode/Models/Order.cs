using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double Total { get; set; }
        public double ShippingCost { get; set; }
        public bool Shipped { get; set; }
        public int ShippingNumber { get; set; }
        public bool Delivered { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        
    }

    

    
}
