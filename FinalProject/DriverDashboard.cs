using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DriverDashboard : Form
    {
        // DLL imports to allow dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        HomeForm homeForm;
        AccountForm accountForm;
        ManageLeaveRequestForm manageLeaveRequestForm;
        EmployeePaySlipForm employeePaySlipForm;
        ConfirmDeliveryForm confirmDeliveryForm;
        ViewAnnouncementForm viewAnnouncementForm;

        public DriverDashboard()
        {
            InitializeComponent();
        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {
            Home();
            AlertTimer.Interval = 120000; // 120 seconds
            AlertTimer.Tick += new EventHandler(AlertTimer_Tick);
            AlertTimer.Start();
        }

        bool employeeMenuExpand;
        private void EmployeeTimer_Tick(object sender, EventArgs e)
        {
            if (employeeMenuExpand == false)
            {
                PanelEmployeeMenu.Height += 10;
                if (PanelEmployeeMenu.Height >= 120)
                {
                    EmployeeTimer.Stop();
                    employeeMenuExpand = true;
                }
            }
            else
            {
                PanelEmployeeMenu.Height -= 10;
                if (PanelEmployeeMenu.Height <= 40)
                {
                    EmployeeTimer.Stop();
                    employeeMenuExpand = false;
                }
            }
        }
        private void BtnEmployeeMenu_Click(object sender, EventArgs e)
        {
            EmployeeTimer.Start();
        }

        bool deliveryMenuExpand;
        private void DeliveryTimer_Tick(object sender, EventArgs e)
        {
            if (deliveryMenuExpand == false)
            {
                PanelDeliveryMenu.Height += 10;
                if (PanelDeliveryMenu.Height >= 80)
                {
                    DeliveryTimer.Stop();
                    deliveryMenuExpand = true;
                }
            }
            else
            {
                PanelDeliveryMenu.Height -= 10;
                if (PanelDeliveryMenu.Height <= 40)
                {
                    DeliveryTimer.Stop();
                    deliveryMenuExpand = false;
                }
            }
        }
        private void BtnDeliveryMenu_Click(object sender, EventArgs e)
        {
            DeliveryTimer.Start();
        }

        private void Home()
        {
            homeForm = new HomeForm();
            homeForm.FormClosed += HomeForm_FormClosed;
            homeForm.MdiParent = this;
            homeForm.Dock = DockStyle.Fill;
            homeForm.Show();
        }
        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm = null;
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void BtnEmployeeLeaveReq_Click(object sender, EventArgs e)
        {
            manageLeaveRequestForm = new ManageLeaveRequestForm();
            manageLeaveRequestForm.FormClosed += ManageLeaveRequestForm_FormClosed;
            manageLeaveRequestForm.MdiParent = this;
            manageLeaveRequestForm.Dock = DockStyle.Fill;
            manageLeaveRequestForm.Show();
        }
        private void ManageLeaveRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageLeaveRequestForm = null;
        }

        private void BtnPaySlip_Click(object sender, EventArgs e)
        {
            employeePaySlipForm = new EmployeePaySlipForm();
            employeePaySlipForm.FormClosed += EmployeePaySlipForm_FormClosed;
            employeePaySlipForm.MdiParent = this;
            employeePaySlipForm.Dock = DockStyle.Fill;
            employeePaySlipForm.Show();
        }
        private void EmployeePaySlipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeePaySlipForm = null;
        }

        private void BtnConfirmDelivery_Click(object sender, EventArgs e)
        {
            confirmDeliveryForm = new ConfirmDeliveryForm();
            confirmDeliveryForm.FormClosed += ConfirmDeliveryForm_FormClosed;
            confirmDeliveryForm.MdiParent = this;
            confirmDeliveryForm.Dock = DockStyle.Fill;
            confirmDeliveryForm.Show();
        }

        private void ConfirmDeliveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            confirmDeliveryForm = null;
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            accountForm = new AccountForm();
            accountForm.FormClosed += AccountForm_FormClosed;
            accountForm.MdiParent = this;
            accountForm.Dock = DockStyle.Fill;
            accountForm.Show();
        }
        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountForm = null;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Log Out?", "Log Out",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            CheckStockLevels();
        }
        private void CheckStockLevels()
        {
            try
            {
                con.Open();
                string query = "select ProductName from tblProduct where productQty = 0";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string productName = dr["ProductName"].ToString();
                    ShowAlert(productName);
                    //ShowNotification(productName);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking stock: " + ex.Message);
            }
        }

        private void ShowAlert(string productName)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Warning;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Stock Alert";
            notifyIcon.BalloonTipText = $"Product '{productName}' is out of stock!";
            notifyIcon.ShowBalloonTip(5000); // Show for 5 seconds
        }

        private void ShowNotification(string productName)
        {
            string msg = $"Product '{productName}' is out of stock!";
            MessageBox.Show(msg, "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnAnnouncemt_Click(object sender, EventArgs e)
        {
            viewAnnouncementForm = new ViewAnnouncementForm();
            viewAnnouncementForm.FormClosed += ViewAnnouncementForm_FormClosed;
            viewAnnouncementForm.MdiParent = this;
            viewAnnouncementForm.Dock = DockStyle.Fill;
            viewAnnouncementForm.Show();
        }

        private void ViewAnnouncementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewAnnouncementForm = null;
        }
    }
}
