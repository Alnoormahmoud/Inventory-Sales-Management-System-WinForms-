namespace Inventory___Sales_Management_System
{
    partial class frmSupplayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            updatePoductToolStripMenuItem = new ToolStripMenuItem();
            eleteProductToolStripMenuItem = new ToolStripMenuItem();
            btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new DataGridView();
            guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { addProductToolStripMenuItem, updatePoductToolStripMenuItem, eleteProductToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(203, 100);
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(202, 32);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // updatePoductToolStripMenuItem
            // 
            updatePoductToolStripMenuItem.Name = "updatePoductToolStripMenuItem";
            updatePoductToolStripMenuItem.Size = new Size(202, 32);
            updatePoductToolStripMenuItem.Text = "Update Poduct";
            // 
            // eleteProductToolStripMenuItem
            // 
            eleteProductToolStripMenuItem.Name = "eleteProductToolStripMenuItem";
            eleteProductToolStripMenuItem.Size = new Size(202, 32);
            eleteProductToolStripMenuItem.Text = "elete Product";
            // 
            // btnAddNew
            // 
            btnAddNew.Animated = true;
            btnAddNew.AnimatedGIF = true;
            btnAddNew.AutoRoundedCorners = true;
            btnAddNew.BackgroundImageLayout = ImageLayout.None;
            btnAddNew.BorderColor = Color.Cornsilk;
            btnAddNew.BorderRadius = 33;
            btnAddNew.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnAddNew.BorderThickness = 5;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.CustomizableEdges = customizableEdges1;
            btnAddNew.DialogResult = DialogResult.OK;
            btnAddNew.DisabledState.BorderColor = Color.DarkGray;
            btnAddNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNew.FillColor = Color.LimeGreen;
            btnAddNew.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.AliceBlue;
            btnAddNew.ImeMode = ImeMode.On;
            btnAddNew.Location = new Point(986, 458);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.PressedColor = Color.CadetBlue;
            btnAddNew.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddNew.Size = new Size(270, 68);
            btnAddNew.TabIndex = 9;
            btnAddNew.Text = "اضافه مورد جديد ";
            btnAddNew.Click += btnAddNew_Click;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BackgroundColor = Color.White;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.GridColor = Color.White;
            guna2DataGridView1.Location = new Point(12, 64);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RightToLeft = RightToLeft.Yes;
            guna2DataGridView1.RowHeadersWidth = 62;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.Size = new Size(1421, 363);
            guna2DataGridView1.TabIndex = 10;
            // 
            // frmSupplayers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1476, 563);
            Controls.Add(guna2DataGridView1);
            Controls.Add(btnAddNew);
            Name = "frmSupplayers";
            Text = "Supplayers";
            Load += frmSupplayers_Load;
            guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem updatePoductToolStripMenuItem;
        private ToolStripMenuItem eleteProductToolStripMenuItem;
        private DataGridView guna2DataGridView1;
    }
}