namespace hotel_managemnet_and_reservation_system.UI
{
    partial class ViewRoomDetails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNoLB = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.contactLB = new System.Windows.Forms.Label();
            this.sexLB = new System.Windows.Forms.Label();
            this.cnameLB = new System.Windows.Forms.Label();
            this.roomLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.departureLB = new System.Windows.Forms.Label();
            this.arrivalLB = new System.Windows.Forms.Label();
            this.durationLB = new System.Windows.Forms.Label();
            this.addressLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(187, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.roomNoLB);
            this.panel2.Location = new System.Drawing.Point(23, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 386);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // roomNoLB
            // 
            this.roomNoLB.FormattingEnabled = true;
            this.roomNoLB.Location = new System.Drawing.Point(14, 36);
            this.roomNoLB.Name = "roomNoLB";
            this.roomNoLB.Size = new System.Drawing.Size(120, 329);
            this.roomNoLB.TabIndex = 0;
            this.roomNoLB.SelectedIndexChanged += new System.EventHandler(this.roomNoLB_SelectedItemChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.53216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.46783F));
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.contactLB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sexLB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cnameLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomLB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.departureLB, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.arrivalLB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.durationLB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.addressLB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(244, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 373);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Duration";
            // 
            // contactLB
            // 
            this.contactLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactLB.AutoSize = true;
            this.contactLB.Location = new System.Drawing.Point(221, 133);
            this.contactLB.Name = "contactLB";
            this.contactLB.Size = new System.Drawing.Size(0, 13);
            this.contactLB.TabIndex = 11;
            // 
            // sexLB
            // 
            this.sexLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexLB.AutoSize = true;
            this.sexLB.Location = new System.Drawing.Point(221, 85);
            this.sexLB.Name = "sexLB";
            this.sexLB.Size = new System.Drawing.Size(0, 13);
            this.sexLB.TabIndex = 10;
            // 
            // cnameLB
            // 
            this.cnameLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnameLB.AutoSize = true;
            this.cnameLB.Location = new System.Drawing.Point(221, 47);
            this.cnameLB.Name = "cnameLB";
            this.cnameLB.Size = new System.Drawing.Size(0, 13);
            this.cnameLB.TabIndex = 9;
            // 
            // roomLB
            // 
            this.roomLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomLB.AutoSize = true;
            this.roomLB.Location = new System.Drawing.Point(221, 12);
            this.roomLB.Name = "roomLB";
            this.roomLB.Size = new System.Drawing.Size(0, 13);
            this.roomLB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contact No";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Arrival Date";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Departure Date";
            // 
            // departureLB
            // 
            this.departureLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departureLB.AutoSize = true;
            this.departureLB.Location = new System.Drawing.Point(221, 298);
            this.departureLB.Name = "departureLB";
            this.departureLB.Size = new System.Drawing.Size(0, 13);
            this.departureLB.TabIndex = 13;
            // 
            // arrivalLB
            // 
            this.arrivalLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalLB.AutoSize = true;
            this.arrivalLB.Location = new System.Drawing.Point(221, 246);
            this.arrivalLB.Name = "arrivalLB";
            this.arrivalLB.Size = new System.Drawing.Size(0, 13);
            this.arrivalLB.TabIndex = 12;
            // 
            // durationLB
            // 
            this.durationLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationLB.AutoSize = true;
            this.durationLB.Location = new System.Drawing.Point(221, 344);
            this.durationLB.Name = "durationLB";
            this.durationLB.Size = new System.Drawing.Size(0, 13);
            this.durationLB.TabIndex = 15;
            // 
            // addressLB
            // 
            this.addressLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLB.AutoSize = true;
            this.addressLB.Location = new System.Drawing.Point(221, 189);
            this.addressLB.Name = "addressLB";
            this.addressLB.Size = new System.Drawing.Size(0, 13);
            this.addressLB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewRoomDetails";
            this.Text = "ViewRoomDetails";
            this.Load += new System.EventHandler(this.ViewRoomDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox roomNoLB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label contactLB;
        private System.Windows.Forms.Label sexLB;
        private System.Windows.Forms.Label cnameLB;
        private System.Windows.Forms.Label roomLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label departureLB;
        private System.Windows.Forms.Label arrivalLB;
        private System.Windows.Forms.Label durationLB;
        private System.Windows.Forms.Label addressLB;
    }
}