using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeeReportForm : Form
    {
        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            LoadEmpData();
            LoadReport();
        }
        private void LoadReport()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblEmployee", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblEmployee");

            EmployeeReport employeeReport = new EmployeeReport();
            employeeReport.SetDataSource(ds);
            EmpCrystalReportViewer.ReportSource = employeeReport;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblEmployee where empId = '" + CBoxEmpId.SelectedItem.ToString() + "'", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblEmployee");

            EmployeeReport employeeReport = new EmployeeReport();
            employeeReport.SetDataSource(ds);
            EmpCrystalReportViewer.ReportSource = employeeReport;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CBoxEmpId.SelectedIndex = -1;
            LoadReport();
        }
    }
}
