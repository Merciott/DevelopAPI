using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public virtual ICollection<BrandSupplier> BrandSuppliers { get; set; } = new List<BrandSupplier>();

    public virtual ICollection<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
