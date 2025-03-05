using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ApproveDamagedProductRequestsForm : Form
    {
        public ApproveDamagedProductRequestsForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int damageReqId;
        private int damagedProductId;
        private string date;
        private string status;
        private void ApproveDamagedProductRequestsForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
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

        private void GridDamagedProductRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridDamagedProductRequest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridDamagedProductRequest.CurrentRow.Selected = true;

                    BoxDamagedProductRequestId.Text = GridDamagedProductRequest.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BoxDamagedProductId.Text = GridDamagedProductRequest.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBoxStatus.SelectedItem = GridDamagedProductRequest.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DateAdded.Text = GridDamagedProductRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnUpdateRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxDamagedProductRequestId.Text != string.Empty || BoxDamagedProductId.Text != string.Empty)
            {
                try
                {
                    damageReqId = Convert.ToInt32(BoxDamagedProductRequestId.Text);
                    date = DateAdded.Text;
                    status = CBoxStatus.SelectedItem.ToString();

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblDamagedProductRequest set status=@status, date=@date where damageProductRequestId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("id", damageReqId);
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
        private void Clear()
        {
            BoxDamagedProductRequestId.Text = string.Empty;
            BoxDamagedProductId.Text = string.Empty;
            DateAdded.Value = DateTime.Now;
            CBoxStatus.SelectedIndex = -1;
        }

        private void BtnSearchRestockRequest_Click(object sender, EventArgs e)
        {
            if (BoxDamagedProductRequestSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    damageReqId = Convert.ToInt32(BoxDamagedProductRequestSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblDamagedProductRequest where damageProductRequestId=@id", con);
                    cmd.Parameters.AddWithValue("id", damageReqId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    BoxDamagedProductRequestSearch.Text = string.Empty;
                    GridDamagedProductRequest.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefreshRestockRequest_Click(object sender, EventArgs e)
        {
            con.Close();
            LoadGrid();
        }

        private void BtnClearRestockRequest_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
