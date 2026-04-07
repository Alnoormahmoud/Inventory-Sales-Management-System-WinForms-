using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.ProductsDTO
{
    public class ProductDTO
    {
        public int Id { get; set; }             // رقمالمنتج
        public string Name { get; set; } = "";  // اسمالمنتج
        public string? Category { get; set; }    // رقمالتصنيف
     //   public int? CategoryID { get; set; }    // رقمالتصنيف
        public string? Barcode { get; set; }    // الباركود
        public decimal? PurchasePrice { get; set; } // سعرالشراء
        public decimal? SalePrice { get; set; }     // سعرالبيع
        public int? Quantity { get; set; }          // الكمية
        public bool? IsActive { get; set; }        // نشط
        public string? ImagePath { get; set; }      // مسارالصورة
    }
}
