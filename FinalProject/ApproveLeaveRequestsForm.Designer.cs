namespace FinalProject
{
    partial class ApproveLeaveRequestsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.BoxLeaveReqId = new System.Windows.Forms.TextBox();
            this.CBoxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearRestockRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateRestockRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.GridLeaveRequest = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel1.TabIndex = 10;
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
            this.label8.Size = new System.Drawing.Size(305, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Approve Leave Requests";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.BoxLeaveReqId);
            this.panel5.Controls.Add(this.CBoxStatus);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 136);
            this.panel5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // BoxLeaveReqId
            // 
            this.BoxLeaveReqId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLeaveReqId.Location = new System.Drawing.Point(206, 25);
            this.BoxLeaveReqId.Name = "BoxLeaveReqId";
            this.BoxLeaveReqId.ReadOnly = true;
            this.BoxLeaveReqId.Size = new System.Drawing.Size(187, 30);
            this.BoxLeaveReqId.TabIndex = 4;
            // 
            // CBoxStatus
            // 
            this.CBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxStatus.FormattingEnabled = true;
            this.CBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Denied",
            "Cancelled"});
            this.CBoxStatus.Location = new System.Drawing.Point(206, 82);
            this.CBoxStatus.Name = "CBoxStatus";
            this.CBoxStatus.Size = new System.Drawing.Size(187, 29);
            this.CBoxStatus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Leave Request Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearRestockRequest);
            this.panel3.Controls.Add(this.BtnUpdateRestockRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 14;
            // 
            // BtnClearRestockRequest
            // 
            this.BtnClearRestockRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearRestockRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearRestockRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearRestockRequest.Location = new System.Drawing.Point(152, 32);
            this.BtnClearRestockRequest.Name = "BtnClearRestockRequest";
            this.BtnClearRestockRequest.Rounded = false;
            this.BtnClearRestockRequest.Size = new System.Drawing.Size(90, 40);
            this.BtnClearRestockRequest.TabIndex = 7;
            this.BtnClearRestockRequest.Text = "Clear";
            this.BtnClearRestockRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearRestockRequest.Click += new System.EventHandler(this.BtnClearRestockRequest_Click);
            // 
            // BtnUpdateRestockRequest
            // 
            this.BtnUpdateRestockRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateRestockRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateRestockRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateRestockRequest.Location = new System.Drawing.Point(31, 32);
            this.BtnUpdateRestockRequest.Name = "BtnUpdateRestockRequest";
            this.BtnUpdateRestockRequest.Rounded = false;
            this.BtnUpdateRestockRequest.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateRestockRequest.TabIndex = 7;
            this.BtnUpdateRestockRequest.Text = "Update";
            this.BtnUpdateRestockRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateRestockRequest.Click += new System.EventHandler(this.BtnUpdateRestockRequest_Click);
            // 
            // GridLeaveRequest
            // 
            this.GridLeaveRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridLeaveRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridLeaveRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLeaveRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLeaveRequest.Location = new System.Drawing.Point(424, 66);
            this.GridLeaveRequest.Name = "GridLeaveRequest";
            this.GridLeaveRequest.Size = new System.Drawing.Size(801, 591);
            this.GridLeaveRequest.TabIndex = 15;
            this.GridLeaveRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRestockRequest_CellClick);
            // 
            // ApproveLeaveRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridLeaveRequest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApproveLeaveRequestsForm";
            this.Text = "ApproveLeaveRequestsForm";
            this.Load += new System.EventHandler(this.ApproveLeaveRequestsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxLeaveReqId;
        private System.Windows.Forms.ComboBox CBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearRestockRequest;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateRestockRequest;
        private System.Windows.Forms.DataGridView GridLeaveRequest;
    }
}