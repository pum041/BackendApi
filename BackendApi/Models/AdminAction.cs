using System;
using System.Collections.Generic;

namespace BackendApi.Models;

public partial class AdminAction
{
    public int ActionId { get; set; }

    public int AdminId { get; set; }

    public string ActionDescription { get; set; } = null!;

    public DateTime? ActionDate { get; set; }

    public virtual User Admin { get; set; } = null!;
}
