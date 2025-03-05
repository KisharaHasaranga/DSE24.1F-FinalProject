using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ReaLTaiizor.Controls.ExtendedPanel;

namespace FinalProject
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int deliveryId;
        private string deliveryStatus;
        private int orderId;
        private string retailerName;
        private string retailerAddress;
        private int driverId;
        private string driverName;
        private string vehicleNo;
        private string deliveryDate;

        private string userType = "Driver";

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadDeliveryId();
            LoadDriverId();
            LoadVehicleNo();
            LoadOrderId();
        }
        // Load Auto-generated DeliveryId
        private void LoadDeliveryId()
        {
            con.Close();
            // Auto-generate the next DeliveryId and load it into the text box
            int nextDeliveryId = GetNextDeliveryId();
            if (nextDeliveryId != -1)
            {
                BoxDeliveryId.Text = nextDeliveryId.ToString();
            }
        }
        // Get next DeliveryId
        private int GetNextDeliveryId()
        {       
            try
            {
                cmd = new SqlCommand("SELECT ISNULL(MAX(deliveryId), 0) + 1 FROM tblDelivery", con);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next DeliveryId: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }
        // Load DriverId into ComboBox     
        private void LoadDriverId()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select empId from tblEmployee where empType = @empType", con);
            cmd.Parameters.AddWithValue("empType", userType);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear ComboBox before adding new items
            CBoxDriverId.Items.Clear();
            // Load DriverId into ComboBox
            while (reader.Read())
            {
                CBoxDriverId.Items.Add(reader["empId"].ToString());
            }
            con.Close();
        }
        // When selecting DriverID, load the corresponding DriverName
        private void CBoxDriverId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxDriverId.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    string selectedDriverId = CBoxDriverId.SelectedItem.ToString();

                    string query = "select empStatus from tblEmployee where empId = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", selectedDriverId);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string status = result.ToString();
                        if (status != "Available")
                        {
                            MessageBox.Show("Selected Driver is Currently Unavailable!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CBoxVehicleNo.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Driver Available.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                            con.Close();
                            selectedDriverId = CBoxDriverId.SelectedItem.ToString();
                            // Look up corresponding Driver Name based on DriverID
                            string query2 = "select empName from tblEmployee where empId = @empId";
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.Parameters.AddWithValue("@empId", selectedDriverId);

                            con.Open();
                            object result2 = cmd2.ExecuteScalar();  // Get the corresponding name
                            if (result2 != null)
                            {
                                BoxDriverName.Text = result2.ToString();
                            }
                            con.Close();
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
                }
            }

        }
        // Load VehicleNo into ComboBox     
        private void LoadVehicleNo()
        {
            try
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("select vehicleNo from tblVehicle", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear ComboBox before adding new items
                CBoxVehicleNo.Items.Clear();
                // Load DriverId into ComboBox
                while (reader.Read())
                {
                    CBoxVehicleNo.Items.Add(reader["vehicleNo"].ToString());
                }
                con.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void CBoxVehicleNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxVehicleNo.Text != string.Empty) 
            {
                try
                {
                    con.Close();
                    string selectedVehicleNo = CBoxVehicleNo.SelectedItem.ToString();

                    string query = "select vehicleStatus from tblVehicle where vehicleNo = @vehicleNo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@vehicleNo", selectedVehicleNo);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string status = result.ToString();
                        if (status != "Idle")
                        {
                            MessageBox.Show("Selected Vehicle is Currently Unavailable!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CBoxVehicleNo.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Vehicle Available.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }
        // Load DriverId into ComboBox     
        private void LoadOrderId()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select orderId from tblRetailerOrder", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear ComboBox before adding new items
            CBoxOrderId.Items.Clear();
            // Load DriverId into ComboBox
            while (reader.Read())
            {
                CBoxOrderId.Items.Add(reader["orderId"].ToString());
            }
            con.Close();
        }
        private void CBoxOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxOrderId.SelectedItem != null)
            {
                con.Close();
                string selectedOrderId = CBoxOrderId.SelectedItem.ToString();

                // Look up corresponding Retailer Name based on OrderID
                string query = " select retailerName from tblRetailer inner join tblRetailerOrder on tblRetailerOrder.retailerId = tblRetailer.retailerId where tblRetailerOrder.orderId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", selectedOrderId);
                con.Open();
                object result = cmd.ExecuteScalar();  // Get the corresponding name
                if (result != null)
                {
                    BoxRetailerName.Text = result.ToString();
                }
                con.Close();

                // Look up corresponding Retailer Address based on OrderID
                string query1 = " select retailerAddress from tblRetailer inner join tblRetailerOrder on tblRetailerOrder.retailerId = tblRetailer.retailerId where tblRetailerOrder.orderId = @id";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@id", selectedOrderId);
                con.Open();
                object result1 = cmd1.ExecuteScalar();

                if (result1 != null)
                {
                    BoxRetailerAddress.Text = result1.ToString();
                }
                con.Close();
            }
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblDelivery", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridDelivery.DataSource = dt.DefaultView;
        }
        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (BoxDeliveryId.Text == null)
            {
                MessageBox.Show("Delivery Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxDeliveryStatus.SelectedItem == null)
            {
                MessageBox.Show("Delivery Status is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxOrderId.SelectedItem == null)
            {
                MessageBox.Show("Order Id is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxRetailerName.Text == null)
            {
                MessageBox.Show("Error getting retailer name!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxRetailerAddress.Text == null)
            {
                MessageBox.Show("Error getting retailer address!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxDriverId.SelectedItem == null)
            {
                MessageBox.Show("Driver Id is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxDriverName.Text == null)
            {
                MessageBox.Show("Error getting Driver name!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxVehicleNo.SelectedItem == null)
            {
                MessageBox.Show("Vehicle No is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Clear()
        {
            LoadDeliveryId();
            CBoxDeliveryStatus.SelectedIndex = -1;
            LoadOrderId();
            BoxRetailerName.Text = String.Empty;
            BoxRetailerAddress.Text = String.Empty;
            LoadDriverId();
            BoxDriverName.Text = String.Empty;
            LoadVehicleNo();
            DateDelivery.Value = DateTime.Now;
            
        }
        private void BtnInsertDelivery_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    deliveryId = Convert.ToInt32(BoxDeliveryId.Text);
                    deliveryStatus = CBoxDeliveryStatus.SelectedItem.ToString();
                    orderId = Convert.ToInt32(CBoxOrderId.SelectedItem.ToString());
                    retailerName = BoxRetailerName.Text;
                    retailerAddress = BoxRetailerAddress.Text;
                    driverId = Convert.ToInt32(CBoxDriverId.SelectedItem.ToString());
                    driverName = BoxDriverName.Text;
                    vehicleNo = CBoxVehicleNo.SelectedItem.ToString();
                    deliveryDate = DateDelivery.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblDelivery values (@id, @status, @orderId, @retailerName, @retailerAddress, @driverId, @driverName, @vehicle, @date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", deliveryId);
                    cmd.Parameters.AddWithValue("status", deliveryStatus);
                    cmd.Parameters.AddWithValue("orderId", orderId);
                    cmd.Parameters.AddWithValue("retailerName", retailerName);
                    cmd.Parameters.AddWithValue("retailerAddress", retailerAddress);
                    cmd.Parameters.AddWithValue("driverId", driverId);
                    cmd.Parameters.AddWithValue("driverName", driverName);
                    cmd.Parameters.AddWithValue("vehicle", vehicleNo);
                    cmd.Parameters.AddWithValue("date", deliveryDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string dstatus = "Unavailable";
                    SqlCommand cmd2 = new SqlCommand("update tblEmployee set empStatus=@status where empId=@id", con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("id", driverId);
                    cmd2.Parameters.AddWithValue("status", dstatus);
                    con.Open();
                    cmd2.ExecuteNonQuery();
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
        private void BtnUpdateDelivery_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    deliveryId = Convert.ToInt32(BoxDeliveryId.Text);
                    deliveryStatus = CBoxDeliveryStatus.SelectedItem.ToString();
                    orderId = Convert.ToInt32(CBoxOrderId.SelectedItem.ToString());
                    retailerName = BoxRetailerName.Text;
                    retailerAddress = BoxRetailerAddress.Text;
                    driverId = Convert.ToInt32(CBoxDriverId.SelectedItem.ToString());
                    driverName = BoxDriverName.Text;
                    vehicleNo = CBoxVehicleNo.SelectedItem.ToString();
                    deliveryDate = DateDelivery.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblDelivery set deliveryStatus=@status, orderId=@orderId, retailerName=@retailerName, retailerAddress=@retailerAddress, driverId=@driverId, driverName=@driverName, vehicleNo=@vehicle, deliveryDate=@date where deliveryId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", deliveryId);
                    cmd.Parameters.AddWithValue("status", deliveryStatus);
                    cmd.Parameters.AddWithValue("orderId", orderId);
                    cmd.Parameters.AddWithValue("retailerName", retailerName);
                    cmd.Parameters.AddWithValue("retailerAddress", retailerAddress);
                    cmd.Parameters.AddWithValue("driverId", driverId);
                    cmd.Parameters.AddWithValue("driverName", driverName);
                    cmd.Parameters.AddWithValue("vehicle", vehicleNo);
                    cmd.Parameters.AddWithValue("date", deliveryDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string dstatus = "Unavailable";
                    SqlCommand cmd2 = new SqlCommand("update tblEmployee set empStatus=@status where empId=@id", con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("id", driverId);
                    cmd2.Parameters.AddWithValue("status", dstatus);
                    con.Open();
                    cmd2.ExecuteNonQuery();
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
        private void BtnDeleteDelivery_Click(object sender, EventArgs e)
        {
            if (BoxDeliveryId.Text != string.Empty || CBoxDriverId.SelectedItem == null)
            {
                try
                {
                    deliveryId = Convert.ToInt32(BoxDeliveryId.Text);
                    driverId = Convert.ToInt32(CBoxDriverId.SelectedItem.ToString());

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblDelivery where deliveryId=@id", con);
                    cmd.Parameters.AddWithValue("id", deliveryId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string dstatus = "Available";
                    SqlCommand cmd2 = new SqlCommand("update tblEmployee set empStatus=@status where empId=@id", con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("id", driverId);
                    cmd2.Parameters.AddWithValue("status", dstatus);
                    con.Open();
                    cmd2.ExecuteNonQuery();
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
                MessageBox.Show("Delivery Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSearchDelivery_Click(object sender, EventArgs e)
        {
            if (BoxDeliverySearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    deliveryId = Convert.ToInt32(BoxDeliverySearch.Text);
                    SqlCommand cmd = new SqlCommand("select * from tblDelivery where deliveryId=@id", con);
                    cmd.Parameters.AddWithValue("id", deliveryId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridDelivery.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Search Unsuccessfull" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Delivery Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridDelivery.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridDelivery.CurrentRow.Selected = true;

                    BoxDeliveryId.Text = GridDelivery.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxDeliveryStatus.SelectedItem = GridDelivery.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBoxOrderId.SelectedItem = GridDelivery.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxRetailerName.Text = GridDelivery.Rows[e.RowIndex].Cells[3].Value.ToString();
                    BoxRetailerAddress.Text = GridDelivery.Rows[e.RowIndex].Cells[4].Value.ToString();
                    CBoxDriverId.SelectedItem = GridDelivery.Rows[e.RowIndex].Cells[5].Value.ToString();
                    BoxDriverName.Text = GridDelivery.Rows[e.RowIndex].Cells[6].Value.ToString();
                    CBoxVehicleNo.SelectedItem = GridDelivery.Rows[e.RowIndex].Cells[7].Value.ToString();
                    DateDelivery.Text = GridDelivery.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void BtnRefreshDelivery_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void BtnClearDelivery_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}