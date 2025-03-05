using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class InventoryManagerDashboard : Form
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
        AdminItemsForm itemsForm;
        ManageLeaveRequestForm manageLeaveRequestForm;
        EmployeePaySlipForm employeePaySlipForm;
        RestockProductsForm restockProductsForm;
        RestockProductRequestsForm reststockProductRequestsForm;
        DamagedProductsForm damageProductsForm;
        DamagedProductRequestsForm damageProductRequestsForm;
        SupplierForm supplierForm;
        ViewAnnouncementForm viewAnnouncementForm;

        public InventoryManagerDashboard()
        {
            InitializeComponent();
        }

        private void InventoryManagerDashboard_Load(object sender, EventArgs e)
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

        bool restockMenuExpand = false;
        private void RestockTimer_Tick(object sender, EventArgs e)
        {
            if (restockMenuExpand == false)
            {
                PanelRestock.Height += 10;
                if (PanelRestock.Height >= 120)
                {
                    RestockTimer.Stop();
                    restockMenuExpand = true;
                }
            }
            else
            {
                PanelRestock.Height -= 10;
                if (PanelRestock.Height <= 40)
                {
                    RestockTimer.Stop();
                    restockMenuExpand = false;
                }
            }
        }
        private void BtnRestockMenu_Click(object sender, EventArgs e)
        {
            RestockTimer.Start();
        }

        bool damageMenuExpand = false;
        private void DamageTimer_Tick(object sender, EventArgs e)
        {
            if (damageMenuExpand == false)
            {
                PanelDamagedInv.Height += 10;
                if (PanelDamagedInv.Height >= 120)
                {
                    DamageTimer.Stop();
                    damageMenuExpand = true;
                }
            }
            else
            {
                PanelDamagedInv.Height -= 10;
                if (PanelDamagedInv.Height <= 40)
                {
                    DamageTimer.Stop();
                    damageMenuExpand = false;
                }
            }
        }
        private void BtnDamagedInvMenu_Click(object sender, EventArgs e)
        {
            DamageTimer.Start();
        }

        bool supplierMenuExpand = false;
        private void SupplierTimer_Tick(object sender, EventArgs e)
        {
            if (supplierMenuExpand == false)
            {
                SupplierMenuPanel.Height += 10;
                if (SupplierMenuPanel.Height >= 80)
                {
                    SupplierTimer.Stop();
                    supplierMenuExpand = true;
                }
            }
            else
            {
                SupplierMenuPanel.Height -= 10;
                if (SupplierMenuPanel.Height <= 40)
                {
                    SupplierTimer.Stop();
                    supplierMenuExpand = false;
                }
            }
        }
        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            SupplierTimer.Start();
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
            reststockProductRequestsForm = new RestockProductRequestsForm();
            reststockProductRequestsForm.FormClosed += ReststockProductRequestsForm_FormClosed;
            reststockProductRequestsForm.MdiParent = this;
            reststockProductRequestsForm.Dock = DockStyle.Fill;
            reststockProductRequestsForm.Show();
        }

        private void ReststockProductRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reststockProductRequestsForm = null;
        }

        private void BtnDamagedProducts_Click(object sender, EventArgs e)
        {
            damageProductsForm = new DamagedProductsForm();
            damageProductsForm.FormClosed += DamageProductsForm_FormClosed;
            damageProductsForm.MdiParent = this;
            damageProductsForm.Dock = DockStyle.Fill;
            damageProductsForm.Show();
        }

        private void DamageProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            damageProductsForm = null;
        }

        private void BtnDamagedProductRequests_Click(object sender, EventArgs e)
        {
            damageProductRequestsForm = new DamagedProductRequestsForm();
            damageProductRequestsForm.FormClosed += DamageProductRequestsForm_FormClosed;
            damageProductsForm.MdiParent = this;
            damageProductRequestsForm.Dock = DockStyle.Fill;
            damageProductsForm.Show();
        }

        private void DamageProductRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            damageProductRequestsForm = null;
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