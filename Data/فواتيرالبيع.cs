using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class فواتيرالبيع
{
    public int رقمالفاتورة { get; set; }

    public DateTime? تاريخالفاتورة { get; set; }

    public int? رقمالعميل { get; set; }

    public int? رقمالمستخدم { get; set; }

    public decimal? الإجمالي { get; set; }

    public virtual ICollection<تفاصيلفاتورةالبيع> تفاصيلفاتورةالبيعs { get; } = new List<تفاصيلفاتورةالبيع>();

    public virtual العملاء? رقمالعميلNavigation { get; set; }

    public virtual المستخدمون? رقمالمستخدمNavigation { get; set; }
}
