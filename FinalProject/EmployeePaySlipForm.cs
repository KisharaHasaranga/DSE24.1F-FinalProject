using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeePaySlipForm : Form
    {
        public EmployeePaySlipForm()
        {
            InitializeComponent();
        }

        //SQL var
        public SqlCommand cmd;
        public SqlDataReader dr;
        private static readonly SqlConnection sqlConnection = new SqlConnection("Data source = kishara; " +
            "Initial Catalog = finalproject; Integrated Security = True; Encrypt=False;");

        SqlConnection con = sqlConnection;

        int empId = Convert.ToInt32(LoginForm.empId);

        private void EmployeePaySlipForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblSalary where empId = '" + empId + "'", con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "tblSalary");

            EmployeeSalaryReport employeeSalaryReport = new EmployeeSalaryReport();
            employeeSalaryReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = employeeSalaryReport;
        }      
    }
}
