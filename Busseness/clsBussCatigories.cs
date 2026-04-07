using DataAccesses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenessAccesses
{
    public class CatigoryDTO
    {
        public int Id { get; set; }              
        public string Name { get; set; } = "";  
        public bool IsDeleted { get; set; }

    }
    public class clsBussCatigories
    {
        public async Task<List<CatigoryDTO>> GetAllCatigoriessAsync()
        {
            using (AppDBContext _Context = new AppDBContext())
            {
                return await Task.Run(() =>
                {
                    return _Context.التصنيفاتs.Where(c => c.محذوف == false)
                    .Select(c => new CatigoryDTO
                    {
                        Id = c.رقمالتصنيف,
                        Name = c.اسمالتصنيف,
                        IsDeleted = c.محذوف == false
                    }).ToListAsync();
                });
            }
        }
    }
}
