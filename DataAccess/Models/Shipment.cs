using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public int OrderId { get; set; }

    public DateTime ShipmentDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? TrackingNumber { get; set; }

    public virtual Order Order { get; set; } = null!;
}
