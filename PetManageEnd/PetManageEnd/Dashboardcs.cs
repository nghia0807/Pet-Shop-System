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
    public partial class Dashboardcs : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        string title = "Pet Shop Management System";

        public Dashboardcs()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());

        }

        #region Method
        public int extractData(string str)
        {
            int data = 0;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT ISNULL(SUM(pqty), 0) AS qty FROM tbProduct WHERE pcategory = '" + str + "'", cn);
                data = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
            return data;
        }
        #endregion Method

        private void Dashboardcs_Load(object sender, EventArgs e)
        {
            lblDogNum.Text = extractData("Dog").ToString();
            lblCatNum.Text = extractData("Cat").ToString();
            lblHamNum.Text = extractData("Hamster").ToString();
        }
    }
}
