using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.BL;
using Hotel_Management_System.DL;
namespace Hotel_Management_System.UI
{
    public partial class CustomerDashboard : Form
    {
        public static CustomerDashboard Instance;

        public static Customer customer { get; set; }
        public CustomerDashboard(Customer customer)
        {
            CustomerDashboard.customer = customer;
            InitializeComponent();
            Instance = this;
            CheckBooked();
        }
        public void CheckBooked()
        {
            FetchDB.GetBookingRoomCustomer(CustomerDashboard.customer);
            if (CustomerDashboard.customer.Bookings.Count > 0 && BLClass.checkInDateConfirm(customer))
            {
                CustomerDashboard.customer.BookedRoom = true;
                FetchDB.GetOrderList(CustomerDashboard.customer);
            }
            else
            {
                CustomerDashboard.customer.BookedRoom = false;
            }
            if (!customer.BookedRoom)
            {
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else
            {
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            if (form is Form obj)
            {
                obj.TopLevel = false;
                obj.Dock = DockStyle.Fill;
                this.MainPanel.Controls.Add(obj);
                this.MainPanel.Tag = obj;
                obj.Show();
            }
        }
        private void btn3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerHome());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new BookingAdd());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerBookingView());
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerAddOrder());
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerFeedback());
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginFormDashboard().Show();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerHome());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerViewOrder());
        }
    }
}
