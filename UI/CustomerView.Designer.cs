namespace Hotel_Management_System.UI
{
    partial class CustomerView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lbl1 = new Label();
            txtSearchBy = new ComboBox();
            lbl3 = new Label();
            txtSearch = new TextBox();
            lbl2 = new Label();
            CustomerDataGridView = new DataGridView();
            AdminName = new DataGridViewTextBoxColumn();
            CNIC = new DataGridViewTextBoxColumn();
            Phone_NO = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Pay = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(344, 38);
            lbl1.TabIndex = 7;
            lbl1.Text = "View Customer Data";
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Name", "CNIC", "Phone Number", "Gender", "Address" });
            txtSearchBy.Location = new Point(1093, 280);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(315, 33);
            txtSearchBy.TabIndex = 14;
            txtSearchBy.SelectedIndexChanged += txtSearchBy_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(940, 277);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 13;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(207, 280);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(466, 31);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(95, 280);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 11;
            lbl2.Text = "Search";
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.AllowUserToAddRows = false;
            CustomerDataGridView.AllowUserToDeleteRows = false;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Columns.AddRange(new DataGridViewColumn[] { AdminName, CNIC, Phone_NO, Address, Gender, Amount, Pay, Delete, Update });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            CustomerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            CustomerDataGridView.Location = new Point(95, 342);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidth = 62;
            CustomerDataGridView.Size = new Size(1313, 547);
            CustomerDataGridView.TabIndex = 15;
            CustomerDataGridView.CellContentClick += CustomerDataGridView_CellContentClick;
            // 
            // AdminName
            // 
            AdminName.HeaderText = "Name";
            AdminName.MinimumWidth = 8;
            AdminName.Name = "AdminName";
            AdminName.ReadOnly = true;
            AdminName.Width = 250;
            // 
            // CNIC
            // 
            CNIC.HeaderText = "CNIC";
            CNIC.MinimumWidth = 8;
            CNIC.Name = "CNIC";
            CNIC.ReadOnly = true;
            CNIC.Width = 250;
            // 
            // Phone_NO
            // 
            Phone_NO.HeaderText = "Phone Number";
            Phone_NO.MinimumWidth = 8;
            Phone_NO.Name = "Phone_NO";
            Phone_NO.ReadOnly = true;
            Phone_NO.Width = 250;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 250;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 150;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 150;
            // 
            // Pay
            // 
            Pay.HeaderText = "Pay";
            Pay.MinimumWidth = 8;
            Pay.Name = "Pay";
            Pay.ReadOnly = true;
            Pay.Width = 150;
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
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 948);
            Controls.Add(CustomerDataGridView);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerView";
            Text = "CustomerView";
            Load += CustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lbl1;
        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private DataGridView CustomerDataGridView;
        private DataGridViewTextBoxColumn AdminName;
        private DataGridViewTextBoxColumn CNIC;
        private DataGridViewTextBoxColumn Phone_NO;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewButtonColumn Pay;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Update;
    }
}
