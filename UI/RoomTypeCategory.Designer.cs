namespace Hotel_Management_System.UI
{
    partial class RoomTypeCategory
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
            lbl2 = new Label();
            txtRoomType = new TextBox();
            label1 = new Label();
            cbRoomType = new ComboBox();
            btn1 = new Button();
            btn3 = new Button();
            cbRoomCategory = new ComboBox();
            label2 = new Label();
            txtRoomCategory = new TextBox();
            lbl4 = new Label();
            btn2 = new Button();
            btn4 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(459, 42);
            lbl1.TabIndex = 74;
            lbl1.Text = "Room Type and Category";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 14F, FontStyle.Bold);
            lbl2.ForeColor = SystemColors.ControlText;
            lbl2.Location = new Point(349, 282);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(169, 33);
            lbl2.TabIndex = 75;
            lbl2.Text = "Room Type";
            lbl2.Click += lbl2_Click;
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = SystemColors.Control;
            txtRoomType.Location = new Point(596, 286);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(237, 31);
            txtRoomType.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(930, 286);
            label1.Name = "label1";
            label1.Size = new Size(219, 33);
            label1.TabIndex = 77;
            label1.Text = "All Room Type";
            // 
            // cbRoomType
            // 
            cbRoomType.BackColor = SystemColors.Control;
            cbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(1228, 282);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(237, 33);
            cbRoomType.TabIndex = 78;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(669, 446);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 79;
            btn1.Text = "Add";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.Control;
            btn3.Location = new Point(669, 772);
            btn3.Name = "btn3";
            btn3.Size = new Size(164, 51);
            btn3.TabIndex = 85;
            btn3.Text = "Add";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button3_Click;
            // 
            // cbRoomCategory
            // 
            cbRoomCategory.BackColor = SystemColors.Control;
            cbRoomCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomCategory.FormattingEnabled = true;
            cbRoomCategory.Location = new Point(1242, 616);
            cbRoomCategory.Name = "cbRoomCategory";
            cbRoomCategory.Size = new Size(237, 33);
            cbRoomCategory.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(930, 612);
            label2.Name = "label2";
            label2.Size = new Size(276, 33);
            label2.TabIndex = 83;
            label2.Text = "All Room Category";
            // 
            // txtRoomCategory
            // 
            txtRoomCategory.BackColor = SystemColors.Control;
            txtRoomCategory.Location = new Point(596, 612);
            txtRoomCategory.Name = "txtRoomCategory";
            txtRoomCategory.Size = new Size(237, 31);
            txtRoomCategory.TabIndex = 82;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 14F, FontStyle.Bold);
            lbl4.ForeColor = SystemColors.ControlText;
            lbl4.Location = new Point(349, 608);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(226, 33);
            lbl4.TabIndex = 81;
            lbl4.Text = "Room Category";
            lbl4.Click += lbl4_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.Control;
            btn2.Location = new Point(930, 446);
            btn2.Name = "btn2";
            btn2.Size = new Size(164, 51);
            btn2.TabIndex = 86;
            btn2.Text = "Delete";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.Control;
            btn4.Location = new Point(930, 772);
            btn4.Name = "btn4";
            btn4.Size = new Size(164, 51);
            btn4.TabIndex = 87;
            btn4.Text = "Delete";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click_1;
            // 
            // RoomTypeCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1721, 969);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(cbRoomCategory);
            Controls.Add(label2);
            Controls.Add(txtRoomCategory);
            Controls.Add(lbl4);
            Controls.Add(btn1);
            Controls.Add(cbRoomType);
            Controls.Add(label1);
            Controls.Add(txtRoomType);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomTypeCategory";
            Text = "RoomTypeCategory";
            Load += RoomTypeCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txtRoomType;
        private Label label1;
        private ComboBox cbRoomType;
        private Button btn1;
        private Button btn3;
        private ComboBox cbRoomCategory;
        private Label label2;
        private TextBox txtRoomCategory;
        private Label lbl4;
        private Button btn2;
        private Button btn4;
    }
}