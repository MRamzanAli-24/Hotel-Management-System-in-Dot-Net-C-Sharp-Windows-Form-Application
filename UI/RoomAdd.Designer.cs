namespace Hotel_Management_System.UI
{
    partial class RoomAdd
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
            lbl6 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            txtRoomNo = new TextBox();
            txtPrice = new TextBox();
            lbl3 = new Label();
            lbl4 = new Label();
            txtcbRoomType = new ComboBox();
            txtcbRoomCategory = new ComboBox();
            lbl5 = new Label();
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
            btn1.Location = new Point(873, 581);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 66;
            btn1.Text = "Add";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl6
            // 
            lbl6.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.Red;
            lbl6.Location = new Point(860, 459);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(320, 75);
            lbl6.TabIndex = 65;
            lbl6.Text = "*Enter Complete Data";
            lbl6.Visible = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(295, 42);
            lbl1.TabIndex = 46;
            lbl1.Text = "Add Room Data";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl2.Location = new Point(364, 226);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(120, 28);
            lbl2.TabIndex = 61;
            lbl2.Text = "Room No";
            // 
            // txtRoomNo
            // 
            txtRoomNo.BackColor = SystemColors.Control;
            txtRoomNo.Location = new Point(538, 226);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(220, 31);
            txtRoomNo.TabIndex = 62;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Control;
            txtPrice.Location = new Point(1022, 226);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 31);
            txtPrice.TabIndex = 68;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl3.Location = new Point(848, 229);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(75, 28);
            lbl3.TabIndex = 67;
            lbl3.Text = "Price";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(364, 289);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(71, 28);
            lbl4.TabIndex = 69;
            lbl4.Text = "Type";
            // 
            // txtcbRoomType
            // 
            txtcbRoomType.BackColor = SystemColors.Control;
            txtcbRoomType.FormattingEnabled = true;
            txtcbRoomType.Location = new Point(538, 289);
            txtcbRoomType.Name = "txtcbRoomType";
            txtcbRoomType.Size = new Size(220, 33);
            txtcbRoomType.TabIndex = 70;
            // 
            // txtcbRoomCategory
            // 
            txtcbRoomCategory.BackColor = SystemColors.Control;
            txtcbRoomCategory.FormattingEnabled = true;
            txtcbRoomCategory.Location = new Point(1022, 289);
            txtcbRoomCategory.Name = "txtcbRoomCategory";
            txtcbRoomCategory.Size = new Size(220, 33);
            txtcbRoomCategory.TabIndex = 72;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl5.Location = new Point(848, 294);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(120, 28);
            lbl5.TabIndex = 71;
            lbl5.Text = "Category";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gray;
            TopPanel.Controls.Add(btn2);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1421, 49);
            TopPanel.TabIndex = 73;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.Cursor = Cursors.Hand;
            btn2.Dock = DockStyle.Right;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(1372, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 49);
            btn2.TabIndex = 10;
            btn2.Text = "X";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // RoomAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 732);
            Controls.Add(TopPanel);
            Controls.Add(txtcbRoomCategory);
            Controls.Add(lbl5);
            Controls.Add(txtcbRoomType);
            Controls.Add(lbl4);
            Controls.Add(txtPrice);
            Controls.Add(lbl3);
            Controls.Add(btn1);
            Controls.Add(lbl6);
            Controls.Add(txtRoomNo);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomAdd";
            Load += RoomAdd_Load;
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label lbl6;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtRoomNo;
        private TextBox txtPrice;
        private Label lbl3;
        private Label lbl4;
        private ComboBox txtcbRoomType;
        private ComboBox txtcbRoomCategory;
        private Label lbl5;
        private Panel TopPanel;
        private Button btn2;
    }
}