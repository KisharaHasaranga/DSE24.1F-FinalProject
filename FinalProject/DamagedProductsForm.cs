using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DamagedProductsForm : Form
    {
        public DamagedProductsForm()
        {
            InitializeComponent();
            LoadProductId();
            LoadGrid();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int damagedProductId;
        private int productId;
        private string productName;
        private int productQty;
        private string dateAdded;

        private int totalQty;
        private int newQty;

        private void DamagedProductsForm_Load(object sender, EventArgs e)
        {
            LoadDamagedProductId();
        }

        // Load Auto-generated SalaryID
        private void LoadDamagedProductId()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextEmpID = GetNextDamagedProductID();
            if (nextEmpID != -1)
            {
                BoxDmgProductId.Text = nextEmpID.ToString();
            }
        }
        // Get next SalaryID
        private int GetNextDamagedProductID()
        {
            string query = "SELECT ISNULL(MAX(damagedProductId), 0) + 1 FROM tblDamagedProduct";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next DamagedProductId: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }

        // Get ProductId and load it into the ComboBox
        private void LoadProductId()
        {
            con.Close();
            string query = "select productId, productQty from tblProduct";
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

        private void GetProductQty()
        {
            if (CBoxProductId.SelectedItem != null)
            {
                productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                con.Close();
                string query = "select productQty from tblProduct where productId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    totalQty = Convert.ToInt32(reader["productQty"].ToString());
                }
                con.Close();
            }
        }

        // When selecting ProductID, load the corresponding ProductName
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
                    BoxProductName.Text = result.ToString();
                }
                con.Close();
            }
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblDamagedProduct", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridDamagedProducts.DataSource = dt.DefaultView;
        }

        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (BoxDmgProductId.Text == string.Empty)
            {
                MessageBox.Show("Damaged Product Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxProductId.Text == string.Empty)
            {
                MessageBox.Show("Product Id is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxProductName.Text == string.Empty)
            {
                MessageBox.Show("Product Name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxQty.Text == string.Empty)
            {
                MessageBox.Show("Qty is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void BtnInsertDmgProduct_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    GetProductQty();

                    damagedProductId = Convert.ToInt32(BoxDmgProductId.Text);
                    productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                    productName = BoxProductName.Text;
                    productQty = Convert.ToInt32(BoxQty.Text);
                    newQty = totalQty - productQty;
                    dateAdded = DateAdded.Text;
                    
                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblProduct set productQty=@qty where productId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("qty", newQty);
                    cmd.Parameters.AddWithValue("id", productId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd1 = new SqlCommand("insert into tblDamagedProduct values (@dmgId, @pId, @pName, @qty, @date)", con);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("dmgId", damagedProductId);
                    cmd1.Parameters.AddWithValue("pId", productId);
                    cmd1.Parameters.AddWithValue("pName", productName);
                    cmd1.Parameters.AddWithValue("qty", productQty);
                    cmd1.Parameters.AddWithValue("date", dateAdded);
                    con.Open();
                    cmd1.ExecuteNonQuery();
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

        // Search Data
        private void BoxDmgProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchDamagedProduct();
            }
        }
        private void BtnSearchDmgProduct_Click(object sender, EventArgs e)
        {
            SearchDamagedProduct();
        }
        private void SearchDamagedProduct()
        {
            if (BoxDmgProductSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    damagedProductId = Convert.ToInt32(BoxDmgProductSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblDamagedProduct where damagedProductId=@id", con);
                    cmd.Parameters.AddWithValue("id", damagedProductId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridDamagedProducts.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Clear Data and Reset
        private void Clear()
        {
            LoadDamagedProductId();
            CBoxProductId.SelectedIndex = -1;
            BoxProductName.Text = string.Empty;
            BoxQty.Text = "0";
            DateAdded.Value = DateTime.Now;
        }
        private void BtnClearDmgProduct_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Refresh Grid
        private void BtnRefreshDmgProduct_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}