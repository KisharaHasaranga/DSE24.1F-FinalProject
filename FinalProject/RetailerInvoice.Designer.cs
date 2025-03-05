namespace FinalProject
{
    partial class RetailerInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.RetailerInvoiceCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 36);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retailer Invoice";
            // 
            // RetailerInvoiceCrystalReportViewer
            // 
            this.RetailerInvoiceCrystalReportViewer.ActiveViewIndex = -1;
            this.RetailerInvoiceCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetailerInvoiceCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RetailerInvoiceCrystalReportViewer.DisplayStatusBar = false;
            this.RetailerInvoiceCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetailerInvoiceCrystalReportViewer.Location = new System.Drawing.Point(0, 36);
            this.RetailerInvoiceCrystalReportViewer.Name = "RetailerInvoiceCrystalReportViewer";
            this.RetailerInvoiceCrystalReportViewer.ShowCloseButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowCopyButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowExportButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowGotoPageButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowGroupTreeButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowPageNavigateButtons = false;
            this.RetailerInvoiceCrystalReportViewer.ShowParameterPanelButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowTextSearchButton = false;
            this.RetailerInvoiceCrystalReportViewer.ShowZoomButton = false;
            this.RetailerInvoiceCrystalReportViewer.Size = new System.Drawing.Size(878, 675);
            this.RetailerInvoiceCrystalReportViewer.TabIndex = 3;
            this.RetailerInvoiceCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::FinalProject.Properties.Resources.icons8_close_24__dark_grey;
            this.pictureBox4.Location = new System.Drawing.Point(845, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // RetailerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 711);
            this.Controls.Add(this.RetailerInvoiceCrystalReportViewer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetailerInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetailerInvoice";
            this.Load += new System.EventHandler(this.RetailerInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RetailerInvoiceCrystalReportViewer;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}