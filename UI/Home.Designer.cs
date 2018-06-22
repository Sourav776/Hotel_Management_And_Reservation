namespace hotel_managemnet_and_reservation_system
{
    partial class Home
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
            this.helpBT = new System.Windows.Forms.Button();
            this.exitBT = new System.Windows.Forms.Button();
            this.foodMenuBT = new System.Windows.Forms.Button();
            this.viewRoomBT = new System.Windows.Forms.Button();
            this.checkOutBT = new System.Windows.Forms.Button();
            this.bookingBT = new System.Windows.Forms.Button();
            this.checkInBT = new System.Windows.Forms.Button();
            this.addCustomerBT = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userRB = new System.Windows.Forms.RadioButton();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.quitBT = new System.Windows.Forms.Button();
            this.loginBT = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.informationPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.informationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.informationPanel.Controls.Add(this.helpBT);
            this.informationPanel.Controls.Add(this.exitBT);
            this.informationPanel.Controls.Add(this.foodMenuBT);
            this.informationPanel.Controls.Add(this.viewRoomBT);
            this.informationPanel.Controls.Add(this.checkOutBT);
            this.informationPanel.Controls.Add(this.bookingBT);
            this.informationPanel.Controls.Add(this.checkInBT);
            this.informationPanel.Controls.Add(this.addCustomerBT);
            this.informationPanel.Enabled = false;
            this.informationPanel.Location = new System.Drawing.Point(12, 90);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(388, 433);
            this.informationPanel.TabIndex = 1;
            this.informationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.informationPanel_Paint);
            // 
            // helpBT
            // 
            this.helpBT.Location = new System.Drawing.Point(35, 319);
            this.helpBT.Name = "helpBT";
            this.helpBT.Size = new System.Drawing.Size(111, 54);
            this.helpBT.TabIndex = 8;
            this.helpBT.Text = "Help";
            this.helpBT.UseVisualStyleBackColor = true;
            this.helpBT.Click += new System.EventHandler(this.helpBT_Click);
            // 
            // exitBT
            // 
            this.exitBT.Location = new System.Drawing.Point(219, 319);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(111, 54);
            this.exitBT.TabIndex = 7;
            this.exitBT.Text = "Exit";
            this.exitBT.UseVisualStyleBackColor = true;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // foodMenuBT
            // 
            this.foodMenuBT.Location = new System.Drawing.Point(219, 233);
            this.foodMenuBT.Name = "foodMenuBT";
            this.foodMenuBT.Size = new System.Drawing.Size(111, 54);
            this.foodMenuBT.TabIndex = 5;
            this.foodMenuBT.Text = "Food Menu";
            this.foodMenuBT.UseVisualStyleBackColor = true;
            this.foodMenuBT.Click += new System.EventHandler(this.foodMenuBT_Click);
            // 
            // viewRoomBT
            // 
            this.viewRoomBT.Location = new System.Drawing.Point(35, 233);
            this.viewRoomBT.Name = "viewRoomBT";
            this.viewRoomBT.Size = new System.Drawing.Size(111, 54);
            this.viewRoomBT.TabIndex = 4;
            this.viewRoomBT.Text = "View All Rooms";
            this.viewRoomBT.UseVisualStyleBackColor = true;
            this.viewRoomBT.Click += new System.EventHandler(this.viewRoomBT_Click);
            // 
            // checkOutBT
            // 
            this.checkOutBT.Location = new System.Drawing.Point(219, 144);
            this.checkOutBT.Name = "checkOutBT";
            this.checkOutBT.Size = new System.Drawing.Size(111, 54);
            this.checkOutBT.TabIndex = 3;
            this.checkOutBT.Text = "Check Out";
            this.checkOutBT.UseVisualStyleBackColor = true;
            this.checkOutBT.Click += new System.EventHandler(this.checkOutBT_Click);
            // 
            // bookingBT
            // 
            this.bookingBT.Location = new System.Drawing.Point(35, 144);
            this.bookingBT.Name = "bookingBT";
            this.bookingBT.Size = new System.Drawing.Size(111, 54);
            this.bookingBT.TabIndex = 2;
            this.bookingBT.Text = "Booking";
            this.bookingBT.UseVisualStyleBackColor = true;
            this.bookingBT.Click += new System.EventHandler(this.bookingBT_Click);
            // 
            // checkInBT
            // 
            this.checkInBT.Location = new System.Drawing.Point(219, 51);
            this.checkInBT.Name = "checkInBT";
            this.checkInBT.Size = new System.Drawing.Size(111, 54);
            this.checkInBT.TabIndex = 1;
            this.checkInBT.Text = "Check In";
            this.checkInBT.UseVisualStyleBackColor = true;
            this.checkInBT.Click += new System.EventHandler(this.checkInBT_Click);
            // 
            // addCustomerBT
            // 
            this.addCustomerBT.Location = new System.Drawing.Point(35, 51);
            this.addCustomerBT.Name = "addCustomerBT";
            this.addCustomerBT.Size = new System.Drawing.Size(111, 54);
            this.addCustomerBT.TabIndex = 0;
            this.addCustomerBT.Text = "Add Customer";
            this.addCustomerBT.UseVisualStyleBackColor = true;
            this.addCustomerBT.Click += new System.EventHandler(this.addCustomerBT_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPanel.Controls.Add(this.userRB);
            this.loginPanel.Controls.Add(this.adminRB);
            this.loginPanel.Controls.Add(this.quitBT);
            this.loginPanel.Controls.Add(this.loginBT);
            this.loginPanel.Controls.Add(this.passwordTB);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.userNameTB);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.panel3);
            this.loginPanel.Location = new System.Drawing.Point(479, 90);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Padding = new System.Windows.Forms.Padding(1);
            this.loginPanel.Size = new System.Drawing.Size(405, 364);
            this.loginPanel.TabIndex = 2;
            // 
            // userRB
            // 
            this.userRB.AutoSize = true;
            this.userRB.Location = new System.Drawing.Point(236, 231);
            this.userRB.Name = "userRB";
            this.userRB.Size = new System.Drawing.Size(47, 17);
            this.userRB.TabIndex = 8;
            this.userRB.TabStop = true;
            this.userRB.Text = "User";
            this.userRB.UseVisualStyleBackColor = true;
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Location = new System.Drawing.Point(108, 231);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(54, 17);
            this.adminRB.TabIndex = 7;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = true;
            // 
            // quitBT
            // 
            this.quitBT.Location = new System.Drawing.Point(246, 282);
            this.quitBT.Name = "quitBT";
            this.quitBT.Size = new System.Drawing.Size(75, 23);
            this.quitBT.TabIndex = 6;
            this.quitBT.Text = "Quit";
            this.quitBT.UseVisualStyleBackColor = true;
            this.quitBT.Click += new System.EventHandler(this.quitBT_Click);
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(108, 282);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(75, 23);
            this.loginBT.TabIndex = 5;
            this.loginBT.Text = "Login";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(108, 177);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(229, 20);
            this.passwordTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(108, 125);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(229, 20);
            this.userNameTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::hotel_managemnet_and_reservation_system.Properties.Resources.human;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 100);
            this.panel3.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(379, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 48);
            this.panel4.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel_managemnet_and_reservation_system.Properties.Resources.hotelmanagement;
            this.ClientSize = new System.Drawing.Size(906, 549);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.informationPanel);
            this.Name = "Home";
            this.Text = "Hotel Management and Reservation System";
            this.informationPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Button foodMenuBT;
        private System.Windows.Forms.Button viewRoomBT;
        private System.Windows.Forms.Button checkOutBT;
        private System.Windows.Forms.Button bookingBT;
        private System.Windows.Forms.Button checkInBT;
        private System.Windows.Forms.Button addCustomerBT;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button quitBT;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button helpBT;
        private System.Windows.Forms.Button exitBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton userRB;
        private System.Windows.Forms.RadioButton adminRB;
        private System.Windows.Forms.Panel panel4;
    }
}

