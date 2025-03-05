using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LabelEmpId.Text = LoginForm.empId;
            LabelEmpName.Text = LoginForm.empName;
            LabelEmpUserType.Text = LoginForm.userType;
            LabelUsername.Text = LoginForm.empUsername;
            LabelNIC.Text = LoginForm.empNIC;
            LabelContact.Text = LoginForm.empContact;
            LabelEmail.Text = LoginForm.empEmail;
            LabelAddress.Text = LoginForm.empAddress;
            LabelJoinedDate.Text = LoginForm.empJoinedDate;
        }
    }
}
