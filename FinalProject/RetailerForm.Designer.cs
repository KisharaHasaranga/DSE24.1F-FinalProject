namespace FinalProject
{
    partial class RetailerForm
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
            this.BoxRetailerSearch = new System.Windows.Forms.TextBox();
            this.BtnRefreshRetailer = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearchRetailer = new ReaLTaiizor.Controls.ForeverButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoxAddress = new System.Windows.Forms.TextBox();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.BoxContact = new System.Windows.Forms.TextBox();
            this.BoxRetailerId = new System.Windows.Forms.TextBox();
            this.BoxRetailerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClearRetailer = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnDeleteRetailer = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnUpdateRetailer = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnInsertRetailer = new ReaLTaiizor.Controls.ForeverButton();
            this.GridRetailer = new System.Windows.Forms.DataGridView();
            this.CBoxPriority = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRetailer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BoxRetailerSearch);
            this.panel1.Controls.Add(this.BtnRefreshRetailer);
            this.panel1.Controls.Add(this.BtnSearchRetailer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 5;
            // 
            // BoxRetailerSearch
            // 
            this.BoxRetailerSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRetailerSearch.Location = new System.Drawing.Point(427, 24);
            this.BoxRetailerSearch.Name = "BoxRetailerSearch";
            this.BoxRetailerSearch.Size = new System.Drawing.Size(187, 30);
            this.BoxRetailerSearch.TabIndex = 4;
            // 
            // BtnRefreshRetailer
            // 
            this.BtnRefreshRetailer.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefreshRetailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefreshRetailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshRetailer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefreshRetailer.Location = new System.Drawing.Point(756, 24);
            this.BtnRefreshRetailer.Name = "BtnRefreshRetailer";
            this.BtnRefreshRetailer.Rounded = false;
            this.BtnRefreshRetailer.Size = new System.Drawing.Size(90, 30);
            this.BtnRefreshRetailer.TabIndex = 7;
            this.BtnRefreshRetailer.Text = "Refresh";
            this.BtnRefreshRetailer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnRefreshRetailer.Click += new System.EventHandler(this.BtnRefreshRetailer_Click);
            // 
            // BtnSearchRetailer
            // 
            this.BtnSearchRetailer.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchRetailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnSearchRetailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchRetailer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearchRetailer.Location = new System.Drawing.Point(640, 24);
            this.BtnSearchRetailer.Name = "BtnSearchRetailer";
            this.BtnSearchRetailer.Rounded = false;
            this.BtnSearchRetailer.Size = new System.Drawing.Size(90, 30);
            this.BtnSearchRetailer.TabIndex = 7;
            this.BtnSearchRetailer.Text = "Search";
            this.BtnSearchRetailer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearchRetailer.Click += new System.EventHandler(this.BtnSearchRetailer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Retailer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.CBoxPriority);
            this.panel2.Controls.Add(this.BoxAddress);
            this.panel2.Controls.Add(this.BoxEmail);
            this.panel2.Controls.Add(this.BoxContact);
            this.panel2.Controls.Add(this.BoxRetailerId);
            this.panel2.Controls.Add(this.BoxRetailerName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 6;
            // 
            // BoxAddress
            // 
            this.BoxAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAddress.Location = new System.Drawing.Point(218, 235);
            this.BoxAddress.Name = "BoxAddress";
            this.BoxAddress.Size = new System.Drawing.Size(187, 30);
            this.BoxAddress.TabIndex = 4;
            // 
            // BoxEmail
            // 
            this.BoxEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmail.Location = new System.Drawing.Point(218, 187);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(187, 30);
            this.BoxEmail.TabIndex = 4;
            // 
            // BoxContact
            // 
            this.BoxContact.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxContact.Location = new System.Drawing.Point(218, 138);
            this.BoxContact.Name = "BoxContact";
            this.BoxContact.Size = new System.Drawing.Size(187, 30);
            this.BoxContact.TabIndex = 4;
            // 
            // BoxRetailerId
            // 
            this.BoxRetailerId.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRetailerId.Location = new System.Drawing.Point(218, 43);
            this.BoxRetailerId.Name = "BoxRetailerId";
            this.BoxRetailerId.ReadOnly = true;
            this.BoxRetailerId.Size = new System.Drawing.Size(187, 30);
            this.BoxRetailerId.TabIndex = 4;
            // 
            // BoxRetailerName
            // 
            this.BoxRetailerName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRetailerName.Location = new System.Drawing.Point(218, 87);
            this.BoxRetailerName.Name = "BoxRetailerName";
            this.BoxRetailerName.Size = new System.Drawing.Size(187, 30);
            this.BoxRetailerName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Priority:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Retailer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Retailer Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.BtnClearRetailer);
            this.panel3.Controls.Add(this.BtnDeleteRetailer);
            this.panel3.Controls.Add(this.BtnUpdateRetailer);
            this.panel3.Controls.Add(this.BtnInsertRetailer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 93);
            this.panel3.TabIndex = 7;
            // 
            // BtnClearRetailer
            // 
            this.BtnClearRetailer.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearRetailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnClearRetailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearRetailer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClearRetailer.Location = new System.Drawing.Point(385, 32);
            this.BtnClearRetailer.Name = "BtnClearRetailer";
            this.BtnClearRetailer.Rounded = false;
            this.BtnClearRetailer.Size = new System.Drawing.Size(90, 40);
            this.BtnClearRetailer.TabIndex = 7;
            this.BtnClearRetailer.Text = "Clear";
            this.BtnClearRetailer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnClearRetailer.Click += new System.EventHandler(this.BtnClearRetailer_Click);
            // 
            // BtnDeleteRetailer
            // 
            this.BtnDeleteRetailer.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteRetailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnDeleteRetailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteRetailer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeleteRetailer.Location = new System.Drawing.Point(267, 32);
            this.BtnDeleteRetailer.Name = "BtnDeleteRetailer";
            this.BtnDeleteRetailer.Rounded = false;
            this.BtnDeleteRetailer.Size = new System.Drawing.Size(90, 40);
            this.BtnDeleteRetailer.TabIndex = 7;
            this.BtnDeleteRetailer.Text = "Delete";
            this.BtnDeleteRetailer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnDeleteRetailer.Click += new System.EventHandler(this.BtnDeleteRetailer_Click);
            // 
            // BtnUpdateRetailer
            // 
            this.BtnUpdateRetailer.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateRetailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnUpdateRetailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateRetailer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUpdateRetailer.Location = new System.Drawing.Point(149, 32);
            this.BtnUpdateRetailer.Name = "BtnUpdateRetailer";
            this.BtnUpdateRetailer.Rounded = false;
            this.BtnUpdateRetailer.Size = new System.Drawing.Size(90, 40);
            this.BtnUpdateRetailer.TabIndex = 7;
            this.BtnUpdateRetailer.Text = "Update";
            this.BtnUpdateRetailer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnUpdateRetailer.Click += new System.EventHandler(this.BtnUpdateRetailer_Click);
            // 
            // BtnInsertRetailer
            // 
            this.BtnInsertRetailer.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsertRetailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnInsertRetailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertRetailer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnInsertRetailer.Location = new System.Drawing.Point(31, 32);
            this.BtnInsertRetailer.Name = "BtnInsertRetailer";
            this.BtnInsertRetailer.Rounded = false;
            this.BtnInsertRetailer.Size = new System.Drawing.Size(90, 40);
            this.BtnInsertRetailer.TabIndex = 7;
            this.BtnInsertRetailer.Text = "Insert";
            this.BtnInsertRetailer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnInsertRetailer.Click += new System.EventHandler(this.BtnInsertRetailer_Click);
            // 
            // GridRetailer
            // 
            this.GridRetailer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridRetailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRetailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRetailer.Location = new System.Drawing.Point(424, 66);
            this.GridRetailer.Name = "GridRetailer";
            this.GridRetailer.Size = new System.Drawing.Size(801, 591);
            this.GridRetailer.TabIndex = 8;
            this.GridRetailer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRetailer_CellClick);
            // 
            // CBoxPriority
            // 
            this.CBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxPriority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxPriority.FormattingEnabled = true;
            this.CBoxPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.CBoxPriority.Location = new System.Drawing.Point(218, 284);
            this.CBoxPriority.Name = "CBoxPriority";
            this.CBoxPriority.Size = new System.Drawing.Size(187, 29);
            this.CBoxPriority.TabIndex = 8;
            // 
            // RetailerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridRetailer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetailerForm";
            this.Text = "RetailerForm";
            this.Load += new System.EventHandler(this.RetailerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRetailer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxRetailerSearch;
        private ReaLTaiizor.Controls.ForeverButton BtnRefreshRetailer;
        private ReaLTaiizor.Controls.ForeverButton BtnSearchRetailer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BoxAddress;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.TextBox BoxContact;
        private System.Windows.Forms.TextBox BoxRetailerId;
        private System.Windows.Forms.TextBox BoxRetailerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnClearRetailer;
        private ReaLTaiizor.Controls.ForeverButton BtnDeleteRetailer;
        private ReaLTaiizor.Controls.ForeverButton BtnUpdateRetailer;
        private ReaLTaiizor.Controls.ForeverButton BtnInsertRetailer;
        private System.Windows.Forms.DataGridView GridRetailer;
        private System.Windows.Forms.ComboBox CBoxPriority;
    }
}