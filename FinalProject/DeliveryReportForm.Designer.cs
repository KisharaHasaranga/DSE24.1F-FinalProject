namespace FinalProject
{
    partial class DeliveryReportForm
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
            this.DeliveryCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DeliveryCrystalReportViewer
            // 
            this.DeliveryCrystalReportViewer.ActiveViewIndex = -1;
            this.DeliveryCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeliveryCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeliveryCrystalReportViewer.DisplayStatusBar = false;
            this.DeliveryCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DeliveryCrystalReportViewer.Name = "DeliveryCrystalReportViewer";
            this.DeliveryCrystalReportViewer.ShowCloseButton = false;
            this.DeliveryCrystalReportViewer.ShowCopyButton = false;
            this.DeliveryCrystalReportViewer.ShowExportButton = false;
            this.DeliveryCrystalReportViewer.ShowGotoPageButton = false;
            this.DeliveryCrystalReportViewer.ShowGroupTreeButton = false;
            this.DeliveryCrystalReportViewer.ShowPageNavigateButtons = false;
            this.DeliveryCrystalReportViewer.ShowParameterPanelButton = false;
            this.DeliveryCrystalReportViewer.ShowTextSearchButton = false;
            this.DeliveryCrystalReportViewer.ShowZoomButton = false;
            this.DeliveryCrystalReportViewer.Size = new System.Drawing.Size(1225, 750);
            this.DeliveryCrystalReportViewer.TabIndex = 1;
            this.DeliveryCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DeliveryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.DeliveryCrystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryReportForm";
            this.Text = "DeliveryReportForm";
            this.Load += new System.EventHandler(this.DeliveryReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DeliveryCrystalReportViewer;
    }
}