using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class BrandManufacturer
{
    public int BrandManufacturerId { get; set; }

    public int BrandId { get; set; }

    public int ManufacturerId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;
}
