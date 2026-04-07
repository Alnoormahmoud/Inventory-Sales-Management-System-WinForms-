using BussenessAccesses;
using DTOs.SuplayersDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory___Sales_Management_System
{
    public partial class frmAddUpdateSuplayer : Form
    {
        public frmAddUpdateSuplayer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "اسم المورد مطلوب");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAdderes.Text))
            {
                errorProvider1.SetError(txtAdderes, "عنوان المورد مطلوب");
                isValid = false;
            }
  
  
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "رقم هاتف المورد مطلوب");
                isValid = false;
            }
  
  

            return isValid;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateForm())
                return;

            try
            {
                btnSave.Enabled = false; // prevent double click
                SuplayersDTO dto = new SuplayersDTO
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAdderes.Text,
                    IsActive = true
                };

                clsBussSuplayers Suplayer = new clsBussSuplayers();

                await Suplayer.AddSupplierAsync(dto);

                lblId.Text = dto.Id.ToString();
                MessageBox.Show("تم حفظ المورد بنجاح");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
