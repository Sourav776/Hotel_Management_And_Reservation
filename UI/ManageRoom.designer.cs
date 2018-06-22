namespace hotel_managemnet_and_reservation_system.UI
{
    partial class ManageRoom
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
            this.label3 = new System.Windows.Forms.Label();
            this.roomNumber1TB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pricePerDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomTypeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNumber2TB = new System.Windows.Forms.TextBox();
            this.closeBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.updateBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 46);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Room Number";
            // 
            // roomNumber1TB
            // 
            this.roomNumber1TB.Location = new System.Drawing.Point(168, 29);
            this.roomNumber1TB.Name = "roomNumber1TB";
            this.roomNumber1TB.Size = new System.Drawing.Size(207, 20);
            this.roomNumber1TB.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.roomNumber1TB);
            this.panel2.Location = new System.Drawing.Point(28, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 123);
            this.panel2.TabIndex = 12;
            // 
            // searchBT
            // 
            this.searchBT.Location = new System.Drawing.Point(168, 74);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(91, 32);
            this.searchBT.TabIndex = 5;
            this.searchBT.Text = "Search";
            this.searchBT.UseVisualStyleBackColor = true;
            this.searchBT.Click += new System.EventHandler(this.searchBT_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pricePerDay);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.roomTypeTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.roomNumber2TB);
            this.panel3.Location = new System.Drawing.Point(28, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 161);
            this.panel3.TabIndex = 13;
            // 
            // pricePerDay
            // 
            this.pricePerDay.Location = new System.Drawing.Point(168, 129);
            this.pricePerDay.Name = "pricePerDay";
            this.pricePerDay.Size = new System.Drawing.Size(207, 20);
            this.pricePerDay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price / Day";
            // 
            // roomTypeTB
            // 
            this.roomTypeTB.Location = new System.Drawing.Point(168, 85);
            this.roomTypeTB.Name = "roomTypeTB";
            this.roomTypeTB.Size = new System.Drawing.Size(207, 20);
            this.roomTypeTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room Number";
            // 
            // roomNumber2TB
            // 
            this.roomNumber2TB.Location = new System.Drawing.Point(168, 29);
            this.roomNumber2TB.Name = "roomNumber2TB";
            this.roomNumber2TB.Size = new System.Drawing.Size(207, 20);
            this.roomNumber2TB.TabIndex = 2;
            // 
            // closeBT
            // 
            this.closeBT.Location = new System.Drawing.Point(312, 512);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(91, 32);
            this.closeBT.TabIndex = 17;
            this.closeBT.Text = "CLOSE";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Location = new System.Drawing.Point(312, 455);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(91, 32);
            this.deleteBT.TabIndex = 16;
            this.deleteBT.Text = "DELETE";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // updateBT
            // 
            this.updateBT.Location = new System.Drawing.Point(171, 455);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(91, 32);
            this.updateBT.TabIndex = 15;
            this.updateBT.Text = "UPDATE";
            this.updateBT.UseVisualStyleBackColor = true;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // addBT
            // 
            this.addBT.Location = new System.Drawing.Point(28, 455);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(91, 32);
            this.addBT.TabIndex = 14;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // ManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.closeBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.addBT);
            this.Name = "ManageRoom";
            this.Text = "ManageRoom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomNumber1TB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchBT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox roomTypeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomNumber2TB;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button updateBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.TextBox pricePerDay;
        private System.Windows.Forms.Label label5;
    }
}