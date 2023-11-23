using System.ComponentModel.DataAnnotations;

namespace Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MinAmount { get; set; }
        [Required]
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
    }
}
