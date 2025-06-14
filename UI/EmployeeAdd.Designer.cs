namespace Hotel_Management_System.UI
{
    partial class EmployeeAdd
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
            btn1 = new Button();
            lbl11 = new Label();
            txtCPassword = new TextBox();
            lbl10 = new Label();
            txtPassword = new TextBox();
            lbl9 = new Label();
            txtUserName = new TextBox();
            lbl8 = new Label();
            txtGender = new ComboBox();
            lbl7 = new Label();
            txtPhoneNo = new TextBox();
            lbl6 = new Label();
            txtAddress = new TextBox();
            lbl5 = new Label();
            txtCNIC = new TextBox();
            lbl4 = new Label();
            txtSalary = new TextBox();
            lbl3 = new Label();
            txtName = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            lbl12 = new Label();
            TopPanel = new Panel();
            btn2 = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(971, 602);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 66;
            btn1.Text = "Add";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl11
            // 
            lbl11.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl11.ForeColor = Color.Red;
            lbl11.Location = new Point(958, 480);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(320, 75);
            lbl11.TabIndex = 65;
            lbl11.Text = "*Enter Complete Data";
            lbl11.Visible = false;
            // 
            // txtCPassword
            // 
            txtCPassword.BackColor = SystemColors.Control;
            txtCPassword.Location = new Point(571, 534);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.Size = new Size(220, 31);
            txtCPassword.TabIndex = 64;
            // 
            // lbl10
            // 
            lbl10.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl10.Location = new Point(397, 534);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(140, 60);
            lbl10.TabIndex = 63;
            lbl10.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Location = new Point(571, 479);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 31);
            txtPassword.TabIndex = 62;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl9.Location = new Point(397, 479);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(127, 28);
            lbl9.TabIndex = 61;
            lbl9.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.Location = new Point(571, 425);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 31);
            txtUserName.TabIndex = 60;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl8.Location = new Point(397, 425);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(148, 28);
            lbl8.TabIndex = 59;
            lbl8.Text = "User Name";
            // 
            // txtGender
            // 
            txtGender.BackColor = SystemColors.Control;
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(1115, 364);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(220, 33);
            txtGender.TabIndex = 58;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl7.Location = new Point(939, 364);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(101, 28);
            lbl7.TabIndex = 57;
            lbl7.Text = "Gender";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.BackColor = SystemColors.Control;
            txtPhoneNo.Location = new Point(571, 306);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(220, 31);
            txtPhoneNo.TabIndex = 56;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl6.Location = new Point(397, 306);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(129, 28);
            lbl6.TabIndex = 55;
            lbl6.Text = "Phone No";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.Location = new Point(1115, 309);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 31);
            txtAddress.TabIndex = 54;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl5.Location = new Point(942, 309);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(109, 28);
            lbl5.TabIndex = 53;
            lbl5.Text = "Address";
            // 
            // txtCNIC
            // 
            txtCNIC.BackColor = SystemColors.Control;
            txtCNIC.Location = new Point(1115, 255);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(220, 31);
            txtCNIC.TabIndex = 52;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(941, 255);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(80, 28);
            lbl4.TabIndex = 51;
            lbl4.Text = "CNIC";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = SystemColors.Control;
            txtSalary.Location = new Point(571, 361);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(220, 31);
            txtSalary.TabIndex = 50;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl3.Location = new Point(398, 361);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(91, 28);
            lbl3.TabIndex = 49;
            lbl3.Text = "Salary";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Location = new Point(571, 255);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 31);
            txtName.TabIndex = 48;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl2.Location = new Point(397, 253);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(82, 28);
            lbl2.TabIndex = 47;
            lbl2.Text = "Name";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(368, 42);
            lbl1.TabIndex = 46;
            lbl1.Text = "Add Employee Data";
            // 
            // lbl12
            // 
            lbl12.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl12.ForeColor = Color.Red;
            lbl12.Location = new Point(398, 616);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(320, 75);
            lbl12.TabIndex = 67;
            lbl12.Text = "*Enter Correct Password";
            lbl12.Visible = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gray;
            TopPanel.Controls.Add(btn2);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1542, 45);
            TopPanel.TabIndex = 68;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Right;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(1493, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 45);
            btn2.TabIndex = 7;
            btn2.Text = "X";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // EmployeeAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 770);
            Controls.Add(TopPanel);
            Controls.Add(lbl12);
            Controls.Add(btn1);
            Controls.Add(lbl11);
            Controls.Add(txtCPassword);
            Controls.Add(lbl10);
            Controls.Add(txtPassword);
            Controls.Add(lbl9);
            Controls.Add(txtUserName);
            Controls.Add(lbl8);
            Controls.Add(txtGender);
            Controls.Add(lbl7);
            Controls.Add(txtPhoneNo);
            Controls.Add(lbl6);
            Controls.Add(txtAddress);
            Controls.Add(lbl5);
            Controls.Add(txtCNIC);
            Controls.Add(lbl4);
            Controls.Add(txtSalary);
            Controls.Add(lbl3);
            Controls.Add(txtName);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeAdd";
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label lbl11;
        private TextBox txtCPassword;
        private Label lbl10;
        private TextBox txtPassword;
        private Label lbl9;
        private TextBox txtUserName;
        private Label lbl8;
        private ComboBox txtGender;
        private Label lbl7;
        private TextBox txtPhoneNo;
        private Label lbl6;
        private TextBox txtAddress;
        private Label lbl5;
        private TextBox txtCNIC;
        private Label lbl4;
        private TextBox txtSalary;
        private Label lbl3;
        private TextBox txtName;
        private Label lbl2;
        private Label lbl1;
        private Label lbl12;
        private Panel TopPanel;
        private Button btn2;
    }
}