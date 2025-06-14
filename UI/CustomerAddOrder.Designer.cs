namespace Hotel_Management_System.UI
{
    partial class CustomerAddOrder
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
            ItemName = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            Order = new DataGridViewButtonColumn();
            txtQuantity = new TextBox();
            lbl5 = new Label();
            txtItemName = new TextBox();
            lbl4 = new Label();
            btn1 = new Button();
            lbl11 = new Label();
            txtPrice = new TextBox();
            lbl6 = new Label();
            lbl7 = new Label();
            txtcbRoomNumber = new ComboBox();
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
            lbl1.Size = new Size(204, 42);
            lbl1.TabIndex = 7;
            lbl1.Text = "Add Order";
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Item Name", "Item Price" });
            txtSearchBy.Location = new Point(999, 246);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(168, 33);
            txtSearchBy.TabIndex = 23;
            txtSearchBy.SelectedIndexChanged += txtSearchBy_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(846, 251);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 22;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(534, 251);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(224, 31);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(414, 251);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 20;
            lbl2.Text = "Search";
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemName, ItemPrice, Order });
            OrderDataGridView.Location = new Point(414, 299);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.ReadOnly = true;
            OrderDataGridView.RowHeadersVisible = false;
            OrderDataGridView.RowHeadersWidth = 62;
            OrderDataGridView.Size = new Size(754, 225);
            OrderDataGridView.TabIndex = 19;
            OrderDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 8;
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            ItemName.Width = 300;
            // 
            // ItemPrice
            // 
            ItemPrice.HeaderText = "Item Price";
            ItemPrice.MinimumWidth = 8;
            ItemPrice.Name = "ItemPrice";
            ItemPrice.ReadOnly = true;
            ItemPrice.Width = 300;
            // 
            // Order
            // 
            Order.HeaderText = "Order";
            Order.MinimumWidth = 8;
            Order.Name = "Order";
            Order.ReadOnly = true;
            Order.Width = 150;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Control;
            txtQuantity.Location = new Point(588, 754);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(220, 31);
            txtQuantity.TabIndex = 35;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl5.Location = new Point(383, 754);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(121, 28);
            lbl5.TabIndex = 34;
            lbl5.Text = "Quantity";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.Control;
            txtItemName.Location = new Point(588, 697);
            txtItemName.Name = "txtItemName";
            txtItemName.ReadOnly = true;
            txtItemName.Size = new Size(220, 31);
            txtItemName.TabIndex = 33;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(383, 695);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(68, 28);
            lbl4.TabIndex = 32;
            lbl4.Text = "Item";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(588, 949);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 47;
            btn1.Text = "Order";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl11
            // 
            lbl11.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl11.ForeColor = Color.Red;
            lbl11.Location = new Point(898, 695);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(320, 75);
            lbl11.TabIndex = 46;
            lbl11.Text = "*Enter Complete Data";
            lbl11.Visible = false;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Control;
            txtPrice.Location = new Point(588, 809);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(220, 31);
            txtPrice.TabIndex = 49;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl6.Location = new Point(383, 809);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(146, 28);
            lbl6.TabIndex = 48;
            lbl6.Text = "Total Price";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl7.Location = new Point(383, 854);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(184, 28);
            lbl7.TabIndex = 50;
            lbl7.Text = "Room Number";
            // 
            // txtcbRoomNumber
            // 
            txtcbRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcbRoomNumber.FormattingEnabled = true;
            txtcbRoomNumber.Location = new Point(588, 854);
            txtcbRoomNumber.Name = "txtcbRoomNumber";
            txtcbRoomNumber.Size = new Size(220, 33);
            txtcbRoomNumber.TabIndex = 51;
            // 
            // CustomerAddOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 1037);
            Controls.Add(txtcbRoomNumber);
            Controls.Add(lbl7);
            Controls.Add(txtPrice);
            Controls.Add(lbl6);
            Controls.Add(btn1);
            Controls.Add(lbl11);
            Controls.Add(txtQuantity);
            Controls.Add(lbl5);
            Controls.Add(txtItemName);
            Controls.Add(lbl4);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(OrderDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerAddOrder";
            Text = "CustomerOrder";
            Load += CustomerAddOrder_Load;
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
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewButtonColumn Order;
        private TextBox txtQuantity;
        private Label lbl5;
        private TextBox txtItemName;
        private Label lbl4;
        private Button btn1;
        private Label lbl11;
        private TextBox txtPrice;
        private Label lbl6;
        private Label lbl7;
        private ComboBox txtcbRoomNumber;
    }
}