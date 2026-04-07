namespace DTOs.ProductsDTO
{
    public class ProductToAddDTO
    {
        public int Id { get; set; }             // رقمالمنتج
        public string Name { get; set; } = "";  // اسمالمنتج
        public int? CategoryID { get; set; }    // رقمالتصنيف
        public string? Barcode { get; set; }    // الباركود
        public decimal? PurchasePrice { get; set; } // سعرالشراء
        public decimal? SalePrice { get; set; }     // سعرالبيع
        public int? Quantity { get; set; }          // الكمية
        public bool? IsActive { get; set; }        // نشط
        public string? ImagePath { get; set; }      // مسارالصورة
    }
}
