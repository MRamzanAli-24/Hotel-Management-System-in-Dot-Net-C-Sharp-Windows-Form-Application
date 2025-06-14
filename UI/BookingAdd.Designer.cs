namespace Hotel_Management_System.UI
{
    partial class BookingAdd
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
            RoomDataGridView = new DataGridView();
            RoomNo = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomCategory = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            BookRoom = new DataGridViewButtonColumn();
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            btn1 = new Button();
            txtCNIC = new TextBox();
            lbl7 = new Label();
            lbl6 = new Label();
            txtCheckInDate = new DateTimePicker();
            txtCheckOutDate = new DateTimePicker();
            txtRoomNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RoomDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(192, 38);
            lbl1.TabIndex = 10;
            lbl1.Text = "Book Room";
            // 
            // RoomDataGridView
            // 
            RoomDataGridView.AllowUserToAddRows = false;
            RoomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomDataGridView.Columns.AddRange(new DataGridViewColumn[] { RoomNo, RoomType, RoomCategory, Price, BookRoom });
            RoomDataGridView.Location = new Point(335, 306);
            RoomDataGridView.Name = "RoomDataGridView";
            RoomDataGridView.RowHeadersVisible = false;
            RoomDataGridView.RowHeadersWidth = 62;
            RoomDataGridView.Size = new Size(855, 225);
            RoomDataGridView.TabIndex = 11;
            RoomDataGridView.CellContentClick += RoomDataGridView_CellContentClick;
            // 
            // RoomNo
            // 
            RoomNo.HeaderText = "Room Number";
            RoomNo.MinimumWidth = 8;
            RoomNo.Name = "RoomNo";
            RoomNo.Width = 150;
            // 
            // RoomType
            // 
            RoomType.HeaderText = "Room Type";
            RoomType.MinimumWidth = 8;
            RoomType.Name = "RoomType";
            RoomType.Width = 200;
            // 
            // RoomCategory
            // 
            RoomCategory.HeaderText = "Room Category";
            RoomCategory.MinimumWidth = 8;
            RoomCategory.Name = "RoomCategory";
            RoomCategory.Width = 200;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // BookRoom
            // 
            BookRoom.HeaderText = "Book Room";
            BookRoom.MinimumWidth = 8;
            BookRoom.Name = "BookRoom";
            BookRoom.Width = 150;
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Room Number", "Room Type", "Room Category" });
            txtSearchBy.Location = new Point(1018, 258);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(172, 33);
            txtSearchBy.TabIndex = 22;
            txtSearchBy.SelectedIndexChanged += searchbyBox_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(865, 263);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 21;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(455, 263);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(267, 31);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(335, 263);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 19;
            lbl2.Text = "Search";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(335, 691);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(184, 28);
            lbl4.TabIndex = 28;
            lbl4.Text = "Room Number";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl5.Location = new Point(335, 739);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(204, 28);
            lbl5.TabIndex = 30;
            lbl5.Text = "Customer CNIC";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(572, 899);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 46;
            btn1.Text = "Book";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // txtCNIC
            // 
            txtCNIC.BackColor = SystemColors.Control;
            txtCNIC.Location = new Point(570, 739);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(277, 31);
            txtCNIC.TabIndex = 47;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl7.Location = new Point(335, 824);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(200, 28);
            lbl7.TabIndex = 49;
            lbl7.Text = "Check Out date";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl6.Location = new Point(335, 781);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(186, 28);
            lbl6.TabIndex = 48;
            lbl6.Text = "Check In Date";
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.CalendarMonthBackground = SystemColors.Control;
            txtCheckInDate.Location = new Point(570, 781);
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.Size = new Size(277, 31);
            txtCheckInDate.TabIndex = 50;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.Location = new Point(572, 824);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.Size = new Size(275, 31);
            txtCheckOutDate.TabIndex = 51;
            // 
            // txtRoomNo
            // 
            txtRoomNo.BackColor = SystemColors.Control;
            txtRoomNo.Location = new Point(572, 688);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(277, 31);
            txtRoomNo.TabIndex = 52;
            // 
            // BookingAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 1045);
            Controls.Add(txtRoomNo);
            Controls.Add(txtCheckOutDate);
            Controls.Add(txtCheckInDate);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(txtCNIC);
            Controls.Add(btn1);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(RoomDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingAdd";
            Text = "BookingAdd";
            Load += BookingAdd_Load;
            ((System.ComponentModel.ISupportInitialize)RoomDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView RoomDataGridView;
        private DataGridViewTextBoxColumn RoomNo;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomCategory;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn BookRoom;
        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private Label lbl4;
        private Label lbl5;
        private Button btn1;
        private TextBox txtCNIC;
        private Label lbl7;
        private Label lbl6;
        private DateTimePicker txtCheckInDate;
        private DateTimePicker txtCheckOutDate;
        private TextBox txtRoomNo;
    }
}