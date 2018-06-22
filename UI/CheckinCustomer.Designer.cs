﻿namespace hotel_managemnet_and_reservation_system.UI
{
    partial class CheckinCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerIdCB = new System.Windows.Forms.ComboBox();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkInDateTP = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reservedDaysTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.roomNumberCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.advanceTB = new System.Windows.Forms.TextBox();
            this.priceCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkInBT = new System.Windows.Forms.Button();
            this.closeBT = new System.Windows.Forms.Button();
            this.lastCheckInBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addressTB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.customerIdCB);
            this.panel2.Controls.Add(this.contactTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.genderCB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.customerNameTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 283);
            this.panel2.TabIndex = 13;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(127, 237);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(240, 20);
            this.addressTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // customerIdCB
            // 
            this.customerIdCB.FormattingEnabled = true;
            this.customerIdCB.Location = new System.Drawing.Point(127, 19);
            this.customerIdCB.Name = "customerIdCB";
            this.customerIdCB.Size = new System.Drawing.Size(240, 21);
            this.customerIdCB.TabIndex = 12;
            this.customerIdCB.SelectedIndexChanged += new System.EventHandler(this.customerIdCB_SelectedIndexChanged);
            // 
            // contactTB
            // 
            this.contactTB.Location = new System.Drawing.Point(127, 180);
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(240, 20);
            this.contactTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Number";
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(127, 121);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(240, 21);
            this.genderCB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(127, 73);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(240, 20);
            this.customerNameTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CheckIn Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CheckOut Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "No Of Days Reserved";
            // 
            // checkInDateTP
            // 
            this.checkInDateTP.CustomFormat = "yyyy-MM-dd";
            this.checkInDateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkInDateTP.Location = new System.Drawing.Point(145, 29);
            this.checkInDateTP.Name = "checkInDateTP";
            this.checkInDateTP.Size = new System.Drawing.Size(200, 20);
            this.checkInDateTP.TabIndex = 5;
            this.checkInDateTP.Value = new System.DateTime(2015, 12, 8, 12, 18, 57, 0);
            // 
            // checkOutDateTP
            // 
            this.checkOutDateTP.CustomFormat = "yyyy-MM-dd";
            this.checkOutDateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOutDateTP.Location = new System.Drawing.Point(145, 74);
            this.checkOutDateTP.Name = "checkOutDateTP";
            this.checkOutDateTP.Size = new System.Drawing.Size(200, 20);
            this.checkOutDateTP.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reservedDaysTB);
            this.groupBox2.Controls.Add(this.checkOutDateTP);
            this.groupBox2.Controls.Add(this.checkInDateTP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CheckIn Information";
            // 
            // reservedDaysTB
            // 
            this.reservedDaysTB.Location = new System.Drawing.Point(145, 114);
            this.reservedDaysTB.Name = "reservedDaysTB";
            this.reservedDaysTB.Size = new System.Drawing.Size(200, 20);
            this.reservedDaysTB.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.roomTypeCB);
            this.groupBox3.Controls.Add(this.roomNumberCB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(487, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Information";
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.roomTypeCB.Location = new System.Drawing.Point(139, 80);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(177, 21);
            this.roomTypeCB.TabIndex = 8;
            // 
            // roomNumberCB
            // 
            this.roomNumberCB.FormattingEnabled = true;
            this.roomNumberCB.Location = new System.Drawing.Point(139, 26);
            this.roomNumberCB.Name = "roomNumberCB";
            this.roomNumberCB.Size = new System.Drawing.Size(177, 21);
            this.roomNumberCB.TabIndex = 7;
            this.roomNumberCB.SelectedIndexChanged += new System.EventHandler(this.roomNumberCB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Room Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Room Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.advanceTB);
            this.groupBox4.Controls.Add(this.priceCB);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(487, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settlement";
            // 
            // advanceTB
            // 
            this.advanceTB.Location = new System.Drawing.Point(139, 79);
            this.advanceTB.Name = "advanceTB";
            this.advanceTB.Size = new System.Drawing.Size(177, 20);
            this.advanceTB.TabIndex = 11;
            // 
            // priceCB
            // 
            this.priceCB.FormattingEnabled = true;
            this.priceCB.Items.AddRange(new object[] {
            "2000",
            "1500"});
            this.priceCB.Location = new System.Drawing.Point(139, 26);
            this.priceCB.Name = "priceCB";
            this.priceCB.Size = new System.Drawing.Size(177, 21);
            this.priceCB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Advance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Price/Day";
            // 
            // checkInBT
            // 
            this.checkInBT.Location = new System.Drawing.Point(541, 409);
            this.checkInBT.Name = "checkInBT";
            this.checkInBT.Size = new System.Drawing.Size(107, 47);
            this.checkInBT.TabIndex = 4;
            this.checkInBT.Text = "CheckIn";
            this.checkInBT.UseVisualStyleBackColor = true;
            this.checkInBT.Click += new System.EventHandler(this.checkInBT_Click);
            // 
            // closeBT
            // 
            this.closeBT.Location = new System.Drawing.Point(723, 408);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(107, 47);
            this.closeBT.TabIndex = 5;
            this.closeBT.Text = "Close";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // lastCheckInBT
            // 
            this.lastCheckInBT.Location = new System.Drawing.Point(541, 477);
            this.lastCheckInBT.Name = "lastCheckInBT";
            this.lastCheckInBT.Size = new System.Drawing.Size(107, 47);
            this.lastCheckInBT.TabIndex = 6;
            this.lastCheckInBT.Text = "Last CheckIn";
            this.lastCheckInBT.UseVisualStyleBackColor = true;
            this.lastCheckInBT.Click += new System.EventHandler(this.lastCheckInBT_Click);
            // 
            // CheckinCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 585);
            this.Controls.Add(this.lastCheckInBT);
            this.Controls.Add(this.closeBT);
            this.Controls.Add(this.checkInBT);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckinCustomer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CheckinCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerIdCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker checkInDateTP;
        private System.Windows.Forms.DateTimePicker checkOutDateTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox reservedDaysTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.ComboBox roomNumberCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox advanceTB;
        private System.Windows.Forms.ComboBox priceCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button checkInBT;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button lastCheckInBT;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label5;
    }
}