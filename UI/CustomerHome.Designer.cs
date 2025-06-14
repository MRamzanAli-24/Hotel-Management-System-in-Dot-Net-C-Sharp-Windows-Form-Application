namespace Hotel_Management_System.UI
{
    partial class CustomerHome
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
            TotalAmountPanel = new Panel();
            lblAmount = new Label();
            OrderPanel = new Panel();
            lblPendingOrder = new Label();
            DeliveredOrder = new Panel();
            lblDeliveredOrder = new Label();
            lbl1 = new Label();
            RoomDataPanel = new Panel();
            lblRoom = new Label();
            TotalAmountPanel.SuspendLayout();
            OrderPanel.SuspendLayout();
            DeliveredOrder.SuspendLayout();
            RoomDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TotalAmountPanel
            // 
            TotalAmountPanel.BackColor = Color.Gray;
            TotalAmountPanel.Controls.Add(lblAmount);
            TotalAmountPanel.Location = new Point(823, 600);
            TotalAmountPanel.Name = "TotalAmountPanel";
            TotalAmountPanel.Size = new Size(410, 316);
            TotalAmountPanel.TabIndex = 15;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Century", 14F, FontStyle.Bold);
            lblAmount.ForeColor = SystemColors.Control;
            lblAmount.Location = new Point(30, 234);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(248, 33);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Pending Amount";
            // 
            // OrderPanel
            // 
            OrderPanel.BackColor = Color.Gray;
            OrderPanel.Controls.Add(lblPendingOrder);
            OrderPanel.Location = new Point(381, 600);
            OrderPanel.Name = "OrderPanel";
            OrderPanel.Size = new Size(410, 316);
            OrderPanel.TabIndex = 14;
            // 
            // lblPendingOrder
            // 
            lblPendingOrder.AutoSize = true;
            lblPendingOrder.Font = new Font("Century", 14F, FontStyle.Bold);
            lblPendingOrder.ForeColor = SystemColors.Control;
            lblPendingOrder.Location = new Point(26, 234);
            lblPendingOrder.Name = "lblPendingOrder";
            lblPendingOrder.Size = new Size(179, 33);
            lblPendingOrder.TabIndex = 1;
            lblPendingOrder.Text = "Total Order";
            // 
            // DeliveredOrder
            // 
            DeliveredOrder.BackColor = Color.Gray;
            DeliveredOrder.Controls.Add(lblDeliveredOrder);
            DeliveredOrder.Location = new Point(823, 250);
            DeliveredOrder.Name = "DeliveredOrder";
            DeliveredOrder.Size = new Size(410, 316);
            DeliveredOrder.TabIndex = 13;
            // 
            // lblDeliveredOrder
            // 
            lblDeliveredOrder.AutoSize = true;
            lblDeliveredOrder.Font = new Font("Century", 14F, FontStyle.Bold);
            lblDeliveredOrder.ForeColor = SystemColors.Control;
            lblDeliveredOrder.Location = new Point(30, 234);
            lblDeliveredOrder.Name = "lblDeliveredOrder";
            lblDeliveredOrder.Size = new Size(167, 33);
            lblDeliveredOrder.TabIndex = 2;
            lblDeliveredOrder.Text = "Room Rent";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century", 18F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(458, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(715, 42);
            lbl1.TabIndex = 11;
            lbl1.Text = "Welcome To Hotel Management System";
            // 
            // RoomDataPanel
            // 
            RoomDataPanel.BackColor = Color.Gray;
            RoomDataPanel.Controls.Add(lblRoom);
            RoomDataPanel.Location = new Point(381, 250);
            RoomDataPanel.Name = "RoomDataPanel";
            RoomDataPanel.Size = new Size(410, 316);
            RoomDataPanel.TabIndex = 10;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Century", 14F, FontStyle.Bold);
            lblRoom.ForeColor = SystemColors.Control;
            lblRoom.Location = new Point(30, 223);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(202, 33);
            lblRoom.TabIndex = 1;
            lblRoom.Text = "Booked Room";
            // 
            // CustomerHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 1018);
            Controls.Add(TotalAmountPanel);
            Controls.Add(OrderPanel);
            Controls.Add(DeliveredOrder);
            Controls.Add(lbl1);
            Controls.Add(RoomDataPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerHome";
            Text = "CustomerHome";
            Load += CustomerHome_Load;
            TotalAmountPanel.ResumeLayout(false);
            TotalAmountPanel.PerformLayout();
            OrderPanel.ResumeLayout(false);
            OrderPanel.PerformLayout();
            DeliveredOrder.ResumeLayout(false);
            DeliveredOrder.PerformLayout();
            RoomDataPanel.ResumeLayout(false);
            RoomDataPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TotalAmountPanel;
        private Label lblAmount;
        private Panel OrderPanel;
        private Label lblPendingOrder;
        private Panel DeliveredOrder;
        private Label lblDeliveredOrder;
        private Label lbl1;
        private Panel RoomDataPanel;
        private Label lblRoom;
    }
}