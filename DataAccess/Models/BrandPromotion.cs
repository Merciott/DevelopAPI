using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class BrandPromotion
{
    public int BrandPromotionId { get; set; }

    public int BrandId { get; set; }

    public int PromotionId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
}
