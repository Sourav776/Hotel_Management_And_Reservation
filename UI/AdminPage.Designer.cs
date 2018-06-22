namespace hotel_managemnet_and_reservation_system.UI
{
    partial class AdminPage
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.manageUserBT = new System.Windows.Forms.Button();
            this.closeBT = new System.Windows.Forms.Button();
            this.roomManageBT = new System.Windows.Forms.Button();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(384, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 48);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "HOTEL SEA PARK";
            // 
            // manageUserBT
            // 
            this.manageUserBT.Location = new System.Drawing.Point(35, 109);
            this.manageUserBT.Name = "manageUserBT";
            this.manageUserBT.Size = new System.Drawing.Size(111, 54);
            this.manageUserBT.TabIndex = 0;
            this.manageUserBT.Text = "Manage User";
            this.manageUserBT.UseVisualStyleBackColor = true;
            this.manageUserBT.Click += new System.EventHandler(this.manageUserBT_Click);
            // 
            // closeBT
            // 
            this.closeBT.Location = new System.Drawing.Point(113, 263);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(136, 65);
            this.closeBT.TabIndex = 7;
            this.closeBT.Text = "Log Out";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // roomManageBT
            // 
            this.roomManageBT.Location = new System.Drawing.Point(227, 109);
            this.roomManageBT.Name = "roomManageBT";
            this.roomManageBT.Size = new System.Drawing.Size(111, 54);
            this.roomManageBT.TabIndex = 4;
            this.roomManageBT.Text = "Manage Rooms";
            this.roomManageBT.UseVisualStyleBackColor = true;
            this.roomManageBT.Click += new System.EventHandler(this.roomManageBT_Click);
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.informationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.informationPanel.Controls.Add(this.closeBT);
            this.informationPanel.Controls.Add(this.roomManageBT);
            this.informationPanel.Controls.Add(this.manageUserBT);
            this.informationPanel.Location = new System.Drawing.Point(17, 97);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(388, 433);
            this.informationPanel.TabIndex = 5;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel_managemnet_and_reservation_system.Properties.Resources.hotelmanagement;
            this.ClientSize = new System.Drawing.Size(906, 549);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.informationPanel);
            this.Name = "AdminPage";
            this.Text = "Hotel Management and Reservation System";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button manageUserBT;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button roomManageBT;
        private System.Windows.Forms.Panel informationPanel;

    }
}