using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LogisticsCoordinatorDashboard : Form
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
        VehicleForm vehicleForm;
        VehicleMaintenanceForm vehicleMaintenanceForm;
        DeliveryForm deliveryForm;
        DeliveryReportForm deliveryReportForm;
        ViewAnnouncementForm viewAnnouncementForm;

        public LogisticsCoordinatorDashboard()
        {
            InitializeComponent();
        }

        private void LogisticsCoordinatorDashboard_Load(object sender, EventArgs e)
        {
            Home();
            //CheckStockLevels();
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

        bool logisticsMenuExpand;
        private void LogisticsTimer_Tick(object sender, EventArgs e)
        {
            if (logisticsMenuExpand == false)
            {
                PanelLogisticsMenu.Height += 10;
                if (PanelLogisticsMenu.Height >= 200)
                {
                    LogisticsTimer.Stop();
                    logisticsMenuExpand = true;
                }
            }
            else
            {
                PanelLogisticsMenu.Height -= 10;
                if (PanelLogisticsMenu.Height <= 40)
                {
                    LogisticsTimer.Stop();
                    logisticsMenuExpand = false;
                }
            }
        }
        private void BtnLogisticsMenu_Click(object sender, EventArgs e)
        {
            LogisticsTimer.Start();
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
        private void BtnManageVehicles_Click(object sender, EventArgs e)
        {
            vehicleForm = new VehicleForm();
            vehicleForm.FormClosed += VehicleForm_FormClosed;
            vehicleForm.MdiParent = this;
            vehicleForm.Dock = DockStyle.Fill;
            vehicleForm.Show();
        }

        private void VehicleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            vehicleForm = null;
        }

        private void BtnMaintenence_Click(object sender, EventArgs e)
        {
            vehicleMaintenanceForm = new VehicleMaintenanceForm();
            vehicleMaintenanceForm.FormClosed += VehicleMaintenanceForm_FormClosed;
            vehicleMaintenanceForm.MdiParent = this;
            vehicleMaintenanceForm.Dock = DockStyle.Fill;
            vehicleMaintenanceForm.Show();
        }

        private void VehicleMaintenanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            vehicleMaintenanceForm = null;  
        }

        private void BtnDelivery_Click(object sender, EventArgs e)
        {
            deliveryForm = new DeliveryForm();
            deliveryForm.FormClosed += DeliveryForm_FormClosed;
            deliveryForm.MdiParent = this;
            deliveryForm.Dock = DockStyle.Fill;
            deliveryForm.Show();
        }

        private void DeliveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            deliveryForm = null;
        }

        private void BtnDeliveryReport_Click(object sender, EventArgs e)
        {
            deliveryReportForm = new DeliveryReportForm();
            deliveryReportForm.FormClosed += DeliveryReportForm_FormClosed;
            deliveryReportForm.MdiParent = this;
            deliveryReportForm.Dock = DockStyle.Fill;
            deliveryReportForm.Show();
        }

        private void DeliveryReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            deliveryReportForm=null;
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
