using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory___Sales_Management_System.Theam
{
    public static class UIStyler
    {
        public static void ApplyPrimaryButtonStyle(Button btn)
        {
            btn.BackColor = AppColors.Accent;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = AppFonts.Button;
        }
    }
}
