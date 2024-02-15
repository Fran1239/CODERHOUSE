using System;
using System.Collections.Generic;

namespace CRM_DAL.Models;

public partial class SoldProduct
{
    public Guid Id { get; set; }

    public string? Stock { get; set; }
}
