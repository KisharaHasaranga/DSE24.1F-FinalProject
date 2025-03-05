using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ViewAnnouncementForm : Form
    {
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        public ViewAnnouncementForm()
        {
            InitializeComponent();
        }

        private void ViewAnnouncementForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblAnnouncement", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridMessage.DataSource = dt.DefaultView;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
