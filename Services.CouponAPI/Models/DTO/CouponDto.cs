﻿namespace Services.CouponAPI.Models.DTO
{
    public class CouponDto
    {
        public int Id { get; set; }
        public int MinAmount { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
    }
}