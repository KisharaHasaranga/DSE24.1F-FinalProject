using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private string vehicleNo;
        private string vehicleType;
        private string purchasedDate;
        private string status;
        private void VehicleForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("select * from tblVehicle", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                GridVehicle.DataSource = dt.DefaultView;
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (BoxVehicelNum.Text == string.Empty)
            {
                MessageBox.Show("Vehicle Number is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxVehicleType.SelectedIndex == -1)
            {
                MessageBox.Show("Vehcile Type is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PurchaseDate.Text == string.Empty)
            {
                MessageBox.Show("Purchased Date is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Clear()
        {
            BoxVehicelNum.Text = string.Empty;
            CBoxVehicleType.SelectedIndex = -1;
            PurchaseDate.Value = DateTime.Now;
            BoxStatus.Text = string.Empty;
        }
        private void BtnInsertVehicle_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    vehicleNo = BoxVehicelNum.Text.Trim();
                    vehicleType = CBoxVehicleType.SelectedItem.ToString();
                    purchasedDate = PurchaseDate.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblVehicle (vehicleNo, vehcleType, purchasedDate) values (@vehicleNo, @vehicleType, @purchasedDate)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("vehicleNo", vehicleNo);
                    cmd.Parameters.AddWithValue("vehicleType", vehicleType);
                    cmd.Parameters.AddWithValue("purchasedDate", purchasedDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert Succesfull!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BtnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    vehicleNo = BoxVehicelNum.Text.Trim();
                    vehicleType = CBoxVehicleType.SelectedItem.ToString();
                    purchasedDate = PurchaseDate.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblVehicle set vehcleType=@vehcleType, purchasedDate=@purchasedDate where vehicleNo=@vehicleNo", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("vehicleType", vehicleType);
                    cmd.Parameters.AddWithValue("purchasedDate", purchasedDate);
                    cmd.Parameters.AddWithValue("vehicleNo", vehicleNo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successful!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BtnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (BoxVehicelNum.Text != string.Empty)
            {
                try
                {
                    vehicleNo = BoxVehicelNum.Text.Trim();

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblVehicle where vehicleNo=@id", con);
                    cmd.Parameters.AddWithValue("id", vehicleNo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Delete Unsuccessfull" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Vehicle No is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearchVehicle_Click(object sender, EventArgs e)
        {
            if (BoxSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    vehicleNo = BoxSearch.Text.Trim();
                    SqlCommand cmd = new SqlCommand("select * from tblVehicle where vehicleNo=@id", con);
                    cmd.Parameters.AddWithValue("id", vehicleNo);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    BoxSearch.Text = string.Empty;
                    GridVehicle.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Search Unsuccessfull" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Vehicle No is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridVehicle.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridVehicle.CurrentRow.Selected = true;

                BoxVehicelNum.Text = GridVehicle.Rows[e.RowIndex].Cells[0].Value.ToString();
                CBoxVehicleType.SelectedItem = GridVehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
                PurchaseDate.Text = GridVehicle.Rows[e.RowIndex].Cells[2].Value.ToString();
                BoxStatus.Text = GridVehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void BtnClearVehicle_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void BtnRefreshVehicle_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
