using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        //global variables
        public static string empId;
        public static string empName;
        public static string empUsername;
        public static string userType;
        public static string empPassword;
        public static string empNIC;
        public static string empContact;
        public static string empEmail;
        public static string empAddress;
        public static string empJoinedDate;

        // DLL imports to allow dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string username = BoxUsername.Text;
            string password = BoxPassword.Text;
            string hashedPassword = HashPassword(password); // Hash the entered password

            if (BoxUsername.Text.Equals(null) || BoxPassword.Text.Equals(null))
            {
                MessageBox.Show("Please Enter Username and Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Close();                    
                    string sql = "select empId, empName, empType, empUsername, empPassword, empNIC, empContact, empEmail, empAddress, joinedDate from tblEmployee where empUsername = @username and empPassword = @password";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Hash the entered password before comparing
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Store user information in global variables
                            empId = reader["empId"].ToString();
                            empName = reader["empUsername"].ToString();
                            userType = reader["empType"].ToString();
                            empUsername = reader["empUsername"].ToString();
                            empPassword = reader["empPassword"].ToString(); // This will store the hashed password from the DB
                            empNIC = reader["empNIC"].ToString();
                            empContact = reader["empContact"].ToString();
                            empEmail = reader["empEmail"].ToString();
                            empAddress = reader["empAddress"].ToString();
                            empJoinedDate = reader["joinedDate"].ToString();

                        }
                        MessageBox.Show("Successfully Logged In.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (userType.Equals("Admin"))
                        {
                            AdminDashboard adminDashboardForm = new AdminDashboard();
                            adminDashboardForm.Show();
                        }
                        if (userType.Equals("SalesRep")){
                            SalesRepDashboard salesRepDashboard = new SalesRepDashboard();
                            salesRepDashboard.Show();
                        }
                        if (userType.Equals("Logistics-Coordinator"))
                        {
                            LogisticsCoordinatorDashboard logisticsDashboardForm = new LogisticsCoordinatorDashboard();
                            logisticsDashboardForm.Show();
                        }
                        if (userType.Equals("Inventory Manager"))
                        {
                            InventoryManagerDashboard inventoryManagerDashboardForm = new InventoryManagerDashboard();
                            inventoryManagerDashboardForm.Show();
                        }
                        if (userType.Equals("Driver"))
                        {
                            DriverDashboard driverDashboardForm = new DriverDashboard();
                            driverDashboardForm.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // Close Btn
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
