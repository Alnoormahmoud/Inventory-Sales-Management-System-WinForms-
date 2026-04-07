using System;
using System.Collections.Generic;

namespace DataAccesses;

public partial class المستخدمون
{
    public int رقمالمستخدم { get; set; }

    public string الاسمالكامل { get; set; } = null!;

    public string اسمالدخول { get; set; } = null!;

    public string كلمةالمرور { get; set; } = null!;

    public int رقمالدور { get; set; }

    public bool? نشط { get; set; }

    public DateTime? تاريخالإنشاء { get; set; }

    public virtual الأدوار رقمالدورNavigation { get; set; } = null!;

    public virtual ICollection<فواتيرالبيع> فواتيرالبيعs { get; } = new List<فواتيرالبيع>();
}
