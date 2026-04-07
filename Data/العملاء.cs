using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class العملاء
{
    public int رقمالعميل { get; set; }

    public string اسمالعميل { get; set; } = null!;

    public string? الهاتف { get; set; }

    public string? العنوان { get; set; }

    public bool? محذوف { get; set; }

    public virtual ICollection<فواتيرالبيع> فواتيرالبيعs { get; } = new List<فواتيرالبيع>();
}
