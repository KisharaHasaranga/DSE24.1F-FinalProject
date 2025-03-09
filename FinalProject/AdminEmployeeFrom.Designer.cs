namespace FinalProject
{
    partial class AdminEmployeeFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearEmp = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteEmp = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateEmp = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertEmp = new ReaLTaiizor.Controls.ForeverButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.BoxStatus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxEmployeeSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshEmp = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchEmp = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CBoxUserType = new System.Windows.Forms.ComboBox();
            this.DateJoined = new System.Windows.Forms.DateTimePicker();
            this.BoxAddress = new System.Windows.Forms.TextBox();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.BoxContact = new System.Windows.Forms.TextBox();
            this.BoxNIC = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.BoxUsername = new System.Windows.Forms.TextBox();
            this.BoxEmpId = new System.Windows.Forms.TextBox();
            this.BoxEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridEmployee
            // 
            this.GridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmployee.Location = new System.Drawing.Point(424, 66);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.Size = new System.Drawing.Size(801, 591);
            this.GridEmployee.TabIndex = 7;
            this.GridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmployee_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearEmp);
            this.panel3.Controls.Add(this.BtnDeleteEmp);
            this.panel3.Controls.Add(this.BtnUpdateEmp);
            this.panel3.Controls.Add(this.BtnInsertEmp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 6;
            // 
            // BtnClearEmp
            // 
            this.BtnClearEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearEmp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearEmp.Location = new System.Drawing.Point(385, 32);
            this.BtnClearEmp.Name = "BtnClearEmp";
            this.BtnClearEmp.Rounded = false;
            this.BtnClearEmp.Size = new System.Drawing.Size(90, 40);
            this.BtnClearEmp.TabIndex = 7;
            this.BtnClearEmp.Text = "Clear";
            this.BtnClearEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearEmp.Click += new System.EventHandler(this.BtnClearEmp_Click);
            // 
            // BtnDeleteEmp
            // 
            this.BtnDeleteEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteEmp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteEmp.Location = new System.Drawing.Point(267, 32);
            this.BtnDeleteEmp.Name = "BtnDeleteEmp";
            this.BtnDeleteEmp.Rounded = false;
            this.BtnDeleteEmp.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteEmp.TabIndex = 7;
            this.BtnDeleteEmp.Text = "Delete";
            this.BtnDeleteEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteEmp.Click += new System.EventHandler(this.BtnDeleteEmp_Click);
            // 
            // BtnUpdateEmp
            // 
            this.BtnUpdateEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateEmp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateEmp.Location = new System.Drawing.Point(149, 32);
            this.BtnUpdateEmp.Name = "BtnUpdateEmp";
            this.BtnUpdateEmp.Rounded = false;
            this.BtnUpdateEmp.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateEmp.TabIndex = 7;
            this.BtnUpdateEmp.Text = "Update";
            this.BtnUpdateEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateEmp.Click += new System.EventHandler(this.BtnUpdateEmp_Click);
            // 
            // BtnInsertEmp
            // 
            this.BtnInsertEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertEmp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertEmp.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertEmp.Name = "BtnInsertEmp";
            this.BtnInsertEmp.Rounded = false;
            this.BtnInsertEmp.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertEmp.TabIndex = 7;
            this.BtnInsertEmp.Text = "Insert";
            this.BtnInsertEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertEmp.Click += new System.EventHandler(this.BtnInsertEmp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.BoxStatus);
            this.panel6.Location = new System.Drawing.Point(12, 522);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 69);
            this.panel6.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Status:";
            // 
            // BoxStatus
            // 
            this.BoxStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxStatus.Location = new System.Drawing.Point(206, 21);
            this.BoxStatus.Name = "BoxStatus";
            this.BoxStatus.Size = new System.Drawing.Size(187, 30);
            this.BoxStatus.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxEmployeeSearch);
            this.panel1.Controls.Add(this.BtnRefreshEmp);
            this.panel1.Controls.Add(this.BtnSearchEmp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 4;
            // 
            // BoxEmployeeSearch
            // 
            this.BoxEmployeeSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmployeeSearch.Location = new System.Drawing.Point(429, 24);
            this.BoxEmployeeSearch.Name = "BoxEmployeeSearch";
            this.BoxEmployeeSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxEmployeeSearch.TabIndex = 4;
            // 
            // BtnRefreshEmp
            // 
            this.BtnRefreshEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshEmp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshEmp.Location = new System.Drawing.Point(758, 24);
            this.BtnRefreshEmp.Name = "BtnRefreshEmp";
            this.BtnRefreshEmp.Rounded = false;
            this.BtnRefreshEmp.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshEmp.TabIndex = 7;
            this.BtnRefreshEmp.Text = "Refresh";
            this.BtnRefreshEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshEmp.Click += new System.EventHandler(this.BtnRefreshEmp_Click);
            // 
            // BtnSearchEmp
            // 
            this.BtnSearchEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchEmp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchEmp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchEmp.Location = new System.Drawing.Point(642, 24);
            this.BtnSearchEmp.Name = "BtnSearchEmp";
            this.BtnSearchEmp.Rounded = false;
            this.BtnSearchEmp.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchEmp.TabIndex = 7;
            this.BtnSearchEmp.Text = "Search";
            this.BtnSearchEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchEmp.Click += new System.EventHandler(this.BtnSearchEmp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Employee";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.CBoxUserType);
            this.panel4.Controls.Add(this.DateJoined);
            this.panel4.Controls.Add(this.BoxAddress);
            this.panel4.Controls.Add(this.BoxEmail);
            this.panel4.Controls.Add(this.BoxContact);
            this.panel4.Controls.Add(this.BoxNIC);
            this.panel4.Controls.Add(this.BoxPassword);
            this.panel4.Controls.Add(this.BoxUsername);
            this.panel4.Controls.Add(this.BoxEmpId);
            this.panel4.Controls.Add(this.BoxEmpName);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 506);
            this.panel4.TabIndex = 10;
            // 
            // CBoxUserType
            // 
            this.CBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxUserType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxUserType.FormattingEnabled = true;
            this.CBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "Director",
            "Operation-Manager",
            "Logistics-Coordinator",
            "Inventory Manager",
            "SalesRep",
            "Driver"});
            this.CBoxUserType.Location = new System.Drawing.Point(203, 116);
            this.CBoxUserType.Name = "CBoxUserType";
            this.CBoxUserType.Size = new System.Drawing.Size(187, 29);
            this.CBoxUserType.TabIndex = 27;
            // 
            // DateJoined
            // 
            this.DateJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateJoined.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateJoined.Location = new System.Drawing.Point(203, 450);
            this.DateJoined.Name = "DateJoined";
            this.DateJoined.Size = new System.Drawing.Size(187, 26);
            this.DateJoined.TabIndex = 26;
            // 
            // BoxAddress
            // 
            this.BoxAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAddress.Location = new System.Drawing.Point(203, 402);
            this.BoxAddress.Name = "BoxAddress";
            this.BoxAddress.Size = new System.Drawing.Size(187, 30);
            this.BoxAddress.TabIndex = 24;
            // 
            // BoxEmail
            // 
            this.BoxEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmail.Location = new System.Drawing.Point(203, 354);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(187, 30);
            this.BoxEmail.TabIndex = 23;
            // 
            // BoxContact
            // 
            this.BoxContact.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxContact.Location = new System.Drawing.Point(203, 305);
            this.BoxContact.Name = "BoxContact";
            this.BoxContact.Size = new System.Drawing.Size(187, 30);
            this.BoxContact.TabIndex = 22;
            // 
            // BoxNIC
            // 
            this.BoxNIC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNIC.Location = new System.Drawing.Point(203, 254);
            this.BoxNIC.Name = "BoxNIC";
            this.BoxNIC.Size = new System.Drawing.Size(187, 30);
            this.BoxNIC.TabIndex = 21;
            // 
            // BoxPassword
            // 
            this.BoxPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPassword.Location = new System.Drawing.Point(203, 203);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(187, 30);
            this.BoxPassword.TabIndex = 20;
            // 
            // BoxUsername
            // 
            this.BoxUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsername.Location = new System.Drawing.Point(203, 159);
            this.BoxUsername.Name = "BoxUsername";
            this.BoxUsername.Size = new System.Drawing.Size(187, 30);
            this.BoxUsername.TabIndex = 19;
            // 
            // BoxEmpId
            // 
            this.BoxEmpId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmpId.Location = new System.Drawing.Point(203, 21);
            this.BoxEmpId.Name = "BoxEmpId";
            this.BoxEmpId.ReadOnly = true;
            this.BoxEmpId.Size = new System.Drawing.Size(187, 30);
            this.BoxEmpId.TabIndex = 25;
            // 
            // BoxEmpName
            // 
            this.BoxEmpName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmpName.Location = new System.Drawing.Point(203, 65);
            this.BoxEmpName.Name = "BoxEmpName";
            this.BoxEmpName.Size = new System.Drawing.Size(187, 30);
            this.BoxEmpName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Joined Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "NIC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Id:";
            // 
            // AdminEmployeeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEmployeeFrom";
            this.Text = "AdminEmployeeFrom";
            this.Load += new System.EventHandler(this.AdminEmployeeFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEmployee;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearEmp;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteEmp;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateEmp;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxEmployeeSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshEmp;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BoxStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CBoxUserType;
        private System.Windows.Forms.DateTimePicker DateJoined;
        private System.Windows.Forms.TextBox BoxAddress;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.TextBox BoxContact;
        private System.Windows.Forms.TextBox BoxNIC;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.TextBox BoxUsername;
        private System.Windows.Forms.TextBox BoxEmpId;
        private System.Windows.Forms.TextBox BoxEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}