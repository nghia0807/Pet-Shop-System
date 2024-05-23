namespace PetManageEnd
{
    partial class ProductModule
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            lblPcode = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            txtType = new TextBox();
            lblType = new Label();
            txtName = new TextBox();
            lblName = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            txtQty = new TextBox();
            lblQty = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.delete;
            btnClose.Location = new Point(757, 31);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(43, 41);
            btnClose.TabIndex = 8;
            btnClose.Click += guna2Button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(593, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = " Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += buttonCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(416, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 31);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = " Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += buttonUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(238, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 31);
            btnSave.TabIndex = 5;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSave_Click;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Transparent;
            cbCategory.CustomizableEdges = customizableEdges3;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 20;
            cbCategory.Items.AddRange(new object[] { "Dog", "Cat", "Hamster" });
            cbCategory.Location = new Point(238, 223);
            cbCategory.Name = "cbCategory";
            cbCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbCategory.Size = new Size(466, 26);
            cbCategory.TabIndex = 2;
            // 
            // lblPcode
            // 
            lblPcode.AutoSize = true;
            lblPcode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPcode.Location = new Point(82, 370);
            lblPcode.Name = "lblPcode";
            lblPcode.Size = new Size(68, 25);
            lblPcode.TabIndex = 33;
            lblPcode.Text = "Pcode:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(238, 322);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(466, 23);
            txtPrice.TabIndex = 4;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(82, 322);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 25);
            lblPrice.TabIndex = 31;
            lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(82, 223);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 25);
            lblCategory.TabIndex = 29;
            lblCategory.Text = "Category";
            // 
            // txtType
            // 
            txtType.Location = new Point(238, 175);
            txtType.Name = "txtType";
            txtType.Size = new Size(466, 23);
            txtType.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(82, 175);
            lblType.Name = "lblType";
            lblType.Size = new Size(57, 25);
            lblType.TabIndex = 25;
            lblType.Text = "Type:";
            // 
            // txtName
            // 
            txtName.Location = new Point(238, 127);
            txtName.Name = "txtName";
            txtName.Size = new Size(466, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(82, 127);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 25);
            lblName.TabIndex = 23;
            lblName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(317, 29);
            label1.TabIndex = 22;
            label1.Text = "Product Registation";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 17);
            panel1.TabIndex = 21;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(238, 274);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(466, 23);
            txtQty.TabIndex = 3;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(82, 274);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(92, 25);
            lblQty.TabIndex = 40;
            lblQty.Text = "Quantity:";
            // 
            // ProductModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(txtQty);
            Controls.Add(lblQty);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(cbCategory);
            Controls.Add(lblPcode);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(txtType);
            Controls.Add(lblType);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        public Label lblPcode;
        public Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        public TextBox txtPrice;
        public Label lblPrice;
        public Label lblCategory;
        public TextBox txtType;
        public Label lblType;
        public TextBox txtName;
        public Label lblName;
        public TextBox txtQty;
        public Label lblQty;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
    }
}