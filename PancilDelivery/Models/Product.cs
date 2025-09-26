using System;
using System.Collections.Generic;

namespace PancilDelivery.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal PricePerUnit { get; set; }

    public int Unitid { get; set; }

    public string? Volume { get; set; }

    public double Rating { get; set; }

    public string Description { get; set; } = null!;

    public string ExpirationDate { get; set; } = null!;

    public int Categoryld { get; set; }

    public int Manufactureld { get; set; }

    public virtual Category CategoryldNavigation { get; set; } = null!;

    public virtual Manufacturer ManufactureldNavigation { get; set; } = null!;

    public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

    public virtual Unit Unit { get; set; } = null!;
}
