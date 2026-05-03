using DataAccesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenessAccesses
{
    public class clsBussRoles
    {
        public Task<Dictionary<int, string>> GetAllRolesAsync()
        {
            using (AppDBContext _Context = new AppDBContext())
            {
                return Task.FromResult(_Context.الأدوارs.ToDictionary(r => r.رقمالدور, r => r.اسمالدور));

            }

        }
    }
}
