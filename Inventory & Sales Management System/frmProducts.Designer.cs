namespace Inventory___Sales_Management_System
{
    partial class frmProducts
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
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            updatePoductToolStripMenuItem = new ToolStripMenuItem();
            eleteProductToolStripMenuItem = new ToolStripMenuItem();
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
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.AllowUserToResizeColumns = false;
            guna2DataGridView1.AllowUserToResizeRows = false;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BackgroundColor = Color.White;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.ContextMenuStrip = guna2ContextMenuStrip1;
            guna2DataGridView1.Location = new Point(12, 44);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RightToLeft = RightToLeft.Yes;
            guna2DataGridView1.RowHeadersWidth = 62;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.Size = new Size(1567, 423);
            guna2DataGridView1.TabIndex = 1;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1591, 703);
            Controls.Add(guna2DataGridView1);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem updatePoductToolStripMenuItem;
        private ToolStripMenuItem eleteProductToolStripMenuItem;
        private DataGridView guna2DataGridView1;
    }
}