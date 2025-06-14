namespace Hotel_Management_System.UI
{
    partial class AdminHome
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
            AdminDataPanel = new Panel();
            lblAdmin = new Label();
            RoomDataPanel = new Panel();
            lblRoom = new Label();
            lbl1 = new Label();
            CustomerDataPanel = new Panel();
            lblCustomer = new Label();
            EmployeeDataPanel = new Panel();
            lblEmployee = new Label();
            TotalEarningPanel = new Panel();
            lblTotalEarning = new Label();
            AvaiableRoomPanel = new Panel();
            lblAvaiableRoom = new Label();
            AdminDataPanel.SuspendLayout();
            RoomDataPanel.SuspendLayout();
            CustomerDataPanel.SuspendLayout();
            EmployeeDataPanel.SuspendLayout();
            TotalEarningPanel.SuspendLayout();
            AvaiableRoomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminDataPanel
            // 
            AdminDataPanel.BackColor = Color.Gray;
            AdminDataPanel.Controls.Add(lblAdmin);
            AdminDataPanel.Location = new Point(121, 220);
            AdminDataPanel.Name = "AdminDataPanel";
            AdminDataPanel.Size = new Size(410, 316);
            AdminDataPanel.TabIndex = 0;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Century", 14F, FontStyle.Bold);
            lblAdmin.ForeColor = SystemColors.Control;
            lblAdmin.Location = new Point(26, 223);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(190, 33);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Total Admin";
            // 
            // RoomDataPanel
            // 
            RoomDataPanel.BackColor = Color.Gray;
            RoomDataPanel.Controls.Add(lblRoom);
            RoomDataPanel.Location = new Point(121, 570);
            RoomDataPanel.Name = "RoomDataPanel";
            RoomDataPanel.Size = new Size(410, 316);
            RoomDataPanel.TabIndex = 1;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Century", 14F, FontStyle.Bold);
            lblRoom.ForeColor = SystemColors.Control;
            lblRoom.Location = new Point(30, 223);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(189, 33);
            lblRoom.TabIndex = 1;
            lblRoom.Text = "Total Rooms";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(439, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(715, 42);
            lbl1.TabIndex = 4;
            lbl1.Text = "Welcome To Hotel Management System";
            // 
            // CustomerDataPanel
            // 
            CustomerDataPanel.BackColor = Color.Gray;
            CustomerDataPanel.Controls.Add(lblCustomer);
            CustomerDataPanel.Location = new Point(1002, 220);
            CustomerDataPanel.Name = "CustomerDataPanel";
            CustomerDataPanel.Size = new Size(410, 316);
            CustomerDataPanel.TabIndex = 6;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Century", 14F, FontStyle.Bold);
            lblCustomer.ForeColor = SystemColors.Control;
            lblCustomer.Location = new Point(30, 234);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(232, 33);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Total Customer";
            // 
            // EmployeeDataPanel
            // 
            EmployeeDataPanel.BackColor = Color.Gray;
            EmployeeDataPanel.Controls.Add(lblEmployee);
            EmployeeDataPanel.Location = new Point(560, 220);
            EmployeeDataPanel.Name = "EmployeeDataPanel";
            EmployeeDataPanel.Size = new Size(410, 316);
            EmployeeDataPanel.TabIndex = 5;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Century", 14F, FontStyle.Bold);
            lblEmployee.ForeColor = SystemColors.Control;
            lblEmployee.Location = new Point(26, 234);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(233, 33);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Total Employee";
            // 
            // TotalEarningPanel
            // 
            TotalEarningPanel.BackColor = Color.Gray;
            TotalEarningPanel.Controls.Add(lblTotalEarning);
            TotalEarningPanel.Location = new Point(1002, 570);
            TotalEarningPanel.Name = "TotalEarningPanel";
            TotalEarningPanel.Size = new Size(410, 316);
            TotalEarningPanel.TabIndex = 8;
            // 
            // lblTotalEarning
            // 
            lblTotalEarning.AutoSize = true;
            lblTotalEarning.Font = new Font("Century", 14F, FontStyle.Bold);
            lblTotalEarning.ForeColor = SystemColors.Control;
            lblTotalEarning.Location = new Point(30, 234);
            lblTotalEarning.Name = "lblTotalEarning";
            lblTotalEarning.Size = new Size(211, 33);
            lblTotalEarning.TabIndex = 2;
            lblTotalEarning.Text = "Total Earning";
            // 
            // AvaiableRoomPanel
            // 
            AvaiableRoomPanel.BackColor = Color.Gray;
            AvaiableRoomPanel.Controls.Add(lblAvaiableRoom);
            AvaiableRoomPanel.Location = new Point(560, 570);
            AvaiableRoomPanel.Name = "AvaiableRoomPanel";
            AvaiableRoomPanel.Size = new Size(410, 316);
            AvaiableRoomPanel.TabIndex = 7;
            // 
            // lblAvaiableRoom
            // 
            lblAvaiableRoom.AutoSize = true;
            lblAvaiableRoom.Font = new Font("Century", 14F, FontStyle.Bold);
            lblAvaiableRoom.ForeColor = SystemColors.Control;
            lblAvaiableRoom.Location = new Point(26, 234);
            lblAvaiableRoom.Name = "lblAvaiableRoom";
            lblAvaiableRoom.Size = new Size(224, 33);
            lblAvaiableRoom.TabIndex = 1;
            lblAvaiableRoom.Text = "Avaiable Room";
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 931);
            Controls.Add(TotalEarningPanel);
            Controls.Add(AvaiableRoomPanel);
            Controls.Add(CustomerDataPanel);
            Controls.Add(EmployeeDataPanel);
            Controls.Add(lbl1);
            Controls.Add(RoomDataPanel);
            Controls.Add(AdminDataPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminHome";
            Text = "AdminHome";
            Load += AdminHome_Load;
            AdminDataPanel.ResumeLayout(false);
            AdminDataPanel.PerformLayout();
            RoomDataPanel.ResumeLayout(false);
            RoomDataPanel.PerformLayout();
            CustomerDataPanel.ResumeLayout(false);
            CustomerDataPanel.PerformLayout();
            EmployeeDataPanel.ResumeLayout(false);
            EmployeeDataPanel.PerformLayout();
            TotalEarningPanel.ResumeLayout(false);
            TotalEarningPanel.PerformLayout();
            AvaiableRoomPanel.ResumeLayout(false);
            AvaiableRoomPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AdminDataPanel;
        private Panel RoomDataPanel;
        private Label lbl1;
        private Label lblAdmin;
        private Label lblRoom;
        private Panel CustomerDataPanel;
        private Label lblCustomer;
        private Panel EmployeeDataPanel;
        private Label lblEmployee;
        private Panel TotalEarningPanel;
        private Label lblTotalEarning;
        private Panel AvaiableRoomPanel;
        private Label lblAvaiableRoom;
    }
}