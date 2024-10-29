using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class BrandSupplier
{
    public int BrandSupplierId { get; set; }

    public int BrandId { get; set; }

    public int SupplierId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
