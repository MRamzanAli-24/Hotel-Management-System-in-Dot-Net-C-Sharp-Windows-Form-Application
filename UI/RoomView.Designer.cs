namespace Hotel_Management_System.UI
{
    partial class RoomView
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
            Type = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Avaiable = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
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
            lbl1.Size = new Size(279, 38);
            lbl1.TabIndex = 7;
            lbl1.Text = "View Room Data";
            // 
            // RoomDataGridView
            // 
            RoomDataGridView.AllowUserToAddRows = false;
            RoomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomDataGridView.Columns.AddRange(new DataGridViewColumn[] { RoomNo, Type, Category, Price, Avaiable, Delete, Update });
            RoomDataGridView.Location = new Point(215, 315);
            RoomDataGridView.Name = "RoomDataGridView";
            RoomDataGridView.RowHeadersVisible = false;
            RoomDataGridView.RowHeadersWidth = 62;
            RoomDataGridView.Size = new Size(1166, 546);
            RoomDataGridView.TabIndex = 8;
            RoomDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RoomNo
            // 
            RoomNo.HeaderText = "Room Number";
            RoomNo.MinimumWidth = 8;
            RoomNo.Name = "RoomNo";
            RoomNo.Width = 200;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.Width = 200;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 200;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Avaiable
            // 
            Avaiable.HeaderText = "Avaiable";
            Avaiable.MinimumWidth = 8;
            Avaiable.Name = "Avaiable";
            Avaiable.Width = 150;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Width = 150;
            // 
            // Update
            // 
            Update.HeaderText = "Update";
            Update.MinimumWidth = 8;
            Update.Name = "Update";
            Update.Width = 150;
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "RoomNumber", "Type", "Category", "Price" });
            txtSearchBy.Location = new Point(1107, 249);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(274, 33);
            txtSearchBy.TabIndex = 14;
            txtSearchBy.SelectedIndexChanged += txtSearchBy_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(948, 249);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 13;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(327, 249);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(408, 31);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(215, 249);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 11;
            lbl2.Text = "Search";
            // 
            // RoomView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 993);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(RoomDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomView";
            Text = "RoomView";
            Load += RoomView_Load;
            ((System.ComponentModel.ISupportInitialize)RoomDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView RoomDataGridView;
        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private DataGridViewTextBoxColumn RoomNo;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Avaiable;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Update;
    }
}