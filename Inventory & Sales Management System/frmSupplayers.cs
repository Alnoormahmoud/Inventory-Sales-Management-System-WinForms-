using BussenessAccesses;
using DTOs.ProductsDTO;
using DTOs.SuplayersDTO;

namespace Inventory___Sales_Management_System
{
    public partial class frmSupplayers : Form
    {
        public frmSupplayers()
        {
            InitializeComponent();
        }

        private async void ShowSuplayers()
        {
            try
            {
                clsBussSuplayers SuplayersManager = new clsBussSuplayers();

                // Get all products
                List<SuplayersDTO> Suplayers = await SuplayersManager.GetAllSuppliersAsync();

                // 1. Get data from Business layer

                guna2DataGridView1.DataSource = null;
                guna2DataGridView1.DataSource = Suplayers;


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


             
                // 4. (Optional) Rename headers nicely

                guna2DataGridView1.Columns["Id"].HeaderText = "رقم المورد";
                guna2DataGridView1.Columns["Name"].HeaderText = "اسم المورد";
                guna2DataGridView1.Columns["Phone"].HeaderText = "رقم الهاتف";
                guna2DataGridView1.Columns["Address"].HeaderText = "العنوان";
                guna2DataGridView1.Columns["IsActive"].HeaderText = "محذوف";
 

                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                guna2DataGridView1.Columns["Id"].Width = 200;
                guna2DataGridView1.Columns["Name"].Width = 350;
                guna2DataGridView1.Columns["Phone"].Width = 300;
                guna2DataGridView1.Columns["Address"].Width = 400;
 

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
                MessageBox.Show("Error loading Suplayers: " + ex.Message);
            }
        }

        private void frmSupplayers_Load(object sender, EventArgs e)
        {
            ShowSuplayers();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateSuplayer Add = new frmAddUpdateSuplayer();
            Add.ShowDialog();

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateSuplayer Add = new frmAddUpdateSuplayer();
            Add.ShowDialog();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
