using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ApproveRestockRequest : Form
    {
        public ApproveRestockRequest()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int restockReqId;
        private int restockProductId;
        private string date;
        private string status;
        private void ApproveRestockRequest_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblRestockRequest", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridRestockRequest.DataSource = dt.DefaultView;
        }

        private void GridRestockRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridRestockRequest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridRestockRequest.CurrentRow.Selected = true;

                    BoxRestockRequestId.Text = GridRestockRequest.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BoxRestockProductId.Text = GridRestockRequest.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBoxStatus.SelectedItem = GridRestockRequest.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DateAdded.Text = GridRestockRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnUpdateRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxRestockRequestId.Text != string.Empty || BoxRestockProductId.Text != string.Empty)
            {
                try
                {
                    restockReqId = Convert.ToInt32(BoxRestockRequestId.Text);
                    date = DateAdded.Text;
                    status = CBoxStatus.SelectedItem.ToString();

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblRestockRequest set  status=@status, date=@date where restockRequestId=@restockRequestId", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("restockRequestId", restockReqId);
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
            else
            {
                MessageBox.Show("Please Select a request!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnSearchRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxRestockRequestSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    restockReqId = Convert.ToInt32(BoxRestockRequestSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblRestockRequest where restockRequestId=@id", con);
                    cmd.Parameters.AddWithValue("id", restockReqId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    BoxRestockRequestSearch.Text = string.Empty;
                    GridRestockRequest.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Clear()
        {
            BoxRestockRequestId.Text = string.Empty;
            BoxRestockProductId.Text = string.Empty;
            DateAdded.Value = DateTime.Now;
            CBoxStatus.SelectedIndex = -1;

        }
        private void BtnClearRestockRequest_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void BtnRefreshRestockRequest_Click(object sender, EventArgs e)
        {
            con.Close();
            LoadGrid();
        }
    }
}
