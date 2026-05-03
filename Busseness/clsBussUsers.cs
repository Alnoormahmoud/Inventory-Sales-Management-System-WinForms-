using DataAccesses;
using DTOs.UsersDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenessAccesses
{

    public class clsBussUsers
    {
        private readonly AppDBContext _context;

        public clsBussUsers()
        {
            _context = new AppDBContext();
        }

        // 🔹 Get All Users
        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            return await _context.المستخدمونs
                .Select(u => new UserDTO
                {
                    Id = u.رقمالمستخدم,
                    UserName = u.اسمالدخول,
                    FullName = u.الاسمالكامل,
                    Role = u.رقمالدورNavigation.اسمالدور,
                    IsActive = u.نشط == true,
                    CreatedAt = u.تاريخالإنشاء.Value
                })
                .ToListAsync();
        }

        // 🔹 Add User
        public async Task<int> AddUserAsync(UserToAddDTO dto)
        {
            var user = new المستخدمون
            {
                اسمالدخول = dto.UserName,
                الاسمالكامل = dto.FullName,
                كلمةالمرور = dto.Password, // ⚠️ later we hash this
                 رقمالدور = dto.Role,
                نشط = dto.IsActive,
                تاريخالإنشاء = DateTime.UtcNow
            };

            _context.المستخدمونs.Add(user);
            await _context.SaveChangesAsync();

            return user.رقمالمستخدم;
        }

        //// 🔹 Update User
        //public async Task<bool> UpdateUserAsync(clsUserDTO dto)
        //{
        //    var user = await _context.Users.FindAsync(dto.Id);

        //    if (user == null)
        //        return false;

        //    user.UserName = dto.UserName;
        //    user.FullName = dto.FullName;
        //    user.Password = dto.Password;
        //    user.Role = dto.Role;
        //    user.IsActive = dto.IsActive;

        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //// 🔹 Delete (Soft Delete)
        //public async Task<bool> DeleteUserAsync(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);

        //    if (user == null)
        //        return false;

        //    user.IsActive = false;

        //    await _context.SaveChangesAsync();
        //    return true;
        //}
    }
}
