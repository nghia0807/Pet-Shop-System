namespace PetManageEnd
{
    partial class CustomerModule
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
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblCid = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label4 = new Label();
            panel1 = new Panel();
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
            btnClose.TabIndex = 39;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(597, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 31);
            btnCancel.TabIndex = 38;
            btnCancel.Text = " Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(420, 253);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 31);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = " Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(243, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 31);
            btnSave.TabIndex = 36;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCid
            // 
            lblCid.AutoSize = true;
            lblCid.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCid.Location = new Point(78, 249);
            lblCid.Name = "lblCid";
            lblCid.Size = new Size(45, 25);
            lblCid.TabIndex = 33;
            lblCid.Text = "Cid:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(243, 199);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(466, 23);
            txtPhone.TabIndex = 28;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(243, 156);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(466, 23);
            txtAddress.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 151);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 25;
            label3.Text = "Address:";
            // 
            // txtName
            // 
            txtName.Location = new Point(243, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(466, 23);
            txtName.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 23;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(333, 29);
            label1.TabIndex = 22;
            label1.Text = "Customer Registation";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 194);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 27;
            label4.Text = "Phone:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 17);
            panel1.TabIndex = 21;
            // 
            // CustomerModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 336);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblCid);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label4;
        private Panel panel1;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public Label lblCid;
        public TextBox txtPhone;
        public TextBox txtAddress;
        public TextBox txtName;
    }
}