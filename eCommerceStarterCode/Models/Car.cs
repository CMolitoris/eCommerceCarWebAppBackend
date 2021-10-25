using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Mileage { get; set; }
        public double AverageRating { get; set; }
    }
}
