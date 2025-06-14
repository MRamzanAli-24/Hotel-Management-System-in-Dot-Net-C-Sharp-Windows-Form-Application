namespace Hotel_Management_System.UI
{
    partial class CustomerViewOrder
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
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            OrderDataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(220, 42);
            lbl1.TabIndex = 8;
            lbl1.Text = "View Order";
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Order ID", "Item Name", "Quantity", "Amount", "Room Number", "Order Time" });
            txtSearchBy.Location = new Point(1096, 258);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(230, 33);
            txtSearchBy.TabIndex = 28;
            txtSearchBy.SelectedIndexChanged += searchbyBox_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(943, 263);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 27;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(329, 263);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(359, 31);
            txtSearch.TabIndex = 26;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(209, 263);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 25;
            lbl2.Text = "Search";
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, ItemName, Quantity, Amount, RoomNumber, OrderTime, Status, Cancel });
            OrderDataGridView.Location = new Point(209, 316);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.RowHeadersVisible = false;
            OrderDataGridView.RowHeadersWidth = 62;
            OrderDataGridView.Size = new Size(1117, 586);
            OrderDataGridView.TabIndex = 24;
            OrderDataGridView.CellContentClick += dataGridViewOrders_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Order ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 8;
            ItemName.Name = "ItemName";
            ItemName.Width = 200;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.Width = 150;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 8;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 150;
            // 
            // OrderTime
            // 
            OrderTime.HeaderText = "Order Time";
            OrderTime.MinimumWidth = 8;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Cancel
            // 
            Cancel.HeaderText = "Cancel";
            Cancel.MinimumWidth = 8;
            Cancel.Name = "Cancel";
            Cancel.Width = 120;
            // 
            // CustomerViewOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 954);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(OrderDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerViewOrder";
            Text = "CustomerViewOrder";
            Load += CustomerViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private DataGridView OrderDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Cancel;
    }
}