namespace FinalProject
{
    partial class DamagedProductsForm
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
            this.BoxDmgProductSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshDmgProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchDmgProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxProductId = new System.Windows.Forms.ComboBox();
            this.DateAdded = new System.Windows.Forms.DateTimePicker();
            this.BoxQty = new System.Windows.Forms.TextBox();
            this.BoxDmgProductId = new System.Windows.Forms.TextBox();
            this.BoxProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearDmgProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertDmgProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.GridDamagedProducts = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDamagedProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxDmgProductSearch);
            this.panel1.Controls.Add(this.BtnRefreshDmgProduct);
            this.panel1.Controls.Add(this.BtnSearchDmgProduct);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 6;
            // 
            // BoxDmgProductSearch
            // 
            this.BoxDmgProductSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDmgProductSearch.Location = new System.Drawing.Point(427, 24);
            this.BoxDmgProductSearch.Name = "BoxDmgProductSearch";
            this.BoxDmgProductSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxDmgProductSearch.TabIndex = 4;
            this.BoxDmgProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxDmgProductSearch_KeyDown);
            // 
            // BtnRefreshDmgProduct
            // 
            this.BtnRefreshDmgProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshDmgProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshDmgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshDmgProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshDmgProduct.Location = new System.Drawing.Point(757, 24);
            this.BtnRefreshDmgProduct.Name = "BtnRefreshDmgProduct";
            this.BtnRefreshDmgProduct.Rounded = false;
            this.BtnRefreshDmgProduct.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshDmgProduct.TabIndex = 7;
            this.BtnRefreshDmgProduct.Text = "Refresh";
            this.BtnRefreshDmgProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshDmgProduct.Click += new System.EventHandler(this.BtnRefreshDmgProduct_Click);
            // 
            // BtnSearchDmgProduct
            // 
            this.BtnSearchDmgProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchDmgProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchDmgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchDmgProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchDmgProduct.Location = new System.Drawing.Point(652, 24);
            this.BtnSearchDmgProduct.Name = "BtnSearchDmgProduct";
            this.BtnSearchDmgProduct.Rounded = false;
            this.BtnSearchDmgProduct.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchDmgProduct.TabIndex = 7;
            this.BtnSearchDmgProduct.Text = "Search";
            this.BtnSearchDmgProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchDmgProduct.Click += new System.EventHandler(this.BtnSearchDmgProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Damaged Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.CBoxProductId);
            this.panel2.Controls.Add(this.DateAdded);
            this.panel2.Controls.Add(this.BoxQty);
            this.panel2.Controls.Add(this.BoxDmgProductId);
            this.panel2.Controls.Add(this.BoxProductName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 7;
            // 
            // CBoxProductId
            // 
            this.CBoxProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxProductId.FormattingEnabled = true;
            this.CBoxProductId.Items.AddRange(new object[] {
            "Admin",
            "SalesRep",
            "Logistics-Coordinator",
            "Driver",
            "Inventorty Manager"});
            this.CBoxProductId.Location = new System.Drawing.Point(218, 89);
            this.CBoxProductId.Name = "CBoxProductId";
            this.CBoxProductId.Size = new System.Drawing.Size(187, 29);
            this.CBoxProductId.TabIndex = 7;
            this.CBoxProductId.SelectedIndexChanged += new System.EventHandler(this.CBoxProductId_SelectedIndexChanged);
            // 
            // DateAdded
            // 
            this.DateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAdded.Location = new System.Drawing.Point(218, 245);
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.Size = new System.Drawing.Size(187, 26);
            this.DateAdded.TabIndex = 6;
            // 
            // BoxQty
            // 
            this.BoxQty.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQty.Location = new System.Drawing.Point(218, 191);
            this.BoxQty.Name = "BoxQty";
            this.BoxQty.Size = new System.Drawing.Size(187, 30);
            this.BoxQty.TabIndex = 4;
            this.BoxQty.Text = "0";
            // 
            // BoxDmgProductId
            // 
            this.BoxDmgProductId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDmgProductId.Location = new System.Drawing.Point(218, 39);
            this.BoxDmgProductId.Name = "BoxDmgProductId";
            this.BoxDmgProductId.ReadOnly = true;
            this.BoxDmgProductId.Size = new System.Drawing.Size(187, 30);
            this.BoxDmgProductId.TabIndex = 4;
            // 
            // BoxProductName
            // 
            this.BoxProductName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxProductName.Location = new System.Drawing.Point(218, 138);
            this.BoxProductName.Name = "BoxProductName";
            this.BoxProductName.ReadOnly = true;
            this.BoxProductName.Size = new System.Drawing.Size(187, 30);
            this.BoxProductName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date Added:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Product Qty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Damaged Product Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.BtnClearDmgProduct);
            this.panel3.Controls.Add(this.BtnInsertDmgProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 8;
            // 
            // BtnClearDmgProduct
            // 
            this.BtnClearDmgProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearDmgProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearDmgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearDmgProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearDmgProduct.Location = new System.Drawing.Point(151, 32);
            this.BtnClearDmgProduct.Name = "BtnClearDmgProduct";
            this.BtnClearDmgProduct.Rounded = false;
            this.BtnClearDmgProduct.Size = new System.Drawing.Size(90, 40);
            this.BtnClearDmgProduct.TabIndex = 7;
            this.BtnClearDmgProduct.Text = "Clear";
            this.BtnClearDmgProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearDmgProduct.Click += new System.EventHandler(this.BtnClearDmgProduct_Click);
            // 
            // BtnInsertDmgProduct
            // 
            this.BtnInsertDmgProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertDmgProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertDmgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertDmgProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertDmgProduct.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertDmgProduct.Name = "BtnInsertDmgProduct";
            this.BtnInsertDmgProduct.Rounded = false;
            this.BtnInsertDmgProduct.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertDmgProduct.TabIndex = 7;
            this.BtnInsertDmgProduct.Text = "Insert";
            this.BtnInsertDmgProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertDmgProduct.Click += new System.EventHandler(this.BtnInsertDmgProduct_Click);
            // 
            // GridDamagedProducts
            // 
            this.GridDamagedProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridDamagedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDamagedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDamagedProducts.Location = new System.Drawing.Point(424, 66);
            this.GridDamagedProducts.Name = "GridDamagedProducts";
            this.GridDamagedProducts.Size = new System.Drawing.Size(801, 591);
            this.GridDamagedProducts.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel4.Controls.Add(this.foreverButton1);
            this.panel4.Controls.Add(this.foreverButton2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 93);
            this.panel4.TabIndex = 9;
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButton1.Location = new System.Drawing.Point(151, 32);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = false;
            this.foreverButton1.Size = new System.Drawing.Size(90, 40);
            this.foreverButton1.TabIndex = 7;
            this.foreverButton1.Text = "Clear";
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // foreverButton2
            // 
            this.foreverButton2.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.foreverButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButton2.Location = new System.Drawing.Point(31, 32);
            this.foreverButton2.Name = "foreverButton2";
            this.foreverButton2.Rounded = false;
            this.foreverButton2.Size = new System.Drawing.Size(90, 40);
            this.foreverButton2.TabIndex = 7;
            this.foreverButton2.Text = "Insert";
            this.foreverButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // DamagedProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridDamagedProducts);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DamagedProductsForm";
            this.Text = "DamagedProductsForm";
            this.Load += new System.EventHandler(this.DamagedProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDamagedProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxDmgProductSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshDmgProduct;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchDmgProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBoxProductId;
        private System.Windows.Forms.DateTimePicker DateAdded;
        private System.Windows.Forms.TextBox BoxQty;
        private System.Windows.Forms.TextBox BoxDmgProductId;
        private System.Windows.Forms.TextBox BoxProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearDmgProduct;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertDmgProduct;
        private System.Windows.Forms.DataGridView GridDamagedProducts;
        private System.Windows.Forms.Panel panel4;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
    }
}