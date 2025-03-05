namespace FinalProject
{
    partial class ProductReportForm
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
            this.ProductCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ProductCrystalReportViewer
            // 
            this.ProductCrystalReportViewer.ActiveViewIndex = -1;
            this.ProductCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductCrystalReportViewer.DisplayStatusBar = false;
            this.ProductCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProductCrystalReportViewer.Name = "ProductCrystalReportViewer";
            this.ProductCrystalReportViewer.ShowCloseButton = false;
            this.ProductCrystalReportViewer.ShowCopyButton = false;
            this.ProductCrystalReportViewer.ShowExportButton = false;
            this.ProductCrystalReportViewer.ShowGotoPageButton = false;
            this.ProductCrystalReportViewer.ShowGroupTreeButton = false;
            this.ProductCrystalReportViewer.ShowPageNavigateButtons = false;
            this.ProductCrystalReportViewer.ShowParameterPanelButton = false;
            this.ProductCrystalReportViewer.ShowTextSearchButton = false;
            this.ProductCrystalReportViewer.ShowZoomButton = false;
            this.ProductCrystalReportViewer.Size = new System.Drawing.Size(1225, 750);
            this.ProductCrystalReportViewer.TabIndex = 3;
            this.ProductCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.ProductCrystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductReportForm";
            this.Text = "ProductReportForm";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProductCrystalReportViewer;
    }
}