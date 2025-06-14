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

namespace Hotel_Management_System.UI
{
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
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
        void setLocaion()
        {
            CustomerPanel.Location = new Point(43, 203);
            BookingPanel.Location = new Point(43, 267);
            ItemPanel.Location = new Point(43, 335);
            OrderPanel.Location = new Point(43, 399);
            LogoutPanel.Location = new Point(43, 467);
        }
        public void showCustomerForm(Customer customer)
        {
            CustomerAdd obj = new CustomerAdd("Update Admin Data", "Update", customer);
            obj.ShowDialog();
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
        public void showItemForm(FoodItem item)
        {
            ItemAdd obj = new ItemAdd("Update Food Item Data", "Update", item);
            obj.ShowDialog();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new EmployeeHome());
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerAdd("Add", "Enter Customer Data"));
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new CustomerView());
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new BookingAdd(true));
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new BookingView());
        }
        private void btn13_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new ItemAdd("Add", "Enter Item data"));
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new ItemView());
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            BookingPanel.Size = BookingPanel.MinimumSize;
            ItemPanel.Size = ItemPanel.MinimumSize;
            CustomerPanel.Size = CustomerPanel.MinimumSize;
            setLocaion();
            MainPanel.Controls.Clear();
            LoadForm(new ManageOrder());
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            int heightDifference = CustomerPanel.MaximumSize.Height - CustomerPanel.MinimumSize.Height;
            BookingPanel.Size= BookingPanel.MinimumSize;
            ItemPanel.Size= ItemPanel.MinimumSize;
            setLocaion();
            if (CustomerPanel.Size == CustomerPanel.MaximumSize)
            {
                CustomerPanel.Size = CustomerPanel.MinimumSize;
            }
            else
            {
                CustomerPanel.Size = CustomerPanel.MaximumSize;
                BookingPanel.Top += heightDifference;
                ItemPanel.Top += heightDifference;
                OrderPanel.Top += heightDifference;
                LogoutPanel.Top += heightDifference;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int heightDifference = BookingPanel.MaximumSize.Height - BookingPanel.MinimumSize.Height;
            CustomerPanel.Size = CustomerPanel.MinimumSize;
            ItemPanel.Size = ItemPanel.MinimumSize;
            setLocaion();
            if (BookingPanel.Size == BookingPanel.MaximumSize)
            {
                BookingPanel.Size = BookingPanel.MinimumSize;
            }
            else
            {
                BookingPanel.Size = BookingPanel.MaximumSize;
                ItemPanel.Top += heightDifference;
                OrderPanel.Top += heightDifference;
                LogoutPanel.Top += heightDifference;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            int heightDifference = ItemPanel.MaximumSize.Height - ItemPanel.MinimumSize.Height;
            CustomerPanel.Size = CustomerPanel.MinimumSize;
            BookingPanel.Size = BookingPanel.MinimumSize;
            setLocaion();
            if (ItemPanel.Size == ItemPanel.MaximumSize)
            {
                ItemPanel.Size = ItemPanel.MinimumSize;
            }
            else
            {
                ItemPanel.Size = ItemPanel.MaximumSize;
                OrderPanel.Top += heightDifference;
                LogoutPanel.Top += heightDifference;
            }
        }


        private void btn18_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginFormDashboard().Show();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LoadForm(new EmployeeHome());
        }
    }
}