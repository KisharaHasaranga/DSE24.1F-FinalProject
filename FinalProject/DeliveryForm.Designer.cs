namespace FinalProject
{
    partial class DeliveryForm
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
            this.BoxDeliverySearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxDriverName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxDeliveryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateDelivery = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxVehicleNo = new System.Windows.Forms.ComboBox();
            this.CBoxDriverId = new System.Windows.Forms.ComboBox();
            this.CBoxOrderId = new System.Windows.Forms.ComboBox();
            this.CBoxDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.GridDelivery = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxRetailerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BoxRetailerAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxDeliverySearch);
            this.panel1.Controls.Add(this.BtnRefreshDelivery);
            this.panel1.Controls.Add(this.BtnSearchDelivery);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 6;
            // 
            // BoxDeliverySearch
            // 
            this.BoxDeliverySearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDeliverySearch.Location = new System.Drawing.Point(427, 24);
            this.BoxDeliverySearch.Name = "BoxDeliverySearch";
            this.BoxDeliverySearch.Size = new System.Drawing.Size(187, 30);
            this.BoxDeliverySearch.TabIndex = 4;
            // 
            // BtnRefreshDelivery
            // 
            this.BtnRefreshDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshDelivery.Location = new System.Drawing.Point(757, 24);
            this.BtnRefreshDelivery.Name = "BtnRefreshDelivery";
            this.BtnRefreshDelivery.Rounded = false;
            this.BtnRefreshDelivery.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshDelivery.TabIndex = 7;
            this.BtnRefreshDelivery.Text = "Refresh";
            this.BtnRefreshDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshDelivery.Click += new System.EventHandler(this.BtnRefreshDelivery_Click);
            // 
            // BtnSearchDelivery
            // 
            this.BtnSearchDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchDelivery.Location = new System.Drawing.Point(652, 24);
            this.BtnSearchDelivery.Name = "BtnSearchDelivery";
            this.BtnSearchDelivery.Rounded = false;
            this.BtnSearchDelivery.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchDelivery.TabIndex = 7;
            this.BtnSearchDelivery.Text = "Search";
            this.BtnSearchDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchDelivery.Click += new System.EventHandler(this.BtnSearchDelivery_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Delivery";
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
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.BoxRetailerAddress);
            this.panel5.Controls.Add(this.BoxRetailerName);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.BoxDriverName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.BoxDeliveryId);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.DateDelivery);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.CBoxVehicleNo);
            this.panel5.Controls.Add(this.CBoxDriverId);
            this.panel5.Controls.Add(this.CBoxOrderId);
            this.panel5.Controls.Add(this.CBoxDeliveryStatus);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 483);
            this.panel5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vehicle No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Driver Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Id:";
            // 
            // BoxDriverName
            // 
            this.BoxDriverName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDriverName.Location = new System.Drawing.Point(206, 341);
            this.BoxDriverName.Name = "BoxDriverName";
            this.BoxDriverName.ReadOnly = true;
            this.BoxDriverName.Size = new System.Drawing.Size(187, 30);
            this.BoxDriverName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Driver Name:";
            // 
            // BoxDeliveryId
            // 
            this.BoxDeliveryId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDeliveryId.Location = new System.Drawing.Point(206, 18);
            this.BoxDeliveryId.Name = "BoxDeliveryId";
            this.BoxDeliveryId.ReadOnly = true;
            this.BoxDeliveryId.Size = new System.Drawing.Size(187, 30);
            this.BoxDeliveryId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery Id:";
            // 
            // DateDelivery
            // 
            this.DateDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDelivery.Location = new System.Drawing.Point(206, 440);
            this.DateDelivery.Name = "DateDelivery";
            this.DateDelivery.Size = new System.Drawing.Size(187, 26);
            this.DateDelivery.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delivery Date:";
            // 
            // CBoxVehicleNo
            // 
            this.CBoxVehicleNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxVehicleNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVehicleNo.FormattingEnabled = true;
            this.CBoxVehicleNo.Items.AddRange(new object[] {
            "Lorry",
            "Van"});
            this.CBoxVehicleNo.Location = new System.Drawing.Point(206, 388);
            this.CBoxVehicleNo.Name = "CBoxVehicleNo";
            this.CBoxVehicleNo.Size = new System.Drawing.Size(187, 29);
            this.CBoxVehicleNo.TabIndex = 7;
            this.CBoxVehicleNo.SelectedIndexChanged += new System.EventHandler(this.CBoxVehicleNo_SelectedIndexChanged);
            // 
            // CBoxDriverId
            // 
            this.CBoxDriverId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxDriverId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxDriverId.FormattingEnabled = true;
            this.CBoxDriverId.Location = new System.Drawing.Point(206, 294);
            this.CBoxDriverId.Name = "CBoxDriverId";
            this.CBoxDriverId.Size = new System.Drawing.Size(187, 29);
            this.CBoxDriverId.TabIndex = 7;
            this.CBoxDriverId.SelectedIndexChanged += new System.EventHandler(this.CBoxDriverId_SelectedIndexChanged);
            // 
            // CBoxOrderId
            // 
            this.CBoxOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxOrderId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxOrderId.FormattingEnabled = true;
            this.CBoxOrderId.Location = new System.Drawing.Point(206, 117);
            this.CBoxOrderId.Name = "CBoxOrderId";
            this.CBoxOrderId.Size = new System.Drawing.Size(187, 29);
            this.CBoxOrderId.TabIndex = 7;
            this.CBoxOrderId.SelectedIndexChanged += new System.EventHandler(this.CBoxOrderId_SelectedIndexChanged);
            // 
            // CBoxDeliveryStatus
            // 
            this.CBoxDeliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxDeliveryStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxDeliveryStatus.FormattingEnabled = true;
            this.CBoxDeliveryStatus.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Canceled"});
            this.CBoxDeliveryStatus.Location = new System.Drawing.Point(206, 68);
            this.CBoxDeliveryStatus.Name = "CBoxDeliveryStatus";
            this.CBoxDeliveryStatus.Size = new System.Drawing.Size(187, 29);
            this.CBoxDeliveryStatus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Delivery Status:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearDelivery);
            this.panel3.Controls.Add(this.BtnDeleteDelivery);
            this.panel3.Controls.Add(this.BtnUpdateDelivery);
            this.panel3.Controls.Add(this.BtnInsertDelivery);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 14;
            // 
            // BtnClearDelivery
            // 
            this.BtnClearDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearDelivery.Location = new System.Drawing.Point(386, 32);
            this.BtnClearDelivery.Name = "BtnClearDelivery";
            this.BtnClearDelivery.Rounded = false;
            this.BtnClearDelivery.Size = new System.Drawing.Size(90, 40);
            this.BtnClearDelivery.TabIndex = 7;
            this.BtnClearDelivery.Text = "Clear";
            this.BtnClearDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearDelivery.Click += new System.EventHandler(this.BtnClearDelivery_Click);
            // 
            // BtnDeleteDelivery
            // 
            this.BtnDeleteDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteDelivery.Location = new System.Drawing.Point(263, 32);
            this.BtnDeleteDelivery.Name = "BtnDeleteDelivery";
            this.BtnDeleteDelivery.Rounded = false;
            this.BtnDeleteDelivery.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteDelivery.TabIndex = 7;
            this.BtnDeleteDelivery.Text = "Delete";
            this.BtnDeleteDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteDelivery.Click += new System.EventHandler(this.BtnDeleteDelivery_Click);
            // 
            // BtnUpdateDelivery
            // 
            this.BtnUpdateDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateDelivery.Location = new System.Drawing.Point(145, 32);
            this.BtnUpdateDelivery.Name = "BtnUpdateDelivery";
            this.BtnUpdateDelivery.Rounded = false;
            this.BtnUpdateDelivery.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateDelivery.TabIndex = 7;
            this.BtnUpdateDelivery.Text = "Update";
            this.BtnUpdateDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateDelivery.Click += new System.EventHandler(this.BtnUpdateDelivery_Click);
            // 
            // BtnInsertDelivery
            // 
            this.BtnInsertDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertDelivery.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertDelivery.Name = "BtnInsertDelivery";
            this.BtnInsertDelivery.Rounded = false;
            this.BtnInsertDelivery.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertDelivery.TabIndex = 7;
            this.BtnInsertDelivery.Text = "Insert";
            this.BtnInsertDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertDelivery.Click += new System.EventHandler(this.BtnInsertDelivery_Click);
            // 
            // GridDelivery
            // 
            this.GridDelivery.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDelivery.Location = new System.Drawing.Point(424, 66);
            this.GridDelivery.Name = "GridDelivery";
            this.GridDelivery.ReadOnly = true;
            this.GridDelivery.Size = new System.Drawing.Size(801, 591);
            this.GridDelivery.TabIndex = 15;
            this.GridDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDelivery_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Retailer Name:";
            // 
            // BoxRetailerName
            // 
            this.BoxRetailerName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRetailerName.Location = new System.Drawing.Point(206, 165);
            this.BoxRetailerName.Name = "BoxRetailerName";
            this.BoxRetailerName.ReadOnly = true;
            this.BoxRetailerName.Size = new System.Drawing.Size(187, 30);
            this.BoxRetailerName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Retailer Address:";
            // 
            // BoxRetailerAddress
            // 
            this.BoxRetailerAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRetailerAddress.Location = new System.Drawing.Point(11, 244);
            this.BoxRetailerAddress.Name = "BoxRetailerAddress";
            this.BoxRetailerAddress.ReadOnly = true;
            this.BoxRetailerAddress.Size = new System.Drawing.Size(382, 30);
            this.BoxRetailerAddress.TabIndex = 4;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridDelivery);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxDeliverySearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshDelivery;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchDelivery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox BoxDeliveryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateDelivery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxDeliveryStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearDelivery;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteDelivery;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateDelivery;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertDelivery;
        private System.Windows.Forms.DataGridView GridDelivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxVehicleNo;
        private System.Windows.Forms.ComboBox CBoxDriverId;
        private System.Windows.Forms.ComboBox CBoxOrderId;
        private System.Windows.Forms.TextBox BoxDriverName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxRetailerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BoxRetailerAddress;
        private System.Windows.Forms.Label label10;
    }
}