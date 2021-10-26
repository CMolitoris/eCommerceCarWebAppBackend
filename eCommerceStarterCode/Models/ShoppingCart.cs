using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }

<<<<<<< HEAD
        //Not primary key
=======
>>>>>>> f557e2f8403cbc1c864069ca8b56751a9c9a0d30
        [Key]
        public int Quantity { get; set; }
    }
}
