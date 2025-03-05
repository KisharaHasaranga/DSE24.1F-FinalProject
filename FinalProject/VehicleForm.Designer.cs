namespace FinalProject
{
    partial class VehicleForm
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
            this.BtnRefreshVehicle = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchVehicle = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.BoxVehicelNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearVehicle = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteVehicle = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateVehicle = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertVehicle = new ReaLTaiizor.Controls.ForeverButton();
            this.GridVehicle = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxSearch);
            this.panel1.Controls.Add(this.BtnRefreshVehicle);
            this.panel1.Controls.Add(this.BtnSearchVehicle);
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
            // BtnRefreshVehicle
            // 
            this.BtnRefreshVehicle.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshVehicle.Location = new System.Drawing.Point(761, 21);
            this.BtnRefreshVehicle.Name = "BtnRefreshVehicle";
            this.BtnRefreshVehicle.Rounded = false;
            this.BtnRefreshVehicle.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshVehicle.TabIndex = 7;
            this.BtnRefreshVehicle.Text = "Refresh";
            this.BtnRefreshVehicle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshVehicle.Click += new System.EventHandler(this.BtnRefreshVehicle_Click);
            // 
            // BtnSearchVehicle
            // 
            this.BtnSearchVehicle.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchVehicle.Location = new System.Drawing.Point(656, 21);
            this.BtnSearchVehicle.Name = "BtnSearchVehicle";
            this.BtnSearchVehicle.Rounded = false;
            this.BtnSearchVehicle.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchVehicle.TabIndex = 7;
            this.BtnSearchVehicle.Text = "Search";
            this.BtnSearchVehicle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchVehicle.Click += new System.EventHandler(this.BtnSearchVehicle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Vehicles";
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
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.PurchaseDate);
            this.panel5.Controls.Add(this.BoxVehicelNum);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.CBoxVehicleType);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 166);
            this.panel5.TabIndex = 9;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PurchaseDate.Location = new System.Drawing.Point(206, 121);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(187, 26);
            this.PurchaseDate.TabIndex = 8;
            // 
            // BoxVehicelNum
            // 
            this.BoxVehicelNum.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxVehicelNum.Location = new System.Drawing.Point(206, 21);
            this.BoxVehicelNum.Name = "BoxVehicelNum";
            this.BoxVehicelNum.Size = new System.Drawing.Size(187, 30);
            this.BoxVehicelNum.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Purchase Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle Type:";
            // 
            // CBoxVehicleType
            // 
            this.CBoxVehicleType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVehicleType.FormattingEnabled = true;
            this.CBoxVehicleType.Items.AddRange(new object[] {
            "Lorry",
            "Van"});
            this.CBoxVehicleType.Location = new System.Drawing.Point(206, 71);
            this.CBoxVehicleType.Name = "CBoxVehicleType";
            this.CBoxVehicleType.Size = new System.Drawing.Size(187, 29);
            this.CBoxVehicleType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vehicle Number:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.BoxStatus);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(10, 184);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehicle Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearVehicle);
            this.panel3.Controls.Add(this.BtnDeleteVehicle);
            this.panel3.Controls.Add(this.BtnUpdateVehicle);
            this.panel3.Controls.Add(this.BtnInsertVehicle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 16;
            // 
            // BtnClearVehicle
            // 
            this.BtnClearVehicle.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearVehicle.Location = new System.Drawing.Point(386, 32);
            this.BtnClearVehicle.Name = "BtnClearVehicle";
            this.BtnClearVehicle.Rounded = false;
            this.BtnClearVehicle.Size = new System.Drawing.Size(90, 40);
            this.BtnClearVehicle.TabIndex = 7;
            this.BtnClearVehicle.Text = "Clear";
            this.BtnClearVehicle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearVehicle.Click += new System.EventHandler(this.BtnClearVehicle_Click);
            // 
            // BtnDeleteVehicle
            // 
            this.BtnDeleteVehicle.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteVehicle.Location = new System.Drawing.Point(263, 32);
            this.BtnDeleteVehicle.Name = "BtnDeleteVehicle";
            this.BtnDeleteVehicle.Rounded = false;
            this.BtnDeleteVehicle.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteVehicle.TabIndex = 7;
            this.BtnDeleteVehicle.Text = "Delete";
            this.BtnDeleteVehicle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteVehicle.Click += new System.EventHandler(this.BtnDeleteVehicle_Click);
            // 
            // BtnUpdateVehicle
            // 
            this.BtnUpdateVehicle.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateVehicle.Location = new System.Drawing.Point(145, 32);
            this.BtnUpdateVehicle.Name = "BtnUpdateVehicle";
            this.BtnUpdateVehicle.Rounded = false;
            this.BtnUpdateVehicle.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateVehicle.TabIndex = 7;
            this.BtnUpdateVehicle.Text = "Update";
            this.BtnUpdateVehicle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateVehicle.Click += new System.EventHandler(this.BtnUpdateVehicle_Click);
            // 
            // BtnInsertVehicle
            // 
            this.BtnInsertVehicle.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertVehicle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertVehicle.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertVehicle.Name = "BtnInsertVehicle";
            this.BtnInsertVehicle.Rounded = false;
            this.BtnInsertVehicle.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertVehicle.TabIndex = 7;
            this.BtnInsertVehicle.Text = "Insert";
            this.BtnInsertVehicle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertVehicle.Click += new System.EventHandler(this.BtnInsertVehicle_Click);
            // 
            // GridVehicle
            // 
            this.GridVehicle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridVehicle.Location = new System.Drawing.Point(424, 66);
            this.GridVehicle.Name = "GridVehicle";
            this.GridVehicle.Size = new System.Drawing.Size(801, 591);
            this.GridVehicle.TabIndex = 17;
            this.GridVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVehicle_CellClick);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridVehicle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshVehicle;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchVehicle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker PurchaseDate;
        private System.Windows.Forms.TextBox BoxVehicelNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxVehicleType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox BoxStatus;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearVehicle;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteVehicle;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateVehicle;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertVehicle;
        private System.Windows.Forms.DataGridView GridVehicle;
    }
}