namespace FinalProject
{
    partial class EmployeeSalaryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxSalarySearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxEmpId = new System.Windows.Forms.ComboBox();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.BtnCalculateSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.BoxMinAmt = new System.Windows.Forms.TextBox();
            this.BoxTotalAmt = new System.Windows.Forms.TextBox();
            this.BoxBonus = new System.Windows.Forms.TextBox();
            this.BoxOT = new System.Windows.Forms.TextBox();
            this.BoxSalaryId = new System.Windows.Forms.TextBox();
            this.BoxEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertSalary = new ReaLTaiizor.Controls.ForeverButton();
            this.GridSalary = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxSalarySearch);
            this.panel1.Controls.Add(this.BtnRefreshSalary);
            this.panel1.Controls.Add(this.BtnSearchSalary);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 5;
            // 
            // BoxSalarySearch
            // 
            this.BoxSalarySearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSalarySearch.Location = new System.Drawing.Point(427, 24);
            this.BoxSalarySearch.Name = "BoxSalarySearch";
            this.BoxSalarySearch.Size = new System.Drawing.Size(187, 30);
            this.BoxSalarySearch.TabIndex = 4;
            this.BoxSalarySearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxSalarySearch_KeyDown);
            // 
            // BtnRefreshSalary
            // 
            this.BtnRefreshSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshSalary.Location = new System.Drawing.Point(757, 24);
            this.BtnRefreshSalary.Name = "BtnRefreshSalary";
            this.BtnRefreshSalary.Rounded = false;
            this.BtnRefreshSalary.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshSalary.TabIndex = 7;
            this.BtnRefreshSalary.Text = "Refresh";
            this.BtnRefreshSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshSalary.Click += new System.EventHandler(this.BtnRefreshSalary_Click);
            // 
            // BtnSearchSalary
            // 
            this.BtnSearchSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchSalary.Location = new System.Drawing.Point(652, 24);
            this.BtnSearchSalary.Name = "BtnSearchSalary";
            this.BtnSearchSalary.Rounded = false;
            this.BtnSearchSalary.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchSalary.TabIndex = 7;
            this.BtnSearchSalary.Text = "Search";
            this.BtnSearchSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchSalary.Click += new System.EventHandler(this.BtnSearchSalary_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Employee Salary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.CBoxEmpId);
            this.panel2.Controls.Add(this.DateCreated);
            this.panel2.Controls.Add(this.BtnCalculateSalary);
            this.panel2.Controls.Add(this.BoxMinAmt);
            this.panel2.Controls.Add(this.BoxTotalAmt);
            this.panel2.Controls.Add(this.BoxBonus);
            this.panel2.Controls.Add(this.BoxOT);
            this.panel2.Controls.Add(this.BoxSalaryId);
            this.panel2.Controls.Add(this.BoxEmpName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 6;
            // 
            // CBoxEmpId
            // 
            this.CBoxEmpId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxEmpId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxEmpId.FormattingEnabled = true;
            this.CBoxEmpId.Items.AddRange(new object[] {
            "Admin",
            "SalesRep",
            "Logistics-Coordinator",
            "Driver",
            "Inventorty Manager"});
            this.CBoxEmpId.Location = new System.Drawing.Point(218, 69);
            this.CBoxEmpId.Name = "CBoxEmpId";
            this.CBoxEmpId.Size = new System.Drawing.Size(187, 29);
            this.CBoxEmpId.TabIndex = 7;
            this.CBoxEmpId.SelectedIndexChanged += new System.EventHandler(this.CBoxEmpId_SelectedIndexChanged);
            // 
            // DateCreated
            // 
            this.DateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCreated.Location = new System.Drawing.Point(218, 263);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(187, 26);
            this.DateCreated.TabIndex = 6;
            // 
            // BtnCalculateSalary
            // 
            this.BtnCalculateSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalculateSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCalculateSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculateSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCalculateSalary.Location = new System.Drawing.Point(315, 406);
            this.BtnCalculateSalary.Name = "BtnCalculateSalary";
            this.BtnCalculateSalary.Rounded = false;
            this.BtnCalculateSalary.Size = new System.Drawing.Size(90, 40);
            this.BtnCalculateSalary.TabIndex = 7;
            this.BtnCalculateSalary.Text = "Calculate";
            this.BtnCalculateSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnCalculateSalary.Click += new System.EventHandler(this.BtnCalculateSalary_Click);
            // 
            // BoxMinAmt
            // 
            this.BoxMinAmt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxMinAmt.Location = new System.Drawing.Point(218, 305);
            this.BoxMinAmt.Name = "BoxMinAmt";
            this.BoxMinAmt.Size = new System.Drawing.Size(187, 30);
            this.BoxMinAmt.TabIndex = 4;
            // 
            // BoxTotalAmt
            // 
            this.BoxTotalAmt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTotalAmt.Location = new System.Drawing.Point(218, 355);
            this.BoxTotalAmt.Name = "BoxTotalAmt";
            this.BoxTotalAmt.Size = new System.Drawing.Size(187, 30);
            this.BoxTotalAmt.TabIndex = 4;
            // 
            // BoxBonus
            // 
            this.BoxBonus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBonus.Location = new System.Drawing.Point(218, 215);
            this.BoxBonus.Name = "BoxBonus";
            this.BoxBonus.Size = new System.Drawing.Size(187, 30);
            this.BoxBonus.TabIndex = 4;
            this.BoxBonus.Text = "0";
            // 
            // BoxOT
            // 
            this.BoxOT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOT.Location = new System.Drawing.Point(218, 167);
            this.BoxOT.Name = "BoxOT";
            this.BoxOT.Size = new System.Drawing.Size(187, 30);
            this.BoxOT.TabIndex = 4;
            this.BoxOT.Text = "0";
            // 
            // BoxSalaryId
            // 
            this.BoxSalaryId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSalaryId.Location = new System.Drawing.Point(218, 24);
            this.BoxSalaryId.Name = "BoxSalaryId";
            this.BoxSalaryId.ReadOnly = true;
            this.BoxSalaryId.Size = new System.Drawing.Size(187, 30);
            this.BoxSalaryId.TabIndex = 4;
            // 
            // BoxEmpName
            // 
            this.BoxEmpName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmpName.Location = new System.Drawing.Point(218, 116);
            this.BoxEmpName.Name = "BoxEmpName";
            this.BoxEmpName.ReadOnly = true;
            this.BoxEmpName.Size = new System.Drawing.Size(187, 30);
            this.BoxEmpName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bonus:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mininmum Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "OT Hours:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salary Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearSalary);
            this.panel3.Controls.Add(this.BtnDeleteSalary);
            this.panel3.Controls.Add(this.BtnUpdateSalary);
            this.panel3.Controls.Add(this.BtnInsertSalary);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 7;
            // 
            // BtnClearSalary
            // 
            this.BtnClearSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearSalary.Location = new System.Drawing.Point(386, 32);
            this.BtnClearSalary.Name = "BtnClearSalary";
            this.BtnClearSalary.Rounded = false;
            this.BtnClearSalary.Size = new System.Drawing.Size(90, 40);
            this.BtnClearSalary.TabIndex = 7;
            this.BtnClearSalary.Text = "Clear";
            this.BtnClearSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearSalary.Click += new System.EventHandler(this.BtnClearSalary_Click);
            // 
            // BtnDeleteSalary
            // 
            this.BtnDeleteSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteSalary.Location = new System.Drawing.Point(263, 32);
            this.BtnDeleteSalary.Name = "BtnDeleteSalary";
            this.BtnDeleteSalary.Rounded = false;
            this.BtnDeleteSalary.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteSalary.TabIndex = 7;
            this.BtnDeleteSalary.Text = "Delete";
            this.BtnDeleteSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteSalary.Click += new System.EventHandler(this.BtnDeleteSalary_Click);
            // 
            // BtnUpdateSalary
            // 
            this.BtnUpdateSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateSalary.Location = new System.Drawing.Point(145, 32);
            this.BtnUpdateSalary.Name = "BtnUpdateSalary";
            this.BtnUpdateSalary.Rounded = false;
            this.BtnUpdateSalary.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateSalary.TabIndex = 7;
            this.BtnUpdateSalary.Text = "Update";
            this.BtnUpdateSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateSalary.Click += new System.EventHandler(this.BtnUpdateSalary_Click);
            // 
            // BtnInsertSalary
            // 
            this.BtnInsertSalary.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertSalary.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertSalary.Name = "BtnInsertSalary";
            this.BtnInsertSalary.Rounded = false;
            this.BtnInsertSalary.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertSalary.TabIndex = 7;
            this.BtnInsertSalary.Text = "Insert";
            this.BtnInsertSalary.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertSalary.Click += new System.EventHandler(this.BtnInsertSalary_Click);
            // 
            // GridSalary
            // 
            this.GridSalary.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSalary.Location = new System.Drawing.Point(424, 66);
            this.GridSalary.Name = "GridSalary";
            this.GridSalary.Size = new System.Drawing.Size(801, 591);
            this.GridSalary.TabIndex = 8;
            this.GridSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSalary_CellClick);
            // 
            // EmployeeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridSalary);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSalaryForm";
            this.Text = "EmployeeSalaryForm";
            this.Load += new System.EventHandler(this.EmployeeSalaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSalarySearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshSalary;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.TextBox BoxTotalAmt;
        private System.Windows.Forms.TextBox BoxBonus;
        private System.Windows.Forms.TextBox BoxOT;
        private System.Windows.Forms.TextBox BoxEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearSalary;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteSalary;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateSalary;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertSalary;
        private System.Windows.Forms.DataGridView GridSalary;
        private System.Windows.Forms.ComboBox CBoxEmpId;
        private System.Windows.Forms.TextBox BoxMinAmt;
        private System.Windows.Forms.Label label9;
        private ReaLTaiizor.Controls.ForeverButton BtnCalculateSalary;
        private System.Windows.Forms.TextBox BoxSalaryId;
        private System.Windows.Forms.Label label6;
    }
}