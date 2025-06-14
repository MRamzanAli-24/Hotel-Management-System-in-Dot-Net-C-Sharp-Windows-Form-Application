namespace Hotel_Management_System.UI
{
    partial class EmployeeView
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
            lbl1 = new Label();
            EmployeeDataGridView = new DataGridView();
            lbl2 = new Label();
            EmployeeName = new DataGridViewTextBoxColumn();
            CNIC = new DataGridViewTextBoxColumn();
            Phone_NO = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Update = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "Name", "CNIC", "Phone Number", "Gender", "Address" });
            txtSearchBy.Location = new Point(1249, 230);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(274, 33);
            txtSearchBy.TabIndex = 15;
            txtSearchBy.SelectedIndexChanged += searchbyBox_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(1091, 232);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 14;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(193, 235);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(486, 31);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(344, 38);
            lbl1.TabIndex = 12;
            lbl1.Text = "View Employee Data";
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.AllowUserToAddRows = false;
            EmployeeDataGridView.AllowUserToDeleteRows = false;
            EmployeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, CNIC, Phone_NO, Address, Gender, Salary, Delete, Update });
            EmployeeDataGridView.Location = new Point(56, 290);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.RowHeadersVisible = false;
            EmployeeDataGridView.RowHeadersWidth = 62;
            EmployeeDataGridView.Size = new Size(1465, 621);
            EmployeeDataGridView.TabIndex = 11;
            EmployeeDataGridView.CellContentClick += EmployeeDataGridView_CellContentClick;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(56, 235);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 16;
            lbl2.Text = "Search";
            // 
            // EmployeeName
            // 
            EmployeeName.FillWeight = 13.2796421F;
            EmployeeName.HeaderText = "Name";
            EmployeeName.MinimumWidth = 8;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 250;
            // 
            // CNIC
            // 
            CNIC.FillWeight = 13.2796421F;
            CNIC.HeaderText = "CNIC";
            CNIC.MinimumWidth = 8;
            CNIC.Name = "CNIC";
            CNIC.ReadOnly = true;
            CNIC.Width = 250;
            // 
            // Phone_NO
            // 
            Phone_NO.FillWeight = 13.2796421F;
            Phone_NO.HeaderText = "Phone Number";
            Phone_NO.MinimumWidth = 8;
            Phone_NO.Name = "Phone_NO";
            Phone_NO.ReadOnly = true;
            Phone_NO.Width = 200;
            // 
            // Address
            // 
            Address.FillWeight = 13.2796421F;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 250;
            // 
            // Gender
            // 
            Gender.FillWeight = 13.2796421F;
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 150;
            // 
            // Salary
            // 
            Salary.FillWeight = 13.2796421F;
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 8;
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
            Salary.Width = 150;
            // 
            // Delete
            // 
            Delete.FillWeight = 454.545441F;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 150;
            // 
            // Update
            // 
            Update.FillWeight = 265.776733F;
            Update.HeaderText = "Update";
            Update.MinimumWidth = 8;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Width = 150;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 974);
            Controls.Add(lbl2);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl1);
            Controls.Add(EmployeeDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeView";
            Text = "EmployeeView";
            Load += EmployeeView_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl1;
        private DataGridView EmployeeDataGridView;
        private Label lbl2;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn CNIC;
        private DataGridViewTextBoxColumn Phone_NO;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Update;
    }
}