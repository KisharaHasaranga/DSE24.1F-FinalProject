namespace FinalProject
{
    partial class ManageLeaveRequestForm
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
            this.BoxSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshLeaveRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchLeaveRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BoxDescription = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.BoxEmpId = new System.Windows.Forms.TextBox();
            this.BoxLeaveReqId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxLeaveType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BoxStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearLeaveRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnCancelLeaveRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnApplyLeaveRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.GridLeaveRequest = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLeaveRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxSearch);
            this.panel1.Controls.Add(this.BtnRefreshLeaveRequest);
            this.panel1.Controls.Add(this.BtnSearchLeaveRequest);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 9;
            // 
            // BoxSearch
            // 
            this.BoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearch.Location = new System.Drawing.Point(431, 21);
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxSearch.TabIndex = 4;
            // 
            // BtnRefreshLeaveRequest
            // 
            this.BtnRefreshLeaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshLeaveRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshLeaveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshLeaveRequest.Location = new System.Drawing.Point(761, 21);
            this.BtnRefreshLeaveRequest.Name = "BtnRefreshLeaveRequest";
            this.BtnRefreshLeaveRequest.Rounded = false;
            this.BtnRefreshLeaveRequest.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshLeaveRequest.TabIndex = 7;
            this.BtnRefreshLeaveRequest.Text = "Refresh";
            this.BtnRefreshLeaveRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshLeaveRequest.Click += new System.EventHandler(this.BtnRefreshLeaveRequest_Click);
            // 
            // BtnSearchLeaveRequest
            // 
            this.BtnSearchLeaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchLeaveRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchLeaveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchLeaveRequest.Location = new System.Drawing.Point(656, 21);
            this.BtnSearchLeaveRequest.Name = "BtnSearchLeaveRequest";
            this.BtnSearchLeaveRequest.Rounded = false;
            this.BtnSearchLeaveRequest.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchLeaveRequest.TabIndex = 7;
            this.BtnSearchLeaveRequest.Text = "Search";
            this.BtnSearchLeaveRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchLeaveRequest.Click += new System.EventHandler(this.BtnSearchLeaveRequest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Leave Requests";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.BoxDescription);
            this.panel5.Controls.Add(this.EndDate);
            this.panel5.Controls.Add(this.StartDate);
            this.panel5.Controls.Add(this.BoxEmpId);
            this.panel5.Controls.Add(this.BoxLeaveReqId);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.CBoxLeaveType);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 449);
            this.panel5.TabIndex = 9;
            // 
            // BoxDescription
            // 
            this.BoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.BoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BoxDescription.Hint = "";
            this.BoxDescription.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.BoxDescription.Location = new System.Drawing.Point(13, 195);
            this.BoxDescription.MaxLength = 32767;
            this.BoxDescription.Multiline = true;
            this.BoxDescription.Name = "BoxDescription";
            this.BoxDescription.PasswordChar = '\0';
            this.BoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxDescription.SelectedText = "";
            this.BoxDescription.SelectionLength = 0;
            this.BoxDescription.SelectionStart = 0;
            this.BoxDescription.Size = new System.Drawing.Size(380, 144);
            this.BoxDescription.TabIndex = 9;
            this.BoxDescription.TabStop = false;
            this.BoxDescription.UseSystemPasswordChar = false;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(206, 406);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(187, 26);
            this.EndDate.TabIndex = 8;
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(206, 365);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(187, 26);
            this.StartDate.TabIndex = 8;
            // 
            // BoxEmpId
            // 
            this.BoxEmpId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmpId.Location = new System.Drawing.Point(206, 70);
            this.BoxEmpId.Name = "BoxEmpId";
            this.BoxEmpId.ReadOnly = true;
            this.BoxEmpId.Size = new System.Drawing.Size(187, 30);
            this.BoxEmpId.TabIndex = 4;
            // 
            // BoxLeaveReqId
            // 
            this.BoxLeaveReqId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLeaveReqId.Location = new System.Drawing.Point(206, 21);
            this.BoxLeaveReqId.Name = "BoxLeaveReqId";
            this.BoxLeaveReqId.ReadOnly = true;
            this.BoxLeaveReqId.Size = new System.Drawing.Size(187, 30);
            this.BoxLeaveReqId.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leave Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Id:";
            // 
            // CBoxLeaveType
            // 
            this.CBoxLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxLeaveType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxLeaveType.FormattingEnabled = true;
            this.CBoxLeaveType.Items.AddRange(new object[] {
            "sick  leave",
            "casual leave"});
            this.CBoxLeaveType.Location = new System.Drawing.Point(206, 121);
            this.CBoxLeaveType.Name = "CBoxLeaveType";
            this.CBoxLeaveType.Size = new System.Drawing.Size(187, 29);
            this.CBoxLeaveType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Leave Request Id:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.BoxStatus);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(10, 465);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 69);
            this.panel6.TabIndex = 8;
            // 
            // BoxStatus
            // 
            this.BoxStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxStatus.Location = new System.Drawing.Point(206, 21);
            this.BoxStatus.Name = "BoxStatus";
            this.BoxStatus.ReadOnly = true;
            this.BoxStatus.Size = new System.Drawing.Size(187, 30);
            this.BoxStatus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearLeaveRequest);
            this.panel3.Controls.Add(this.BtnCancelLeaveRequest);
            this.panel3.Controls.Add(this.BtnApplyLeaveRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 13;
            // 
            // BtnClearLeaveRequest
            // 
            this.BtnClearLeaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearLeaveRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearLeaveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearLeaveRequest.Location = new System.Drawing.Point(273, 32);
            this.BtnClearLeaveRequest.Name = "BtnClearLeaveRequest";
            this.BtnClearLeaveRequest.Rounded = false;
            this.BtnClearLeaveRequest.Size = new System.Drawing.Size(90, 40);
            this.BtnClearLeaveRequest.TabIndex = 7;
            this.BtnClearLeaveRequest.Text = "Clear";
            this.BtnClearLeaveRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearLeaveRequest.Click += new System.EventHandler(this.BtnClearLeaveRequest_Click);
            // 
            // BtnCancelLeaveRequest
            // 
            this.BtnCancelLeaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelLeaveRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCancelLeaveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCancelLeaveRequest.Location = new System.Drawing.Point(152, 32);
            this.BtnCancelLeaveRequest.Name = "BtnCancelLeaveRequest";
            this.BtnCancelLeaveRequest.Rounded = false;
            this.BtnCancelLeaveRequest.Size = new System.Drawing.Size(90, 40);
            this.BtnCancelLeaveRequest.TabIndex = 7;
            this.BtnCancelLeaveRequest.Text = "Cancel";
            this.BtnCancelLeaveRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnCancelLeaveRequest.Click += new System.EventHandler(this.BtnCancelLeaveRequest_Click);
            // 
            // BtnApplyLeaveRequest
            // 
            this.BtnApplyLeaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnApplyLeaveRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnApplyLeaveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnApplyLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnApplyLeaveRequest.Location = new System.Drawing.Point(31, 32);
            this.BtnApplyLeaveRequest.Name = "BtnApplyLeaveRequest";
            this.BtnApplyLeaveRequest.Rounded = false;
            this.BtnApplyLeaveRequest.Size = new System.Drawing.Size(90, 40);
            this.BtnApplyLeaveRequest.TabIndex = 7;
            this.BtnApplyLeaveRequest.Text = "Apply";
            this.BtnApplyLeaveRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnApplyLeaveRequest.Click += new System.EventHandler(this.BtnApplyLeaveRequest_Click);
            // 
            // GridLeaveRequest
            // 
            this.GridLeaveRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridLeaveRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLeaveRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLeaveRequest.Location = new System.Drawing.Point(424, 66);
            this.GridLeaveRequest.Name = "GridLeaveRequest";
            this.GridLeaveRequest.Size = new System.Drawing.Size(801, 591);
            this.GridLeaveRequest.TabIndex = 14;
            this.GridLeaveRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLeaveRequest_CellClick);
            // 
            // ManageLeaveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridLeaveRequest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageLeaveRequestForm";
            this.Text = "ManageLeaveRequestForm";
            this.Load += new System.EventHandler(this.ManageLeaveRequestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLeaveRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshLeaveRequest;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchLeaveRequest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.TextBox BoxLeaveReqId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxLeaveType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox BoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearLeaveRequest;
        private ReaLTaiizor.Controls.ForeverButton BtnCancelLeaveRequest;
        private ReaLTaiizor.Controls.ForeverButton BtnApplyLeaveRequest;
        private System.Windows.Forms.DataGridView GridLeaveRequest;
        private System.Windows.Forms.TextBox BoxEmpId;
        private ReaLTaiizor.Controls.HopeRichTextBox BoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label7;
    }
}