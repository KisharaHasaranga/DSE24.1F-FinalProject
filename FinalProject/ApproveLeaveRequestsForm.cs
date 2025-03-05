using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ApproveLeaveRequestsForm : Form
    {
        public ApproveLeaveRequestsForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int leaveReqId;
        private string status;

        private void ApproveLeaveRequestsForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblLeaveRequest", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridLeaveRequest.DataSource = dt.DefaultView;
        }
        private void GridRestockRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridLeaveRequest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridLeaveRequest.CurrentRow.Selected = true;

                    BoxLeaveReqId.Text = GridLeaveRequest.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxStatus.SelectedItem = GridLeaveRequest.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private void Clear()
        {
            BoxLeaveReqId.Text = string.Empty;
            CBoxStatus.SelectedIndex = -1;
        }
        private void BtnUpdateRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxLeaveReqId.Text != string.Empty || CBoxStatus.SelectedIndex != -1)
            {
                try
                {
                    leaveReqId = Convert.ToInt32(BoxLeaveReqId.Text);
                    status = CBoxStatus.SelectedItem.ToString();

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblLeaveRequest set status=@status where leaveRequestId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("id", leaveReqId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BtnSearchLeaveRequest_Click(object sender, EventArgs e)
        {
            if (BoxSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    leaveReqId = Convert.ToInt32(BoxSearch.Text);
                    SqlCommand cmd = new SqlCommand("select * from tblLeaveRequest where leaveRequestId=@leaveId", con);
                    cmd.Parameters.AddWithValue("leaveId", leaveReqId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridLeaveRequest.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void BtnClearRestockRequest_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnRefreshLeaveRequest_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
