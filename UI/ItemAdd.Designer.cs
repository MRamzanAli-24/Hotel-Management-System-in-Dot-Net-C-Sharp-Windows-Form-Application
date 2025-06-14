namespace Hotel_Management_System.UI
{
    partial class ItemAdd
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
            txtItemPrice = new TextBox();
            lbl3 = new Label();
            txtItemName = new TextBox();
            lbl2 = new Label();
            btn1 = new Button();
            lbl4 = new Label();
            TopPanel = new Panel();
            btn2 = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(249, 38);
            lbl1.TabIndex = 8;
            lbl1.Text = "Add Item Data";
            // 
            // txtItemPrice
            // 
            txtItemPrice.BackColor = SystemColors.Control;
            txtItemPrice.Location = new Point(783, 336);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(220, 31);
            txtItemPrice.TabIndex = 33;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl3.Location = new Point(610, 336);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(75, 28);
            lbl3.TabIndex = 32;
            lbl3.Text = "Price";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.Control;
            txtItemName.Location = new Point(783, 266);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(220, 31);
            txtItemName.TabIndex = 31;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl2.Location = new Point(609, 264);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(82, 28);
            lbl2.TabIndex = 30;
            lbl2.Text = "Name";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(796, 549);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 47;
            btn1.Text = "Add";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl4
            // 
            lbl4.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.Red;
            lbl4.Location = new Point(783, 427);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(320, 75);
            lbl4.TabIndex = 46;
            lbl4.Text = "*Enter Complete Data";
            lbl4.Visible = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gray;
            TopPanel.Controls.Add(btn2);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1479, 49);
            TopPanel.TabIndex = 74;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Right;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(1430, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 49);
            btn2.TabIndex = 10;
            btn2.Text = "X";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // ItemAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 797);
            Controls.Add(TopPanel);
            Controls.Add(btn1);
            Controls.Add(lbl4);
            Controls.Add(txtItemPrice);
            Controls.Add(lbl3);
            Controls.Add(txtItemName);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemAdd";
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtItemPrice;
        private Label lbl3;
        private TextBox txtItemName;
        private Label lbl2;
        private Button btn1;
        private Label lbl4;
        private Panel TopPanel;
        private Button btn2;
    }
}