using System;
using System.Collections.Generic;

namespace CRM_DAL.Models;

public partial class Sale
{
    public Guid Id { get; set; }

    public string? Comments { get; set; }

    public string? DateTimes { get; set; }
}
