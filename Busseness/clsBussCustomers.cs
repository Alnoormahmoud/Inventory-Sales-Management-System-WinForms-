using DataAccesses;
using DTOs.CustomersDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenessAccesses
{

    public class clsBussCustomers
    {
        private readonly AppDBContext _context;

        public clsBussCustomers()
        {
            _context = new AppDBContext();
        }

        //  Get All
        public async Task<List<CustomerDTO>> GetAllCustomersAsync()
        {
            return await _context.العملاءs
                .Select(c => new CustomerDTO
                {
                    Id = c.رقمالعميل,
                    Name = c.اسمالعميل,
                    Phone = c.الهاتف,
                    Address = c.العنوان,
                    IsActive = c.محذوف == false
                })
                .ToListAsync();
        }

        //  Add
        //public async Task<int> AddCustomerAsync(clsCustomerDTO dto)
        //{
        //    var customer = new clsDataCustomer
        //    {
        //        Name = dto.Name,
        //        Phone = dto.Phone,
        //        Email = dto.Email,
        //        Address = dto.Address,
        //        Balance = dto.Balance,
        //        IsActive = dto.IsActive
        //    };

        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();

        //    return customer.Id;
        //}

        // 🔹 Update
        //public async Task<bool> UpdateCustomerAsync(clsCustomerDTO dto)
        //{
        //    var customer = await _context.Customers.FindAsync(dto.Id);

        //    if (customer == null)
        //        return false;

        //    customer.Name = dto.Name;
        //    customer.Phone = dto.Phone;
        //    customer.Email = dto.Email;
        //    customer.Address = dto.Address;
        //    customer.Balance = dto.Balance;
        //    customer.IsActive = dto.IsActive;

        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //// 🔹 Delete (Soft)
        //public async Task<bool> DeleteCustomerAsync(int id)
        //{
        //    var customer = await _context.Customers.FindAsync(id);

        //    if (customer == null)
        //        return false;

        //    customer.IsActive = false;

        //    await _context.SaveChangesAsync();
        //    return true;
        //}
    }
}
