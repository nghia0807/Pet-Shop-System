namespace PetManageEnd
{
    partial class Dashboardcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboardcs));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbCat = new PictureBox();
            pbHamster = new PictureBox();
            pbDog = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lblDog = new Label();
            lblDogNum = new Label();
            lblHamster = new Label();
            lblHamNum = new Label();
            lblCat = new Label();
            lblCatNum = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDog).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pbCat
            // 
            pbCat.Image = (Image)resources.GetObject("pbCat.Image");
            pbCat.Location = new Point(642, 87);
            pbCat.Name = "pbCat";
            pbCat.Size = new Size(230, 138);
            pbCat.SizeMode = PictureBoxSizeMode.Zoom;
            pbCat.TabIndex = 7;
            pbCat.TabStop = false;
            // 
            // pbHamster
            // 
            pbHamster.Image = Properties.Resources.hamster;
            pbHamster.Location = new Point(337, 87);
            pbHamster.Name = "pbHamster";
            pbHamster.Size = new Size(230, 138);
            pbHamster.SizeMode = PictureBoxSizeMode.Zoom;
            pbHamster.TabIndex = 6;
            pbHamster.TabStop = false;
            // 
            // pbDog
            // 
            pbDog.Image = (Image)resources.GetObject("pbDog.Image");
            pbDog.Location = new Point(30, 87);
            pbDog.Name = "pbDog";
            pbDog.Size = new Size(230, 138);
            pbDog.SizeMode = PictureBoxSizeMode.Zoom;
            pbDog.TabIndex = 5;
            pbDog.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(12, 5);
            label4.Name = "label4";
            label4.Size = new Size(248, 47);
            label4.TabIndex = 4;
            label4.Text = "Pet summary";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 10);
            panel1.TabIndex = 8;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 15;
            guna2TextBox1.BorderThickness = 2;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = Properties.Resources.search;
            guna2TextBox1.Location = new Point(648, 15);
            guna2TextBox1.Margin = new Padding(9, 10, 9, 10);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Search here";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(249, 33);
            guna2TextBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2TextBox1);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 55);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Location = new Point(0, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 10);
            panel3.TabIndex = 10;
            // 
            // lblDog
            // 
            lblDog.AutoSize = true;
            lblDog.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Bold | FontStyle.Italic);
            lblDog.Location = new Point(30, 228);
            lblDog.Name = "lblDog";
            lblDog.Size = new Size(74, 30);
            lblDog.TabIndex = 11;
            lblDog.Text = "Dogs:";
            // 
            // lblDogNum
            // 
            lblDogNum.AutoSize = true;
            lblDogNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDogNum.Location = new Point(100, 226);
            lblDogNum.Name = "lblDogNum";
            lblDogNum.Size = new Size(28, 32);
            lblDogNum.TabIndex = 11;
            lblDogNum.Text = "0";
            // 
            // lblHamster
            // 
            lblHamster.AutoSize = true;
            lblHamster.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Bold | FontStyle.Italic);
            lblHamster.Location = new Point(337, 228);
            lblHamster.Name = "lblHamster";
            lblHamster.Size = new Size(124, 30);
            lblHamster.TabIndex = 11;
            lblHamster.Text = "Hamsters:";
            // 
            // lblHamNum
            // 
            lblHamNum.AutoSize = true;
            lblHamNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHamNum.Location = new Point(457, 226);
            lblHamNum.Name = "lblHamNum";
            lblHamNum.Size = new Size(28, 32);
            lblHamNum.TabIndex = 11;
            lblHamNum.Text = "0";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Bold | FontStyle.Italic);
            lblCat.Location = new Point(642, 228);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(64, 30);
            lblCat.TabIndex = 11;
            lblCat.Text = "Cats:";
            // 
            // lblCatNum
            // 
            lblCatNum.AutoSize = true;
            lblCatNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCatNum.Location = new Point(701, 225);
            lblCatNum.Name = "lblCatNum";
            lblCatNum.Size = new Size(28, 32);
            lblCatNum.TabIndex = 11;
            lblCatNum.Text = "0";
            // 
            // Dashboardcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(915, 261);
            Controls.Add(lblCatNum);
            Controls.Add(lblHamNum);
            Controls.Add(lblDogNum);
            Controls.Add(lblCat);
            Controls.Add(lblHamster);
            Controls.Add(lblDog);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pbCat);
            Controls.Add(pbHamster);
            Controls.Add(pbDog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboardcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to Pet Shop System";
            Load += Dashboardcs_Load;
            ((System.ComponentModel.ISupportInitialize)pbCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDog).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCat;
        private PictureBox pbHamster;
        private PictureBox pbDog;
        private Label label4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Panel panel2;
        private Panel panel3;
        private Label lblDog;
        private Label lblDogNum;
        private Label lblHamster;
        private Label lblHamNum;
        private Label lblCat;
        private Label lblCatNum;
    }
}