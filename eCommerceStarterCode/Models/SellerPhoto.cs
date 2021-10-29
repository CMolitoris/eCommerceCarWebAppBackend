using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class SellerPhoto
    {
        [Key]
        public int Id { get; set; }
        public string ImageResponseData { get; set; }
       
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
