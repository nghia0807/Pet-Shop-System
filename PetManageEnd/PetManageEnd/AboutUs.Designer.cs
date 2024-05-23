namespace PetManageEnd
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(114, 437);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 32);
            textBox1.TabIndex = 5;
            textBox1.Text = "Bùi Trọng Nghĩa";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(114, 475);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 32);
            textBox2.TabIndex = 5;
            textBox2.Text = "48.01.104.095";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(580, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 357);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(580, 437);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 32);
            textBox3.TabIndex = 5;
            textBox3.Text = "Nguyễn Lê Minh Ngọc";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 18F);
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(580, 475);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 32);
            textBox4.TabIndex = 5;
            textBox4.Text = "48.01.103.056";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 15);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 561);
            panel2.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 192);
            panel8.Location = new Point(465, 72);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 504);
            panel8.TabIndex = 2;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 576);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutUs";
            Text = "About us";
            Load += AboutUs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
    }
}