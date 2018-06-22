namespace hotel_managemnet_and_reservation_system.UI
{
    partial class AddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerIdTB = new System.Windows.Forms.TextBox();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTB = new System.Windows.Forms.TextBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(71, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 43);
            this.panel1.TabIndex = 6;
            // 
            // customerIdTB
            // 
            this.customerIdTB.Enabled = false;
            this.customerIdTB.Location = new System.Drawing.Point(127, 22);
            this.customerIdTB.Name = "customerIdTB";
            this.customerIdTB.Size = new System.Drawing.Size(240, 20);
            this.customerIdTB.TabIndex = 7;
            // 
            // customerNameTB
            // 
            this.customerNameTB.Enabled = false;
            this.customerNameTB.Location = new System.Drawing.Point(127, 73);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(240, 20);
            this.customerNameTB.TabIndex = 8;
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
            // panel2
            // 
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
            this.panel2.Location = new System.Drawing.Point(38, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 410);
            this.panel2.TabIndex = 12;
            // 
            // closeBT
            // 
            this.closeBT.Location = new System.Drawing.Point(275, 317);
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
            this.saveBT.Location = new System.Drawing.Point(146, 317);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(92, 41);
            this.saveBT.TabIndex = 13;
            this.saveBT.Text = "Save Entry";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // addBT
            // 
            this.addBT.Location = new System.Drawing.Point(20, 317);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(92, 41);
            this.addBT.TabIndex = 12;
            this.addBT.Text = "Add Entry";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
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
            // contactTB
            // 
            this.contactTB.Enabled = false;
            this.contactTB.Location = new System.Drawing.Point(127, 168);
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(240, 20);
            this.contactTB.TabIndex = 16;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerIdTB;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.Label label5;
    }
}