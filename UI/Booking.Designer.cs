namespace hotel_managemnet_and_reservation_system.UI
{
    partial class Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerIdTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closeBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.reservedDaysTB = new System.Windows.Forms.TextBox();
            this.checkOutDateTP = new System.Windows.Forms.DateTimePicker();
            this.checkInDateTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookInDateTP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Customer Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(68, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 43);
            this.panel1.TabIndex = 13;
            // 
            // customerIdTB
            // 
            this.customerIdTB.Enabled = false;
            this.customerIdTB.Location = new System.Drawing.Point(127, 22);
            this.customerIdTB.Name = "customerIdTB";
            this.customerIdTB.Size = new System.Drawing.Size(240, 20);
            this.customerIdTB.TabIndex = 7;
            // 
            // addressTB
            // 
            this.addressTB.Enabled = false;
            this.addressTB.Location = new System.Drawing.Point(127, 216);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(240, 20);
            this.addressTB.TabIndex = 10;
            // 
            // genderCB
            // 
            this.genderCB.Enabled = false;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCB.Location = new System.Drawing.Point(127, 121);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(240, 21);
            this.genderCB.TabIndex = 11;
            // 
            // customerNameTB
            // 
            this.customerNameTB.Enabled = false;
            this.customerNameTB.Location = new System.Drawing.Point(127, 73);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(240, 20);
            this.customerNameTB.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bookInDateTP);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.reservedDaysTB);
            this.panel2.Controls.Add(this.checkOutDateTP);
            this.panel2.Controls.Add(this.checkInDateTP);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.contactTB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.closeBT);
            this.panel2.Controls.Add(this.saveBT);
            this.panel2.Controls.Add(this.addBT);
            this.panel2.Controls.Add(this.customerIdTB);
            this.panel2.Controls.Add(this.addressTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.genderCB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.customerNameTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(35, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 494);
            this.panel2.TabIndex = 14;
            // 
            // contactTB
            // 
            this.contactTB.Enabled = false;
            this.contactTB.Location = new System.Drawing.Point(127, 168);
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(240, 20);
            this.contactTB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Number";
            // 
            // closeBT
            // 
            this.closeBT.Location = new System.Drawing.Point(276, 431);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(92, 41);
            this.closeBT.TabIndex = 14;
            this.closeBT.Text = "Close";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.Enabled = false;
            this.saveBT.Location = new System.Drawing.Point(147, 431);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(92, 41);
            this.saveBT.TabIndex = 13;
            this.saveBT.Text = "Save Entry";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // addBT
            // 
            this.addBT.Location = new System.Drawing.Point(8, 431);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(92, 41);
            this.addBT.TabIndex = 12;
            this.addBT.Text = "Add Entry";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // reservedDaysTB
            // 
            this.reservedDaysTB.Location = new System.Drawing.Point(128, 384);
            this.reservedDaysTB.Name = "reservedDaysTB";
            this.reservedDaysTB.Size = new System.Drawing.Size(240, 20);
            this.reservedDaysTB.TabIndex = 22;
            // 
            // checkOutDateTP
            // 
            this.checkOutDateTP.CustomFormat = "yyyy-MM-dd";
            this.checkOutDateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOutDateTP.Location = new System.Drawing.Point(128, 344);
            this.checkOutDateTP.Name = "checkOutDateTP";
            this.checkOutDateTP.Size = new System.Drawing.Size(240, 20);
            this.checkOutDateTP.TabIndex = 21;
            // 
            // checkInDateTP
            // 
            this.checkInDateTP.CustomFormat = "yyyy-MM-dd";
            this.checkInDateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkInDateTP.Location = new System.Drawing.Point(128, 299);
            this.checkInDateTP.Name = "checkInDateTP";
            this.checkInDateTP.Size = new System.Drawing.Size(240, 20);
            this.checkInDateTP.TabIndex = 20;
            this.checkInDateTP.Value = new System.DateTime(2015, 12, 8, 12, 18, 57, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "No Of Days Reserved";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "CheckOut Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "CheckIn Date";
            // 
            // bookInDateTP
            // 
            this.bookInDateTP.CustomFormat = "yyyy-MM-dd";
            this.bookInDateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookInDateTP.Location = new System.Drawing.Point(128, 256);
            this.bookInDateTP.Name = "bookInDateTP";
            this.bookInDateTP.Size = new System.Drawing.Size(240, 20);
            this.bookInDateTP.TabIndex = 24;
            this.bookInDateTP.Value = new System.DateTime(2015, 12, 8, 12, 18, 57, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "BookIn Date";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Booking";
            this.Text = "Bookin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerIdTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.TextBox reservedDaysTB;
        private System.Windows.Forms.DateTimePicker checkOutDateTP;
        private System.Windows.Forms.DateTimePicker checkInDateTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker bookInDateTP;
        private System.Windows.Forms.Label label10;
    }
}