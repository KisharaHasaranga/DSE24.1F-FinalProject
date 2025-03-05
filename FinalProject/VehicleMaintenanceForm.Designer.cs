namespace FinalProject
{
    partial class VehicleMaintenanceForm
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
            this.BtnRefreshVehicleM = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchVehicleM = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxVehicleNum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearVehicleM = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteVehicleM = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnScheduleVehicleM = new ReaLTaiizor.Controls.ForeverButton();
            this.GridVehicleM = new System.Windows.Forms.DataGridView();
            this.BoxDescription = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxMaintenanceId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVehicleM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxSearch);
            this.panel1.Controls.Add(this.BtnRefreshVehicleM);
            this.panel1.Controls.Add(this.BtnSearchVehicleM);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 11;
            // 
            // BoxSearch
            // 
            this.BoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearch.Location = new System.Drawing.Point(431, 21);
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxSearch.TabIndex = 4;
            // 
            // BtnRefreshVehicleM
            // 
            this.BtnRefreshVehicleM.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshVehicleM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshVehicleM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshVehicleM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshVehicleM.Location = new System.Drawing.Point(760, 21);
            this.BtnRefreshVehicleM.Name = "BtnRefreshVehicleM";
            this.BtnRefreshVehicleM.Rounded = false;
            this.BtnRefreshVehicleM.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshVehicleM.TabIndex = 7;
            this.BtnRefreshVehicleM.Text = "Refresh";
            this.BtnRefreshVehicleM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshVehicleM.Click += new System.EventHandler(this.BtnRefreshVehicleM_Click);
            // 
            // BtnSearchVehicleM
            // 
            this.BtnSearchVehicleM.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchVehicleM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchVehicleM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchVehicleM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchVehicleM.Location = new System.Drawing.Point(644, 21);
            this.BtnSearchVehicleM.Name = "BtnSearchVehicleM";
            this.BtnSearchVehicleM.Rounded = false;
            this.BtnSearchVehicleM.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchVehicleM.TabIndex = 7;
            this.BtnSearchVehicleM.Text = "Search";
            this.BtnSearchVehicleM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchVehicleM.Click += new System.EventHandler(this.BtnSearchVehicleM_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Vehicle Maintenance";
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
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.BoxMaintenanceId);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.BoxDescription);
            this.panel5.Controls.Add(this.ServiceDate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.CBoxVehicleNum);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 314);
            this.panel5.TabIndex = 9;
            // 
            // ServiceDate
            // 
            this.ServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ServiceDate.Location = new System.Drawing.Point(206, 272);
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.Size = new System.Drawing.Size(187, 26);
            this.ServiceDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Scheduled Date:";
            // 
            // CBoxVehicleNum
            // 
            this.CBoxVehicleNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxVehicleNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVehicleNum.FormattingEnabled = true;
            this.CBoxVehicleNum.Items.AddRange(new object[] {
            "Lorry",
            "Van"});
            this.CBoxVehicleNum.Location = new System.Drawing.Point(206, 68);
            this.CBoxVehicleNum.Name = "CBoxVehicleNum";
            this.CBoxVehicleNum.Size = new System.Drawing.Size(187, 29);
            this.CBoxVehicleNum.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vehicle Number:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearVehicleM);
            this.panel3.Controls.Add(this.BtnDeleteVehicleM);
            this.panel3.Controls.Add(this.BtnScheduleVehicleM);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 17;
            // 
            // BtnClearVehicleM
            // 
            this.BtnClearVehicleM.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearVehicleM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearVehicleM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearVehicleM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearVehicleM.Location = new System.Drawing.Point(259, 32);
            this.BtnClearVehicleM.Name = "BtnClearVehicleM";
            this.BtnClearVehicleM.Rounded = false;
            this.BtnClearVehicleM.Size = new System.Drawing.Size(90, 40);
            this.BtnClearVehicleM.TabIndex = 7;
            this.BtnClearVehicleM.Text = "Clear";
            this.BtnClearVehicleM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearVehicleM.Click += new System.EventHandler(this.BtnClearVehicleM_Click);
            // 
            // BtnDeleteVehicleM
            // 
            this.BtnDeleteVehicleM.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteVehicleM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteVehicleM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteVehicleM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteVehicleM.Location = new System.Drawing.Point(145, 32);
            this.BtnDeleteVehicleM.Name = "BtnDeleteVehicleM";
            this.BtnDeleteVehicleM.Rounded = false;
            this.BtnDeleteVehicleM.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteVehicleM.TabIndex = 7;
            this.BtnDeleteVehicleM.Text = "Delete";
            this.BtnDeleteVehicleM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteVehicleM.Click += new System.EventHandler(this.BtnDeleteVehicleM_Click);
            // 
            // BtnScheduleVehicleM
            // 
            this.BtnScheduleVehicleM.BackColor = System.Drawing.Color.Transparent;
            this.BtnScheduleVehicleM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnScheduleVehicleM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnScheduleVehicleM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnScheduleVehicleM.Location = new System.Drawing.Point(31, 32);
            this.BtnScheduleVehicleM.Name = "BtnScheduleVehicleM";
            this.BtnScheduleVehicleM.Rounded = false;
            this.BtnScheduleVehicleM.Size = new System.Drawing.Size(90, 40);
            this.BtnScheduleVehicleM.TabIndex = 7;
            this.BtnScheduleVehicleM.Text = "Schedule";
            this.BtnScheduleVehicleM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnScheduleVehicleM.Click += new System.EventHandler(this.BtnScheduleVehicleM_Click);
            // 
            // GridVehicleM
            // 
            this.GridVehicleM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridVehicleM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVehicleM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridVehicleM.Location = new System.Drawing.Point(424, 66);
            this.GridVehicleM.Name = "GridVehicleM";
            this.GridVehicleM.Size = new System.Drawing.Size(801, 591);
            this.GridVehicleM.TabIndex = 18;
            this.GridVehicleM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVehicleM_CellClick);
            // 
            // BoxDescription
            // 
            this.BoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.BoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BoxDescription.Hint = "";
            this.BoxDescription.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.BoxDescription.Location = new System.Drawing.Point(12, 146);
            this.BoxDescription.MaxLength = 32767;
            this.BoxDescription.Multiline = true;
            this.BoxDescription.Name = "BoxDescription";
            this.BoxDescription.PasswordChar = '\0';
            this.BoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxDescription.SelectedText = "";
            this.BoxDescription.SelectionLength = 0;
            this.BoxDescription.SelectionStart = 0;
            this.BoxDescription.Size = new System.Drawing.Size(380, 112);
            this.BoxDescription.TabIndex = 10;
            this.BoxDescription.TabStop = false;
            this.BoxDescription.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maintenance Id:";
            // 
            // BoxMaintenanceId
            // 
            this.BoxMaintenanceId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxMaintenanceId.Location = new System.Drawing.Point(206, 18);
            this.BoxMaintenanceId.Name = "BoxMaintenanceId";
            this.BoxMaintenanceId.ReadOnly = true;
            this.BoxMaintenanceId.Size = new System.Drawing.Size(187, 30);
            this.BoxMaintenanceId.TabIndex = 4;
            // 
            // VehicleMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridVehicleM);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleMaintenanceForm";
            this.Text = "VehicleMaintenanceForm";
            this.Load += new System.EventHandler(this.VehicleMaintenanceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVehicleM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshVehicleM;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchVehicleM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker ServiceDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxVehicleNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearVehicleM;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteVehicleM;
        private ReaLTaiizor.Controls.ForeverButton BtnScheduleVehicleM;
        private System.Windows.Forms.DataGridView GridVehicleM;
        private ReaLTaiizor.Controls.HopeRichTextBox BoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxMaintenanceId;
        private System.Windows.Forms.Label label2;
    }
}