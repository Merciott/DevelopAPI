using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Promotion
{
    public int PromotionId { get; set; }

    public string PromotionName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal DiscountPercentage { get; set; }

    public virtual ICollection<BrandPromotion> BrandPromotions { get; set; } = new List<BrandPromotion>();

    public virtual ICollection<ProductPromotion> ProductPromotions { get; set; } = new List<ProductPromotion>();
}
