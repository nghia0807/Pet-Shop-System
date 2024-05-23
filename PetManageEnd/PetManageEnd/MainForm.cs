using Microsoft.Data.SqlClient;
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
    public partial class MainForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        string title = "Pet Shop Management System";
        private string lastResetDate = "";
        public MainForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            btnDashboard.PerformClick();
            loadDailySale();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboardcs(), childpanel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Panel childPanel = new Panel();
            childPanel.Visible = false;
            OpenChildForm(new UserForm(), childpanel);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer(), childpanel);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product(), childpanel);
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CashForm(this), childpanel);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AboutUs(), childpanel);
        }
        private void btnPR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductReport(), childpanel);
        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerReport(), childpanel);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form2 login = new Form2();
                this.Dispose();
                login.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void childpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Method
        private Form activeForm = null;
        public void OpenChildForm(Form childform, Panel parentPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childform;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            if (childform.Text == "About us")
            {
                parentPanel.Height = 576;
            }
            else
            {
                parentPanel.Height = 261;
            }

            parentPanel.Controls.Add(activeForm);
            activeForm.BringToFront();
            activeForm.Show();

            parentPanel.Parent.Controls.SetChildIndex(parentPanel, 0);

            label3.Text = childform.Text;
        }

        public void loadDailySale()
        {
            string crntdate = DateTime.Now.ToString("yyyyMMdd");
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT ISNULL(SUM(total), 0) AS total FROM tbCash WHERE transno LIKE '" + crntdate + "%'", cn);
                double totalSales = double.Parse(cm.ExecuteScalar().ToString());
                lblDailySale.Text = totalSales.ToString("#0,##0.00");
                cn.Close();
                if (crntdate != lastResetDate)
                {
                    totalSales = 0;
                    lastResetDate = crntdate;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Method

    }
}
