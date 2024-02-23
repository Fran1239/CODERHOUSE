using System;
using System.Collections.Generic;

namespace CRM_DAL.Models;

public partial class Userr
{
    public Guid Id { get; set; }

    public string Names { get; set; }

    public string LastNames { get; set; }

    public string UserNames { get; set; }

    public string Emails { get; set; }

    public string Passwords { get; set; }
}
