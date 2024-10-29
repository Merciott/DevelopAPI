using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Manufacturer
{
    public int ManufacturerId { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<BrandManufacturer> BrandManufacturers { get; set; } = new List<BrandManufacturer>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
