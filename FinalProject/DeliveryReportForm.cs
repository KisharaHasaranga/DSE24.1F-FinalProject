using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DeliveryReportForm : Form
    {
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        public DeliveryReportForm()
        {
            InitializeComponent();
        }

        private void DeliveryReportForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblDelivery", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblDelivery");

            DeliveryReport deliveryReport = new DeliveryReport();
            deliveryReport.SetDataSource(ds);
            DeliveryCrystalReportViewer.ReportSource = deliveryReport;
        }
    }
}
