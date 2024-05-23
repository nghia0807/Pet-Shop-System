using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=NGHIABUI\MSSQLSERVER01;Initial Catalog=DBPETSHOP;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            reportViewer2.RefreshReport();
            SqlCommand command = new SqlCommand("SELECT * from tbCus", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer2.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer2.LocalReport.ReportPath = "C:\\Users\\trong\\Downloads\\PetShopManage-main\\PetManageEnd\\PetManageEnd\\CustomerReport.rdlc";
            reportViewer2.LocalReport.DataSources.Add(source);
            reportViewer2.RefreshReport();
        }
    }
}
