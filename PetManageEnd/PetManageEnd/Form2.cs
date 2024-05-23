using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManageEnd
{
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        string title = "Pet Shop Management System";
        public Form2()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = "", _role = "";
                cn.Open();
                cm = new SqlCommand("SELECT name, role FROM tbUser WHERE name = @name and password = @password", cn);
                cm.Parameters.AddWithValue("@name", txtUsename.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    MessageBox.Show("Welcome " + _name, "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.lblUsername.Text = _name;
                    main.lblRole.Text = _role;
                    if(_role == "Administrator") main.btnUser.Enabled = true;

                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    cn.Close();
                    MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }

            //string usernameQuanLy = "admin";
            //string passwordQuanLy = "admin123";

            //string usernameNhanVien = "staff";
            //string passwordNhanVien = "staff123";
            //string username = User.Text;
            //string password = Pass.Text;

            //if (username == usernameQuanLy && password == passwordQuanLy)
            //{
            //    // Đăng nhập thành công với vai trò quản lý
            //    MainForm f = new MainForm();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else if (username == usernameNhanVien && password == passwordNhanVien)
            //{
            //    // Đăng nhập thành công với vai trò nhân viên
            //    MessageBox.Show("Đăng nhập thành công với vai trò nhân viên");
            //    // Thực hiện các hành động nhân viên tại đây
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên người dùng hoặc mật khẩu");

            //}

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your BOSS!", "FORGOT PASSWORD?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
