using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class فواتيرالشراء
{
    public int رقمالشراء { get; set; }

    public int? رقمالمورد { get; set; }

    public DateTime? تاريخالشراء { get; set; }

    public decimal? الإجمالي { get; set; }

    public virtual ICollection<تفاصيلفاتورةالشراء> تفاصيلفاتورةالشراءs { get; } = new List<تفاصيلفاتورةالشراء>();

    public virtual الموردون? رقمالموردNavigation { get; set; }
}
