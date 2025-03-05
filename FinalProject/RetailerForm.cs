using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RetailerForm : Form
    {
        public RetailerForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int retailerId;
        private string retailerName;
        private string contact;
        private string email;
        private string address;
        private string priority;
        private void RetailerForm_Load(object sender, EventArgs e)
        {
            LoadRetailerId();
            LoadGrid();
        }
        // Load Auto-generated EmpID
        private void LoadRetailerId()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextRetailerId = GetNextRetailerId();
            if (nextRetailerId != -1)
            {
                BoxRetailerId.Text = nextRetailerId.ToString();
            }
        }
        // Get next EmpID
        private int GetNextRetailerId()
        {
            string query = "SELECT ISNULL(MAX(retailerId), 0) + 1 FROM tblRetailer";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next RetailerId: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblRetailer", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridRetailer.DataSource = dt.DefaultView;
        }
        // Validate Fields
        private bool IsValid()
        {
            if (BoxRetailerId.Text == string.Empty)
            {
                MessageBox.Show("Retailer Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxRetailerName.Text == string.Empty)
            {
                MessageBox.Show("Name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxContact.Text == string.Empty)
            {
                MessageBox.Show("User Type is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidTelephone(BoxContact.Text))
            {
                MessageBox.Show("Contact is invalid!, must be 10 digits!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxEmail.Text == string.Empty)
            {
                MessageBox.Show("Email is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(BoxEmail.Text))
            {
                MessageBox.Show("Email is invalid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxPriority.Text == string.Empty)
            {
                MessageBox.Show("Priority is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // Validate email format using a regular expression
        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }
        // Validate telephone number (must be 10 digits)
        private bool IsValidTelephone(string tele)
        {
            var teleRegex = new Regex(@"^\d{10}$");
            return teleRegex.IsMatch(tele);
        }
        private void Clear()
        {
            LoadRetailerId();
            BoxRetailerName.Text = string.Empty;
            BoxContact.Text = string.Empty;
            BoxEmail.Text = string.Empty;
            BoxAddress.Text = string.Empty;
            CBoxPriority.SelectedIndex = -1;
        }
        private void BtnInsertRetailer_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    retailerId = Convert.ToInt32(BoxRetailerId.Text);
                    retailerName = BoxRetailerName.Text;
                    contact = BoxContact.Text;
                    email = BoxEmail.Text;
                    address = BoxAddress.Text;
                    priority = CBoxPriority.SelectedItem.ToString();

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblRetailer values (@id, @name, @contact, @email, @address, @priority)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", retailerId);
                    cmd.Parameters.AddWithValue("name", retailerName);
                    cmd.Parameters.AddWithValue("contact", contact);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("address", address);
                    cmd.Parameters.AddWithValue("priority", priority);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadGrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void BtnUpdateRetailer_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    retailerId = Convert.ToInt32(BoxRetailerId.Text);
                    retailerName = BoxRetailerName.Text;
                    contact = BoxContact.Text;
                    email = BoxEmail.Text;
                    address = BoxAddress.Text;
                    priority = CBoxPriority.SelectedItem.ToString();

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblRetailer set retailerName=@name, retailerContact=@contact, retailerEmail=@email, retailerAddress=@address, retailerPriority=@priority where retailerId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("name", retailerName);
                    cmd.Parameters.AddWithValue("contact", contact);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("address", address);
                    cmd.Parameters.AddWithValue("priority", priority);
                    cmd.Parameters.AddWithValue("id", retailerId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadGrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void BtnDeleteRetailer_Click(object sender, EventArgs e)
        {
            if (BoxRetailerId.Text != string.Empty)
            {
                try
                {
                    retailerId = Convert.ToInt32(BoxRetailerId.Text);

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblRetailer where retailerId=@id", con);
                    cmd.Parameters.AddWithValue("id", retailerId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadGrid();
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
        private void BtnSearchRetailer_Click(object sender, EventArgs e)
        {
            if (BoxRetailerSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    retailerId = Convert.ToInt32(BoxRetailerSearch.Text);
                    SqlCommand cmd = new SqlCommand("select * from tblRetailer where retailerId=@id", con);
                    cmd.Parameters.AddWithValue("id", retailerId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    BoxRetailerSearch.Text = string.Empty;
                    GridRetailer.DataSource = dt.DefaultView;
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
        private void GridRetailer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridRetailer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridRetailer.CurrentRow.Selected = true;

                BoxRetailerId.Text = GridRetailer.Rows[e.RowIndex].Cells[0].Value.ToString();
                BoxRetailerName.Text = GridRetailer.Rows[e.RowIndex].Cells[1].Value.ToString();
                BoxContact.Text = GridRetailer.Rows[e.RowIndex].Cells[2].Value.ToString();
                BoxEmail.Text = GridRetailer.Rows[e.RowIndex].Cells[3].Value.ToString();
                BoxAddress.Text = GridRetailer.Rows[e.RowIndex].Cells[4].Value.ToString();
                CBoxPriority.SelectedItem = GridRetailer.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void BtnRefreshRetailer_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void BtnClearRetailer_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
