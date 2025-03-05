namespace FinalProject
{
    partial class RetailerReportForm
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
            this.RetailerCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RetailerCrystalReportViewer
            // 
            this.RetailerCrystalReportViewer.ActiveViewIndex = -1;
            this.RetailerCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetailerCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RetailerCrystalReportViewer.DisplayStatusBar = false;
            this.RetailerCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetailerCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.RetailerCrystalReportViewer.Name = "RetailerCrystalReportViewer";
            this.RetailerCrystalReportViewer.ShowCloseButton = false;
            this.RetailerCrystalReportViewer.ShowCopyButton = false;
            this.RetailerCrystalReportViewer.ShowExportButton = false;
            this.RetailerCrystalReportViewer.ShowGotoPageButton = false;
            this.RetailerCrystalReportViewer.ShowGroupTreeButton = false;
            this.RetailerCrystalReportViewer.ShowPageNavigateButtons = false;
            this.RetailerCrystalReportViewer.ShowParameterPanelButton = false;
            this.RetailerCrystalReportViewer.ShowTextSearchButton = false;
            this.RetailerCrystalReportViewer.ShowZoomButton = false;
            this.RetailerCrystalReportViewer.Size = new System.Drawing.Size(1225, 750);
            this.RetailerCrystalReportViewer.TabIndex = 2;
            this.RetailerCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RetailerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.RetailerCrystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetailerReportForm";
            this.Text = "RetailerReportForm";
            this.Load += new System.EventHandler(this.RetailerReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RetailerCrystalReportViewer;
    }
}