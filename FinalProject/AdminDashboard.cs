using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminDashboard : Form
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

        // Forms
        HomeForm homeForm;
        AdminItemsForm itemsForm;
        DamagedProductsForm damagedProductForm;
        AdminEmployeeFrom employeeForm;
        AccountForm accountForm;
        EmployeeSalaryForm employeeSalaryForm;
        EmployeePaySlipForm employeePaySlipForm;
        EmployeeReportForm employeeReportForm;
        SupplierForm supplierForm;
        RestockProductsForm restockProductsForm;
        RestockProductRequestsForm restockProductRequestsForm;
        ApproveRestockRequest approveRestockRequest;
        DamagedProductRequestsForm damagedProductRequestsForm;
        ApproveDamagedProductRequestsForm approveDamagedProductRequestsForm;
        ManageLeaveRequestForm manageLeaveRequestForm;
        ApproveLeaveRequestsForm approveLeaveRequestsForm;
        VehicleForm vehicleForm;
        VehicleMaintenanceForm vehicleMaintenanceForm;
        DeliveryForm deliveryForm;
        RetailerForm retailerForm;
        RetailerOrdersForm retailerOrdersForm;
        DeliveryReportForm deliveryReportForm;
        RetailerReportForm retailerReportForm;
        ProductReportForm productReportForm;
        ManageAnnouncementForm manageAnnouncementForm;

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Home();
            AlertTimer.Interval = 120000; // 120 seconds
            AlertTimer.Tick += new EventHandler(AlertTimer_Tick);
            AlertTimer.Start();
        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 120)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void BtnInventoryMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool empMenuExpand = false;
        private void employeeMenu_Tick(object sender, EventArgs e)
        {
            if (empMenuExpand == false)
            {
                EmployeeMenuPanel.Height += 10;
                if (EmployeeMenuPanel.Height >= 280)
                {
                    employeeMenu.Stop();
                    empMenuExpand = true;
                }
            }
            else
            {
                EmployeeMenuPanel.Height -= 10;
                if (EmployeeMenuPanel.Height <= 40)
                {
                    employeeMenu.Stop();
                    empMenuExpand = false;
                }
            }
        }
        private void BtnEmployeeMenu_Click(object sender, EventArgs e)
        {
            employeeMenu.Start();
        }
        bool supplierMenuExpand = false;
        private void supplierMenu_Tick(object sender, EventArgs e)
        {
            if (supplierMenuExpand == false)
            {
                SupplierMenuPanel.Height += 10;
                if (SupplierMenuPanel.Height >= 80)
                {
                    supplierMenu.Stop();
                    supplierMenuExpand = true;
                }
            }
            else
            {
                SupplierMenuPanel.Height -= 10;
                if (SupplierMenuPanel.Height <= 40)
                {
                    supplierMenu.Stop();
                    supplierMenuExpand = false;
                }
            }
        }
        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            supplierMenu.Start();
        }
        bool restockMenuExpand = false;
        private void restockMenu_Tick(object sender, EventArgs e)
        {
            if (restockMenuExpand == false)
            {
                PanelRestock.Height += 10;
                if (PanelRestock.Height >= 160)
                {
                    restockMenu.Stop();
                    restockMenuExpand = true;
                }
            }
            else
            {
                PanelRestock.Height -= 10;
                if (PanelRestock.Height <= 40)
                {
                    restockMenu.Stop();
                    restockMenuExpand = false;
                }
            }
        }
        private void BtnRestockMenu_Click(object sender, EventArgs e)
        {
            restockMenu.Start();
        }
        bool damagedMenuExpand = false;
        private void damagedMenu_Tick(object sender, EventArgs e)
        {
            if (damagedMenuExpand == false)
            {
                PanelDamagedInv.Height += 10;
                if (PanelDamagedInv.Height >= 160)
                {
                    damagedMenu.Stop();
                    damagedMenuExpand = true;
                }
            }
            else
            {
                PanelDamagedInv.Height -= 10;
                if (PanelDamagedInv.Height <= 40)
                {
                    damagedMenu.Stop();
                    damagedMenuExpand = false;
                }
            }
        }
        private void BtnDamagedInvMenu_Click(object sender, EventArgs e)
        {
            damagedMenu.Start();
        }
        bool LogisticsMenuExpand = false;
        private void logisticsMenu_Tick(object sender, EventArgs e)
        {
            if (LogisticsMenuExpand == false)
            {
                PanelLogisticsMenu.Height += 10;
                if (PanelLogisticsMenu.Height >= 200)
                {
                    logisticsMenu.Stop();
                    LogisticsMenuExpand = true;
                }
            }
            else
            {
                PanelLogisticsMenu.Height -= 10;
                if (PanelLogisticsMenu.Height <= 40)
                {
                    logisticsMenu.Stop();
                    LogisticsMenuExpand = false;
                }
            }
        }
        private void BtnLogisticsMenu_Click(object sender, EventArgs e)
        {
            logisticsMenu.Start();
        }
        bool retailerMenuExpand = false;
        private void retailerMenu_Tick(object sender, EventArgs e)
        {
            if (retailerMenuExpand == false)
            {
                PanelRetailerMenu.Height += 10;
                if (PanelRetailerMenu.Height >= 160)
                {
                    retailerMenu.Stop();
                    retailerMenuExpand = true;
                }
            }
            else
            {
                PanelRetailerMenu.Height -= 10;
                if (PanelRetailerMenu.Height <= 40)
                {
                    retailerMenu.Stop();
                    retailerMenuExpand = false;
                }
            }
        }
        private void BtnRetailerMenu_Click(object sender, EventArgs e)
        {
            retailerMenu.Start();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnManageItem_Click(object sender, EventArgs e)
        {
            itemsForm = new AdminItemsForm();
            itemsForm.FormClosed += MenuForm_FormClosed;
            itemsForm.MdiParent = this;
            itemsForm.Dock = DockStyle.Fill;
            itemsForm.Show();
        }
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            itemsForm = null;
        }
        private void BtnEmployeeManage_Click(object sender, EventArgs e)
        {
            employeeForm = new AdminEmployeeFrom();
            employeeForm.FormClosed += EmployeeForm_FormClosed;
            employeeForm.MdiParent = this;
            employeeForm.Dock = DockStyle.Fill;
            employeeForm.Show();
        }
        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeForm = null;
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

        private void BtnEmployeeSalary_Click(object sender, EventArgs e)
        {
            employeeSalaryForm = new EmployeeSalaryForm();
            employeeSalaryForm.FormClosed += EmployeeSalaryForm_FormClosed;
            employeeSalaryForm.MdiParent = this;
            employeeSalaryForm.Dock = DockStyle.Fill;
            employeeSalaryForm.Show();
        }
        private void EmployeeSalaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeSalaryForm = null;
        }
        private void Home()
        {
            homeForm = new HomeForm();
            homeForm.FormClosed += HomeForm_FormClosed;
            homeForm.MdiParent = this;
            homeForm.Dock = DockStyle.Fill;
            homeForm.Show();
        }
        private void BttnHome_Click(object sender, EventArgs e)
        {
            Home();
        }
        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm = null;
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

        private void BtnEmployeeReport_Click(object sender, EventArgs e)
        {
            employeeReportForm = new EmployeeReportForm();
            employeeReportForm.FormClosed += EmployeeReportForm_FormClosed;
            employeeReportForm.MdiParent = this;
            employeeReportForm.Dock = DockStyle.Fill;
            employeeReportForm.Show();
        }

        private void EmployeeReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeReportForm = null;
        }

        private void BtnDamagedProducts_Click(object sender, EventArgs e)
        {
            damagedProductForm = new DamagedProductsForm();
            damagedProductForm.FormClosed += DamagedProductForm_FormClosed;
            damagedProductForm.MdiParent = this;
            damagedProductForm.Dock = DockStyle.Fill;
            damagedProductForm.Show();
        }

        private void DamagedProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            damagedProductForm = null;
        }

        private void BtnManageSuppliers_Click(object sender, EventArgs e)
        {
            supplierForm = new SupplierForm();
            supplierForm.FormClosed += SupplierForm_FormClosed;
            supplierForm.MdiParent = this;
            supplierForm.Dock = DockStyle.Fill;
            supplierForm.Show();
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            supplierForm = null;
        }
        private void BtnRestockProducts_Click(object sender, EventArgs e)
        {
            restockProductsForm = new RestockProductsForm();
            restockProductsForm.FormClosed += RestockProductsForm_FormClosed;
            restockProductsForm.MdiParent = this;
            restockProductsForm.Dock = DockStyle.Fill;
            restockProductsForm.Show();
        }

        private void RestockProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            restockProductsForm = null;
        }

        private void BtnRestockRequest_Click(object sender, EventArgs e)
        {
            restockProductRequestsForm = new RestockProductRequestsForm();
            restockProductRequestsForm.FormClosed += RestockProductRequestsForm_FormClosed;
            restockProductRequestsForm.MdiParent = this;
            restockProductRequestsForm.Dock = DockStyle.Fill;
            restockProductRequestsForm.Show();
        }

        private void RestockProductRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            restockProductRequestsForm = null;
        }
        private void BtnApproveRestockReq_Click(object sender, EventArgs e)
        {
            approveRestockRequest = new ApproveRestockRequest();
            approveRestockRequest.FormClosed += ApproveRestockRequest_FormClosed;
            approveRestockRequest.MdiParent = this;
            approveRestockRequest.Dock = DockStyle.Fill;
            approveRestockRequest.Show();
        }

        private void ApproveRestockRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            approveRestockRequest = null;
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
        private void BtnDamagedProductRequests_Click(object sender, EventArgs e)
        {
            damagedProductRequestsForm = new DamagedProductRequestsForm();
            damagedProductRequestsForm.FormClosed += DamagedProductRequestsForm_FormClosed;
            damagedProductRequestsForm.MdiParent = this;
            damagedProductRequestsForm.Dock = DockStyle.Fill;
            damagedProductRequestsForm.Show();
        }
        private void DamagedProductRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            damagedProductRequestsForm = null;
        }
        private void BtnApproveDamagedProductRequests_Click(object sender, EventArgs e)
        {
            approveDamagedProductRequestsForm = new ApproveDamagedProductRequestsForm();
            approveDamagedProductRequestsForm.FormClosed += ApproveDamagedProductRequestsForm_FormClosed;
            approveDamagedProductRequestsForm.MdiParent = this;
            approveDamagedProductRequestsForm.Dock = DockStyle.Fill;
            approveDamagedProductRequestsForm.Show();
        }

        private void ApproveDamagedProductRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            approveDamagedProductRequestsForm = null;
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
        private void BtnApproveLeaveReq_Click(object sender, EventArgs e)
        {
            approveLeaveRequestsForm = new ApproveLeaveRequestsForm();
            approveLeaveRequestsForm.FormClosed += ApproveLeaveRequestsForm_FormClosed;
            approveLeaveRequestsForm.MdiParent = this;
            approveLeaveRequestsForm.Dock = DockStyle.Fill;
            approveLeaveRequestsForm.Show();
        }
        private void ApproveLeaveRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            approveLeaveRequestsForm = null;
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
            deliveryReportForm = null;
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

        private void BtnInventoryReport_Click(object sender, EventArgs e)
        {
            productReportForm = new ProductReportForm();
            productReportForm.FormClosed += ProductReportForm_FormClosed;
            productReportForm.MdiParent = this;
            productReportForm.Dock= DockStyle.Fill;
            productReportForm.Show();
        }

        private void ProductReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productReportForm = null;
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

        private void BtnAnnouncemt_Click_1(object sender, EventArgs e)
        {
            manageAnnouncementForm = new ManageAnnouncementForm();
            manageAnnouncementForm.FormClosed += ManageAnnouncementForm_FormClosed;
            manageAnnouncementForm.MdiParent = this;
            manageAnnouncementForm.Dock = DockStyle.Fill;
            manageAnnouncementForm.Show();
        }
        private void ManageAnnouncementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageAnnouncementForm = null;
        }
    }
}