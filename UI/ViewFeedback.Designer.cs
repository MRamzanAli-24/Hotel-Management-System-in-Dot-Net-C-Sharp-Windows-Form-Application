namespace Hotel_Management_System.UI
{
    partial class ViewFeedback
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
            dataGridViewFeadback = new DataGridView();
            FeedBackID = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneNo = new DataGridViewTextBoxColumn();
            FeedBackView = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeadback).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(680, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(431, 38);
            lbl1.TabIndex = 13;
            lbl1.Text = "View Customers Feedback";
            // 
            // dataGridViewFeadback
            // 
            dataGridViewFeadback.AllowUserToAddRows = false;
            dataGridViewFeadback.AllowUserToDeleteRows = false;
            dataGridViewFeadback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeadback.Columns.AddRange(new DataGridViewColumn[] { FeedBackID, NameColumn, PhoneNo, FeedBackView, Delete });
            dataGridViewFeadback.Location = new Point(280, 222);
            dataGridViewFeadback.Name = "dataGridViewFeadback";
            dataGridViewFeadback.ReadOnly = true;
            dataGridViewFeadback.RowHeadersVisible = false;
            dataGridViewFeadback.RowHeadersWidth = 62;
            dataGridViewFeadback.Size = new Size(1206, 506);
            dataGridViewFeadback.TabIndex = 14;
            dataGridViewFeadback.CellContentClick += dataGridViewFeadback_CellContentClick;
            // 
            // FeedBackID
            // 
            FeedBackID.HeaderText = "Feedback Id";
            FeedBackID.MinimumWidth = 8;
            FeedBackID.Name = "FeedBackID";
            FeedBackID.ReadOnly = true;
            FeedBackID.Width = 150;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 250;
            // 
            // PhoneNo
            // 
            PhoneNo.HeaderText = "Phone Number";
            PhoneNo.MinimumWidth = 8;
            PhoneNo.Name = "PhoneNo";
            PhoneNo.ReadOnly = true;
            PhoneNo.Width = 250;
            // 
            // FeedBackView
            // 
            FeedBackView.HeaderText = "Feedback";
            FeedBackView.MinimumWidth = 8;
            FeedBackView.Name = "FeedBackView";
            FeedBackView.ReadOnly = true;
            FeedBackView.Width = 500;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 150;
            // 
            // ViewFeedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 758);
            Controls.Add(dataGridViewFeadback);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFeedback";
            Text = "ViewFeadback";
            Load += ViewFeedback_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeadback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView dataGridViewFeadback;
        private DataGridViewTextBoxColumn FeedBackID;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneNo;
        private DataGridViewTextBoxColumn FeedBackView;
        private DataGridViewButtonColumn Delete;
    }
}
