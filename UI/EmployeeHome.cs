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
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {
            int orderCount = 0;
            int deliverCount = 0;
            int pendingCount = 0;
            var reader = new DLClass().ReturnQuery("select OrderStatus from Orders;");
            while (reader.Read())
            {
                orderCount++;
                if (Convert.ToBoolean(reader["OrderStatus"]))
                    deliverCount++;
                else
                    pendingCount++;
            }
            lblRoom.Text="Total Rooms:   " + DL.FetchDB.roomList.Count.ToString();
            lblAvaiableRoom.Text = "Available Rooms:   " +FetchDB.availableRoomsCount.ToString();
            lblCustomer.Text="Total Customers:    "+DL.FetchDB.customerList.Count.ToString();
            lblTotalOrder.Text = "Total Orders:   " + orderCount;
            lblDeliveredOrder.Text = "Delivered Orders:   " + deliverCount;
            lblPendingOrder.Text = "Pending Orders:  " + pendingCount;
        }
    }
}
