using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminItemsForm : Form
    {
        private string productId;
        private string productName;
        private int Qty;
        private string batchNo;
        private string manDate;
        private string expDate;
        private double unitPrice;

        public AdminItemsForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private void AdminItemsForm_Load(object sender, EventArgs e)
        {
            CheckUserType();
            // Auto-generate the next StoreID and load it into the text box
            int nextStoreID = GetNextProductID();
            if (nextStoreID != -1)
            {
                BoxProductId.Text = nextStoreID.ToString();
            }
            LoadGrid();
        }
        // Check UserType
        private void CheckUserType()
        {
            if (LoginForm.userType == "Admin" || LoginForm.userType == "Inventory Manager")
            {
                BtnInsert.Enabled = true;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else if (LoginForm.userType == "SalesRep" || LoginForm.userType == "Logistics-Coordinator" || LoginForm.userType == "Driver")
            {
                BtnInsert.Enabled = false;
                BtnInsert.BaseColor = Color.DimGray;
                BtnUpdate.Enabled = false;
                BtnUpdate.BaseColor = Color.DimGray;
                BtnDelete.Enabled = false;
                BtnDelete.BaseColor = Color.DimGray;
            }
        }
        // Get next ProductID
        private int GetNextProductID()
        {
            string query = "SELECT ISNULL(MAX(productId), 0) + 1 FROM tblProduct";
            cmd = new SqlCommand(query, con);

            try {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex) {
                MessageBox.Show("Error fetching next StoreID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridProduct.DataSource = dt.DefaultView;
        }

        //Clear Fields
        private void Clear()
        {
            BoxProductName.Text = String.Empty;
            BoxProductQty.Text = String.Empty;
            BoxUnitPrice.Text = String.Empty;
            BoxProductQty.Text = String.Empty;
            BoxBatchNo.Text = String.Empty;
            BoxProductSearch.Text = String.Empty;
        }

        // Check if All fields a filled
        private bool IsValid()
        {
            if (BoxProductId.Text == string.Empty)
            {
                MessageBox.Show("Product Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxProductName.Text == string.Empty)
            {
                MessageBox.Show("Name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxProductQty.Text == string.Empty)
            {
                MessageBox.Show("Qty is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxBatchNo.Text == string.Empty)
            {
                MessageBox.Show("BatchNo is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxUnitPrice.Text == string.Empty)
            {
                MessageBox.Show("UnitP is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Insert Data
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    productId = BoxProductId.Text;
                    productName = BoxProductName.Text;
                    unitPrice = Convert.ToDouble(BoxUnitPrice.Text);
                    Qty = Convert.ToInt32(BoxProductQty.Text);
                    batchNo = BoxBatchNo.Text;
                    manDate = DateManufacture.Text;
                    expDate = DateExpire.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblProduct values (@id, @name, @qty, @batchNo, @unitP, @manDate, @expDate)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", productId);
                    cmd.Parameters.AddWithValue("name", productName);
                    cmd.Parameters.AddWithValue("qty", Qty);
                    cmd.Parameters.AddWithValue("batchNo", batchNo);
                    cmd.Parameters.AddWithValue("unitP", unitPrice);
                    cmd.Parameters.AddWithValue("manDate", manDate);
                    cmd.Parameters.AddWithValue("expDate", expDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        // Update Data
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    productId = BoxProductId.Text;
                    productName = BoxProductName.Text;
                    unitPrice = Convert.ToDouble(BoxUnitPrice.Text);
                    Qty = Convert.ToInt32(BoxProductQty.Text);
                    batchNo = BoxBatchNo.Text;
                    manDate = DateManufacture.Text;
                    expDate = DateExpire.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblProduct set productName=@name, productQty=@qty, batchNo=@batchNo, unitPrice=@unitP, manufactureDate=@manDate, expireDate=@expDate where productId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", productId);
                    cmd.Parameters.AddWithValue("name", productName);
                    cmd.Parameters.AddWithValue("qty", Qty);
                    cmd.Parameters.AddWithValue("batchNo", batchNo);
                    cmd.Parameters.AddWithValue("unitP", unitPrice);
                    cmd.Parameters.AddWithValue("manDate", manDate);
                    cmd.Parameters.AddWithValue("expDate", expDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        // Delete Data
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (BoxProductId.Text != string.Empty)
            {
                try
                {
                    productId = BoxProductId.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblProduct where productId=@id", con);
                    cmd.Parameters.AddWithValue("id", productId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Delete Unsuccessfull" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Search Data
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (BoxProductSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    productId = BoxProductSearch.Text;
                    SqlCommand cmd = new SqlCommand("select * from tblProduct where productId=@id", con);
                    cmd.Parameters.AddWithValue("id", productId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridProduct.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Search Unsuccessfull" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refresh Data
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // Clear Data Fields and Reset
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
            // Auto-generate the next StoreID and load it into the text box
            int nextProductID = GetNextProductID();
            if (nextProductID != -1)
            {
                BoxProductId.Text = nextProductID.ToString();
            }
            con.Close();
        }
        // Get Grid Items to Fields
        private void GridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridProduct.CurrentRow.Selected = true;

                    BoxProductId.Text = GridProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BoxProductName.Text = GridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxProductQty.Text = GridProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxBatchNo.Text = GridProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                    BoxUnitPrice.Text = GridProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                    DateManufacture.Text = GridProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                    DateExpire.Text = GridProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
