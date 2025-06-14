namespace Hotel_Management_System.UI
{
    partial class CustomerBookingView
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
            BookedDataGridView = new DataGridView();
            RoomNumber = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomCategory = new DataGridViewTextBoxColumn();
            BookingDate = new DataGridViewTextBoxColumn();
            CheckInDate = new DataGridViewTextBoxColumn();
            CheckOutDate = new DataGridViewTextBoxColumn();
            Days = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            txtSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)BookedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(355, 42);
            lbl1.TabIndex = 6;
            lbl1.Text = "View Booking Data";
            // 
            // BookedDataGridView
            // 
            BookedDataGridView.AllowUserToAddRows = false;
            BookedDataGridView.AllowUserToDeleteRows = false;
            BookedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookedDataGridView.Columns.AddRange(new DataGridViewColumn[] { RoomNumber, RoomType, RoomCategory, BookingDate, CheckInDate, CheckOutDate, Days, Price, Cancel, Update });
            BookedDataGridView.Location = new Point(118, 359);
            BookedDataGridView.Name = "BookedDataGridView";
            BookedDataGridView.RowHeadersVisible = false;
            BookedDataGridView.RowHeadersWidth = 62;
            BookedDataGridView.Size = new Size(1404, 601);
            BookedDataGridView.TabIndex = 7;
            BookedDataGridView.CellContentClick += BookedDataViewGrid_CellContentClick;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "RoomNumber";
            RoomNumber.MinimumWidth = 8;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 150;
            // 
            // RoomType
            // 
            RoomType.HeaderText = "Room Type";
            RoomType.MinimumWidth = 8;
            RoomType.Name = "RoomType";
            RoomType.Width = 150;
            // 
            // RoomCategory
            // 
            RoomCategory.HeaderText = "Room Category";
            RoomCategory.MinimumWidth = 8;
            RoomCategory.Name = "RoomCategory";
            RoomCategory.Width = 150;
            // 
            // BookingDate
            // 
            BookingDate.HeaderText = "Booking Date";
            BookingDate.MinimumWidth = 8;
            BookingDate.Name = "BookingDate";
            BookingDate.Width = 150;
            // 
            // CheckInDate
            // 
            CheckInDate.HeaderText = "Check In Date";
            CheckInDate.MinimumWidth = 8;
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Width = 150;
            // 
            // CheckOutDate
            // 
            CheckOutDate.HeaderText = "Check Out Date";
            CheckOutDate.MinimumWidth = 8;
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Width = 150;
            // 
            // Days
            // 
            Days.HeaderText = "Days";
            Days.MinimumWidth = 8;
            Days.Name = "Days";
            Days.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Cancel
            // 
            Cancel.HeaderText = "Cancel";
            Cancel.MinimumWidth = 8;
            Cancel.Name = "Cancel";
            Cancel.Width = 150;
            // 
            // Update
            // 
            Update.HeaderText = "Update";
            Update.MinimumWidth = 8;
            Update.Name = "Update";
            Update.Width = 150;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(986, 294);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 13;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(230, 294);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(486, 31);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(118, 294);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 11;
            lbl2.Text = "Search";
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Room Number", "Room Type", "Room Category", "Booking Date", "Check In Date", "Check Out Date", "Days", "Price" });
            txtSearchBy.Location = new Point(1148, 289);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(374, 33);
            txtSearchBy.TabIndex = 29;
            txtSearchBy.SelectedIndexChanged += txtSearchByBox_SelectedIndexChanged;
            // 
            // CustomerBookingView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 1106);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(BookedDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerBookingView";
            Text = "CustomerBookingView";
            Load += CustomerBookingView_Load;
            ((System.ComponentModel.ISupportInitialize)BookedDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView BookedDataGridView;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomCategory;
        private DataGridViewTextBoxColumn BookingDate;
        private DataGridViewTextBoxColumn CheckInDate;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn Days;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Cancel;
        private DataGridViewButtonColumn Update;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private ComboBox txtSearchBy;
    }
}