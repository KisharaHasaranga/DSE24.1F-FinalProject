namespace FinalProject
{
    partial class RestockProductsForm
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
            this.BoxRestockProductSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshRestockProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchRestockProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxProductId = new System.Windows.Forms.ComboBox();
            this.DateAdded = new System.Windows.Forms.DateTimePicker();
            this.BoxRestockQty = new System.Windows.Forms.TextBox();
            this.BoxRestockProductId = new System.Windows.Forms.TextBox();
            this.BoxRestockProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearRestockProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteRestockProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateRestockProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertRestockProduct = new ReaLTaiizor.Controls.ForeverButton();
            this.GridRestockProduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRestockProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxRestockProductSearch);
            this.panel1.Controls.Add(this.BtnRefreshRestockProduct);
            this.panel1.Controls.Add(this.BtnSearchRestockProduct);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 7;
            // 
            // BoxRestockProductSearch
            // 
            this.BoxRestockProductSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRestockProductSearch.Location = new System.Drawing.Point(427, 24);
            this.BoxRestockProductSearch.Name = "BoxRestockProductSearch";
            this.BoxRestockProductSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxRestockProductSearch.TabIndex = 4;
            this.BoxRestockProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxRestockProductSearch_KeyDown);
            // 
            // BtnRefreshRestockProduct
            // 
            this.BtnRefreshRestockProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshRestockProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshRestockProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshRestockProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshRestockProduct.Location = new System.Drawing.Point(756, 24);
            this.BtnRefreshRestockProduct.Name = "BtnRefreshRestockProduct";
            this.BtnRefreshRestockProduct.Rounded = false;
            this.BtnRefreshRestockProduct.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshRestockProduct.TabIndex = 7;
            this.BtnRefreshRestockProduct.Text = "Refresh";
            this.BtnRefreshRestockProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshRestockProduct.Click += new System.EventHandler(this.BtnRefreshRestockProduct_Click);
            // 
            // BtnSearchRestockProduct
            // 
            this.BtnSearchRestockProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchRestockProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchRestockProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchRestockProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchRestockProduct.Location = new System.Drawing.Point(640, 24);
            this.BtnSearchRestockProduct.Name = "BtnSearchRestockProduct";
            this.BtnSearchRestockProduct.Rounded = false;
            this.BtnSearchRestockProduct.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchRestockProduct.TabIndex = 7;
            this.BtnSearchRestockProduct.Text = "Search";
            this.BtnSearchRestockProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchRestockProduct.Click += new System.EventHandler(this.BtnSearchRestockProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Restock Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.CBoxProductId);
            this.panel2.Controls.Add(this.DateAdded);
            this.panel2.Controls.Add(this.BoxRestockQty);
            this.panel2.Controls.Add(this.BoxRestockProductId);
            this.panel2.Controls.Add(this.BoxRestockProductName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 8;
            // 
            // CBoxProductId
            // 
            this.CBoxProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxProductId.FormattingEnabled = true;
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
            // BoxRestockQty
            // 
            this.BoxRestockQty.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRestockQty.Location = new System.Drawing.Point(218, 191);
            this.BoxRestockQty.Name = "BoxRestockQty";
            this.BoxRestockQty.Size = new System.Drawing.Size(187, 30);
            this.BoxRestockQty.TabIndex = 4;
            this.BoxRestockQty.Text = "0";
            // 
            // BoxRestockProductId
            // 
            this.BoxRestockProductId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRestockProductId.Location = new System.Drawing.Point(218, 39);
            this.BoxRestockProductId.Name = "BoxRestockProductId";
            this.BoxRestockProductId.ReadOnly = true;
            this.BoxRestockProductId.Size = new System.Drawing.Size(187, 30);
            this.BoxRestockProductId.TabIndex = 4;
            // 
            // BoxRestockProductName
            // 
            this.BoxRestockProductName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRestockProductName.Location = new System.Drawing.Point(218, 138);
            this.BoxRestockProductName.Name = "BoxRestockProductName";
            this.BoxRestockProductName.ReadOnly = true;
            this.BoxRestockProductName.Size = new System.Drawing.Size(187, 30);
            this.BoxRestockProductName.TabIndex = 4;
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
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Restock Product Id:";
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
            this.panel3.Controls.Add(this.BtnClearRestockProduct);
            this.panel3.Controls.Add(this.BtnDeleteRestockProduct);
            this.panel3.Controls.Add(this.BtnUpdateRestockProduct);
            this.panel3.Controls.Add(this.BtnInsertRestockProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 11;
            // 
            // BtnClearRestockProduct
            // 
            this.BtnClearRestockProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearRestockProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearRestockProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearRestockProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearRestockProduct.Location = new System.Drawing.Point(385, 32);
            this.BtnClearRestockProduct.Name = "BtnClearRestockProduct";
            this.BtnClearRestockProduct.Rounded = false;
            this.BtnClearRestockProduct.Size = new System.Drawing.Size(90, 40);
            this.BtnClearRestockProduct.TabIndex = 7;
            this.BtnClearRestockProduct.Text = "Clear";
            this.BtnClearRestockProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearRestockProduct.Click += new System.EventHandler(this.BtnClearRestockProduct_Click);
            // 
            // BtnDeleteRestockProduct
            // 
            this.BtnDeleteRestockProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteRestockProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteRestockProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteRestockProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteRestockProduct.Location = new System.Drawing.Point(267, 32);
            this.BtnDeleteRestockProduct.Name = "BtnDeleteRestockProduct";
            this.BtnDeleteRestockProduct.Rounded = false;
            this.BtnDeleteRestockProduct.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteRestockProduct.TabIndex = 7;
            this.BtnDeleteRestockProduct.Text = "Delete";
            this.BtnDeleteRestockProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteRestockProduct.Click += new System.EventHandler(this.BtnDeleteRestockProduct_Click);
            // 
            // BtnUpdateRestockProduct
            // 
            this.BtnUpdateRestockProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateRestockProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateRestockProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateRestockProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateRestockProduct.Location = new System.Drawing.Point(149, 32);
            this.BtnUpdateRestockProduct.Name = "BtnUpdateRestockProduct";
            this.BtnUpdateRestockProduct.Rounded = false;
            this.BtnUpdateRestockProduct.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateRestockProduct.TabIndex = 7;
            this.BtnUpdateRestockProduct.Text = "Update";
            this.BtnUpdateRestockProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateRestockProduct.Click += new System.EventHandler(this.BtnUpdateRestockProduct_Click);
            // 
            // BtnInsertRestockProduct
            // 
            this.BtnInsertRestockProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertRestockProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertRestockProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertRestockProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertRestockProduct.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertRestockProduct.Name = "BtnInsertRestockProduct";
            this.BtnInsertRestockProduct.Rounded = false;
            this.BtnInsertRestockProduct.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertRestockProduct.TabIndex = 7;
            this.BtnInsertRestockProduct.Text = "Insert";
            this.BtnInsertRestockProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertRestockProduct.Click += new System.EventHandler(this.BtnInsertRestockProduct_Click);
            // 
            // GridRestockProduct
            // 
            this.GridRestockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRestockProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridRestockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRestockProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRestockProduct.Location = new System.Drawing.Point(424, 66);
            this.GridRestockProduct.Name = "GridRestockProduct";
            this.GridRestockProduct.Size = new System.Drawing.Size(801, 591);
            this.GridRestockProduct.TabIndex = 12;
            this.GridRestockProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRestockProduct_CellClick);
            // 
            // RestockProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridRestockProduct);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestockProductsForm";
            this.Text = "RestockProductsForm";
            this.Load += new System.EventHandler(this.RestockProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRestockProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxRestockProductSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshRestockProduct;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchRestockProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBoxProductId;
        private System.Windows.Forms.DateTimePicker DateAdded;
        private System.Windows.Forms.TextBox BoxRestockQty;
        private System.Windows.Forms.TextBox BoxRestockProductId;
        private System.Windows.Forms.TextBox BoxRestockProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearRestockProduct;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteRestockProduct;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateRestockProduct;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertRestockProduct;
        private System.Windows.Forms.DataGridView GridRestockProduct;
    }
}