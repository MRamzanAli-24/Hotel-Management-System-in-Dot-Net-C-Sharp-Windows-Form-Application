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
    public partial class BookingUpdate : Form
    {
        int Amount;
        bool isEmployee = false;
        string CNIC;
        public BookingUpdate(Booking obj, int price)
        {
            InitializeComponent();
            txtRoomNo.Text = obj.BookRoomNo;
            txtCheckInDate.Value = obj.CheckIn;
            txtCheckOutDate.Value = obj.CheckOut;
            Amount = price;
            if (txtCheckInDate.Value.Date <= DateTime.Now.Date)
            {
                txtCheckInDate.Enabled = false;
            }

        }
        public BookingUpdate(Booking obj, int price,bool isEmployee, string cNIC)
        {
            InitializeComponent();
            txtRoomNo.Text = obj.BookRoomNo;
            txtCheckInDate.Value = obj.CheckIn;
            txtCheckOutDate.Value = obj.CheckOut;
            Amount = price;
            if (txtCheckInDate.Value.Date <= DateTime.Now.Date)
            {
                txtCheckInDate.Enabled = false;
            }
            this.isEmployee = isEmployee;
            CNIC = cNIC;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!isEmployee)
            {
                if (txtCheckOutDate.Value.Date > txtCheckInDate.Value.Date)
                {
                    if (MessageBox.Show("Do you want to Update the Booking?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Booking obj = new Booking();
                        obj.BookingDate = DateTime.Now.Date;
                        obj.CheckIn = txtCheckInDate.Value.Date;
                        obj.CheckOut = txtCheckOutDate.Value.Date;
                        obj.BookRoomNo = txtRoomNo.Text;
                        TimeSpan timeSpan = obj.CheckOut - obj.CheckIn;
                        obj.days = timeSpan.Days;
                        obj.customerCNIC = CustomerDashboard.customer.CNIC;
                        if (UpdateDB.UpdateBooking(obj, Amount))
                        {
                            MessageBox.Show("Booking has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FetchDB.GetBookingRoomCustomer(CustomerDashboard.customer);
                            CustomerDashboard.Instance.CheckBooked();
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter the complete and correct data and DATES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtCheckOutDate.Value.Date > txtCheckInDate.Value.Date)
                {
                    if (MessageBox.Show("Do you want to Update the Booking?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Booking obj = new Booking();
                        obj.BookingDate = DateTime.Now.Date;
                        obj.CheckIn = txtCheckInDate.Value.Date;
                        obj.CheckOut = txtCheckOutDate.Value.Date;
                        obj.BookRoomNo = txtRoomNo.Text;
                        TimeSpan timeSpan = obj.CheckOut - obj.CheckIn;
                        obj.days = timeSpan.Days;
                        obj.customerCNIC = CNIC;
                        if (UpdateDB.UpdateBooking(obj, Amount))
                        {
                            MessageBox.Show("Booking has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter the complete and correct data and DATES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
