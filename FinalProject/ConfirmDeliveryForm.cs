using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ConfirmDeliveryForm : Form
    {
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int deliveryId;
        private string status;

        public ConfirmDeliveryForm()
        {
            InitializeComponent();
        }

        private void ConfirmDeliveryForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("select * from tblDelivery where driverId= '" + LoginForm.empId + "'", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                GridDelivery.DataSource = dt.DefaultView;
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    BoxOrderId.Text = GridDelivery.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxDriverId.Text = GridDelivery.Rows[e.RowIndex].Cells[5].Value.ToString();
                    BoxVehicleNo.Text = GridDelivery.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void BtnConfirmDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                deliveryId = Convert.ToInt32(BoxDeliveryId.Text);
                status = CBoxDeliveryStatus.SelectedItem.ToString();

                con.Close();
                SqlCommand cmd = new SqlCommand("update tblDelivery set deliveryStatus=@status where deliveryId=@id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("id", deliveryId);
                cmd.Parameters.AddWithValue("status", status);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadGrid();
                Clear();
                MessageBox.Show("Delivery status updated!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            BoxDeliveryId.Text= String.Empty;
            BoxOrderId.Text= String.Empty;
            BoxDriverId.Text= String.Empty;
            BoxVehicleNo.Text= String.Empty;
            CBoxDeliveryStatus.SelectedIndex = -1;
        }
        private void BtnClearDelivery_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                deliveryId = Convert.ToInt32(BoxSearch.Text.Trim());

                con.Close();
                SqlCommand cmd = new SqlCommand("select * from tblDelivery where driverId= '" + LoginForm.empId + "' and deliveryId=@id", con);
                cmd.Parameters.AddWithValue("id", deliveryId);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                BoxSearch.Text = String.Empty;
                GridDelivery.DataSource = dt.DefaultView;
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
