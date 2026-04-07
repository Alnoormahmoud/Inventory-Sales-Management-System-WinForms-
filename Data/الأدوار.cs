using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class الأدوار
{
    public int رقمالدور { get; set; }

    public string اسمالدور { get; set; } = null!;

    public virtual ICollection<المستخدمون> المستخدمونs { get; } = new List<المستخدمون>();
}
