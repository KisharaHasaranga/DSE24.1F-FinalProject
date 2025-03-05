using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class VehicleMaintenanceForm : Form
    {
        public VehicleMaintenanceForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int maintenanceId;
        private string vehicleNo;
        private string description;
        private string date;
        private string status;
        private void VehicleMaintenanceForm_Load(object sender, EventArgs e)
        {
            LoadMaintenanceId();
            LoadVehicleNo();
            LoadGrid();
        }
        // Load Auto-generated SalaryID
        private void LoadMaintenanceId()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextMaintenanceId = GetNextMaintenanceId();
            if (nextMaintenanceId != -1)
            {
                BoxMaintenanceId.Text = nextMaintenanceId.ToString();
            }
        }
        // Get next SalaryID
        private int GetNextMaintenanceId()
        {
            string query = "SELECT ISNULL(MAX(maintenanceId), 0) + 1 FROM tblVehicleMaintenance";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next Maintenance Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }
        // Load EmpId into ComboBox
        private void LoadVehicleNo()
        {
            con.Close();
            string query = "select vehicleNo from tblVehicle";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear ComboBox before adding new items
            CBoxVehicleNum.Items.Clear();

            // Load EmpIDs into ComboBox
            while (reader.Read())
            {
                CBoxVehicleNum.Items.Add(reader["vehicleNo"].ToString());
            }
            con.Close();
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblVehicleMaintenance", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridVehicleM.DataSource = dt.DefaultView;
        }
        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (BoxMaintenanceId.Text == string.Empty)
            {
                MessageBox.Show("Maintenance Id is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxVehicleNum.Text == string.Empty)
            {
                MessageBox.Show("Vehicle No is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxDescription.Text == string.Empty)
            {
                MessageBox.Show("Description is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Clear()
        {
            LoadMaintenanceId();
            LoadVehicleNo();
            BoxDescription.Text = string.Empty;
            ServiceDate.Value = DateTime.Now;            
        }
        private void BtnScheduleVehicleM_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    maintenanceId = Convert.ToInt32(BoxMaintenanceId.Text);
                    vehicleNo = CBoxVehicleNum.SelectedItem.ToString();
                    description = BoxDescription.Text;
                    date = ServiceDate.Text;
                    status = "In Maintenence";

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblVehicleMaintenance values (@id, @vehicleNo, @jobDescription, @date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("id", maintenanceId);
                    cmd.Parameters.AddWithValue("vehicleNo", vehicleNo);
                    cmd.Parameters.AddWithValue("jobDescription", description);
                    cmd.Parameters.AddWithValue("date", date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    SqlCommand cmd2 = new SqlCommand("update tblVehicle set vehicleStatus=@status where vehicleNo=@vehicleNo", con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("status", status);
                    cmd2.Parameters.AddWithValue("vehicleNo", vehicleNo);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Schedule Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private string GetMaintenanceVehicleNo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select vehicleNo from tblVehicleMaintenance where maintenanceId = @id", con);
                cmd.Parameters.AddWithValue("id", maintenanceId);
                con.Open();
                return (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
        private void BtnDeleteVehicleM_Click(object sender, EventArgs e)
        {
            if (BoxMaintenanceId.Text != string.Empty || CBoxVehicleNum.Text != string.Empty)
            {
                try
                {
                    maintenanceId = Convert.ToInt32(BoxMaintenanceId.Text);
                    vehicleNo = GetMaintenanceVehicleNo();
                    status = "Idle";

                    con.Close();
                    SqlCommand cmd = new SqlCommand("delete from tblVehicleMaintenance where maintenanceId=@id", con);
                    cmd.Parameters.AddWithValue("id", maintenanceId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd2 = new SqlCommand("update tblVehicle set vehicleStatus=@status where vehicleNo=@vehicleNo", con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("status", status);
                    cmd2.Parameters.AddWithValue("vehicleNo", vehicleNo);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Delete Unsuccessfull" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Maintenance Id and Vehicel No is required");
            }
        }

        private void GridVehicleM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridVehicleM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridVehicleM.CurrentRow.Selected = true;

                    BoxMaintenanceId.Text = GridVehicleM.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxVehicleNum.SelectedItem = GridVehicleM.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxDescription.Text = GridVehicleM.Rows[e.RowIndex].Cells[2].Value.ToString();
                    ServiceDate.Text = GridVehicleM.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BtnClearVehicleM_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSearchVehicleM_Click(object sender, EventArgs e)
        {
            if (BoxSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    maintenanceId = Convert.ToInt32(BoxSearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblVehicleMaintenance where maintenanceId=@id", con);
                    cmd.Parameters.AddWithValue("id", maintenanceId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridVehicleM.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefreshVehicleM_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
