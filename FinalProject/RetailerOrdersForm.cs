using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RetailerOrdersForm : Form
    {
        public RetailerOrdersForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int orderId;
        private int retailerId;
        public static int retailerIdGlobal;
        private int productId;
        private string productName;
        private int productQty;
        private double unitPrice;
        private string orderDate;

        private double totalPrice;
        private int totalQty;
        private int newQty;
        private void RetailerOrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrderId();
            LoadProductGrid();
            LoadRetailerId();
            LoadProductId();
            CBoxProductId.SelectedIndex = 0;
            CBoxRetailerId.SelectedIndex = 0;
        }
        // Load Auto-generated OrderId
        private void LoadOrderId()
        {
            con.Close();
            // Auto-generate the next OrderId and load it into the text box
            int nextOrderId = GetNextOrderId();
            if (nextOrderId != -1)
            {
                BoxOrderId.Text = nextOrderId.ToString();
            }
        }
        // Get next OrderId
        private int GetNextOrderId()
        {
            string query = "SELECT ISNULL(MAX(orderId), 0) + 1 FROM tblRetailerOrder";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next DamagedProductId: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }
        // Load Data to Grid
        private void LoadProductGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridProduct.DataSource = dt.DefaultView;
        }
        // Load Data to Grid
        private void LoadRetailerOrderGrid()
        {
            try
            {
                con.Close();
                int selectedRetailerId = Convert.ToInt32(CBoxRetailerId.Text);
                SqlCommand cmd = new SqlCommand("select * from tblRetailerOrder where retailerId=@id", con);
                cmd.Parameters.AddWithValue("id", selectedRetailerId);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                GridRetailerOrder.DataSource = dt.DefaultView;
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Load RetailerId into ComboBox
        private void LoadRetailerId()
        {
            con.Close();
            string query = "select retailerId from tblRetailer";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear ComboBox before adding new items
            CBoxRetailerId.Items.Clear();

            // Load RetailerId into ComboBox
            while (reader.Read())
            {
                CBoxRetailerId.Items.Add(reader["retailerId"].ToString());
            }
            con.Close();
        }

        private void CBoxRetailerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            retailerIdGlobal = Convert.ToInt32(CBoxRetailerId.SelectedItem.ToString());

            if (CBoxRetailerId.SelectedItem != null)
            {
                con.Close();
                string selectedRetailerId = CBoxRetailerId.SelectedItem.ToString();

                string query = "select retailerName from tblRetailer where retailerId = @retailerId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("retailerId", selectedRetailerId);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    LabelRetailerName.Text = result.ToString();
                }
                con.Close();
                LoadRetailerOrderGrid();
                displayTotalPrice();
            }
        }
        // Load ProductId into ComboBox
        private void LoadProductId()
        {
            con.Close();
            string query = "select productId from tblProduct";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear ComboBox before adding new items
            CBoxProductId.Items.Clear();

            // Load RetailerId into ComboBox
            while (reader.Read())
            {
                CBoxProductId.Items.Add(reader["productId"].ToString());
            }
            con.Close();
        }
        private bool CheckAvailability()
        {
            try
            {
                con.Close();
                string selectedProductId = CBoxProductId.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand("select productQty from tblProduct where productId = @id", con);
                cmd.Parameters.AddWithValue("id", selectedProductId);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string qtyString = result.ToString();
                    int qty = Convert.ToInt32(qtyString);
                    if (qty == 0)
                    {
                        MessageBox.Show("Product Not Available", "Alert", MessageBoxButtons.OK);
                        return false;
                    }
                }
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void CBoxProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isAvailable = CheckAvailability();
            if (CBoxProductId.SelectedItem != null || isAvailable == true)
            {
                con.Close();
                string selectedProductId = CBoxProductId.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand("select productName from tblProduct where productId = @id", con);
                cmd.Parameters.AddWithValue("id", selectedProductId);
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    LabelProductName.Text = result.ToString();
                    productName = result.ToString();
                }
                con.Close();

                SqlCommand cmd2 = new SqlCommand("select unitPrice from tblProduct where productId = @id", con);
                cmd2.Parameters.AddWithValue("id", selectedProductId);
                con.Open();
                object result2 = cmd2.ExecuteScalar();

                if (result2 != null)
                {
                    LabelProductPrice.Text = result2.ToString();
                    unitPrice = Convert.ToDouble(result2.ToString());
                }
                con.Close();
            }
        }
        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (CBoxRetailerId.SelectedItem == null)
            {
                MessageBox.Show("Retailer Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxProductId.SelectedItem == null)
            {
                MessageBox.Show("Product Id is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (NumericUpDownQty.Value == 0)
            {
                MessageBox.Show("Qty is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        private void displayTotalPrice()
        {
            LabelTotalPrice.Text = "00.00";
            if (CBoxRetailerId.SelectedItem != null)
            {
                try
                {
                    con.Close();
                    string selectedRetailerId = CBoxRetailerId.SelectedItem.ToString();

                    SqlCommand cmd = new SqlCommand("select sum(unitPrice * productQty) from tblRetailerOrder where retailerId = @id", con);
                    cmd.Parameters.AddWithValue("id", selectedRetailerId);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        totalPrice = Convert.ToDouble(result);
                        LabelTotalPrice.Text = totalPrice.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void GetProductQty()
        {
            if (CBoxProductId.SelectedItem != null)
            {
                productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                con.Close();
                string query = "select productQty from tblProduct where productId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    totalQty = Convert.ToInt32(reader["productQty"].ToString());
                }
                con.Close();
            }
        }
        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        GetProductQty();
                        orderId = Convert.ToInt32(BoxOrderId.Text);
                        retailerId = Convert.ToInt32(CBoxRetailerId.SelectedItem.ToString());
                        productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                        productQty = Convert.ToInt32(NumericUpDownQty.Value);
                        orderDate = DateTime.Now.ToString();
                        newQty = totalQty - productQty;

                        SqlCommand cmd = new SqlCommand("update tblProduct set productQty=@qty where productId=@id", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("qty", newQty);
                        cmd.Parameters.AddWithValue("id", productId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        SqlCommand cmd2 = new SqlCommand("insert into tblRetailerOrder values (@orderId, @retailerId, @productId, @productName, @productQty, @unitPrice, @orderDate)", con);
                        cmd2.CommandType = CommandType.Text;
                        cmd2.Parameters.AddWithValue("orderId", orderId);
                        cmd2.Parameters.AddWithValue("retailerId", retailerId);
                        cmd2.Parameters.AddWithValue("productId", productId);
                        cmd2.Parameters.AddWithValue("productName", productName);
                        cmd2.Parameters.AddWithValue("productQty", productQty);
                        cmd2.Parameters.AddWithValue("unitPrice", unitPrice);
                        cmd2.Parameters.AddWithValue("orderDate", orderDate);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Order Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRetailerOrderGrid();
                        LoadOrderId();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            displayTotalPrice();
        }
        private int orderProductQty;
        private void GetOrderProductQty()
        {
            if (CBoxProductId.SelectedItem != null)
            {
                productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                con.Close();
                string query = "select productQty from tblRetailerOrder where productId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", productId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orderProductQty = Convert.ToInt32(reader["productQty"].ToString());
                }
                con.Close();
            }
        }
        int latestOrderId;
        private bool IsLatestOrderId()
        {
            try
            {
                con.Close();
                string query = "SELECT MAX(orderId) FROM tblRetailerOrder";
                SqlCommand cmd1 = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    latestOrderId = Convert.ToInt32(reader["orderId"].ToString());
                    if (latestOrderId != Convert.ToInt32(BoxOrderId.Text))
                    {
                        return false;
                    }
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                return false;
            }
        }
        private void BtnReomveOrder_Click(object sender, EventArgs e)
        {
            if (BoxOrderId.Text != string.Empty || CBoxProductId.SelectedItem != null || IsLatestOrderId() == true)
            {
                try
                {
                    con.Close();
                    GetProductQty();
                    GetOrderProductQty();
                    newQty = 0;
                    productId = Convert.ToInt32(CBoxProductId.SelectedItem.ToString());
                    newQty = totalQty + orderProductQty;
                    orderId = Convert.ToInt32(BoxOrderId.Text);

                    SqlCommand cmd = new SqlCommand("update tblProduct set productQty=@qty where productId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("qty", newQty);
                    cmd.Parameters.AddWithValue("id", productId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd2 = new SqlCommand("delete from tblRetailerOrder where orderId=@id", con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("id", orderId);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Remove Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRetailerOrderGrid();
                    LoadOrderId();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill out OrderId and ProductId", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayTotalPrice();
        }

        private void GridRetailerOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridRetailerOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridRetailerOrder.CurrentRow.Selected = true;

                    BoxOrderId.Text = GridRetailerOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxRetailerId.SelectedItem = GridRetailerOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBoxProductId.SelectedItem = GridRetailerOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                    NumericUpDownQty.Value = Convert.ToInt32(GridRetailerOrder.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            RetailerInvoice retailerInvoice = new RetailerInvoice();
            retailerInvoice.Show();
        }
    }
}
