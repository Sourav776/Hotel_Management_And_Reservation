namespace hotel_managemnet_and_reservation_system.UI
{
    partial class Food_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food_Report));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backKBT = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showBT = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.DocumentMapWidth = 30;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "hotel_managemnet_and_reservation_system.UI.Food_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(623, 435);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // backKBT
            // 
            this.backKBT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.backKBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backKBT.Location = new System.Drawing.Point(175, 547);
            this.backKBT.Name = "backKBT";
            this.backKBT.Size = new System.Drawing.Size(110, 45);
            this.backKBT.TabIndex = 7;
            this.backKBT.Text = "BACK";
            this.backKBT.UseVisualStyleBackColor = false;
            this.backKBT.Click += new System.EventHandler(this.backKBT_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(-5, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(644, 76);
            this.panel7.TabIndex = 8;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(76, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "FOOD BILL";
            // 
            // showBT
            // 
            this.showBT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.showBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBT.Location = new System.Drawing.Point(333, 548);
            this.showBT.Name = "showBT";
            this.showBT.Size = new System.Drawing.Size(110, 45);
            this.showBT.TabIndex = 9;
            this.showBT.Text = "SHOW";
            this.showBT.UseVisualStyleBackColor = false;
            this.showBT.Click += new System.EventHandler(this.showBT_Click);
            // 
            // Food_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 604);
            this.Controls.Add(this.showBT);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.backKBT);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Food_Report";
            this.Text = "Food_Report";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button backKBT;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showBT;
    }
}