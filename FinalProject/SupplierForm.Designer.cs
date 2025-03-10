namespace FinalProject
{
    partial class SupplierForm
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
            this.BoxSupplierSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshSupplier = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchSupplier = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoxSupplierId = new System.Windows.Forms.TextBox();
            this.BoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.BoxSupplierEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxSupplierContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearSupplier = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteSupplier = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateSupplier = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertSupplier = new ReaLTaiizor.Controls.ForeverButton();
            this.GridSupplier = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSupplier)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxSupplierSearch);
            this.panel1.Controls.Add(this.BtnRefreshSupplier);
            this.panel1.Controls.Add(this.BtnSearchSupplier);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 6;
            // 
            // BoxSupplierSearch
            // 
            this.BoxSupplierSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierSearch.Location = new System.Drawing.Point(427, 24);
            this.BoxSupplierSearch.Name = "BoxSupplierSearch";
            this.BoxSupplierSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxSupplierSearch.TabIndex = 4;
            // 
            // BtnRefreshSupplier
            // 
            this.BtnRefreshSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshSupplier.Location = new System.Drawing.Point(757, 24);
            this.BtnRefreshSupplier.Name = "BtnRefreshSupplier";
            this.BtnRefreshSupplier.Rounded = false;
            this.BtnRefreshSupplier.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshSupplier.TabIndex = 7;
            this.BtnRefreshSupplier.Text = "Refresh";
            this.BtnRefreshSupplier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshSupplier.Click += new System.EventHandler(this.BtnRefreshSupplier_Click);
            // 
            // BtnSearchSupplier
            // 
            this.BtnSearchSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchSupplier.Location = new System.Drawing.Point(652, 24);
            this.BtnSearchSupplier.Name = "BtnSearchSupplier";
            this.BtnSearchSupplier.Rounded = false;
            this.BtnSearchSupplier.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchSupplier.TabIndex = 7;
            this.BtnSearchSupplier.Text = "Search";
            this.BtnSearchSupplier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchSupplier.Click += new System.EventHandler(this.BtnSearchSupplier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Suppliers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 7;
            // 
            // BoxSupplierId
            // 
            this.BoxSupplierId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierId.Location = new System.Drawing.Point(210, 17);
            this.BoxSupplierId.Name = "BoxSupplierId";
            this.BoxSupplierId.ReadOnly = true;
            this.BoxSupplierId.Size = new System.Drawing.Size(187, 30);
            this.BoxSupplierId.TabIndex = 4;
            // 
            // BoxSupplierAddress
            // 
            this.BoxSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierAddress.Location = new System.Drawing.Point(210, 211);
            this.BoxSupplierAddress.Name = "BoxSupplierAddress";
            this.BoxSupplierAddress.Size = new System.Drawing.Size(187, 30);
            this.BoxSupplierAddress.TabIndex = 4;
            // 
            // BoxSupplierEmail
            // 
            this.BoxSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierEmail.Location = new System.Drawing.Point(210, 162);
            this.BoxSupplierEmail.Name = "BoxSupplierEmail";
            this.BoxSupplierEmail.Size = new System.Drawing.Size(187, 30);
            this.BoxSupplierEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier Address:";
            // 
            // BoxSupplierContact
            // 
            this.BoxSupplierContact.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierContact.Location = new System.Drawing.Point(210, 113);
            this.BoxSupplierContact.Name = "BoxSupplierContact";
            this.BoxSupplierContact.Size = new System.Drawing.Size(187, 30);
            this.BoxSupplierContact.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier Email:";
            // 
            // BoxSupplierName
            // 
            this.BoxSupplierName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierName.Location = new System.Drawing.Point(210, 66);
            this.BoxSupplierName.Name = "BoxSupplierName";
            this.BoxSupplierName.Size = new System.Drawing.Size(187, 30);
            this.BoxSupplierName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Supplier Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearSupplier);
            this.panel3.Controls.Add(this.BtnDeleteSupplier);
            this.panel3.Controls.Add(this.BtnUpdateSupplier);
            this.panel3.Controls.Add(this.BtnInsertSupplier);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 8;
            // 
            // BtnClearSupplier
            // 
            this.BtnClearSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearSupplier.Location = new System.Drawing.Point(386, 32);
            this.BtnClearSupplier.Name = "BtnClearSupplier";
            this.BtnClearSupplier.Rounded = false;
            this.BtnClearSupplier.Size = new System.Drawing.Size(90, 40);
            this.BtnClearSupplier.TabIndex = 7;
            this.BtnClearSupplier.Text = "Clear";
            this.BtnClearSupplier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearSupplier.Click += new System.EventHandler(this.BtnClearSupplier_Click);
            // 
            // BtnDeleteSupplier
            // 
            this.BtnDeleteSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteSupplier.Location = new System.Drawing.Point(263, 32);
            this.BtnDeleteSupplier.Name = "BtnDeleteSupplier";
            this.BtnDeleteSupplier.Rounded = false;
            this.BtnDeleteSupplier.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteSupplier.TabIndex = 7;
            this.BtnDeleteSupplier.Text = "Delete";
            this.BtnDeleteSupplier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteSupplier.Click += new System.EventHandler(this.BtnDeleteSupplier_Click);
            // 
            // BtnUpdateSupplier
            // 
            this.BtnUpdateSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateSupplier.Location = new System.Drawing.Point(145, 32);
            this.BtnUpdateSupplier.Name = "BtnUpdateSupplier";
            this.BtnUpdateSupplier.Rounded = false;
            this.BtnUpdateSupplier.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateSupplier.TabIndex = 7;
            this.BtnUpdateSupplier.Text = "Update";
            this.BtnUpdateSupplier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateSupplier.Click += new System.EventHandler(this.BtnUpdateSupplier_Click);
            // 
            // BtnInsertSupplier
            // 
            this.BtnInsertSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertSupplier.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertSupplier.Name = "BtnInsertSupplier";
            this.BtnInsertSupplier.Rounded = false;
            this.BtnInsertSupplier.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertSupplier.TabIndex = 7;
            this.BtnInsertSupplier.Text = "Insert";
            this.BtnInsertSupplier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertSupplier.Click += new System.EventHandler(this.BtnInsertSupplier_Click);
            // 
            // GridSupplier
            // 
            this.GridSupplier.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSupplier.Location = new System.Drawing.Point(424, 66);
            this.GridSupplier.Name = "GridSupplier";
            this.GridSupplier.Size = new System.Drawing.Size(801, 591);
            this.GridSupplier.TabIndex = 9;
            this.GridSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSupplier_CellClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.BoxSupplierAddress);
            this.panel6.Controls.Add(this.BoxSupplierId);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.BoxSupplierEmail);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.BoxSupplierName);
            this.panel6.Controls.Add(this.BoxSupplierContact);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 256);
            this.panel6.TabIndex = 10;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridSupplier);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSupplier)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSupplierSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshSupplier;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BoxSupplierId;
        private System.Windows.Forms.TextBox BoxSupplierName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearSupplier;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteSupplier;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateSupplier;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertSupplier;
        private System.Windows.Forms.TextBox BoxSupplierAddress;
        private System.Windows.Forms.TextBox BoxSupplierEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxSupplierContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridSupplier;
        private System.Windows.Forms.Panel panel6;
    }
}