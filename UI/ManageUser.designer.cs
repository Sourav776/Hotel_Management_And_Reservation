namespace hotel_managemnet_and_reservation_system.UI
{
    partial class ManageUser
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
            this.userName1TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName2TB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            this.updateBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.closeBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(90, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage User";
            // 
            // userName1TB
            // 
            this.userName1TB.Location = new System.Drawing.Point(168, 29);
            this.userName1TB.Name = "userName1TB";
            this.userName1TB.Size = new System.Drawing.Size(207, 20);
            this.userName1TB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter User Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.userName1TB);
            this.panel2.Location = new System.Drawing.Point(25, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 123);
            this.panel2.TabIndex = 5;
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
            this.panel3.Controls.Add(this.passwordTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.userName2TB);
            this.panel3.Location = new System.Drawing.Point(25, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 144);
            this.panel3.TabIndex = 6;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(168, 92);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(207, 20);
            this.passwordTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Passowrd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = " User Name";
            // 
            // userName2TB
            // 
            this.userName2TB.Location = new System.Drawing.Point(168, 29);
            this.userName2TB.Name = "userName2TB";
            this.userName2TB.Size = new System.Drawing.Size(207, 20);
            this.userName2TB.TabIndex = 2;
            // 
            // addBT
            // 
            this.addBT.Location = new System.Drawing.Point(25, 448);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(91, 32);
            this.addBT.TabIndex = 7;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // updateBT
            // 
            this.updateBT.Location = new System.Drawing.Point(168, 448);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(91, 32);
            this.updateBT.TabIndex = 8;
            this.updateBT.Text = "UPDATE";
            this.updateBT.UseVisualStyleBackColor = true;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Location = new System.Drawing.Point(309, 448);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(91, 32);
            this.deleteBT.TabIndex = 9;
            this.deleteBT.Text = "DELETE";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // closeBT
            // 
            this.closeBT.Location = new System.Drawing.Point(309, 505);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(91, 32);
            this.closeBT.TabIndex = 10;
            this.closeBT.Text = "CLOSE";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 562);
            this.Controls.Add(this.closeBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageUser";
            this.Text = "AddUser";
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
        private System.Windows.Forms.TextBox userName1TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchBT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName2TB;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Button updateBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button closeBT;
    }
}