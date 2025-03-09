using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ManageLeaveRequestForm : Form
    {
        public ManageLeaveRequestForm()
        {
            InitializeComponent();
        }
        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private int leaveReqId;
        private int empId;
        private string leaveType;
        private string description;
        private string startDate;
        private string endDate;
        private string status;
        private void ManageLeaveRequestForm_Load(object sender, EventArgs e)
        {
            LoadLeaveRequestId();
            LoadEmployeeId();
            LoadGrid();
        }
        // Load Auto-generated LeaveRequestId
        private void LoadLeaveRequestId()
        {
            con.Close();
            // Auto-generate the next LeaveRequestId and load it into the text box
            int nextLeaveRequestID = GetNextLeaveRequestId();
            if (nextLeaveRequestID != -1)
            {
                BoxLeaveReqId.Text = nextLeaveRequestID.ToString();
            }
        }
        // Get next LeaveRequestId
        private int GetNextLeaveRequestId()
        {
            string query = "SELECT ISNULL(MAX(leaveRequestId), 0) + 1 FROM tblLeaveRequest";
            cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next Leave Request Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid ID if there's an error
            }
        }
        // Load Employee Id of the logged in user
        private void LoadEmployeeId()
        {
            BoxEmpId.Text = LoginForm.empId.ToString();
        }
        // Load Data to Grid
        private void LoadGrid()
        {
            con.Close();
            empId = Convert.ToInt32(LoginForm.empId);
            SqlCommand cmd = new SqlCommand("select * from tblLeaveRequest where employeeId = @employeeId", con);
            cmd.Parameters.AddWithValue("employeeId", empId);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            GridLeaveRequest.DataSource = dt.DefaultView;
        }
        // Check if all the fields are not empty
        private bool IsValid()
        {
            if (BoxLeaveReqId.Text == string.Empty)
            {
                MessageBox.Show("Error, Can not get Leave Request Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxEmpId.Text == string.Empty)
            {
                MessageBox.Show("Error, Can not find Employee Id!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CBoxLeaveType.SelectedIndex == -1)
            {
                MessageBox.Show("Leave type is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (BoxDescription.Text == string.Empty)
            {
                MessageBox.Show("Description is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (StartDate.Text == string.Empty)
            {
                MessageBox.Show("Start Date is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (EndDate.Text == string.Empty)
            {
                MessageBox.Show("End Date is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Clear()
        {
            CBoxLeaveType.SelectedIndex = -1;
            BoxDescription.Text = string.Empty;
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
        }
        private void BtnApplyLeaveRequest_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    leaveReqId = Convert.ToInt32(BoxLeaveReqId.Text);
                    empId = Convert.ToInt32(BoxEmpId.Text);
                    leaveType = CBoxLeaveType.SelectedItem.ToString();
                    description = BoxDescription.Text;
                    startDate = StartDate.Text;
                    endDate = EndDate.Text;

                    con.Close();
                    SqlCommand cmd = new SqlCommand("insert into tblLeaveRequest (leaveRequestId, employeeId, leaveType, description, startDate, endDate) values (@leaveRequestId, @employeeId, @leaveType, @description, @startDate, @endDate)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("leaveRequestId", leaveReqId);
                    cmd.Parameters.AddWithValue("employeeId", empId);
                    cmd.Parameters.AddWithValue("leaveType", leaveType);
                    cmd.Parameters.AddWithValue("description", description);
                    cmd.Parameters.AddWithValue("startDate", startDate);
                    cmd.Parameters.AddWithValue("endDate", endDate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert Succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    Clear();
                    LoadLeaveRequestId();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void BtnCancelLeaveRequest_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    status = "Cancelled";
                    leaveReqId = Convert.ToInt32(BoxLeaveReqId.Text);

                    con.Close();
                    SqlCommand cmd = new SqlCommand("update tblLeaveRequest set status=@status where leaveRequestId=@id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("id", leaveReqId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Leave Request successfully cancelled", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadLeaveRequestId();
                    LoadGrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void BtnSearchLeaveRequest_Click(object sender, EventArgs e)
        {
            if (BoxSearch.Text != string.Empty)
            {
                try
                {
                    con.Close();
                    empId = Convert.ToInt32(BoxEmpId.Text);
                    leaveReqId = Convert.ToInt32(BoxSearch.Text);
                    SqlCommand cmd = new SqlCommand("select * from tblLeaveRequest where employeeId=@employeeId and leaveRequestId=@leaveId", con);
                    cmd.Parameters.AddWithValue("employeeId", empId);
                    cmd.Parameters.AddWithValue("leaveId", leaveReqId);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.Close();
                    GridLeaveRequest.DataSource = dt.DefaultView;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GridLeaveRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridLeaveRequest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GridLeaveRequest.CurrentRow.Selected = true;

                    BoxLeaveReqId.Text = GridLeaveRequest.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BoxEmpId.Text = GridLeaveRequest.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBoxLeaveType.SelectedItem = GridLeaveRequest.Rows[e.RowIndex].Cells[2].Value.ToString();
                    BoxDescription.Text = GridLeaveRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                    StartDate.Text = GridLeaveRequest.Rows[e.RowIndex].Cells[4].Value.ToString();
                    EndDate.Text = GridLeaveRequest.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private void BtnClearLeaveRequest_Click(object sender, EventArgs e)
        {
            LoadLeaveRequestId();
            LoadEmployeeId();
            Clear();
        }
        private void BtnRefreshLeaveRequest_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}