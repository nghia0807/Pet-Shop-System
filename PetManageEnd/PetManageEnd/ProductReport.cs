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
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=NGHIABUI\MSSQLSERVER01;Initial Catalog=DBPETSHOP;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            SqlCommand command = new SqlCommand("SELECT * from tbProduct", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\trong\\Downloads\\PetShopManage-main\\PetManageEnd\\PetManageEnd\\ProductReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

    }
}
