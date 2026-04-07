 using Guna.UI2.WinForms;
using Inventory___Sales_Management_System.Theam;
using System;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace Inventory___Sales_Management_System
{
    public partial class frmMain : Form
    {
        private IconButton Currentbtn;
        private Panel Leftborderbtn;
        private Form CurrentChildForm;
        public frmMain()
        {
            InitializeComponent();

            Leftborderbtn = new Panel();
            Leftborderbtn.Size = new Size(10, 90);
            MenuPanel.Controls.Add(Leftborderbtn);

            //form

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void ActiveteBtn(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableBtn();

                Currentbtn = (IconButton)senderbtn;
                Currentbtn.BackColor = Color.FromArgb(37, 63, 81);
                Currentbtn.ForeColor = color;
                Currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                Currentbtn.IconColor = color;
                Currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                Currentbtn.ImageAlign = ContentAlignment.MiddleLeft;

                //leftborder

                Leftborderbtn.BackColor = color;
                Leftborderbtn.Location = new Point(287, Currentbtn.Location.Y);
                Leftborderbtn.Visible = true;
                Leftborderbtn.BringToFront();

                //Icon and Title

            }
        }

        private void DisableBtn()
        {
            if (Currentbtn != null)
            {
                Currentbtn.BackColor = Color.Teal;//FromArgb(31, 41, 55);
                Currentbtn.ForeColor = Color.FloralWhite;
                Currentbtn.TextAlign = ContentAlignment.MiddleRight;
                Currentbtn.IconColor = Color.FloralWhite;
                Currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                Currentbtn.ImageAlign = ContentAlignment.MiddleRight;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OpenChildForm(new frmChildMain());

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
            OpenChildForm(new frmChildMain());


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);

            OpenChildForm(new frmChildMain());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
            OpenChildForm(new frmProducts());

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
            OpenChildForm(new frmChildMain());


        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            DisableBtn();

            Leftborderbtn.Visible = false;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableBtn();

            Leftborderbtn.Visible = false;


        }


        //drag form

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr HWND, int WsMG, int Wparm, int lParm);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            paneldesktop.Controls.Add(ChildForm);
            paneldesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }


        private void ibReports_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
        }

        private void ibPurchases_Click(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);
 
            OpenChildForm(new frmSupplayers());
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActiveteBtn(sender, Color.BlanchedAlmond);

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
