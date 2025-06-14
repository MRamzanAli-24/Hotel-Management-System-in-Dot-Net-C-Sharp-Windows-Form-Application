namespace Hotel_Management_System.UI
{
    partial class ItemView
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
            ItemDataGridView = new DataGridView();
            ItemName = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(178, 38);
            lbl1.TabIndex = 9;
            lbl1.Text = "View Item";
            // 
            // ItemDataGridView
            // 
            ItemDataGridView.AllowUserToAddRows = false;
            ItemDataGridView.AllowUserToDeleteRows = false;
            ItemDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemName, ItemPrice, Delete, Update });
            ItemDataGridView.Location = new Point(345, 298);
            ItemDataGridView.Name = "ItemDataGridView";
            ItemDataGridView.ReadOnly = true;
            ItemDataGridView.RowHeadersVisible = false;
            ItemDataGridView.RowHeadersWidth = 62;
            ItemDataGridView.Size = new Size(803, 423);
            ItemDataGridView.TabIndex = 10;
            ItemDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ItemName
            // 
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 8;
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            ItemName.Width = 250;
            // 
            // ItemPrice
            // 
            ItemPrice.HeaderText = "Item Price";
            ItemPrice.MinimumWidth = 8;
            ItemPrice.Name = "ItemPrice";
            ItemPrice.ReadOnly = true;
            ItemPrice.Width = 250;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 150;
            // 
            // Update
            // 
            Update.HeaderText = "Update";
            Update.MinimumWidth = 8;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Width = 150;
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Item Name", "Item Price" });
            txtSearchBy.Location = new Point(980, 245);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(168, 33);
            txtSearchBy.TabIndex = 18;
            txtSearchBy.SelectedIndexChanged += searchbyBox_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(827, 250);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 17;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(465, 250);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(224, 31);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(345, 250);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 15;
            lbl2.Text = "Search";
            // 
            // ItemView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 733);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(ItemDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemView";
            Text = "ItemView";
            Load += ItemView_Load;
            ((System.ComponentModel.ISupportInitialize)ItemDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView ItemDataGridView;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Update;
        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
    }
}