using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<BrandManufacturer> BrandManufacturers { get; set; } = new List<BrandManufacturer>();

    public virtual ICollection<BrandPromotion> BrandPromotions { get; set; } = new List<BrandPromotion>();

    public virtual ICollection<BrandReview> BrandReviews { get; set; } = new List<BrandReview>();

    public virtual ICollection<BrandSupplier> BrandSuppliers { get; set; } = new List<BrandSupplier>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
