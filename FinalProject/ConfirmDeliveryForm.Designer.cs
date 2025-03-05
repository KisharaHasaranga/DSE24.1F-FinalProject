namespace FinalProject
{
    partial class ConfirmDeliveryForm
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
            this.BtnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearch = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnConfirmDelivery = new ReaLTaiizor.Controls.ForeverButton();
            this.GridDelivery = new System.Windows.Forms.DataGridView();
            this.CBoxDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxDeliveryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxDriverId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxVehicleNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxSearch);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 1;
            // 
            // BoxSearch
            // 
            this.BoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearch.Location = new System.Drawing.Point(427, 24);
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxSearch.TabIndex = 4;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefresh.Location = new System.Drawing.Point(757, 24);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Rounded = false;
            this.BtnRefresh.Size = new System.Drawing.Size(90, 30);
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearch.Location = new System.Drawing.Point(652, 24);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rounded = false;
            this.BtnSearch.Size = new System.Drawing.Size(90, 30);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Confirm Delivery";
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
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.BoxVehicleNo);
            this.panel5.Controls.Add(this.BoxDriverId);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.BoxOrderId);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.BoxDeliveryId);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 206);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.CBoxDeliveryStatus);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(10, 222);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 69);
            this.panel6.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearDelivery);
            this.panel3.Controls.Add(this.BtnConfirmDelivery);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 17;
            // 
            // BtnClearDelivery
            // 
            this.BtnClearDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearDelivery.Location = new System.Drawing.Point(135, 32);
            this.BtnClearDelivery.Name = "BtnClearDelivery";
            this.BtnClearDelivery.Rounded = false;
            this.BtnClearDelivery.Size = new System.Drawing.Size(90, 40);
            this.BtnClearDelivery.TabIndex = 7;
            this.BtnClearDelivery.Text = "Clear";
            this.BtnClearDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearDelivery.Click += new System.EventHandler(this.BtnClearDelivery_Click);
            // 
            // BtnConfirmDelivery
            // 
            this.BtnConfirmDelivery.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnConfirmDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmDelivery.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnConfirmDelivery.Location = new System.Drawing.Point(25, 32);
            this.BtnConfirmDelivery.Name = "BtnConfirmDelivery";
            this.BtnConfirmDelivery.Rounded = false;
            this.BtnConfirmDelivery.Size = new System.Drawing.Size(90, 40);
            this.BtnConfirmDelivery.TabIndex = 7;
            this.BtnConfirmDelivery.Text = "Confirm";
            this.BtnConfirmDelivery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnConfirmDelivery.Click += new System.EventHandler(this.BtnConfirmDelivery_Click);
            // 
            // GridDelivery
            // 
            this.GridDelivery.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDelivery.Location = new System.Drawing.Point(424, 66);
            this.GridDelivery.Name = "GridDelivery";
            this.GridDelivery.Size = new System.Drawing.Size(801, 591);
            this.GridDelivery.TabIndex = 18;
            this.GridDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDelivery_CellClick);
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
            this.CBoxDeliveryStatus.Location = new System.Drawing.Point(206, 23);
            this.CBoxDeliveryStatus.Name = "CBoxDeliveryStatus";
            this.CBoxDeliveryStatus.Size = new System.Drawing.Size(187, 29);
            this.CBoxDeliveryStatus.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delivery Status:";
            // 
            // BoxDeliveryId
            // 
            this.BoxDeliveryId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDeliveryId.Location = new System.Drawing.Point(206, 21);
            this.BoxDeliveryId.Name = "BoxDeliveryId";
            this.BoxDeliveryId.ReadOnly = true;
            this.BoxDeliveryId.Size = new System.Drawing.Size(187, 30);
            this.BoxDeliveryId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delivery Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order Id:";
            // 
            // BoxOrderId
            // 
            this.BoxOrderId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOrderId.Location = new System.Drawing.Point(206, 69);
            this.BoxOrderId.Name = "BoxOrderId";
            this.BoxOrderId.ReadOnly = true;
            this.BoxOrderId.Size = new System.Drawing.Size(187, 30);
            this.BoxOrderId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Driver Id:";
            // 
            // BoxDriverId
            // 
            this.BoxDriverId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDriverId.Location = new System.Drawing.Point(206, 114);
            this.BoxDriverId.Name = "BoxDriverId";
            this.BoxDriverId.ReadOnly = true;
            this.BoxDriverId.Size = new System.Drawing.Size(187, 30);
            this.BoxDriverId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehicle No:";
            // 
            // BoxVehicleNo
            // 
            this.BoxVehicleNo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxVehicleNo.Location = new System.Drawing.Point(206, 161);
            this.BoxVehicleNo.Name = "BoxVehicleNo";
            this.BoxVehicleNo.ReadOnly = true;
            this.BoxVehicleNo.Size = new System.Drawing.Size(187, 30);
            this.BoxVehicleNo.TabIndex = 10;
            // 
            // ConfirmDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridDelivery);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmDeliveryForm";
            this.Text = "ConfirmDeliveryForm";
            this.Load += new System.EventHandler(this.ConfirmDeliveryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefresh;
        private ReaLTaiizor.Controls.ForeverButton BtnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearDelivery;
        private ReaLTaiizor.Controls.ForeverButton BtnConfirmDelivery;
        private System.Windows.Forms.DataGridView GridDelivery;
        private System.Windows.Forms.ComboBox CBoxDeliveryStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxDeliveryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxDriverId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxVehicleNo;
    }
}