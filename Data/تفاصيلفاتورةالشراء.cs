using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class تفاصيلفاتورةالشراء
{
    public int رقمالسطر { get; set; }

    public int? رقمالشراء { get; set; }

    public int? رقمالمنتج { get; set; }

    public int? الكمية { get; set; }

    public decimal? سعرالشراء { get; set; }

    public virtual فواتيرالشراء? رقمالشراءNavigation { get; set; }

    public virtual المنتجات? رقمالمنتجNavigation { get; set; }
}
