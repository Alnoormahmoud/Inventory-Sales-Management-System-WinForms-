using BussenessAccesses;
using DTOs.ProductsDTO;
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
    public partial class AddUpdateProduct : Form
    {
        List<CatigoryDTO> Catigories = new List<CatigoryDTO>();
        public AddUpdateProduct()
        {
            InitializeComponent();
        }

        private async void _FillCountriesInComoboBox()
        {
            clsBussCatigories CatigoriesManager = new clsBussCatigories();

            Catigories = await CatigoriesManager.GetAllCatigoriessAsync();

            cbCatigories.DisplayMember = "Name";   // what user sees
            cbCatigories.ValueMember = "Id";       // hidden value

            cbCatigories.DataSource = null;
            cbCatigories.DataSource = Catigories;

        }

        private void AddUpdateProduct_Load(object sender, EventArgs e)
        {
            _FillCountriesInComoboBox();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                // ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbProduct.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                btnSave.Enabled = false; // prevent double click

                var dto = new ProductToAddDTO
                {
                    Name = txtName.Text,
                    PurchasePrice = decimal.Parse(txtPurchesPrice.Text),
                    SalePrice = decimal.Parse(txtSellPrice.Text),
                    Quantity = int.Parse(txtQuentity.Text),
                    Barcode = txtBarcode.Text,

                    CategoryID = cbCatigories.SelectedValue != null ? (int?)cbCatigories.SelectedValue + 1 : null,
                    IsActive = cbIsActive.Checked,
                    ImagePath = (pbProduct.Image).ToString()
                };

                clsBussProducts service = new clsBussProducts();

                bool result = await service.AddProductAsync(dto);

                if (result)
                {
                    lblId.Text = dto.Id.ToString();

                    MessageBox.Show("تم حفظ المنتج بنجاح");
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("فشل في حفظ المنتج");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private bool ValidateForm()
        {
            bool isValid = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "اسم المنتج مطلوب");
                isValid = false;
            }

            if (!decimal.TryParse(txtPurchesPrice.Text, out decimal purchase))
            {
                errorProvider1.SetError(txtPurchesPrice, "قيمة غير صحيحة");
                isValid = false;
            }

            if (!decimal.TryParse(txtSellPrice.Text, out decimal sell))
            {
                errorProvider1.SetError(txtSellPrice, "قيمة غير صحيحة");
                isValid = false;
            }

            if (sell < purchase)
            {
                errorProvider1.SetError(txtSellPrice, "سعر البيع يجب أن يكون أكبر من سعر الشراء");
                isValid = false;
            }

            if (!int.TryParse(txtQuentity.Text, out _))
            {
                errorProvider1.SetError(txtQuentity, "قيمة غير صحيحة");
                isValid = false;
            }

            if(!Nullable.Equals(cbCatigories.SelectedValue, null))
            {
                int selectedCategoryId = (int)cbCatigories.SelectedValue;
                if (!Catigories.Any(c => c.Id == selectedCategoryId))
                {
                    errorProvider1.SetError(cbCatigories, "التصنيف غير صالح");
                    isValid = false;
                }
            }

            if (pbProduct.Image == null)
            {
                errorProvider1.SetError(pbProduct, "يرجى اختيار صورة للمنتج");
                isValid = false;
            }

            return isValid;
        }

    }
}
