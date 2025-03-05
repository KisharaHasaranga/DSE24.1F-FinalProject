using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RestockProductRequestsForm : Form
    {
        public RestockProductRequestsForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int restockRequestId;
        private int restockProductId;
        private string date;
        private string status;

        private void RestockProductRequestsForm_Load(object sender, EventArgs e)
        {
            LoadRestockRequestId();
            LoadRestockProductId();
            LoadGrid();
        }

        // Load Auto-generated RestockRequestID
        private void LoadRestockRequestId()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextRestockProductID = GetNextRestockRequestId();
            if (nextRestockProductID != -1)
            {
                BoxRestockRequestId.Text = nextRestockProductID.ToString();
            }
        }
        // Get next RestockRequestID
        private int GetNextRestockRequestId()
        {
            string query = "SELECT ISNULL(MAX(restockRequestId), 0) + 1 FROM tblRestockRequest";
            cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next Restock Request Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }

        // Get restockProductId and load it into the ComboBox
        private void LoadRestockProductId()
        {
            con.Close();
            string query = "select restockProductId from tblRestockProduct";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            CBoxRestockProductId.Items.Clear();

            while (reader.Read())
            {
                CBoxRestockProductId.Items.Add(reader["restockProductId"].ToString());
            }
            con.Close();
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

        private void BtnInsertRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxRestockRequestId.Text != string.Empty || CBoxRestockProductId.SelectedIndex.ToString() != null)
            {
                try
                {
                    restockRequestId = Convert.ToInt32(BoxRestockRequestId.Text);
                    restockProductId = Convert.ToInt32(CBoxRestockProductId.SelectedItem.ToString());
                    date = DateAdded.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblRestockRequest (restockRequestId, restockProductId, date) values (@restockRequestId, @restockProductId, @date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("restockRequestId", restockRequestId);
                    cmd.Parameters.AddWithValue("restockProductId", restockProductId);
                    cmd.Parameters.AddWithValue("date", date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BtnDeleteRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxRestockRequestId.Text != string.Empty)
            {
                try
                {
                    restockRequestId = Convert.ToInt32(BoxRestockRequestId.Text);

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblRestockRequest where restockRequestId=@id", con);
                    cmd.Parameters.AddWithValue("id", restockRequestId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void BtnSearchRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxRestockRequestSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    restockRequestId = Convert.ToInt32(BoxRestockRequestSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblRestockRequest where restockRequestId=@id", con);
                    cmd.Parameters.AddWithValue("id", restockRequestId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
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
            LoadRestockRequestId();
            LoadRestockProductId();
            DateAdded.Value = DateTime.Now;
            BoxRestockStatus.Text = string.Empty;
        }
        private void BtnClearRestockRequest_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GridRestockRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridRestockRequest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridRestockRequest.CurrentRow.Selected = true;

                    BoxRestockRequestId.Text = GridRestockRequest.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxRestockProductId.SelectedItem = GridRestockRequest.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxRestockStatus.Text = GridRestockRequest.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DateAdded.Text = GridRestockRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnRefreshRestockRequest_Click(object sender, EventArgs e)
        {
            con.Close();
            LoadGrid();
        }
    }
}
