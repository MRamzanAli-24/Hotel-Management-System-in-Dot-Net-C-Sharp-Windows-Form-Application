namespace Hotel_Management_System.UI
{
    partial class ReportsDetails
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
            ReportDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            PhoneNo = new DataGridViewTextBoxColumn();
            PaidAmount = new DataGridViewTextBoxColumn();
            PaymentDate = new DataGridViewTextBoxColumn();
            lbl1 = new Label();
            txtTotalEarning = new TextBox();
            lbl4 = new Label();
            txtTotalExpance = new TextBox();
            label1 = new Label();
            btn1 = new Button();
            txtExpences = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = SystemColors.Control;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FormattingEnabled = true;
            txtSearchBy.Items.AddRange(new object[] { "All", "ID", "Customer Name", "Customer Phone No", "Paid Amount", "Payment Date" });
            txtSearchBy.Location = new Point(1076, 184);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(191, 33);
            txtSearchBy.TabIndex = 24;
            txtSearchBy.SelectedIndexChanged += txtSearchBy_SelectedIndexChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(923, 189);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 28);
            lbl3.TabIndex = 23;
            lbl3.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(433, 189);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 31);
            txtSearch.TabIndex = 22;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(313, 189);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 28);
            lbl2.TabIndex = 21;
            lbl2.Text = "Search";
            // 
            // ReportDataGridView
            // 
            ReportDataGridView.AllowUserToAddRows = false;
            ReportDataGridView.AllowUserToDeleteRows = false;
            ReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, CustomerName, PhoneNo, PaidAmount, PaymentDate });
            ReportDataGridView.Location = new Point(313, 252);
            ReportDataGridView.Name = "ReportDataGridView";
            ReportDataGridView.ReadOnly = true;
            ReportDataGridView.RowHeadersVisible = false;
            ReportDataGridView.RowHeadersWidth = 62;
            ReportDataGridView.Size = new Size(954, 482);
            ReportDataGridView.TabIndex = 20;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 250;
            // 
            // PhoneNo
            // 
            PhoneNo.HeaderText = "Customer Phone No";
            PhoneNo.MinimumWidth = 8;
            PhoneNo.Name = "PhoneNo";
            PhoneNo.ReadOnly = true;
            PhoneNo.Width = 250;
            // 
            // PaidAmount
            // 
            PaidAmount.HeaderText = "Paid Amount";
            PaidAmount.MinimumWidth = 8;
            PaidAmount.Name = "PaidAmount";
            PaidAmount.ReadOnly = true;
            PaidAmount.Width = 200;
            // 
            // PaymentDate
            // 
            PaymentDate.HeaderText = "Payment Date";
            PaymentDate.MinimumWidth = 8;
            PaymentDate.Name = "PaymentDate";
            PaymentDate.ReadOnly = true;
            PaymentDate.Width = 200;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(226, 38);
            lbl1.TabIndex = 19;
            lbl1.Text = "View Reports";
            // 
            // txtTotalEarning
            // 
            txtTotalEarning.BackColor = SystemColors.Control;
            txtTotalEarning.Location = new Point(577, 833);
            txtTotalEarning.Name = "txtTotalEarning";
            txtTotalEarning.ReadOnly = true;
            txtTotalEarning.Size = new Size(220, 31);
            txtTotalEarning.TabIndex = 78;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(313, 836);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(182, 28);
            lbl4.TabIndex = 77;
            lbl4.Text = "Total Earning";
            // 
            // txtTotalExpance
            // 
            txtTotalExpance.BackColor = SystemColors.Control;
            txtTotalExpance.Location = new Point(577, 796);
            txtTotalExpance.Name = "txtTotalExpance";
            txtTotalExpance.ReadOnly = true;
            txtTotalExpance.Size = new Size(220, 31);
            txtTotalExpance.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(313, 799);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 75;
            label1.Text = "Total Expences";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(577, 922);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 51);
            btn1.TabIndex = 74;
            btn1.Text = "Add";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // txtExpences
            // 
            txtExpences.BackColor = SystemColors.Control;
            txtExpences.Location = new Point(577, 870);
            txtExpences.Name = "txtExpences";
            txtExpences.Size = new Size(220, 31);
            txtExpences.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.Location = new Point(313, 873);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 72;
            label2.Text = "Add Expences";
            // 
            // ReportsDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 1106);
            Controls.Add(txtTotalEarning);
            Controls.Add(lbl4);
            Controls.Add(txtTotalExpance);
            Controls.Add(label1);
            Controls.Add(btn1);
            Controls.Add(txtExpences);
            Controls.Add(label2);
            Controls.Add(txtSearchBy);
            Controls.Add(lbl3);
            Controls.Add(txtSearch);
            Controls.Add(lbl2);
            Controls.Add(ReportDataGridView);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsDetails";
            Text = "ViewReports";
            Load += ViewReports_Load;
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtSearchBy;
        private Label lbl3;
        private TextBox txtSearch;
        private Label lbl2;
        private DataGridView ReportDataGridView;
        private Label lbl1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn PhoneNo;
        private DataGridViewTextBoxColumn PaidAmount;
        private DataGridViewTextBoxColumn PaymentDate;
        private TextBox txtTotalEarning;
        private Label lbl4;
        private TextBox txtTotalExpance;
        private Label label1;
        private Button btn1;
        private TextBox txtExpences;
        private Label label2;
    }
}