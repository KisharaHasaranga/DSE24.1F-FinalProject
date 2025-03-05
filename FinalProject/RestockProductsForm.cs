using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RestockProductsForm : Form
    {
        public RestockProductsForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int restockProductId;
        private int productId;
        private string productName;
        private int productQty;
        private string dateAdded;

        

        private void RestockProductsForm_Load(object sender, EventArgs e)
        {
            LoadRestockProductID();
            LoadProductId();
            LoadGrid();
        }

        // Load Auto-generated SalaryID
        private void LoadRestockProductID()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextRestockProductID = GetNextRestockProductID();
            if (nextRestockProductID != -1)
            {
                BoxRestockProductId.Text = nextRestockProductID.ToString();
            }
        }
        // Get next RestockProductID
        private int GetNextRestockProductID()
        {
            string query = "SELECT ISNULL(MAX(restockProductId), 0) + 1 FROM tblRestockProduct";
            cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next Restock Product Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }

        // Get ProductId and load it into the ComboBox
        private void LoadProductId()
        {
            con.Close();
            string query = "select productId from tblProduct";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            CBoxProductId.Items.Clear();

            while (reader.Read())
            {
                CBoxProductId.Items.Add(reader["productId"].ToString());
            }
            con.Close();
        }

        private void CBoxProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxProductId.SelectedItem != null)
            {
                con.Close();
                string selectedProductID = CBoxProductId.SelectedItem.ToString();

                // Look up corresponding Emp Name based on EmpID
                string query = "select productName from tblProduct where productId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", selectedProductID);

                con.Open();
                object result = cmd.ExecuteScalar();  // Get the corresponding name

                if (result != null)
                {
                    BoxRestockProductName.Text = result.ToString();
                }
                con.Close();
            }
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblRestockProduct", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridRestockProduct.DataSource = dt.DefaultView;
        }

        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (CBoxProductId.Text == string.Empty)
            {
                MessageBox.Show("Restock Product Id is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxRestockProductName.Text == string.Empty)
            {
                MessageBox.Show("Restock Product Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxRestockQty.Text == "0" || BoxRestockQty.Text == string.Empty)
            {
                MessageBox.Show("Restock Product Qty is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Clear()
        {
            LoadRestockProductID();
            CBoxProductId.SelectedIndex = -1;
            BoxRestockProductName.Text = string.Empty;
            BoxRestockQty.Text = "0";
            DateAdded.Value = DateTime.Now;
            BoxRestockProductSearch.Text = string.Empty;
        }
        private void BtnInsertRestockProduct_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    restockProductId = Convert.ToInt32(BoxRestockProductId.Text);
                    productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                    productName = BoxRestockProductName.Text;
                    productQty = Convert.ToInt32(BoxRestockQty.Text);
                    dateAdded = DateAdded.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblRestockProduct values (@restockPId, @pId, @pName, @qty, @date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("restockPId", restockProductId);
                    cmd.Parameters.AddWithValue("pId", productId);
                    cmd.Parameters.AddWithValue("pName", productName);
                    cmd.Parameters.AddWithValue("qty", productQty);
                    cmd.Parameters.AddWithValue("date", dateAdded);
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

        private void BtnUpdateRestockProduct_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    restockProductId = Convert.ToInt32(BoxRestockProductId.Text);
                    productId = Convert.ToInt32(BoxRestockProductId.Text);
                    productName = BoxRestockProductName.Text;
                    productQty = Convert.ToInt32(BoxRestockQty.Text);
                    dateAdded = DateAdded.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblRestockProduct set productId=@pId, productName=@pName, requiredQty=@qty, DateAdded=@date where restockProductId=@restockPId", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("pId", productId);
                    cmd.Parameters.AddWithValue("pName", productName);
                    cmd.Parameters.AddWithValue("qty", productQty);
                    cmd.Parameters.AddWithValue("date", dateAdded);
                    cmd.Parameters.AddWithValue("restockPId", restockProductId);
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

        private void BtnDeleteRestockProduct_Click(object sender, EventArgs e)
        {
            try
            {
                restockProductId = Convert.ToInt32(BoxRestockProductId.Text);

                con.Close();
                SqlCommand cmd = new SqlCommand("delete from tblRestockProduct where restockProductId=@id", con);
                cmd.Parameters.AddWithValue("id", restockProductId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Delete Unsuccessfull" + exception.Message);
            }
        }

        private void BtnClearRestockProduct_Click(object sender, EventArgs e)
        {
            Clear();
            LoadRestockProductID();
        }

        private void BtnSearchRestockProduct_Click(object sender, EventArgs e)
        {
            SearchRestockProduct();
        }

        private void BoxRestockProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchRestockProduct();
            }
        }

        // Search Salary Method
        private void SearchRestockProduct()
        {
            if (BoxRestockProductSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    restockProductId = Convert.ToInt32(BoxRestockProductSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblRestockProduct where restockProductId=@id", con);
                    cmd.Parameters.AddWithValue("id", restockProductId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridRestockProduct.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridRestockProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridRestockProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridRestockProduct.CurrentRow.Selected = true;

                    BoxRestockProductId.Text = GridRestockProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxProductId.SelectedItem = GridRestockProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxRestockProductName.Text = GridRestockProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxRestockQty.Text = GridRestockProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DateAdded.Text = GridRestockProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnRefreshRestockProduct_Click(object sender, EventArgs e)
        {
            con.Close();
            BoxRestockProductSearch.Text = string.Empty;
            LoadGrid();
        }
    }
}
