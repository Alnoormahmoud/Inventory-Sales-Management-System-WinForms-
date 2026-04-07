using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class التصنيفات
{
    public int رقمالتصنيف { get; set; }

    public string اسمالتصنيف { get; set; } = null!;

    public bool? محذوف { get; set; }

    public virtual ICollection<المنتجات> المنتجاتs { get; } = new List<المنتجات>();
}
