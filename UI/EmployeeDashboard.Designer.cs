namespace Hotel_Management_System.UI
{
    partial class EmployeeDashboard
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
            OrderPanel = new Panel();
            btn15 = new Button();
            LogoutPanel = new Panel();
            btn18 = new Button();
            ItemPanel = new Panel();
            btn14 = new Button();
            btn13 = new Button();
            btn12 = new Button();
            BookingPanel = new Panel();
            btn10 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            CustomerPanel = new Panel();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            MainPanel = new Panel();
            TopPanel.SuspendLayout();
            SidePanel.SuspendLayout();
            OrderPanel.SuspendLayout();
            LogoutPanel.SuspendLayout();
            ItemPanel.SuspendLayout();
            BookingPanel.SuspendLayout();
            CustomerPanel.SuspendLayout();
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
            TopPanel.Size = new Size(1489, 45);
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
            btn3.Location = new Point(1342, 0);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 45);
            btn3.TabIndex = 11;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
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
            btn2.Location = new Point(1391, 0);
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
            btn1.Location = new Point(1440, 0);
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
            SidePanel.Controls.Add(BookingPanel);
            SidePanel.Controls.Add(OrderPanel);
            SidePanel.Controls.Add(LogoutPanel);
            SidePanel.Controls.Add(ItemPanel);
            SidePanel.Controls.Add(CustomerPanel);
            SidePanel.Controls.Add(btn4);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 45);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(339, 935);
            SidePanel.TabIndex = 1;
            // 
            // OrderPanel
            // 
            OrderPanel.Controls.Add(btn15);
            OrderPanel.Location = new Point(43, 399);
            OrderPanel.MinimumSize = new Size(247, 60);
            OrderPanel.Name = "OrderPanel";
            OrderPanel.Size = new Size(247, 60);
            OrderPanel.TabIndex = 7;
            // 
            // btn15
            // 
            btn15.BackColor = Color.Gray;
            btn15.Cursor = Cursors.Hand;
            btn15.Dock = DockStyle.Top;
            btn15.FlatStyle = FlatStyle.Popup;
            btn15.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn15.ForeColor = SystemColors.Control;
            btn15.Location = new Point(0, 0);
            btn15.Name = "btn15";
            btn15.Size = new Size(247, 58);
            btn15.TabIndex = 2;
            btn15.Text = "Manage Orders";
            btn15.UseVisualStyleBackColor = false;
            btn15.Click += btn15_Click;
            // 
            // LogoutPanel
            // 
            LogoutPanel.Controls.Add(btn18);
            LogoutPanel.Location = new Point(43, 467);
            LogoutPanel.MaximumSize = new Size(247, 60);
            LogoutPanel.MinimumSize = new Size(247, 60);
            LogoutPanel.Name = "LogoutPanel";
            LogoutPanel.Size = new Size(247, 60);
            LogoutPanel.TabIndex = 8;
            // 
            // btn18
            // 
            btn18.BackColor = Color.Gray;
            btn18.Cursor = Cursors.Hand;
            btn18.Dock = DockStyle.Top;
            btn18.FlatStyle = FlatStyle.Popup;
            btn18.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn18.ForeColor = SystemColors.Control;
            btn18.Location = new Point(0, 0);
            btn18.Name = "btn18";
            btn18.Size = new Size(247, 58);
            btn18.TabIndex = 2;
            btn18.Text = "Log Out";
            btn18.UseVisualStyleBackColor = false;
            btn18.Click += btn18_Click;
            // 
            // ItemPanel
            // 
            ItemPanel.Controls.Add(btn14);
            ItemPanel.Controls.Add(btn13);
            ItemPanel.Controls.Add(btn12);
            ItemPanel.Location = new Point(43, 335);
            ItemPanel.MaximumSize = new Size(247, 173);
            ItemPanel.MinimumSize = new Size(247, 60);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(247, 60);
            ItemPanel.TabIndex = 6;
            // 
            // btn14
            // 
            btn14.BackColor = Color.Gray;
            btn14.Cursor = Cursors.Hand;
            btn14.Dock = DockStyle.Top;
            btn14.FlatStyle = FlatStyle.Popup;
            btn14.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn14.ForeColor = SystemColors.Control;
            btn14.Location = new Point(0, 116);
            btn14.Name = "btn14";
            btn14.Size = new Size(247, 58);
            btn14.TabIndex = 4;
            btn14.Text = "View";
            btn14.UseVisualStyleBackColor = false;
            btn14.Click += btn14_Click;
            // 
            // btn13
            // 
            btn13.BackColor = Color.Gray;
            btn13.Cursor = Cursors.Hand;
            btn13.Dock = DockStyle.Top;
            btn13.FlatStyle = FlatStyle.Popup;
            btn13.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn13.ForeColor = SystemColors.Control;
            btn13.Location = new Point(0, 58);
            btn13.Name = "btn13";
            btn13.Size = new Size(247, 58);
            btn13.TabIndex = 3;
            btn13.Text = "Add";
            btn13.UseVisualStyleBackColor = false;
            btn13.Click += btn13_Click;
            // 
            // btn12
            // 
            btn12.BackColor = Color.Gray;
            btn12.Cursor = Cursors.Hand;
            btn12.Dock = DockStyle.Top;
            btn12.FlatStyle = FlatStyle.Popup;
            btn12.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn12.ForeColor = SystemColors.Control;
            btn12.Location = new Point(0, 0);
            btn12.Name = "btn12";
            btn12.Size = new Size(247, 58);
            btn12.TabIndex = 2;
            btn12.Text = "Manage Items";
            btn12.UseVisualStyleBackColor = false;
            btn12.Click += btn12_Click;
            // 
            // BookingPanel
            // 
            BookingPanel.Controls.Add(btn10);
            BookingPanel.Controls.Add(btn9);
            BookingPanel.Controls.Add(btn8);
            BookingPanel.Location = new Point(43, 267);
            BookingPanel.MaximumSize = new Size(247, 174);
            BookingPanel.MinimumSize = new Size(247, 60);
            BookingPanel.Name = "BookingPanel";
            BookingPanel.Size = new Size(247, 60);
            BookingPanel.TabIndex = 5;
            // 
            // btn10
            // 
            btn10.BackColor = Color.Gray;
            btn10.Cursor = Cursors.Hand;
            btn10.Dock = DockStyle.Top;
            btn10.FlatStyle = FlatStyle.Popup;
            btn10.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn10.ForeColor = SystemColors.Control;
            btn10.Location = new Point(0, 116);
            btn10.Name = "btn10";
            btn10.Size = new Size(247, 58);
            btn10.TabIndex = 4;
            btn10.Text = "View";
            btn10.UseVisualStyleBackColor = false;
            btn10.Click += btn10_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.Cursor = Cursors.Hand;
            btn9.Dock = DockStyle.Top;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.Control;
            btn9.Location = new Point(0, 58);
            btn9.Name = "btn9";
            btn9.Size = new Size(247, 58);
            btn9.TabIndex = 3;
            btn9.Text = "Add";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.Cursor = Cursors.Hand;
            btn8.Dock = DockStyle.Top;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.Control;
            btn8.Location = new Point(0, 0);
            btn8.Name = "btn8";
            btn8.Size = new Size(247, 58);
            btn8.TabIndex = 2;
            btn8.Text = "Manage Booking";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // CustomerPanel
            // 
            CustomerPanel.Controls.Add(btn7);
            CustomerPanel.Controls.Add(btn6);
            CustomerPanel.Controls.Add(btn5);
            CustomerPanel.Location = new Point(43, 203);
            CustomerPanel.MaximumSize = new Size(247, 176);
            CustomerPanel.MinimumSize = new Size(247, 60);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(247, 60);
            CustomerPanel.TabIndex = 5;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.Cursor = Cursors.Hand;
            btn7.Dock = DockStyle.Top;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.Control;
            btn7.Location = new Point(0, 116);
            btn7.Name = "btn7";
            btn7.Size = new Size(247, 60);
            btn7.TabIndex = 4;
            btn7.Text = "View";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.Cursor = Cursors.Hand;
            btn6.Dock = DockStyle.Top;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.Control;
            btn6.Location = new Point(0, 58);
            btn6.Name = "btn6";
            btn6.Size = new Size(247, 58);
            btn6.TabIndex = 3;
            btn6.Text = "Add";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.Cursor = Cursors.Hand;
            btn5.Dock = DockStyle.Top;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.Control;
            btn5.Location = new Point(0, 0);
            btn5.Name = "btn5";
            btn5.Size = new Size(247, 58);
            btn5.TabIndex = 2;
            btn5.Text = "Manage Customer";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
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
            btn4.TabIndex = 12;
            btn4.Text = "Home";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(339, 45);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1150, 935);
            MainPanel.TabIndex = 2;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 980);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDashboard";
            Text = "EmployeeDashboard";
            WindowState = FormWindowState.Maximized;
            Load += EmployeeDashboard_Load;
            TopPanel.ResumeLayout(false);
            SidePanel.ResumeLayout(false);
            OrderPanel.ResumeLayout(false);
            LogoutPanel.ResumeLayout(false);
            ItemPanel.ResumeLayout(false);
            BookingPanel.ResumeLayout(false);
            CustomerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel SidePanel;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn4;
        private Panel MainPanel;
        private Panel CustomerPanel;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Panel BookingPanel;
        private Button btn10;
        private Button btn9;
        private Button btn8;
        private Panel ItemPanel;
        private Button btn14;
        private Button btn13;
        private Button btn12;
        private Panel OrderPanel;
        private Button btn15;
        private Panel LogoutPanel;
        private Button btn18;
    }
}