namespace hotel_managemnet_and_reservation_system.UI
{
    partial class myHelp
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
            this.informationPanel = new System.Windows.Forms.Panel();
            this.closeBT = new System.Windows.Forms.Button();
            this.calculatorBT = new System.Windows.Forms.Button();
            this.checkBookinBT = new System.Windows.Forms.Button();
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.informationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.informationPanel.Controls.Add(this.closeBT);
            this.informationPanel.Controls.Add(this.calculatorBT);
            this.informationPanel.Controls.Add(this.checkBookinBT);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationPanel.Location = new System.Drawing.Point(0, 0);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(441, 447);
            this.informationPanel.TabIndex = 2;
            this.informationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.informationPanel_Paint);
            // 
            // closeBT
            // 
            this.closeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.closeBT.Location = new System.Drawing.Point(101, 314);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(240, 85);
            this.closeBT.TabIndex = 7;
            this.closeBT.Text = "Close";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // calculatorBT
            // 
            this.calculatorBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.calculatorBT.Location = new System.Drawing.Point(101, 176);
            this.calculatorBT.Name = "calculatorBT";
            this.calculatorBT.Size = new System.Drawing.Size(240, 85);
            this.calculatorBT.TabIndex = 1;
            this.calculatorBT.Text = "Calculator";
            this.calculatorBT.UseVisualStyleBackColor = true;
            this.calculatorBT.Click += new System.EventHandler(this.checkInBT_Click);
            // 
            // checkBookinBT
            // 
            this.checkBookinBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBookinBT.Location = new System.Drawing.Point(101, 41);
            this.checkBookinBT.Name = "checkBookinBT";
            this.checkBookinBT.Size = new System.Drawing.Size(240, 85);
            this.checkBookinBT.TabIndex = 0;
            this.checkBookinBT.Text = "Check Bookin";
            this.checkBookinBT.UseVisualStyleBackColor = true;
            this.checkBookinBT.Click += new System.EventHandler(this.addCustomerBT_Click);
            // 
            // myHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 447);
            this.Controls.Add(this.informationPanel);
            this.Name = "myHelp";
            this.Text = "Help";
            this.informationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button calculatorBT;
        private System.Windows.Forms.Button checkBookinBT;

    }
}