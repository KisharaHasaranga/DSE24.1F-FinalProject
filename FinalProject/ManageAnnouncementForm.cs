using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ManageAnnouncementForm : Form
    {
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        public ManageAnnouncementForm()
        {
            InitializeComponent();
        }

        private void ManageAnnouncementForm_Load(object sender, EventArgs e)
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
        private void BtnPost_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into tblAnnouncement (title, message) VALUES (@title, @message)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title", BoxTitle.Text);
                cmd.Parameters.AddWithValue("@message", BoxMessage.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Announcement Posted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BoxTitle.Clear();
                BoxMessage.Clear();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error posting announcement: " + ex.Message);
            }
        }
    }
}
