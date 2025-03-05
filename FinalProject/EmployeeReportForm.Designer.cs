namespace FinalProject
{
    partial class EmployeeReportForm
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
            this.EmpCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxEmpId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearch = new ReaLTaiizor.Controls.ForeverButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpCrystalReportViewer
            // 
            this.EmpCrystalReportViewer.ActiveViewIndex = -1;
            this.EmpCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmpCrystalReportViewer.DisplayStatusBar = false;
            this.EmpCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.EmpCrystalReportViewer.Name = "EmpCrystalReportViewer";
            this.EmpCrystalReportViewer.ShowCloseButton = false;
            this.EmpCrystalReportViewer.ShowCopyButton = false;
            this.EmpCrystalReportViewer.ShowExportButton = false;
            this.EmpCrystalReportViewer.ShowGotoPageButton = false;
            this.EmpCrystalReportViewer.ShowGroupTreeButton = false;
            this.EmpCrystalReportViewer.ShowPageNavigateButtons = false;
            this.EmpCrystalReportViewer.ShowParameterPanelButton = false;
            this.EmpCrystalReportViewer.ShowTextSearchButton = false;
            this.EmpCrystalReportViewer.ShowZoomButton = false;
            this.EmpCrystalReportViewer.Size = new System.Drawing.Size(1225, 683);
            this.EmpCrystalReportViewer.TabIndex = 0;
            this.EmpCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.CBoxEmpId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 67);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EmpCrystalReportViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 683);
            this.panel2.TabIndex = 2;
            // 
            // CBoxEmpId
            // 
            this.CBoxEmpId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxEmpId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxEmpId.FormattingEnabled = true;
            this.CBoxEmpId.Items.AddRange(new object[] {
            "Admin",
            "SalesRep",
            "Logistics-Coordinator",
            "Driver",
            "Inventorty Manager"});
            this.CBoxEmpId.Location = new System.Drawing.Point(169, 20);
            this.CBoxEmpId.Name = "CBoxEmpId";
            this.CBoxEmpId.Size = new System.Drawing.Size(187, 29);
            this.CBoxEmpId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Id:";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefresh.Location = new System.Drawing.Point(492, 19);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Rounded = false;
            this.BtnRefresh.Size = new System.Drawing.Size(90, 30);
            this.BtnRefresh.TabIndex = 10;
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
            this.BtnSearch.Location = new System.Drawing.Point(379, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rounded = false;
            this.BtnSearch.Size = new System.Drawing.Size(90, 30);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // EmployeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeReportForm";
            this.Text = "EmployeeReportForm";
            this.Load += new System.EventHandler(this.EmployeeReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer EmpCrystalReportViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBoxEmpId;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.ForeverButton BtnRefresh;
        private ReaLTaiizor.Controls.ForeverButton BtnSearch;
    }
}