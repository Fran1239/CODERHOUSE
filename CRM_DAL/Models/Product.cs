using System;
using System.Collections.Generic;

namespace CRM_DAL.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string Names { get; set; }

    public int Stock { get; set; }

    public string? Descriptions { get; set; }

    public decimal SalePrices { get; set; }

    public decimal Prices { get; set; }
    
}
