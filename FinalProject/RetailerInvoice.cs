using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RetailerInvoice : Form
    {
        // DLL imports to allow dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        public RetailerInvoice()
        {
            InitializeComponent();
        }
        private void RetailerInvoice_Load(object sender, EventArgs e)
        {
            LoadReport();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void LoadReport()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblRetailer.retailerName, tblRetailer.retailerId, tblRetailer.retailerContact, tblRetailer.retailerEmail, tblRetailer.retailerAddress, tblRetailerOrder.orderId, tblRetailerOrder.productId, tblRetailerOrder.productName, tblRetailerOrder.productQty, tblRetailerOrder.unitPrice, tblRetailerOrder.orderDate FROM finalproject.dbo.tblRetailerOrder tblRetailerOrder INNER JOIN finalproject.dbo.tblRetailer tblRetailer ON tblRetailerOrder.retailerId=tblRetailer.retailerId where tblRetailerOrder.retailerId = '" + RetailerOrdersForm.retailerIdGlobal + "'", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblRetailerOrder");

            RetailerInvoiceCR retailerInvoice = new RetailerInvoiceCR();
            retailerInvoice.SetDataSource(ds);
            RetailerInvoiceCrystalReportViewer.ReportSource = retailerInvoice;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
