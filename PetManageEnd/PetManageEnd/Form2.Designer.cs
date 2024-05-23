namespace PetManageEnd
{
    partial class Form2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label2 = new Label();
            txtUsename = new Guna.UI2.WinForms.Guna2TextBox();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Button();
            btnForgotPass = new Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(269, 45);
            label1.TabIndex = 6;
            label1.Text = "Pet Shop System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(58, 177);
            label3.Name = "label3";
            label3.Size = new Size(191, 45);
            label3.TabIndex = 5;
            label3.Text = "Welcom to ";
            label3.Click += label3_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2CirclePictureBox1.Image = Properties.Resources.Loading;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.InitialImage = Properties.Resources.Loading;
            guna2CirclePictureBox1.Location = new Point(100, 32);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(92, 86);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 4;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(324, 60);
            label2.Name = "label2";
            label2.Size = new Size(349, 45);
            label2.TabIndex = 7;
            label2.Text = "Login to your account";
            // 
            // txtUsename
            // 
            txtUsename.CustomizableEdges = customizableEdges2;
            txtUsename.DefaultText = "";
            txtUsename.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsename.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsename.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsename.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsename.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsename.Font = new Font("Segoe UI", 9F);
            txtUsename.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsename.IconLeft = Properties.Resources.UserIcon;
            txtUsename.Location = new Point(324, 175);
            txtUsename.Name = "txtUsename";
            txtUsename.PasswordChar = '\0';
            txtUsename.PlaceholderText = "Username";
            txtUsename.SelectedText = "";
            txtUsename.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtUsename.Size = new Size(440, 47);
            txtUsename.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.CustomizableEdges = customizableEdges4;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI", 9F);
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.IconLeft = Properties.Resources.ClockIcon;
            txtPass.Location = new Point(324, 248);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.PlaceholderText = "Password";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtPass.Size = new Size(440, 47);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Gray;
            btnLogin.Location = new Point(324, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 37);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnForgotPass
            // 
            btnForgotPass.BackColor = Color.Transparent;
            btnForgotPass.FlatAppearance.BorderSize = 0;
            btnForgotPass.FlatStyle = FlatStyle.Flat;
            btnForgotPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForgotPass.ForeColor = Color.Gray;
            btnForgotPass.Location = new Point(518, 335);
            btnForgotPass.Name = "btnForgotPass";
            btnForgotPass.Size = new Size(246, 37);
            btnForgotPass.TabIndex = 3;
            btnForgotPass.Text = "Forgot Password?";
            btnForgotPass.UseVisualStyleBackColor = false;
            btnForgotPass.Click += btnForgotPass_Click;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges6;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.delete;
            btnClose.Location = new Point(758, 0);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnClose.Size = new Size(43, 41);
            btnClose.TabIndex = 4;
            btnClose.Click += guna2Button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnForgotPass);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUsename);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        internal Button btnLogin;
        private Button btnForgotPass;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2TextBox txtUsename;
    }
}