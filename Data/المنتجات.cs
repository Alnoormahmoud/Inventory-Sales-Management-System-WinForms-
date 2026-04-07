using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class المنتجات
{
    public int رقمالمنتج { get; set; }

    public string اسمالمنتج { get; set; } = null!;

    public int? رقمالتصنيف { get; set; }

    public string? الباركود { get; set; }

    public decimal? سعرالشراء { get; set; }

    public decimal? سعرالبيع { get; set; }

    public int? الكمية { get; set; }

    public bool? نشط { get; set; }

    public string? مسارالصورة { get; set; }

    public virtual ICollection<تفاصيلفاتورةالبيع> تفاصيلفاتورةالبيعs { get; } = new List<تفاصيلفاتورةالبيع>();

    public virtual ICollection<تفاصيلفاتورةالشراء> تفاصيلفاتورةالشراءs { get; } = new List<تفاصيلفاتورةالشراء>();

    public virtual التصنيفات? رقمالتصنيفNavigation { get; set; }


    public static async Task<bool> AddAsync(المنتجات product)
    {
        using (var context = new AppDBContext())
        {
            context.المنتجاتs.Add(product);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
