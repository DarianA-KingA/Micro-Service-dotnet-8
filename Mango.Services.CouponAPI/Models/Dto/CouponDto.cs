﻿namespace Mango.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmmount { get; set; }
        public int MinAmmount { get; set; }
    }
}
