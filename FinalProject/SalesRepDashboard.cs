using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SalesRepDashboard : Form
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
        AdminItemsForm itemsForm;
        AccountForm accountForm;
        RetailerForm retailerForm;
        RetailerOrdersForm retailerOrdersForm;
        RetailerReportForm retailerReportForm;
        ManageLeaveRequestForm manageLeaveRequestForm;
        EmployeePaySlipForm employeePaySlipForm;
        ViewAnnouncementForm viewAnnouncementForm;

        public SalesRepDashboard()
        {
            InitializeComponent();
        }

        private void SalesRepDashboard_Load(object sender, EventArgs e)
        {
            Home();
            //CheckStockLevels();
            AlertTimer.Interval = 120000; // 120 seconds
            AlertTimer.Tick += new EventHandler(AlertTimer_Tick);
            AlertTimer.Start();
        }

        bool retailerMenuExpand = false;
        private void RetailerTimer_Tick(object sender, EventArgs e)
        {
            if (retailerMenuExpand == false)
            {
                PanelRetailerMenu.Height += 10;
                if (PanelRetailerMenu.Height >= 160)
                {
                    RetailerTimer.Stop();
                    retailerMenuExpand = true;
                }
            }
            else
            {
                PanelRetailerMenu.Height -= 10;
                if (PanelRetailerMenu.Height <= 40)
                {
                    RetailerTimer.Stop();
                    retailerMenuExpand = false;
                }
            }
        }
        private void BtnRetailerMenu_Click(object sender, EventArgs e)
        {
            RetailerTimer.Start();
        }

        bool inventoryMenuExpand = false;
        private void InventoryTimer_Tick(object sender, EventArgs e)
        {
            if (inventoryMenuExpand == false)
            {
                PanelInventoryMenu.Height += 10;
                if (PanelInventoryMenu.Height >= 80)
                {
                    InventoryTimer.Stop();
                    inventoryMenuExpand = true;
                }
            }
            else
            {
                PanelInventoryMenu.Height -= 10;
                if (PanelInventoryMenu.Height <= 40)
                {
                    InventoryTimer.Stop();
                    inventoryMenuExpand = false;
                }
            }
        }
        private void BtnInventoryMenu_Click(object sender, EventArgs e)
        {
            InventoryTimer.Start();
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home();
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

        private void BtnManageItem_Click(object sender, EventArgs e)
        {
            itemsForm = new AdminItemsForm();
            itemsForm.FormClosed += ItemsForm_FormClosed;
            itemsForm.MdiParent = this;
            itemsForm.Dock = DockStyle.Fill;
            itemsForm.Show();
        }
        private void ItemsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            itemsForm = null;
        }

        private void BtnRetailer_Click(object sender, EventArgs e)
        {
            retailerForm = new RetailerForm();
            retailerForm.FormClosed += RetailerForm_FormClosed;
            retailerForm.MdiParent = this;
            retailerForm.Dock = DockStyle.Fill;
            retailerForm.Show();
        }
        private void RetailerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            retailerForm = null;
        }

        private void BtnRetailerOrders_Click(object sender, EventArgs e)
        {
            retailerOrdersForm = new RetailerOrdersForm();
            retailerOrdersForm.FormClosed += RetailerOrdersForm_FormClosed;
            retailerOrdersForm.MdiParent = this;
            retailerOrdersForm.Dock = DockStyle.Fill;
            retailerOrdersForm.Show();
        }
        private void RetailerOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            retailerOrdersForm = null;
        }

        private void BtnRetailerReport_Click(object sender, EventArgs e)
        {
            retailerReportForm = new RetailerReportForm();
            retailerReportForm.FormClosed += RetailerReportForm_FormClosed;
            retailerReportForm.MdiParent = this;
            retailerReportForm.Dock = DockStyle.Fill;
            retailerReportForm.Show();
        }
        private void RetailerReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            retailerReportForm = null;
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