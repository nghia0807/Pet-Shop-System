namespace PetManageEnd
{
    partial class CashForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCash = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Increase = new DataGridViewImageColumn();
            Decrease = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            btnCash = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            lblTransno = new Label();
            lblTotalPrice = new Label();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCash).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCash
            // 
            dgvCash.AllowUserToAddRows = false;
            dgvCash.BackgroundColor = SystemColors.ControlLightLight;
            dgvCash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCash.ColumnHeadersHeight = 35;
            dgvCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Increase, Decrease, Delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCash.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCash.Dock = DockStyle.Fill;
            dgvCash.EnableHeadersVisualStyles = false;
            dgvCash.Location = new Point(0, 70);
            dgvCash.Name = "dgvCash";
            dgvCash.RowHeadersVisible = false;
            dgvCash.RowHeadersWidth = 123;
            dgvCash.Size = new Size(1000, 230);
            dgvCash.TabIndex = 5;
            dgvCash.CellContentClick += dgvUser_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 15;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 48;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "CashID";
            Column2.MinimumWidth = 15;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 70;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Pcode";
            Column3.MinimumWidth = 15;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 66;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Name";
            Column4.MaxInputLength = 3276;
            Column4.MinimumWidth = 15;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle2;
            Column5.HeaderText = "Quantity";
            Column5.MinimumWidth = 15;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle3;
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 15;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 60;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle4;
            Column7.HeaderText = "Total";
            Column7.MinimumWidth = 15;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 59;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Customer Name";
            Column8.MinimumWidth = 15;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 122;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Cashier";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 72;
            // 
            // Increase
            // 
            Increase.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Increase.HeaderText = "";
            Increase.Image = (Image)resources.GetObject("Increase.Image");
            Increase.MinimumWidth = 15;
            Increase.Name = "Increase";
            Increase.ReadOnly = true;
            Increase.Width = 15;
            // 
            // Decrease
            // 
            Decrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Decrease.HeaderText = "";
            Decrease.Image = (Image)resources.GetObject("Decrease.Image");
            Decrease.Name = "Decrease";
            Decrease.ReadOnly = true;
            Decrease.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 15;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCash);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTransno);
            panel2.Controls.Add(lblTotalPrice);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(guna2Button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 55);
            panel2.TabIndex = 4;
            // 
            // btnCash
            // 
            btnCash.AutoRoundedCorners = true;
            btnCash.BorderRadius = 18;
            btnCash.CustomizableEdges = customizableEdges1;
            btnCash.DisabledState.BorderColor = Color.DarkGray;
            btnCash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCash.FillColor = Color.FromArgb(255, 192, 192);
            btnCash.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCash.ForeColor = Color.Black;
            btnCash.Location = new Point(789, 7);
            btnCash.Name = "btnCash";
            btnCash.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCash.Size = new Size(116, 39);
            btnCash.TabIndex = 6;
            btnCash.Text = "Cash";
            btnCash.Click += guna2Button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(520, 16);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 6;
            label3.Text = "Total price $";
            // 
            // lblTransno
            // 
            lblTransno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransno.ForeColor = Color.Black;
            lblTransno.Location = new Point(302, 15);
            lblTransno.Name = "lblTransno";
            lblTransno.Size = new Size(106, 25);
            lblTransno.TabIndex = 6;
            lblTransno.Text = "000000000";
            lblTransno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(619, 11);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(130, 31);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "0.00";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(174, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 6;
            label1.Text = "Transaction no:";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.HoverState.BorderColor = Color.Transparent;
            guna2Button1.HoverState.FillColor = Color.Transparent;
            guna2Button1.Image = Properties.Resources.add;
            guna2Button1.Location = new Point(3, 7);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(109, 39);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Product";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 15);
            panel1.TabIndex = 3;
            // 
            // CashForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 300);
            Controls.Add(dgvCash);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashForm";
            Text = "Cash";
            ((System.ComponentModel.ISupportInitialize)dgvCash).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCash;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        public Label lblTransno;
        public Label lblTotalPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewImageColumn Increase;
        private DataGridViewImageColumn Decrease;
        private DataGridViewImageColumn Delete;
    }
}