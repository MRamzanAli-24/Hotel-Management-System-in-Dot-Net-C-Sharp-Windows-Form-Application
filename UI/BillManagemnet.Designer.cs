namespace Hotel_Management_System.UI
{
    partial class BillManagemnet
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
            TopPanel = new Panel();
            btn1 = new Button();
            lbl1 = new Label();
            txtRemaining = new TextBox();
            lbl6 = new Label();
            txtPayable = new TextBox();
            lbl5 = new Label();
            txtAmount = new TextBox();
            lbl4 = new Label();
            txtPhoneNo = new TextBox();
            lbl3 = new Label();
            txtName = new TextBox();
            lbl2 = new Label();
            lbl7 = new Label();
            btn3 = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Gray;
            TopPanel.Controls.Add(btn1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(684, 45);
            TopPanel.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.Cursor = Cursors.Hand;
            btn1.Dock = DockStyle.Right;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(635, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 45);
            btn1.TabIndex = 6;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(196, 80);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(318, 38);
            lbl1.TabIndex = 8;
            lbl1.Text = "Customer Payment";
            // 
            // txtRemaining
            // 
            txtRemaining.BackColor = SystemColors.Control;
            txtRemaining.Location = new Point(326, 394);
            txtRemaining.Name = "txtRemaining";
            txtRemaining.ReadOnly = true;
            txtRemaining.Size = new Size(220, 31);
            txtRemaining.TabIndex = 53;
            // 
            // lbl6
            // 
            lbl6.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl6.Location = new Point(117, 394);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(148, 60);
            lbl6.TabIndex = 52;
            lbl6.Text = "Remaining Amount";
            // 
            // txtPayable
            // 
            txtPayable.BackColor = SystemColors.Control;
            txtPayable.Location = new Point(326, 339);
            txtPayable.Name = "txtPayable";
            txtPayable.Size = new Size(220, 31);
            txtPayable.TabIndex = 51;
            txtPayable.TextChanged += txtPayable_TextChanged;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl5.Location = new Point(117, 339);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(160, 28);
            lbl5.TabIndex = 50;
            lbl5.Text = "Pay Amount";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.Control;
            txtAmount.Location = new Point(326, 285);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(220, 31);
            txtAmount.TabIndex = 49;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl4.Location = new Point(117, 285);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(178, 28);
            lbl4.TabIndex = 48;
            lbl4.Text = "Total Amount";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.BackColor = SystemColors.Control;
            txtPhoneNo.Location = new Point(326, 229);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.ReadOnly = true;
            txtPhoneNo.Size = new Size(220, 31);
            txtPhoneNo.TabIndex = 47;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl3.Location = new Point(117, 229);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(129, 28);
            lbl3.TabIndex = 46;
            lbl3.Text = "Phone No";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Location = new Point(326, 170);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(220, 31);
            txtName.TabIndex = 45;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century", 12F, FontStyle.Bold);
            lbl2.Location = new Point(117, 168);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(82, 28);
            lbl2.TabIndex = 44;
            lbl2.Text = "Name";
            // 
            // lbl7
            // 
            lbl7.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.Red;
            lbl7.Location = new Point(117, 471);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(378, 75);
            lbl7.TabIndex = 55;
            lbl7.Text = "*Enter Current Payable amount";
            lbl7.Visible = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.Control;
            btn3.Location = new Point(382, 549);
            btn3.Name = "btn3";
            btn3.Size = new Size(164, 51);
            btn3.TabIndex = 56;
            btn3.Text = "Pay";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // BillManagemnet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 671);
            Controls.Add(btn3);
            Controls.Add(lbl7);
            Controls.Add(txtRemaining);
            Controls.Add(lbl6);
            Controls.Add(txtPayable);
            Controls.Add(lbl5);
            Controls.Add(txtAmount);
            Controls.Add(lbl4);
            Controls.Add(txtPhoneNo);
            Controls.Add(lbl3);
            Controls.Add(txtName);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillManagemnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillMaagemnet";
            Load += BillMaagemnet_Load;
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Button btn1;
        private Label lbl1;
        private TextBox txtRemaining;
        private Label lbl6;
        private TextBox txtPayable;
        private Label lbl5;
        private TextBox txtAmount;
        private Label lbl4;
        private TextBox txtPhoneNo;
        private Label lbl3;
        private TextBox txtName;
        private Label lbl2;
        private Label lbl7;
        private Button btn3;
    }
}