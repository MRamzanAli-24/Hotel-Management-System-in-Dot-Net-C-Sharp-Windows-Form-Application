namespace Hotel_Management_System.UI
{
    partial class ManageOrder
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
            OrderDataGridView = new DataGridView();
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            OrderId = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            CNIC = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            Delivered = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(260, 38);
            lbl1.TabIndex = 9;
            lbl1.Text = "Manage Orders";
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { OrderId, ItemName, CNIC, RoomNumber, Quantity, OrderTime, amount, Delivered, Delete });
            OrderDataGridView.Location = new Point(324, 307);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.RowHeadersVisible = false;
            OrderDataGridView.RowHeadersWidth = 62;
            OrderDataGridView.Size = new Size(922, 541);
            OrderDataGridView.TabIndex = 10;
            OrderDataGridView.CellContentClick += OrderDataGridView_CellContentClick;
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Item Name", "Room Number", "Customer CNIC", "Order Time", "Amount", "Quantity" });
            txtSearchBy.Location = new Point(1067, 260);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(179, 33);
            txtSearchBy.TabIndex = 18;
            txtSearchBy.SelectedIndexChanged += txtSearchBy_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(914, 257);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 17;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(436, 265);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(284, 31);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(324, 265);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 15;
            lbl2.Text = "Search";
            // 
            // OrderId
            // 
            OrderId.HeaderText = "OrderId";
            OrderId.MinimumWidth = 8;
            OrderId.Name = "OrderId";
            OrderId.Width = 150;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 8;
            ItemName.Name = "ItemName";
            ItemName.Width = 250;
            // 
            // CNIC
            // 
            CNIC.HeaderText = "Customer CNIC";
            CNIC.MinimumWidth = 8;
            CNIC.Name = "CNIC";
            CNIC.Width = 150;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 8;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // OrderTime
            // 
            OrderTime.HeaderText = "Order Time";
            OrderTime.MinimumWidth = 8;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 150;
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.MinimumWidth = 8;
            amount.Name = "amount";
            amount.Width = 150;
            // 
            // Delivered
            // 
            Delivered.HeaderText = "Delivered";
            Delivered.MinimumWidth = 8;
            Delivered.Name = "Delivered";
            Delivered.Width = 150;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Width = 150;
            // 
            // ManageOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 891);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(OrderDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrder";
            Text = "ManageOrder";
            Load += ManageOrder_Load;
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView OrderDataGridView;
        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn CNIC;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewButtonColumn Delivered;
        private DataGridViewButtonColumn Delete;
    }
}