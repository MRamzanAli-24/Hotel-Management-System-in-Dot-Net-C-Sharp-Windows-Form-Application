namespace Hotel_Management_System.UI
{
    partial class BookingView
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
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            BookedDataGridView = new DataGridView();
            RoomNo = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerCNIC = new DataGridViewTextBoxColumn();
            CustomerPhoneNo = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomCategory = new DataGridViewTextBoxColumn();
            BookingDate = new DataGridViewTextBoxColumn();
            CheckIN = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            Days = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            lbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)BookedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Room Number", "Customer Name", "Customer CNIC", "Phone Number", "Room Type", "Room Category", "Booking Date", "Check In Date", "Check Out Date" });
            txtSearchBy.Location = new Point(1191, 258);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(374, 33);
            txtSearchBy.TabIndex = 28;
            txtSearchBy.SelectedIndexChanged += txtSeacrhBy_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(1038, 263);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 27;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(151, 266);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(519, 31);
            txtSearch.TabIndex = 26;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(29, 263);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 25;
            lbl2.Text = "Search";
            // 
            // BookedDataGridView
            // 
            BookedDataGridView.AllowUserToAddRows = false;
            BookedDataGridView.AllowUserToDeleteRows = false;
            BookedDataGridView.AllowUserToResizeColumns = false;
            BookedDataGridView.BorderStyle = BorderStyle.None;
            BookedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookedDataGridView.Columns.AddRange(new DataGridViewColumn[] { RoomNo, CustomerName, CustomerCNIC, CustomerPhoneNo, RoomType, RoomCategory, BookingDate, CheckIN, CheckOut, Days, Price, Cancel, Update });
            BookedDataGridView.Location = new Point(29, 315);
            BookedDataGridView.Name = "BookedDataGridView";
            BookedDataGridView.RowHeadersVisible = false;
            BookedDataGridView.RowHeadersWidth = 62;
            BookedDataGridView.Size = new Size(1536, 691);
            BookedDataGridView.TabIndex = 24;
            BookedDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RoomNo
            // 
            RoomNo.HeaderText = "Room Number";
            RoomNo.MinimumWidth = 8;
            RoomNo.Name = "RoomNo";
            RoomNo.Width = 150;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 200;
            // 
            // CustomerCNIC
            // 
            CustomerCNIC.HeaderText = "Customer CNIC";
            CustomerCNIC.MinimumWidth = 8;
            CustomerCNIC.Name = "CustomerCNIC";
            CustomerCNIC.Width = 200;
            // 
            // CustomerPhoneNo
            // 
            CustomerPhoneNo.HeaderText = "Customer Phone Number";
            CustomerPhoneNo.MinimumWidth = 8;
            CustomerPhoneNo.Name = "CustomerPhoneNo";
            CustomerPhoneNo.Width = 150;
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
            // CheckIN
            // 
            CheckIN.HeaderText = "Check In Date";
            CheckIN.MinimumWidth = 8;
            CheckIN.Name = "CheckIN";
            CheckIN.Width = 150;
            // 
            // CheckOut
            // 
            CheckOut.HeaderText = "Check Out Date";
            CheckOut.MinimumWidth = 8;
            CheckOut.Name = "CheckOut";
            CheckOut.Width = 150;
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
            Cancel.HeaderText = "Cancel Booking";
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(320, 38);
            lbl1.TabIndex = 23;
            lbl1.Text = "View Booking Data";
            // 
            // BookingView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1816, 1018);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(BookedDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingView";
            Text = "BookingView";
            Load += BookingView_Load;
            ((System.ComponentModel.ISupportInitialize)BookedDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private DataGridView BookedDataGridView;
        private Label lbl1;
        private DataGridViewTextBoxColumn RoomNo;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerCNIC;
        private DataGridViewTextBoxColumn CustomerPhoneNo;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomCategory;
        private DataGridViewTextBoxColumn BookingDate;
        private DataGridViewTextBoxColumn CheckIN;
        private DataGridViewTextBoxColumn CheckOut;
        private DataGridViewTextBoxColumn Days;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Cancel;
        private DataGridViewButtonColumn Update;
    }
}