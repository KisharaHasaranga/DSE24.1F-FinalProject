using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminEmployeeFrom : Form
    {
        // Variables
        private string empId;
        private string empName;
        private string userType;
        private string username;
        private string password;
        private string empNIC;
        private string empContact;
        private string empEmail;
        private string empAddress;
        private string empJoinedDate;

        public AdminEmployeeFrom()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private void AdminEmployeeFrom_Load(object sender, EventArgs e)
        {
            LoadEmpID();
            LoadGrid();
            checkUserType();
        }
        // Load Auto-generated EmpID
        private void LoadEmpID()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextEmpID = GetNextEmpID();
            if (nextEmpID != -1)
            {
                BoxEmpId.Text = nextEmpID.ToString();
            }
        }
        // Get next EmpID
        private int GetNextEmpID()
        {
            string query = "SELECT ISNULL(MAX(empId), 0) + 1 FROM tblEmployee";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next EmployeeID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridEmployee.DataSource = dt.DefaultView;
        }
        //Clear Fields
        private void Clear()
        {
            BoxEmpId.Text = String.Empty;
            BoxEmpName.Text = String.Empty;
            CBoxUserType.SelectedItem = null;
            BoxUsername.Text = String.Empty;
            BoxPassword.Text = String.Empty;
            BoxNIC.Text = String.Empty;
            BoxContact.Text = String.Empty;
            BoxEmail.Text = String.Empty;
            BoxAddress.Text = String.Empty;
            DateJoined.Text = String.Empty;
        }
        private void BtnClearEmp_Click(object sender, EventArgs e)
        {
            Clear();
            LoadEmpID();
        }
        // Check UserType
        private void checkUserType()
        {
            if (LoginForm.userType == "Admin")
            {
                BtnInsertEmp.Enabled = true;
                BtnUpdateEmp.Enabled = true;
                BtnDeleteEmp.Enabled = true;
            }
            else if (LoginForm.userType == "SalesRep")
            {
                BtnInsertEmp.Enabled = false;
                BtnUpdateEmp.Enabled = false;
                BtnDeleteEmp.Enabled = false;
            }
            else if (LoginForm.userType == "Logistics-Coordinator")
            {
                BtnInsertEmp.Enabled = false;
                BtnUpdateEmp.Enabled = false;
                BtnDeleteEmp.Enabled = false;
            }
            else if (LoginForm.userType == "Inventory Manager")
            {
                BtnInsertEmp.Enabled = false;
                BtnUpdateEmp.Enabled = false;
                BtnDeleteEmp.Enabled = false;
            }
            else if (LoginForm.userType == "Driver")
            {
                BtnInsertEmp.Enabled = false;
                BtnUpdateEmp.Enabled = false;
                BtnDeleteEmp.Enabled = false;
            }
        }
        // Validate Fields
        private bool IsValid()
        {
            if (BoxEmpId.Text == string.Empty)
            {
                MessageBox.Show("Emp Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxEmpName.Text == string.Empty)
            {
                MessageBox.Show("Name is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxUserType.Text == string.Empty)
            {
                MessageBox.Show("User Type is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxUsername.Text == string.Empty)
            {
                MessageBox.Show("Username is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Password is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxNIC.Text == string.Empty)
            {
                MessageBox.Show("NIC is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxContact.Text == string.Empty)
            {
                MessageBox.Show("Contact is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidTelephone(BoxContact.Text))
            {
                MessageBox.Show("Contact is invalid!, must be 10 digits", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnInsertEmp_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    empId = BoxEmpId.Text;
                    empName = BoxEmpName.Text;
                    userType = CBoxUserType.SelectedItem?.ToString();
                    username = BoxUsername.Text;
                    password = BoxPassword.Text;
                    empNIC = BoxNIC.Text;
                    empContact = BoxContact.Text;
                    empEmail = BoxEmail.Text;
                    empAddress = BoxAddress.Text;
                    empJoinedDate = DateJoined.Text;
                    string hashedPassword = HashPassword(password);

                    con.Close();
                    // Check if the username is unique.
                    string checkUserSql = "SELECT COUNT(1) FROM tblEmployee WHERE empUsername = @username";
                    SqlCommand checkUserCmd = new SqlCommand(checkUserSql, con);
                    checkUserCmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    int userCount = (int)checkUserCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        con.Close();
                        SqlCommand cmd = new SqlCommand("insert into tblEmployee (empId, empName, empType, empUsername, empPassword, empNIC, empContact, empEmail, empAddress, joinedDate) values (@id, @name, @type, @username, @password, @nic, @contact, @email, @address, @datejoined)", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("id", empId);
                        cmd.Parameters.AddWithValue("name", empName);
                        cmd.Parameters.AddWithValue("type", userType);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", hashedPassword);
                        cmd.Parameters.AddWithValue("nic", empNIC);
                        cmd.Parameters.AddWithValue("contact", empContact);
                        cmd.Parameters.AddWithValue("email", empEmail);
                        cmd.Parameters.AddWithValue("address", empAddress);
                        cmd.Parameters.AddWithValue("datejoined", empJoinedDate);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        LoadGrid();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        // Encrypt Password
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        // Update Data
        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    empId = BoxEmpId.Text;
                    empName = BoxEmpName.Text;
                    userType = CBoxUserType.SelectedItem?.ToString();
                    username = BoxUsername.Text;
                    password = BoxPassword.Text;
                    empNIC = BoxNIC.Text;
                    empContact = BoxContact.Text;
                    empEmail = BoxEmail.Text;
                    empAddress = BoxAddress.Text;
                    empJoinedDate = DateJoined.Text;
                    string hashedPassword = HashPassword(password);

                    con.Close();
                    // Check if the username is unique.
                    string checkUserSql = "SELECT COUNT(1) FROM tblEmployee WHERE empUsername = @username";
                    SqlCommand checkUserCmd = new SqlCommand(checkUserSql, con);
                    checkUserCmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    int userCount = (int)checkUserCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        con.Close();
                        SqlCommand cmd = new SqlCommand("update tblEmployee set empName=@name, empType=@type," +
                            " empUsername=@username, empPassword=@password, empNIC=@nic, empContact=@contact," +
                            " empEmail=@email, empAddress=@address, joinedDate=@datejoined where empId=@id", con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("name", empName);
                        cmd.Parameters.AddWithValue("type", userType);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", hashedPassword);
                        cmd.Parameters.AddWithValue("nic", empNIC);
                        cmd.Parameters.AddWithValue("contact", empContact);
                        cmd.Parameters.AddWithValue("email", empEmail);
                        cmd.Parameters.AddWithValue("address", empAddress);
                        cmd.Parameters.AddWithValue("datejoined", empJoinedDate);
                        cmd.Parameters.AddWithValue("id", empId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Update Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        LoadGrid();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        // Delete Data
        private void BtnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (BoxEmpId.Text != string.Empty)
            {
                try
                {
                    empId = BoxEmpId.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblEmployee where empId=@id", con);
                    cmd.Parameters.AddWithValue("id", empId);
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
        // Search Data
        private void BtnSearchEmp_Click(object sender, EventArgs e)
        {
            if (BoxEmployeeSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    empId = BoxEmployeeSearch.Text;
                    SqlCommand cmd = new SqlCommand("select * from tblEmployee where empId=@id", con);
                    cmd.Parameters.AddWithValue("id", empId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridEmployee.DataSource = dt.DefaultView;
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
        private void BtnRefreshEmp_Click(object sender, EventArgs e)
        {
            con.Close();
            LoadGrid();
        }
        // Get Grid Items to Fields
        private void GridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridEmployee.CurrentRow.Selected = true;

                    BoxEmpId.Text = GridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BoxEmpName.Text = GridEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBoxUserType.Text = GridEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxUsername.Text = GridEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                    BoxPassword.Text = GridEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                    BoxNIC.Text = GridEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                    BoxContact.Text = GridEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                    BoxEmail.Text = GridEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
                    BoxAddress.Text = GridEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();
                    DateJoined.Text = GridEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();
                    BoxStatus.Text = GridEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
