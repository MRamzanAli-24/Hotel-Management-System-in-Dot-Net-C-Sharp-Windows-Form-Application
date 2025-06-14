namespace Hotel_Management_System
{
    partial class LoginFormDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lbl5 = new Label();
            btn5 = new Button();
            lbl1 = new Label();
            panel2 = new Panel();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(lbl5);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(lbl1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 654);
            panel1.TabIndex = 0;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Cursor = Cursors.Hand;
            lbl5.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.Location = new Point(44, 500);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(183, 27);
            lbl5.TabIndex = 14;
            lbl5.Text = "Create Account";
            lbl5.Click += lbl5_Click;
            // 
            // btn5
            // 
            btn5.BackgroundImage = Properties.Resources.icons8_back_arrow_50;
            btn5.BackgroundImageLayout = ImageLayout.Zoom;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(12, 12);
            btn5.Name = "btn5";
            btn5.Size = new Size(53, 51);
            btn5.TabIndex = 25;
            btn5.UseVisualStyleBackColor = true;
            btn5.Visible = false;
            btn5.Click += btn5_Click;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Century", 14F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.Control;
            lbl1.Location = new Point(35, 195);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(207, 218);
            lbl1.TabIndex = 0;
            lbl1.Text = "Welcome to Hotel Management System";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btn3);
            panel2.Controls.Add(btn2);
            panel2.Controls.Add(btn1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(280, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 45);
            panel2.TabIndex = 1;
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
            btn3.Location = new Point(363, 0);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 45);
            btn3.TabIndex = 5;
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
            btn2.Location = new Point(412, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 45);
            btn2.TabIndex = 4;
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
            btn1.Location = new Point(461, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 45);
            btn1.TabIndex = 3;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(280, 45);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(510, 609);
            mainpanel.TabIndex = 2;
            // 
            // LoginFormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 654);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginFormDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainpanel;
        private Label lbl1;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Label lbl5;
    }
}
