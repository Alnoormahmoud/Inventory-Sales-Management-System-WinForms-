using DataAccesses;
using DTOs.ProductsDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BussenessAccesses
{
    public class clsBussProducts
    { 
        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            using (AppDBContext _Context = new AppDBContext())
            {
                return await _Context.المنتجاتs
                    .Select(p => new ProductDTO
                    {
                        Id = p.رقمالمنتج,
                        Name = p.اسمالمنتج,
                        Category = p.رقمالتصنيفNavigation.اسمالتصنيف,
                        Barcode = p.الباركود,
                        PurchasePrice = p.سعرالشراء,
                        SalePrice = p.سعرالبيع,
                        Quantity = p.الكمية,
                        IsActive = p.نشط,
                        ImagePath = p.مسارالصورة
                    })
                    .ToListAsync();

            }
        }


        public async Task<bool> AddProductAsync(ProductToAddDTO dto)
        {
            // 🔴 Validation
            if (string.IsNullOrWhiteSpace(dto.Name))
                return false;

            if (dto.SalePrice < dto.PurchasePrice)
                return false;

            // 🔄 Map DTO → Entity
            var product = new المنتجات
            {
                رقمالتصنيف = dto.CategoryID,
                الباركود = dto.Barcode,
                اسمالمنتج = dto.Name,
                سعرالشراء = dto.PurchasePrice,
                سعرالبيع = dto.SalePrice,
                الكمية = dto.Quantity,
                نشط = dto.IsActive,
                مسارالصورة = dto.ImagePath
            };

            // 💾 Save using Data Access
            return await المنتجات.AddAsync(product);
        }
        
    }
}
     
