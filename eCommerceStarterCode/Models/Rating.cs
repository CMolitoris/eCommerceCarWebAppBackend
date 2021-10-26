using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int RatingScore { get; set; }


        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
