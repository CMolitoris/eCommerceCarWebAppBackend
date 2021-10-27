using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class SellerConnection
    {
        [Column(Order = 0), Key, ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Column(Order = 1), Key, ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int Quantity { get; set; }
    }
}
