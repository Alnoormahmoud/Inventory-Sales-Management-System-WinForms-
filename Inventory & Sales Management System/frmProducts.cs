using BussenessAccesses;
using DTOs.ProductsDTO;
using Guna.UI2.WinForms;
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
    public partial class frmProducts : Form
    {

        public frmProducts()
        {
            InitializeComponent();

            guna2DataGridView1.ColumnHeadersVisible = true;
            guna2DataGridView1.EnableHeadersVisualStyles = false;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            guna2DataGridView1.ColumnHeadersHeight = 40;

            // ثم اربطها بالـ DataSource
        }


        private async void ShowProducts()
        {
            try
            {
                clsBussProducts productManager = new clsBussProducts();

                // Get all products
                List<ProductDTO> products = await productManager.GetAllProductsAsync();

                // 1. Get data from Business layer

                guna2DataGridView1.DataSource = null;
                guna2DataGridView1.DataSource = products;
                if (!guna2DataGridView1.Columns.Contains("ProductImage"))
                {
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.Name = "ProductImage";
                    imgCol.HeaderText = "الصورة";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    guna2DataGridView1.Columns.Insert(0, imgCol); // optional: first column


                    //guna2DataGridView1.Columns.Add(imgCol);
                }
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    string? path = row.Cells["ImagePath"].Value?.ToString();

                    if (!string.IsNullOrEmpty(path))
                    {
                        string fullPath = Path.Combine(Application.StartupPath, path.Replace("/", "\\"));

                        if (File.Exists(fullPath))
                        {
                            using (var imgTemp = Image.FromFile(fullPath))
                            {
                                // resize to fit nicely
                                row.Cells["ProductImage"].Value = new Bitmap(imgTemp, new Size(100, 100));
                            }
                        }
                        else
                        {
                            row.Cells["ProductImage"].Value = null; // optional default image
                        }
                    }
                }
                // 3. Adjust UI
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.RowTemplate.Height = 500;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

                // Font for rows
                guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                // Align text nicely
                guna2DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Optional: better selection color
                guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;


                //  Status Settings

                if (!guna2DataGridView1.Columns.Contains("StatusText"))
                {
                    guna2DataGridView1.Columns.Add("StatusText", "الحالة");
                }
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    bool? isActive = row.Cells["IsActive"].Value as bool?;

                    row.Cells["StatusText"].Value = (isActive == true) ? "نشط" : "غير نشط";
                }
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    var cell = row.Cells["StatusText"];

                    if (cell.Value?.ToString() == "نشط")
                    {
                        cell.Style.BackColor = Color.LightGreen;
                        cell.Style.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightCoral;
                        cell.Style.ForeColor = Color.DarkRed;
                    }

                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                guna2DataGridView1.Columns["PurchasePrice"].DefaultCellStyle.Format = "N2";
                guna2DataGridView1.Columns["SalePrice"].DefaultCellStyle.Format = "N2";
                guna2DataGridView1.Columns["ImagePath"].Visible = false;
                guna2DataGridView1.Columns["IsActive"].Visible = false;

                // 4. (Optional) Rename headers nicely

                guna2DataGridView1.Columns["Id"].HeaderText = "رقم المنتج";
                guna2DataGridView1.Columns["Name"].HeaderText = "اسم المنتج";
                guna2DataGridView1.Columns["Category"].HeaderText = "التصنيف";
                guna2DataGridView1.Columns["Barcode"].HeaderText = "باركود";
                guna2DataGridView1.Columns["PurchasePrice"].HeaderText = "سعر الشراء";
                guna2DataGridView1.Columns["SalePrice"].HeaderText = "سعر البيع";
                guna2DataGridView1.Columns["Quantity"].HeaderText = "الكمية";
                guna2DataGridView1.Columns["IsActive"].HeaderText = "نشط";

                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                guna2DataGridView1.Columns["Name"].Width = 250;
                guna2DataGridView1.Columns["Category"].Width = 250;
                guna2DataGridView1.Columns["Barcode"].Width = 170;
                guna2DataGridView1.Columns["PurchasePrice"].Width = 140;
                guna2DataGridView1.Columns["SalePrice"].Width = 140;
                guna2DataGridView1.Columns["Quantity"].Width = 100;
                guna2DataGridView1.Columns["IsActive"].Width = 80;
                guna2DataGridView1.Columns["ProductImage"].Width = 150;

                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    int? qty = row.Cells["Quantity"].Value as int?;

                    if (qty.HasValue && qty < 5)
                    {
                        row.Cells["Quantity"].Style.BackColor = Color.LightYellow;
                        row.Cells["Quantity"].Style.ForeColor = Color.Red;
                    }
                }
                // Remove ugly borders
                guna2DataGridView1.BorderStyle = BorderStyle.None;
                guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

                // Header style
                guna2DataGridView1.EnableHeadersVisualStyles = false;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // Alternating rows (zebra effect 🔥)
                guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Add = new AddUpdateProduct();

            Add.ShowDialog();
 

        }


    }
}
