namespace Hotel_Management_System.UI
{
    partial class CustomerAdd
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
            lbl1 = new Label();
            txtName = new TextBox();
            lbl2 = new Label();
            txtCNIC = new TextBox();
            lbl4 = new Label();
            txtAddress = new TextBox();
            lbl5 = new Label();
            txtPhoneNo = new TextBox();
            lbl6 = new Label();
            lbl7 = new Label();
            txtGender = new ComboBox();
            txtUserName = new TextBox();
            lbl8 = new Label();
            txtPassword = new TextBox();
            lbl9 = new Label();
            txtCPassword = new TextBox();
            lbl10 = new Label();
            btn1 = new Button();
            lbl11 = new Label();
            lbl12 = new Label();
            TopPanel = new Panel();
            btn2 = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(271, 108);
            lbl1.TabIndex = 1;
            lbl1.Text = "Enter User Data";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Location = new Point(592, 317);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 31);
            txtName.TabIndex = 5;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(419, 317);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(77, 27);
            lbl2.TabIndex = 4;
            lbl2.Text = "Name";
            // 
            // txtCNIC
            // 
            txtCNIC.BackColor = SystemColors.Control;
            txtCNIC.Location = new Point(1011, 313);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(190, 31);
            txtCNIC.TabIndex = 9;
            txtCNIC.TextChanged += textBox3_TextChanged;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(838, 313);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(75, 27);
            lbl4.TabIndex = 8;
            lbl4.Text = "CNIC";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.Location = new Point(1011, 371);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 31);
            txtAddress.TabIndex = 11;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.Location = new Point(838, 371);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(102, 27);
            lbl5.TabIndex = 10;
            lbl5.Text = "Address";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.BackColor = SystemColors.Control;
            txtPhoneNo.Location = new Point(592, 367);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(190, 31);
            txtPhoneNo.TabIndex = 13;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.Location = new Point(419, 367);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(118, 27);
            lbl6.TabIndex = 12;
            lbl6.Text = "Phone No";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.Location = new Point(835, 426);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(93, 27);
            lbl7.TabIndex = 14;
            lbl7.Text = "Gender";
            // 
            // txtGender
            // 
            txtGender.BackColor = SystemColors.Control;
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(1011, 426);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(190, 33);
            txtGender.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.Location = new Point(592, 423);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(190, 31);
            txtUserName.TabIndex = 18;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl8.Location = new Point(419, 423);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(137, 27);
            lbl8.TabIndex = 17;
            lbl8.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Location = new Point(592, 477);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 31);
            txtPassword.TabIndex = 20;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl9.Location = new Point(419, 477);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(118, 27);
            lbl9.TabIndex = 19;
            lbl9.Text = "Password";
            // 
            // txtCPassword
            // 
            txtCPassword.BackColor = SystemColors.Control;
            txtCPassword.Location = new Point(592, 532);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.Size = new Size(190, 31);
            txtCPassword.TabIndex = 22;
            // 
            // lbl10
            // 
            lbl10.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl10.Location = new Point(419, 532);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(140, 60);
            lbl10.TabIndex = 21;
            lbl10.Text = "Confirm Password";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(1011, 653);
            btn1.Name = "btn1";
            btn1.Size = new Size(200, 50);
            btn1.TabIndex = 23;
            btn1.Text = "Sign UP";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl11
            // 
            lbl11.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl11.ForeColor = Color.Red;
            lbl11.Location = new Point(838, 543);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(320, 75);
            lbl11.TabIndex = 25;
            lbl11.Text = "*Enter Complete Data";
            lbl11.Visible = false;
            // 
            // lbl12
            // 
            lbl12.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl12.ForeColor = Color.Red;
            lbl12.Location = new Point(419, 616);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(320, 75);
            lbl12.TabIndex = 26;
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
            TopPanel.Size = new Size(1493, 45);
            TopPanel.TabIndex = 27;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Right;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(1444, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 45);
            btn2.TabIndex = 7;
            btn2.Text = "X";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 733);
            Controls.Add(TopPanel);
            Controls.Add(lbl12);
            Controls.Add(lbl11);
            Controls.Add(btn1);
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
            Controls.Add(txtName);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerAdd";
            Text = "SignUP";
            Load += CustomerAdd_Load;
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtName;
        private Label lbl2;
        private TextBox txtCNIC;
        private Label lbl4;
        private TextBox txtAddress;
        private Label lbl5;
        private TextBox txtPhoneNo;
        private Label lbl6;
        private Label lbl7;
        private ComboBox txtGender;
        private TextBox txtUserName;
        private Label lbl8;
        private TextBox txtPassword;
        private Label lbl9;
        private TextBox txtCPassword;
        private Label lbl10;
        private Label lbl11;
        public Button btn1;
        private Label lbl12;
        private Panel TopPanel;
        private Button btn2;
    }
}