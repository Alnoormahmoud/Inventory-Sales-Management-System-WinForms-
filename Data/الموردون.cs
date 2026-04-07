using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class الموردون
{
    public int رقمالمورد { get; set; }

    public string اسمالمورد { get; set; } = null!;

    public string? الهاتف { get; set; }

    public string? العنوان { get; set; }

    public bool? محذوف { get; set; }

    public virtual ICollection<فواتيرالشراء> فواتيرالشراءs { get; } = new List<فواتيرالشراء>();
}
