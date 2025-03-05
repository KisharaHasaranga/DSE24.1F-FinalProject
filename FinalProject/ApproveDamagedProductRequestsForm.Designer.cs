namespace FinalProject
{
    partial class ApproveDamagedProductRequestsForm
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
            this.BoxDamagedProductRequestSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshRestockRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchRestockRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DateAdded = new System.Windows.Forms.DateTimePicker();
            this.BoxDamagedProductId = new System.Windows.Forms.TextBox();
            this.BoxDamagedProductRequestId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxStatus = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearRestockRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateRestockRequest = new ReaLTaiizor.Controls.ForeverButton();
            this.GridDamagedProductRequest = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDamagedProductRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxDamagedProductRequestSearch);
            this.panel1.Controls.Add(this.BtnRefreshRestockRequest);
            this.panel1.Controls.Add(this.BtnSearchRestockRequest);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 10;
            // 
            // BoxDamagedProductRequestSearch
            // 
            this.BoxDamagedProductRequestSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDamagedProductRequestSearch.Location = new System.Drawing.Point(472, 20);
            this.BoxDamagedProductRequestSearch.Name = "BoxDamagedProductRequestSearch";
            this.BoxDamagedProductRequestSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxDamagedProductRequestSearch.TabIndex = 4;
            // 
            // BtnRefreshRestockRequest
            // 
            this.BtnRefreshRestockRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshRestockRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshRestockRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshRestockRequest.Location = new System.Drawing.Point(797, 20);
            this.BtnRefreshRestockRequest.Name = "BtnRefreshRestockRequest";
            this.BtnRefreshRestockRequest.Rounded = false;
            this.BtnRefreshRestockRequest.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshRestockRequest.TabIndex = 7;
            this.BtnRefreshRestockRequest.Text = "Refresh";
            this.BtnRefreshRestockRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshRestockRequest.Click += new System.EventHandler(this.BtnRefreshRestockRequest_Click);
            // 
            // BtnSearchRestockRequest
            // 
            this.BtnSearchRestockRequest.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchRestockRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchRestockRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchRestockRequest.Location = new System.Drawing.Point(683, 20);
            this.BtnSearchRestockRequest.Name = "BtnSearchRestockRequest";
            this.BtnSearchRestockRequest.Rounded = false;
            this.BtnSearchRestockRequest.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchRestockRequest.TabIndex = 7;
            this.BtnSearchRestockRequest.Text = "Search";
            this.BtnSearchRestockRequest.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchRestockRequest.Click += new System.EventHandler(this.BtnSearchRestockRequest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(452, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Approve Damaged Product Requests";
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
            this.panel2.Size = new System.Drawing.Size(461, 684);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.DateAdded);
            this.panel5.Controls.Add(this.BoxDamagedProductId);
            this.panel5.Controls.Add(this.BoxDamagedProductRequestId);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(441, 158);
            this.panel5.TabIndex = 9;
            // 
            // DateAdded
            // 
            this.DateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAdded.Location = new System.Drawing.Point(206, 120);
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.Size = new System.Drawing.Size(209, 26);
            this.DateAdded.TabIndex = 8;
            // 
            // BoxDamagedProductId
            // 
            this.BoxDamagedProductId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDamagedProductId.Location = new System.Drawing.Point(206, 70);
            this.BoxDamagedProductId.Name = "BoxDamagedProductId";
            this.BoxDamagedProductId.ReadOnly = true;
            this.BoxDamagedProductId.Size = new System.Drawing.Size(209, 30);
            this.BoxDamagedProductId.TabIndex = 4;
            // 
            // BoxDamagedProductRequestId
            // 
            this.BoxDamagedProductRequestId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDamagedProductRequestId.Location = new System.Drawing.Point(206, 21);
            this.BoxDamagedProductRequestId.Name = "BoxDamagedProductRequestId";
            this.BoxDamagedProductRequestId.ReadOnly = true;
            this.BoxDamagedProductRequestId.Size = new System.Drawing.Size(209, 30);
            this.BoxDamagedProductRequestId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Damaged Product Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Damage Request Id:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.CBoxStatus);
            this.panel6.Location = new System.Drawing.Point(10, 179);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(441, 69);
            this.panel6.TabIndex = 8;
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
            // CBoxStatus
            // 
            this.CBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxStatus.FormattingEnabled = true;
            this.CBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Denied"});
            this.CBoxStatus.Location = new System.Drawing.Point(206, 22);
            this.CBoxStatus.Name = "CBoxStatus";
            this.CBoxStatus.Size = new System.Drawing.Size(209, 29);
            this.CBoxStatus.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearRestockRequest);
            this.panel3.Controls.Add(this.BtnUpdateRestockRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(461, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 93);
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
            // GridDamagedProductRequest
            // 
            this.GridDamagedProductRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridDamagedProductRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDamagedProductRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDamagedProductRequest.Location = new System.Drawing.Point(461, 66);
            this.GridDamagedProductRequest.Name = "GridDamagedProductRequest";
            this.GridDamagedProductRequest.Size = new System.Drawing.Size(764, 591);
            this.GridDamagedProductRequest.TabIndex = 15;
            this.GridDamagedProductRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDamagedProductRequest_CellClick);
            // 
            // ApproveDamagedProductRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridDamagedProductRequest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApproveDamagedProductRequestsForm";
            this.Text = "ApproveDamagedProductRequestsForm";
            this.Load += new System.EventHandler(this.ApproveDamagedProductRequestsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDamagedProductRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxDamagedProductRequestSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshRestockRequest;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchRestockRequest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker DateAdded;
        private System.Windows.Forms.TextBox BoxDamagedProductId;
        private System.Windows.Forms.TextBox BoxDamagedProductRequestId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxStatus;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearRestockRequest;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateRestockRequest;
        private System.Windows.Forms.DataGridView GridDamagedProductRequest;
    }
}