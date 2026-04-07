using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class تفاصيلفاتورةالبيع
{
    public int رقمالسطر { get; set; }

    public int رقمالفاتورة { get; set; }

    public int رقمالمنتج { get; set; }

    public int الكمية { get; set; }

    public decimal? سعرالوحدة { get; set; }

    public decimal? الإجمالي { get; set; }

    public virtual فواتيرالبيع رقمالفاتورةNavigation { get; set; } = null!;

    public virtual المنتجات رقمالمنتجNavigation { get; set; } = null!;
}
