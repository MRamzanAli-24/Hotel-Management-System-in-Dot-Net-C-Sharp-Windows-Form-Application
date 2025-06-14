namespace Hotel_Management_System.UI
{
    partial class BookingUpdate
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
            TopPanel = new Panel();
            btn1 = new Button();
            txtCheckOutDate = new DateTimePicker();
            txtCheckInDate = new DateTimePicker();
            lbl7 = new Label();
            lbl6 = new Label();
            btn2 = new Button();
            txtRoomNo = new TextBox();
            lbl4 = new Label();
            lbl1 = new Label();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gray;
            TopPanel.Controls.Add(btn1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(624, 45);
            TopPanel.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.Cursor = Cursors.Hand;
            btn1.Dock = DockStyle.Right;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(575, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 45);
            btn1.TabIndex = 10;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.Location = new Point(291, 329);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.Size = new Size(275, 31);
            txtCheckOutDate.TabIndex = 60;
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.CalendarMonthBackground = SystemColors.Control;
            txtCheckInDate.Location = new Point(289, 286);
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.Size = new Size(277, 31);
            txtCheckInDate.TabIndex = 59;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl7.Location = new Point(54, 329);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(200, 28);
            lbl7.TabIndex = 58;
            lbl7.Text = "Check Out date";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl6.Location = new Point(54, 286);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(186, 28);
            lbl6.TabIndex = 57;
            lbl6.Text = "Check In Date";
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.Control;
            btn2.Location = new Point(291, 457);
            btn2.Name = "btn2";
            btn2.Size = new Size(164, 51);
            btn2.TabIndex = 55;
            btn2.Text = "Update";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // txtRoomNo
            // 
            txtRoomNo.BackColor = SystemColors.Control;
            txtRoomNo.Location = new Point(289, 246);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.ReadOnly = true;
            txtRoomNo.Size = new Size(277, 31);
            txtRoomNo.TabIndex = 53;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(54, 249);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(184, 28);
            lbl4.TabIndex = 52;
            lbl4.Text = "Room Number";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(166, 109);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(269, 38);
            lbl1.TabIndex = 61;
            lbl1.Text = "Update Booking";
            // 
            // UpdateBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 617);
            Controls.Add(lbl1);
            Controls.Add(txtCheckOutDate);
            Controls.Add(txtCheckInDate);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(btn2);
            Controls.Add(txtRoomNo);
            Controls.Add(lbl4);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateBookings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateBookings";
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Button btn1;
        private DateTimePicker txtCheckOutDate;
        private DateTimePicker txtCheckInDate;
        private Label lbl7;
        private Label lbl6;
        private Button btn2;
        private TextBox txtRoomNo;
        private Label lbl4;
        private Label lbl1;
    }
}