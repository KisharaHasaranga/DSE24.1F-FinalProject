using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ProductReportForm : Form
    {
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");
        SqlConnection con = sqlConnection;
        public ProductReportForm()
        {
            InitializeComponent();
        }
        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblProduct", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblProduct");

            ProductReport productReport = new ProductReport();
            productReport.SetDataSource(ds);
            ProductCrystalReportViewer.ReportSource = productReport;
        }
    }
}