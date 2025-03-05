using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RetailerReportForm : Form
    {
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");
        SqlConnection con = sqlConnection;
        public RetailerReportForm()
        {
            InitializeComponent();
        }
        private void RetailerReportForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblRetailer", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblRetailer");

            RetailerReport retailerReport = new RetailerReport();
            retailerReport.SetDataSource(ds);
            RetailerCrystalReportViewer.ReportSource = retailerReport;
        }
    }
}
