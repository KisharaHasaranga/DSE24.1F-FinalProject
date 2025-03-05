using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int supplierId;
        private string supplierName;
        private string supplierContact;
        private string supplierEmail;
        private string supplierAddress;

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSupplierID();
            LoadGrid();
        }

        // Load Auto-generated SupplierID
        private void LoadSupplierID()
        {
            con.Close();
            // Auto-generate the next SupplierID and load it into the text box
            int nextEmpID = GetNextSupplierID();
            if (nextEmpID != -1)
            {
                BoxSupplierId.Text = nextEmpID.ToString();
            }
        }
        // Get next SupplierID
        private int GetNextSupplierID()
        {
            string query = "SELECT ISNULL(MAX(supplierId), 0) + 1 FROM tblSupplier";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next SalaryID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblSupplier", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridSupplier.DataSource = dt.DefaultView;
        }

        private void Clear()
        {
            BoxSupplierName.Text = string.Empty;
            BoxSupplierContact.Text = string.Empty;
            BoxSupplierEmail.Text = string.Empty;
            BoxSupplierAddress.Text = string.Empty;
            BoxSupplierSearch.Text = string.Empty;
        }

        private void BtnClearSupplier_Click(object sender, EventArgs e)
        {
            Clear();
            LoadSupplierID();
        }
        // Validate Fields
        private bool IsValid()
        {
            if (BoxSupplierId.Text == string.Empty)
            {
                MessageBox.Show("Supplier Id is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxSupplierName.Text == string.Empty)
            {
                MessageBox.Show("SupplierName is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxSupplierContact.Text == string.Empty)
            {
                MessageBox.Show("Contact is required!, must be 10 digits", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidTelephone(BoxSupplierContact.Text))
            {
                MessageBox.Show("Contact is invalid!, must be 10 digits", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxSupplierEmail.Text == string.Empty)
            {
                MessageBox.Show("Email is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(BoxSupplierEmail.Text))
            {
                MessageBox.Show("Email is invalid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxSupplierAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Insert Data
        private void BtnInsertSupplier_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    supplierId = Convert.ToInt32(BoxSupplierId.Text);
                    supplierName = BoxSupplierName.Text;
                    supplierContact = BoxSupplierContact.Text;
                    supplierEmail = BoxSupplierEmail.Text;
                    supplierAddress = BoxSupplierAddress.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblSupplier values (@id, @name, @contact, @email, @address)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", supplierId);
                    cmd.Parameters.AddWithValue("name", supplierName);
                    cmd.Parameters.AddWithValue("contact", supplierContact);
                    cmd.Parameters.AddWithValue("email", supplierEmail);
                    cmd.Parameters.AddWithValue("address", supplierAddress);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    LoadSupplierID();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        // Update Data
        private void BtnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    supplierId = Convert.ToInt32(BoxSupplierId.Text);
                    supplierName = BoxSupplierName.Text;
                    supplierContact = BoxSupplierContact.Text;
                    supplierEmail = BoxSupplierEmail.Text;
                    supplierAddress = BoxSupplierAddress.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblSupplier set supplierName=@name, supplierContact=@contact, supplierEmail=@email, supplierAddress=@address where supplierId=@id", con);
                    cmd.CommandType = CommandType.Text;           
                    cmd.Parameters.AddWithValue("name", supplierName);
                    cmd.Parameters.AddWithValue("contact", supplierContact);
                    cmd.Parameters.AddWithValue("email", supplierEmail);
                    cmd.Parameters.AddWithValue("address", supplierAddress);
                    cmd.Parameters.AddWithValue("id", supplierId);
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
        // Delete Data
        private void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                supplierId = Convert.ToInt32(BoxSupplierId.Text);

                con.Close();
                SqlCommand cmd = new SqlCommand("delete from tblSupplier where supplierId=@id", con);
                cmd.Parameters.AddWithValue("id", supplierId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Succesfull!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Delete Unsuccessfull" + exception.Message);
            }
        }

        private void BtnSearchSupplier_Click(object sender, EventArgs e)
        {
            if (BoxSupplierSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    supplierId = Convert.ToInt32(BoxSupplierSearch.Text);
                    SqlCommand cmd = new SqlCommand("select * from tblSupplier where supplierId=@id", con);
                    cmd.Parameters.AddWithValue("id", supplierId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridSupplier.DataSource = dt.DefaultView;
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

        private void GridSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridSupplier.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridSupplier.CurrentRow.Selected = true;

                    BoxSupplierId.Text = GridSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BoxSupplierName.Text = GridSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxSupplierContact.Text = GridSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxSupplierEmail.Text = GridSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                    BoxSupplierAddress.Text = GridSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnRefreshSupplier_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
