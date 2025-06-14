using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.DL;

namespace Hotel_Management_System.UI
{
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            int pendingOrder = 0;
            int deliveredOrder = 0;
            var reader= new DLClass().ReturnQuery("SELECT OrderStatus FROM Orders WHERE CustomerCNIC = @1", CustomerDashboard.customer.CNIC);
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["OrderStatus"]) )
                {
                    deliveredOrder++;
                }
                else
                {
                    pendingOrder++;
                }
            }
            lblRoom.Text = "Booked Room:   " + CustomerDashboard.customer.Bookings.Count;
            lblAmount.Text = "Pending Amount:  " + CustomerDashboard.customer.totalAmount;
            lblDeliveredOrder.Text = "Delivered Orders:   "+deliveredOrder;
            lblPendingOrder.Text = "Pending Orders:  " + pendingOrder;
        }
    }
}
