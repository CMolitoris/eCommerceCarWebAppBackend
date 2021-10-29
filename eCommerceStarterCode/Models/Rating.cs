using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public double RatingScore { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
