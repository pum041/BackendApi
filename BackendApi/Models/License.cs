using System;
using System.Collections.Generic;

namespace BackendApi.Models;

public partial class License
{
    public int LicenseId { get; set; }

    public int ProductId { get; set; }

    public string LicenseKey { get; set; } = null!;

    public bool? IsActivated { get; set; }

    public DateTime? ActivatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;
}
