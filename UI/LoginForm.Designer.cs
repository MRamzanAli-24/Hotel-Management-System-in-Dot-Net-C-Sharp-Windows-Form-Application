namespace Hotel_Management_System.UI
{
    partial class LoginForm
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
            btn4 = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            SuspendLayout();
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkGray;
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(247, 373);
            btn4.Name = "btn4";
            btn4.Size = new Size(190, 39);
            btn4.TabIndex = 12;
            btn4.Text = "Login";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Location = new Point(247, 310);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 31);
            txtPassword.TabIndex = 11;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.Location = new Point(247, 269);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(190, 31);
            txtUserName.TabIndex = 10;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(74, 310);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(118, 27);
            lbl4.TabIndex = 9;
            lbl4.Text = "Password";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(74, 269);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(137, 27);
            lbl3.TabIndex = 8;
            lbl3.Text = "User Name";
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = SystemColors.ControlText;
            lbl2.Location = new Point(147, 95);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(191, 108);
            lbl2.TabIndex = 7;
            lbl2.Text = "Enter Login Data";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 609);
            Controls.Add(btn4);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn4;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
    }
}