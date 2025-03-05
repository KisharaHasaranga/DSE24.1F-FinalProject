namespace FinalProject
{
    partial class ManageAnnouncementForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BoxMessage = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.BoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPost = new ReaLTaiizor.Controls.ForeverButton();
            this.GridMessage = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage Announcement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.BtnPost);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(424, 684);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.BoxMessage);
            this.panel5.Controls.Add(this.BoxTitle);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 306);
            this.panel5.TabIndex = 9;
            // 
            // BoxMessage
            // 
            this.BoxMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.BoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BoxMessage.Hint = "";
            this.BoxMessage.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.BoxMessage.Location = new System.Drawing.Point(13, 123);
            this.BoxMessage.MaxLength = 32767;
            this.BoxMessage.Multiline = true;
            this.BoxMessage.Name = "BoxMessage";
            this.BoxMessage.PasswordChar = '\0';
            this.BoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxMessage.SelectedText = "";
            this.BoxMessage.SelectionLength = 0;
            this.BoxMessage.SelectionStart = 0;
            this.BoxMessage.Size = new System.Drawing.Size(380, 169);
            this.BoxMessage.TabIndex = 9;
            this.BoxMessage.TabStop = false;
            this.BoxMessage.UseSystemPasswordChar = false;
            // 
            // BoxTitle
            // 
            this.BoxTitle.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTitle.Location = new System.Drawing.Point(13, 50);
            this.BoxTitle.Name = "BoxTitle";
            this.BoxTitle.Size = new System.Drawing.Size(380, 30);
            this.BoxTitle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Title :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(424, 713);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 37);
            this.panel3.TabIndex = 14;
            // 
            // BtnPost
            // 
            this.BtnPost.BackColor = System.Drawing.Color.Transparent;
            this.BtnPost.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPost.Location = new System.Drawing.Point(324, 338);
            this.BtnPost.Name = "BtnPost";
            this.BtnPost.Rounded = false;
            this.BtnPost.Size = new System.Drawing.Size(90, 40);
            this.BtnPost.TabIndex = 7;
            this.BtnPost.Text = "Post";
            this.BtnPost.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnPost.Click += new System.EventHandler(this.BtnPost_Click);
            // 
            // GridMessage
            // 
            this.GridMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMessage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMessage.Location = new System.Drawing.Point(424, 66);
            this.GridMessage.Name = "GridMessage";
            this.GridMessage.Size = new System.Drawing.Size(801, 647);
            this.GridMessage.TabIndex = 15;
            // 
            // ManageAnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 750);
            this.Controls.Add(this.GridMessage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAnnouncementForm";
            this.Text = "ManageAnnouncementForm";
            this.Load += new System.EventHandler(this.ManageAnnouncementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.HopeRichTextBox BoxMessage;
        private System.Windows.Forms.TextBox BoxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton BtnPost;
        private System.Windows.Forms.DataGridView GridMessage;
    }
}