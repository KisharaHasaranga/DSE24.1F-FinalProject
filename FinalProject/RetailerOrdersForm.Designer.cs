namespace FinalProject
{
    partial class RetailerOrdersForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridProduct = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BoxOrderId = new System.Windows.Forms.TextBox();
            this.NumericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.LabelRetailerName = new System.Windows.Forms.Label();
            this.LabelProductPrice = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxRetailerId = new System.Windows.Forms.ComboBox();
            this.CBoxProductId = new System.Windows.Forms.ComboBox();
            this.BtnReomveOrder = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnAddOrder = new ReaLTaiizor.Controls.ForeverButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridRetailerOrder = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnPrintInvoice = new ReaLTaiizor.Controls.ForeverButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQty)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRetailerOrder)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.GridProduct);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(747, 750);
            this.panel2.TabIndex = 2;
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProduct.Location = new System.Drawing.Point(10, 38);
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.ReadOnly = true;
            this.GridProduct.Size = new System.Drawing.Size(727, 426);
            this.GridProduct.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.BoxOrderId);
            this.panel5.Controls.Add(this.NumericUpDownQty);
            this.panel5.Controls.Add(this.LabelRetailerName);
            this.panel5.Controls.Add(this.LabelProductPrice);
            this.panel5.Controls.Add(this.LabelProductName);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.CBoxRetailerId);
            this.panel5.Controls.Add(this.CBoxProductId);
            this.panel5.Controls.Add(this.BtnReomveOrder);
            this.panel5.Controls.Add(this.BtnAddOrder);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 464);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(727, 276);
            this.panel5.TabIndex = 12;
            // 
            // BoxOrderId
            // 
            this.BoxOrderId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOrderId.Location = new System.Drawing.Point(191, 22);
            this.BoxOrderId.Name = "BoxOrderId";
            this.BoxOrderId.ReadOnly = true;
            this.BoxOrderId.Size = new System.Drawing.Size(181, 30);
            this.BoxOrderId.TabIndex = 15;
            // 
            // NumericUpDownQty
            // 
            this.NumericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownQty.Location = new System.Drawing.Point(191, 199);
            this.NumericUpDownQty.Name = "NumericUpDownQty";
            this.NumericUpDownQty.Size = new System.Drawing.Size(181, 26);
            this.NumericUpDownQty.TabIndex = 14;
            // 
            // LabelRetailerName
            // 
            this.LabelRetailerName.AutoSize = true;
            this.LabelRetailerName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRetailerName.Location = new System.Drawing.Point(573, 71);
            this.LabelRetailerName.Name = "LabelRetailerName";
            this.LabelRetailerName.Size = new System.Drawing.Size(57, 23);
            this.LabelRetailerName.TabIndex = 12;
            this.LabelRetailerName.Text = "name";
            // 
            // LabelProductPrice
            // 
            this.LabelProductPrice.AutoSize = true;
            this.LabelProductPrice.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductPrice.Location = new System.Drawing.Point(573, 166);
            this.LabelProductPrice.Name = "LabelProductPrice";
            this.LabelProductPrice.Size = new System.Drawing.Size(59, 23);
            this.LabelProductPrice.TabIndex = 12;
            this.LabelProductPrice.Text = "00.00";
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductName.Location = new System.Drawing.Point(573, 119);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(57, 23);
            this.LabelProductName.TabIndex = 12;
            this.LabelProductName.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Retailer Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Product Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Qty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Order Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Retailer Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Id:";
            // 
            // CBoxRetailerId
            // 
            this.CBoxRetailerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxRetailerId.FormattingEnabled = true;
            this.CBoxRetailerId.Location = new System.Drawing.Point(191, 69);
            this.CBoxRetailerId.Name = "CBoxRetailerId";
            this.CBoxRetailerId.Size = new System.Drawing.Size(181, 29);
            this.CBoxRetailerId.TabIndex = 13;
            this.CBoxRetailerId.SelectedIndexChanged += new System.EventHandler(this.CBoxRetailerId_SelectedIndexChanged);
            // 
            // CBoxProductId
            // 
            this.CBoxProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxProductId.FormattingEnabled = true;
            this.CBoxProductId.Location = new System.Drawing.Point(191, 117);
            this.CBoxProductId.Name = "CBoxProductId";
            this.CBoxProductId.Size = new System.Drawing.Size(181, 29);
            this.CBoxProductId.TabIndex = 13;
            this.CBoxProductId.SelectedIndexChanged += new System.EventHandler(this.CBoxProductId_SelectedIndexChanged);
            // 
            // BtnReomveOrder
            // 
            this.BtnReomveOrder.BackColor = System.Drawing.Color.Transparent;
            this.BtnReomveOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnReomveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReomveOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnReomveOrder.Location = new System.Drawing.Point(616, 217);
            this.BtnReomveOrder.Name = "BtnReomveOrder";
            this.BtnReomveOrder.Rounded = false;
            this.BtnReomveOrder.Size = new System.Drawing.Size(90, 40);
            this.BtnReomveOrder.TabIndex = 10;
            this.BtnReomveOrder.Text = "Remove";
            this.BtnReomveOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnReomveOrder.Click += new System.EventHandler(this.BtnReomveOrder_Click);
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAddOrder.Location = new System.Drawing.Point(504, 217);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Rounded = false;
            this.BtnAddOrder.Size = new System.Drawing.Size(90, 40);
            this.BtnAddOrder.TabIndex = 11;
            this.BtnAddOrder.Text = "Add";
            this.BtnAddOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 28);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.GridRetailerOrder);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(747, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(478, 750);
            this.panel1.TabIndex = 3;
            // 
            // GridRetailerOrder
            // 
            this.GridRetailerOrder.AllowUserToAddRows = false;
            this.GridRetailerOrder.AllowUserToDeleteRows = false;
            this.GridRetailerOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRetailerOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridRetailerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRetailerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRetailerOrder.Location = new System.Drawing.Point(10, 38);
            this.GridRetailerOrder.Name = "GridRetailerOrder";
            this.GridRetailerOrder.ReadOnly = true;
            this.GridRetailerOrder.Size = new System.Drawing.Size(458, 531);
            this.GridRetailerOrder.TabIndex = 14;
            this.GridRetailerOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRetailerOrder_CellClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.LabelTotalPrice);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.BtnPrintInvoice);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 569);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(458, 171);
            this.panel6.TabIndex = 13;
            // 
            // LabelTotalPrice
            // 
            this.LabelTotalPrice.AutoSize = true;
            this.LabelTotalPrice.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalPrice.Location = new System.Drawing.Point(147, 21);
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            this.LabelTotalPrice.Size = new System.Drawing.Size(59, 23);
            this.LabelTotalPrice.TabIndex = 12;
            this.LabelTotalPrice.Text = "00.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 23);
            this.label16.TabIndex = 12;
            this.label16.Text = "Total Price:";
            // 
            // BtnPrintInvoice
            // 
            this.BtnPrintInvoice.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrintInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPrintInvoice.Location = new System.Drawing.Point(110, 82);
            this.BtnPrintInvoice.Name = "BtnPrintInvoice";
            this.BtnPrintInvoice.Rounded = false;
            this.BtnPrintInvoice.Size = new System.Drawing.Size(233, 35);
            this.BtnPrintInvoice.TabIndex = 11;
            this.BtnPrintInvoice.Text = "Print ";
            this.BtnPrintInvoice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnPrintInvoice.Click += new System.EventHandler(this.BtnPrintInvoice_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 28);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Orderd Products:";
            // 
            // RetailerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetailerOrdersForm";
            this.Text = "RetailerOrdersForm";
            this.Load += new System.EventHandler(this.RetailerOrdersForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRetailerOrder)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridProduct;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.ForeverButton BtnReomveOrder;
        private ReaLTaiizor.Controls.ForeverButton BtnAddOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxProductId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumericUpDownQty;
        private System.Windows.Forms.Label LabelRetailerName;
        private System.Windows.Forms.Label LabelProductPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxRetailerId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridRetailerOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private ReaLTaiizor.Controls.ForeverButton BtnPrintInvoice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BoxOrderId;
    }
}