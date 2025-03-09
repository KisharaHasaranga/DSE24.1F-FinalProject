using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeeSalaryForm : Form
    {
        public EmployeeSalaryForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int salaryId;
        private int empId;
        private string empName;
        private float OT;
        private double bonus;
        private string date;
        private double minAmt;
        private double totalAmt;


        private void EmployeeSalaryForm_Load(object sender, EventArgs e)
        {
            LoadSalaryID();
            LoadEmpData();
            LoadGrid();
        }

        // Load Auto-generated SalaryID
        private void LoadSalaryID()
        {
            con.Close();
            // Auto-generate the next EmpID and load it into the text box
            int nextEmpID = GetNextSalaryID();
            if (nextEmpID != -1)
            {
                BoxSalaryId.Text = nextEmpID.ToString();
            }
        }
        // Get next SalaryID
        private int GetNextSalaryID()
        {
            string query = "SELECT ISNULL(MAX(salaryId), 0) + 1 FROM tblSalary";
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next SalaryID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }

        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from tblSalary", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridSalary.DataSource = dt.DefaultView;
        }

        // Load EmpId into ComboBox
        private void LoadEmpData()
        {
            con.Close();
            string query = "select empId from tblEmployee";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear ComboBox before adding new items
            CBoxEmpId.Items.Clear();

            // Load EmpIDs into ComboBox
            while (reader.Read())
            {
                CBoxEmpId.Items.Add(reader["empId"].ToString());
            }
            con.Close();
        }

        // When selecting EmpID, load the corresponding EmpName
        private void CBoxEmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxEmpId.SelectedItem != null)
            {
                con.Close();
                string selectedEmpID = CBoxEmpId.SelectedItem.ToString();

                // Look up corresponding Emp Name based on EmpID
                string query = "select empName from tblEmployee where empId = @empId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@empId", selectedEmpID);

                con.Open();
                object result = cmd.ExecuteScalar();  // Get the corresponding name

                if (result != null)
                {
                    BoxEmpName.Text = result.ToString();
                }
                con.Close();
            }
        }

        // Calculate Salary
        private void BtnCalculateSalary_Click(object sender, EventArgs e)
        {
            double bonus = Convert.ToDouble(BoxBonus.Text);
            float OT = Convert.ToSingle(BoxOT.Text);
            double OTRate = 200;
            double minSalary = 0;
            double totalAmt = 0;

            try
            {
                if (CBoxEmpId.SelectedItem != null)
                {
                    con.Close();
                    string selectedEmpId = CBoxEmpId.SelectedItem.ToString();

                    string query = "select empType from tblEmployee where empId = @empId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@empId", selectedEmpId);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string EmpType = result.ToString();

                        if (EmpType == "Operation Manager")
                        {
                            minSalary = 120000.00d;
                            totalAmt = minSalary + bonus + (OT * OTRate);
                            BoxMinAmt.Text = minSalary.ToString();
                            BoxTotalAmt.Text = totalAmt.ToString();

                        }
                        else if (EmpType == "SalesRep")
                        {
                            minSalary = 90000.00d;
                            totalAmt = minSalary + bonus + (OT * OTRate);
                            BoxMinAmt.Text = minSalary.ToString();
                            BoxTotalAmt.Text = totalAmt.ToString();
                        }
                        else if (EmpType == "Logistics-Coordinator")
                        {
                            minSalary = 100000.00d;
                            totalAmt = minSalary + bonus + (OT * OTRate);
                            BoxMinAmt.Text = minSalary.ToString();
                            BoxTotalAmt.Text = totalAmt.ToString();
                        }

                        else if (EmpType == "Inventorty Manager")
                        {
                            minSalary = 110000.00d;
                            totalAmt = minSalary + bonus + (OT * OTRate);
                            BoxMinAmt.Text = minSalary.ToString();
                            BoxTotalAmt.Text = totalAmt.ToString();
                        }
                        else if (EmpType == "Driver")
                        {
                            minSalary = 60000.00d;
                            totalAmt = minSalary + bonus + (OT * OTRate);
                            BoxMinAmt.Text = minSalary.ToString();
                            BoxTotalAmt.Text = totalAmt.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot find employee type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Cannot find employee Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (BoxSalaryId.Text == string.Empty)
            {
                MessageBox.Show("SalaryId is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxEmpId.Text == string.Empty)
            {
                MessageBox.Show("EmpId is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxEmpName.Text == string.Empty)
            {
                MessageBox.Show("EmpName is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxOT.Text == string.Empty)
            {
                MessageBox.Show("OT Hours are required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxBonus.Text == string.Empty)
            {
                MessageBox.Show("Bonus is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DateCreated.Text == string.Empty)
            {
                MessageBox.Show("Date is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxMinAmt.Text == string.Empty)
            {
                MessageBox.Show("Minimum Amount is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxTotalAmt.Text == string.Empty)
            {
                MessageBox.Show("Total Amount is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Insert Data
        private void BtnInsertSalary_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    salaryId = Convert.ToInt32(BoxSalaryId.Text);
                    empId = Convert.ToInt32(CBoxEmpId.SelectedItem.ToString());
                    empName = BoxEmpName.Text;
                    OT = Convert.ToSingle(BoxOT.Text);
                    bonus = Convert.ToDouble(BoxBonus.Text);
                    date = DateCreated.Text;
                    minAmt = Convert.ToDouble(BoxMinAmt.Text);
                    totalAmt = Convert.ToDouble(BoxTotalAmt.Text);

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblSalary values (@salaryId, @empId, @empName, @bonus, @ot, @minSalary, @totalSalary, @date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("salaryId", salaryId);
                    cmd.Parameters.AddWithValue("empId", empId);
                    cmd.Parameters.AddWithValue("empName", empName);
                    cmd.Parameters.AddWithValue("bonus", bonus);
                    cmd.Parameters.AddWithValue("ot", OT);
                    cmd.Parameters.AddWithValue("minSalary", minAmt);
                    cmd.Parameters.AddWithValue("totalSalary", totalAmt);
                    cmd.Parameters.AddWithValue("date", date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                    LoadSalaryID();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        // Update Data
        private void BtnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    salaryId = Convert.ToInt32(BoxSalaryId.Text);
                    empId = Convert.ToInt32(CBoxEmpId.SelectedItem.ToString());
                    empName = BoxEmpName.Text;
                    OT = Convert.ToSingle(BoxOT.Text);
                    bonus = Convert.ToDouble(BoxBonus.Text);
                    date = DateCreated.Text;
                    minAmt = Convert.ToDouble(BoxMinAmt.Text);
                    totalAmt = Convert.ToDouble(BoxTotalAmt.Text);

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblSalary set empId=@empId, empName=@empName, bonus=@bonus, otHrs=@ot, minimumSalary=@minSalary, totalSalary=@totalSalary, Date=@date where salaryId=@salaryId", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("empId", empId);
                    cmd.Parameters.AddWithValue("empName", empName);
                    cmd.Parameters.AddWithValue("bonus", bonus);
                    cmd.Parameters.AddWithValue("ot", OT);
                    cmd.Parameters.AddWithValue("minSalary", minAmt);
                    cmd.Parameters.AddWithValue("totalSalary", totalAmt);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("salaryId", salaryId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                    LoadSalaryID();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        // Delete Data
        private void BtnDeleteSalary_Click(object sender, EventArgs e)
        {
            try
            {
                salaryId = Convert.ToInt32(BoxSalaryId.Text);

                con.Close();
                SqlCommand cmd = new SqlCommand("delete from tblSalary where salaryId=@id", con);
                cmd.Parameters.AddWithValue("id", salaryId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Succesfull", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                Clear();
                LoadSalaryID();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Delete Unsuccessfull" + exception.Message);
            }
        }

        // Search Data
        private void BtnSearchSalary_Click(object sender, EventArgs e)
        {
            SearchSalary();
        }
        private void BoxSalarySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchSalary();
            }
        }
        // Search Salary Method
        private void SearchSalary()
        {
            if (BoxSalarySearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    salaryId = Convert.ToInt32(BoxSalarySearch.Text.Trim());
                    SqlCommand cmd = new SqlCommand("select * from tblSalary where salaryId=@id", con);
                    cmd.Parameters.AddWithValue("id", salaryId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridSalary.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Refresh Data and close db connection if its open
        private void BtnRefreshSalary_Click(object sender, EventArgs e)
        {
            con.Close();
            LoadGrid();
        }

        // Select Grid Data to Fields
        private void GridSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridSalary.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridSalary.CurrentRow.Selected = true;

                    BoxSalaryId.Text = GridSalary.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBoxEmpId.SelectedItem = GridSalary.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BoxEmpName.Text = GridSalary.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxBonus.Text = GridSalary.Rows[e.RowIndex].Cells[3].Value.ToString();
                    BoxOT.Text = GridSalary.Rows[e.RowIndex].Cells[4].Value.ToString();
                    BoxMinAmt.Text = GridSalary.Rows[e.RowIndex].Cells[5].Value.ToString();
                    BoxTotalAmt.Text = GridSalary.Rows[e.RowIndex].Cells[6].Value.ToString();
                    DateCreated.Text = GridSalary.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        // Clear Fields and Reset
        private void BtnClearSalary_Click(object sender, EventArgs e)
        {
            Clear();
            LoadSalaryID();
        }

        private void Clear()
        {
            CBoxEmpId.SelectedIndex = -1;
            BoxEmpName.Text = "";
            BoxBonus.Text = "0";
            BoxOT.Text = "0";
            BoxMinAmt.Text = "";
            BoxTotalAmt.Text = "";
            DateCreated.Value = DateTime.Now;
        }
    }
}
