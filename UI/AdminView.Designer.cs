namespace Hotel_Management_System.UI
{
    partial class AdminView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AdminDataGridView = new DataGridView();
            AdminName = new DataGridViewTextBoxColumn();
            CNIC = new DataGridViewTextBoxColumn();
            Phone_NO = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            lbl1 = new Label();
            lbl2 = new Label();
            txtSearch = new TextBox();
            lbl3 = new Label();
            txtSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AdminDataGridView
            // 
            AdminDataGridView.AllowUserToAddRows = false;
            AdminDataGridView.AllowUserToDeleteRows = false;
            AdminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminDataGridView.Columns.AddRange(new DataGridViewColumn[] { AdminName, CNIC, Phone_NO, Address, Gender, Delete, Update });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            AdminDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            AdminDataGridView.Location = new Point(108, 317);
            AdminDataGridView.Name = "AdminDataGridView";
            AdminDataGridView.ReadOnly = true;
            AdminDataGridView.RowHeadersVisible = false;
            AdminDataGridView.RowHeadersWidth = 62;
            AdminDataGridView.Size = new Size(1313, 547);
            AdminDataGridView.TabIndex = 0;
            AdminDataGridView.CellContentClick += dataGridView1_CellContentClick;
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(296, 38);
            lbl1.TabIndex = 6;
            lbl1.Text = "View Admin Data";
            lbl1.Click += lbl1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(108, 251);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 7;
            lbl2.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(220, 251);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(486, 31);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSeacrch_TextChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(994, 249);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 9;
            lbl3.Text = "Search by";
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Name", "CNIC", "Phone Number", "Gender", "Address" });
            txtSearchBy.Location = new Point(1147, 246);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(274, 33);
            txtSearchBy.TabIndex = 10;
            txtSearchBy.SelectedIndexChanged += txtSearchBy_SelectedIndexChanged;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 884);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(AdminDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminView";
            Load += AdminView_Load;
            ((System.ComponentModel.ISupportInitialize)AdminDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AdminDataGridView;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtSearch;
        private Label lbl3;
        private ComboBox txtSearchBy;
        private DataGridViewTextBoxColumn AdminName;
        private DataGridViewTextBoxColumn CNIC;
        private DataGridViewTextBoxColumn Phone_NO;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Update;
    }
}