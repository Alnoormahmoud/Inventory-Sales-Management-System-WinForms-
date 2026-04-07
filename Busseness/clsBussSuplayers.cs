using DataAccesses;
using DTOs.SuplayersDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenessAccesses
{
    public class clsBussSuplayers
    {
        private readonly AppDBContext  _context;

        public clsBussSuplayers()
        {
            _context = new AppDBContext();
        }

        // 🔹 Get All
        public async Task<List<SuplayersDTO>> GetAllSuppliersAsync()
        {
            return await _context.الموردونs
                .Select(s => new SuplayersDTO
                {
                    Id = s.رقمالمورد,
                    Name = s.اسمالمورد,
                    Phone = s.الهاتف,
                    Address = s. العنوان,
                    IsActive = s.محذوف == false
                })
                .ToListAsync();
        }

        // 🔹 Get By Id
        //public async Task<clsSupplierDTO?> GetSupplierByIdAsync(int id)
        //{
        //    var s = await _context.Suppliers.FindAsync(id);

        //    if (s == null)
        //        return null;

        //    return new clsSupplierDTO
        //    {
        //        Id = s.Id,
        //        Name = s.Name,
        //        Phone = s.Phone,
        //        Email = s.Email,
        //        Address = s.Address,
        //        IsActive = s.IsActive
        //    };
        //}

        // 🔹 Add
        public async Task<int> AddSupplierAsync(SuplayersDTO dto)
        {
            var supplier = new الموردون
            {
                 اسمالمورد = dto.Name,
                 الهاتف = dto.Phone,
                 العنوان = dto.Address,
                 محذوف = dto.IsActive
            };

            _context.الموردونs.Add(supplier);
            await _context.SaveChangesAsync();

            return supplier.رقمالمورد;
        }

        // 🔹 Update
    //    public async Task<bool> UpdateSupplierAsync(clsSupplierDTO dto)
    //    {
    //        var supplier = await _context.Suppliers.FindAsync(dto.Id);

    //        if (supplier == null)
    //            return false;

    //        supplier.Name = dto.Name;
    //        supplier.Phone = dto.Phone;
    //        supplier.Email = dto.Email;
    //        supplier.Address = dto.Address;
    //        supplier.IsActive = dto.IsActive;

    //        await _context.SaveChangesAsync();

    //        return true;
    //    }

    //    // 🔹 Delete (Soft Delete)
    //    public async Task<bool> DeleteSupplierAsync(int id)
    //    {
    //        var supplier = await _context.Suppliers.FindAsync(id);

    //        if (supplier == null)
    //            return false;

    //        supplier.IsActive = false;

    //        await _context.SaveChangesAsync();

    //        return true;
    //    }
    }

}
