using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class BrandReview
{
    public int BrandReviewId { get; set; }

    public int CustomerId { get; set; }

    public int BrandId { get; set; }

    public int Rating { get; set; }

    public string? ReviewText { get; set; }

    public DateTime ReviewDate { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
