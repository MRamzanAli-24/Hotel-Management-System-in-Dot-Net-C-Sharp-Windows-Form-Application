namespace Hotel_Management_System.UI
{
    partial class CustomerDashboard
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
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            SidePanel = new Panel();
            btn5 = new Button();
            btn10 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            MainPanel = new Panel();
            btn8 = new Button();
            TopPanel.SuspendLayout();
            SidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gray;
            TopPanel.Controls.Add(btn3);
            TopPanel.Controls.Add(btn2);
            TopPanel.Controls.Add(btn1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1436, 45);
            TopPanel.TabIndex = 0;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.BackgroundImage = Properties.Resources.icons8_minus_24;
            btn3.BackgroundImageLayout = ImageLayout.Center;
            btn3.Cursor = Cursors.Hand;
            btn3.Dock = DockStyle.Right;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(1289, 0);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 45);
            btn3.TabIndex = 11;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click_1;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.BackgroundImage = Properties.Resources.icons8_maximize_window_50;
            btn2.BackgroundImageLayout = ImageLayout.Zoom;
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Right;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(1338, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 45);
            btn2.TabIndex = 10;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.Cursor = Cursors.Hand;
            btn1.Dock = DockStyle.Right;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(1387, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 45);
            btn1.TabIndex = 9;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Gray;
            SidePanel.Controls.Add(btn8);
            SidePanel.Controls.Add(btn5);
            SidePanel.Controls.Add(btn10);
            SidePanel.Controls.Add(btn9);
            SidePanel.Controls.Add(btn7);
            SidePanel.Controls.Add(btn6);
            SidePanel.Controls.Add(btn4);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 45);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(339, 700);
            SidePanel.TabIndex = 1;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.Cursor = Cursors.Hand;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.Control;
            btn5.Location = new Point(43, 203);
            btn5.Name = "btn5";
            btn5.Size = new Size(247, 58);
            btn5.TabIndex = 14;
            btn5.Text = "Add Booking";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn10
            // 
            btn10.BackColor = Color.Gray;
            btn10.Cursor = Cursors.Hand;
            btn10.FlatStyle = FlatStyle.Popup;
            btn10.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn10.ForeColor = SystemColors.Control;
            btn10.Location = new Point(43, 523);
            btn10.Name = "btn10";
            btn10.Size = new Size(247, 58);
            btn10.TabIndex = 19;
            btn10.Text = "Log Out";
            btn10.UseVisualStyleBackColor = false;
            btn10.Click += btn10_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.Cursor = Cursors.Hand;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.Control;
            btn9.Location = new Point(43, 459);
            btn9.Name = "btn9";
            btn9.Size = new Size(247, 58);
            btn9.TabIndex = 18;
            btn9.Text = "Feedback";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.Cursor = Cursors.Hand;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.Control;
            btn7.Location = new Point(43, 331);
            btn7.Name = "btn7";
            btn7.Size = new Size(247, 58);
            btn7.TabIndex = 16;
            btn7.Text = "Add Orders";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.Cursor = Cursors.Hand;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.Control;
            btn6.Location = new Point(43, 267);
            btn6.Name = "btn6";
            btn6.Size = new Size(247, 58);
            btn6.TabIndex = 15;
            btn6.Text = "View Booking";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.Cursor = Cursors.Hand;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.Control;
            btn4.Location = new Point(43, 139);
            btn4.Name = "btn4";
            btn4.Size = new Size(247, 58);
            btn4.TabIndex = 13;
            btn4.Text = "Home";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(339, 45);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1097, 700);
            MainPanel.TabIndex = 2;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.Cursor = Cursors.Hand;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.Control;
            btn8.Location = new Point(43, 395);
            btn8.Name = "btn8";
            btn8.Size = new Size(247, 58);
            btn8.TabIndex = 20;
            btn8.Text = "View Orders";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += button1_Click;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 745);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            WindowState = FormWindowState.Maximized;
            Load += CustomerDashboard_Load;
            TopPanel.ResumeLayout(false);
            SidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel SidePanel;
        private Panel MainPanel;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn4;
        private Button btn5;
        private Button btn10;
        private Button btn9;
        private Button btn7;
        private Button btn6;
        private Button btn8;
    }
}