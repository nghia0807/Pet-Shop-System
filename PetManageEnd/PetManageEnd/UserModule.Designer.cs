namespace PetManageEnd
{
    partial class UserModule
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPass = new TextBox();
            lblPass = new Label();
            lblUid = new Label();
            cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            dtDob = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 17);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(269, 29);
            label1.TabIndex = 1;
            label1.Text = "User Registation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 130);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(247, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(466, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(247, 178);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(466, 23);
            txtAddress.TabIndex = 1;
            txtAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 173);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(247, 221);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(466, 23);
            txtPhone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 216);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 6;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 259);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 8;
            label5.Text = "Role:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 302);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 10;
            label6.Text = "Date of birth:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(247, 353);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(466, 23);
            txtPass.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(82, 345);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(96, 25);
            lblPass.TabIndex = 12;
            lblPass.Text = "Password:";
            // 
            // lblUid
            // 
            lblUid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUid.AutoSize = true;
            lblUid.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUid.Location = new Point(82, 388);
            lblUid.Name = "lblUid";
            lblUid.Size = new Size(46, 25);
            lblUid.TabIndex = 14;
            lblUid.Text = "Uid:";
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.Transparent;
            cbRole.CustomizableEdges = customizableEdges3;
            cbRole.DrawMode = DrawMode.OwnerDrawFixed;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FocusedColor = Color.FromArgb(94, 148, 255);
            cbRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbRole.Font = new Font("Segoe UI", 10F);
            cbRole.ForeColor = Color.FromArgb(68, 88, 112);
            cbRole.ItemHeight = 20;
            cbRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            cbRole.Location = new Point(247, 264);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbRole.Size = new Size(466, 26);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // dtDob
            // 
            dtDob.Location = new Point(247, 310);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(466, 23);
            dtDob.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(247, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(424, 392);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = " Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button2_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(601, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = " Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += buttonCancel_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.BorderColor = Color.Transparent;
            guna2Button1.HoverState.FillColor = Color.Transparent;
            guna2Button1.Image = Properties.Resources.delete;
            guna2Button1.Location = new Point(757, 17);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(43, 41);
            guna2Button1.TabIndex = 9;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // UserModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtDob);
            Controls.Add(cbRole);
            Controls.Add(lblUid);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label2;
        private Label label1;
        private Label lblPass;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public TextBox txtName;
        public Guna.UI2.WinForms.Guna2ComboBox cbRole;
        public Label lblUid;
        public TextBox txtPass;
        public TextBox txtPhone;
        public TextBox txtAddress;
        public Button btnUpdate;
        public Button btnSave;
        public DateTimePicker dtDob;
    }
}