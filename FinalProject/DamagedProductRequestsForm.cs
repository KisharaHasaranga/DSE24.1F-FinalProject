using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DamagedProductRequestsForm : Form
    {
        public DamagedProductRequestsForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int damagedProductRequestId;
        private int damagedProductId;
        private string date;
        private string status;
        private void DamagedProductRequestsForm_Load(object sender, EventArgs e)
        {
            LoadDamagedProductRequestId();
            LoadDamagedProductId();
            LoadGrid();
        }

        // Load Auto-generated DamagedProductRequestId
        private void LoadDamagedProductRequestId()
        {
            con.Close();
            int nextDamagedProductReqId = GetNextDamagedProductRequestId();
            if (nextDamagedProductReqId != -1)
            {
                BoxDamagedReqId.Text = nextDamagedProductReqId.ToString();
            }
        }
        // Get next DamagedProductRequestId
        private int GetNextDamagedProductRequestId()
        {
            string query = "SELECT ISNULL(MAX(damageProductRequestId), 0) + 1 FROM tblDamagedProductRequest";
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
        // Get LoadDamagedProductId and load it into the ComboBox
        private void LoadDamagedProductId()
        {
            con.Close();
            string query = "select damagedProductId from tblDamagedProduct";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            CBoxDamagedProductId.Items.Clear();

            while (reader.Read())
            {
                CBoxDamagedProductId.Items.Add(reader["damagedProductId"].ToString());
            }
            con.Close();
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblDamagedProductRequest", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridDamagedProductRequest.DataSource = dt.DefaultView;
        }

        private void BtnInsertDamagedProductRequest_Click(object sender, EventArgs e)
        {
            if (BoxDamagedReqId.Text != string.Empty || CBoxDamagedProductId.SelectedIndex.ToString() != null)
            {
                try
                {
                    damagedProductRequestId = Convert.ToInt32(BoxDamagedReqId.Text);
                    damagedProductId = Convert.ToInt32(CBoxDamagedProductId.SelectedItem.ToString());
                    date = DateAdded.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblDamagedProductRequest (damageProductRequestId, damagedProductId, date) values (@damageProductRequestId, @damagedProductId, @date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("damageProductRequestId", damagedProductRequestId);
                    cmd.Parameters.AddWithValue("damagedProductId", damagedProductId);
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
        private void BtnDeleteDamagedProductRequest_Click(object sender, EventArgs e)
        {
            if (BoxDamagedReqId.Text != string.Empty)
            {
                try
                {
                    damagedProductRequestId = Convert.ToInt32(BoxDamagedReqId.Text);

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblDamagedProductRequest where damageProductRequestId=@id", con);
                    cmd.Parameters.AddWithValue("id", damagedProductRequestId);
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

        private void BtnSearchRestockDamagedProductRequest_Click(object sender, EventArgs e)
        {
            if (BoxDamagedReqSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    damagedProductRequestId = Convert.ToInt32(BoxDamagedReqSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblDamagedProductRequest where damageProductRequestId=@id", con);
                    cmd.Parameters.AddWithValue("id", damagedProductRequestId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    BoxDamagedReqSearch.Text = string.Empty;
                    GridDamagedProductRequest.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnRefreshDamagedProductRequest_Click(object sender, EventArgs e)
        {
            con.Close();
            LoadGrid();
        }
        private void Clear()
        {
            LoadDamagedProductRequestId();
            LoadDamagedProductId();
            DateAdded.Value = DateTime.Now;
            BoxStatus.Text = string.Empty;
        }
        private void BtnClearRestockDamagedProductRequest_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GridDamagedProductRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridDamagedProductRequest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridDamagedProductRequest.CurrentRow.Selected = true;

                    BoxDamagedReqId.Text = GridDamagedProductRequest.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxDamagedProductId.SelectedItem = GridDamagedProductRequest.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxStatus.Text = GridDamagedProductRequest.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DateAdded.Text = GridDamagedProductRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
