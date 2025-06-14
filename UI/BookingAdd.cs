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
using Hotel_Management_System.BL;
using Microsoft.Data.SqlClient;

namespace Hotel_Management_System.UI
{
    public partial class BookingAdd : Form
    {
        bool isEmployee = false;
        int priceindex;
        public BookingAdd()
        {
            InitializeComponent();
            if (CustomerDashboard.customer.BookedRoom)
                txtRoomNo.ReadOnly = false;
            else
                txtRoomNo.ReadOnly = true;
        }
        public BookingAdd(bool isEmployee)
        {
            InitializeComponent();
            this.isEmployee = isEmployee;
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchAvailableRooms @1, @2", searchType, searchValue);

            if (reader != null)
            {
                RoomDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    RoomDataGridView.Rows.Add(reader["RoomNumber"].ToString(), reader["Type"].ToString(), reader["Category"].ToString(), reader["Price"].ToString(), "Book Room");
                }
                reader.Close();
            }
        }
        private void BookingAdd_Load(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void searchbyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void RoomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isEmployee)
            {
                if (e.RowIndex > -1 && e.ColumnIndex == 4)
                {
                    txtRoomNo.Text = RoomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                    priceindex = Convert.ToInt32(RoomDataGridView.Rows[e.RowIndex].Cells[3].Value);
                    txtCNIC.Text = CustomerDashboard.customer.CNIC;
                    txtRoomNo.ReadOnly = true;

                }
            }
            else
            {
                if (e.RowIndex > -1 && e.ColumnIndex == 4)
                {
                    txtRoomNo.Text = RoomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                    priceindex = Convert.ToInt32(RoomDataGridView.Rows[e.RowIndex].Cells[3].Value);
                    txtRoomNo.ReadOnly = false;
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (!isEmployee)
            {
                if (txtCheckOutDate.Value.Date > txtCheckInDate.Value.Date && txtCheckInDate.Value > DateTime.Now.Date && txtCNIC != null && txtRoomNo != null)
                {
                    if (MessageBox.Show("Do you want to Book the Room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Booking obj = new Booking();
                        obj.customerCNIC = txtCNIC.Text;
                        obj.BookingDate = DateTime.Now.Date;
                        obj.CheckIn = txtCheckInDate.Value.Date;
                        obj.CheckOut = txtCheckOutDate.Value.Date;
                        TimeSpan timeSpan = obj.CheckOut - obj.CheckIn;
                        obj.days = timeSpan.Days;
                        obj.BookRoomNo = txtRoomNo.Text;
                        obj.price = obj.days * priceindex;
                        if (AddDB.AddBooking(obj))
                        {
                            MessageBox.Show("Room has been booked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CustomerDashboard.customer.Bookings.Add(obj);
                            CustomerDashboard.Instance.CheckBooked();
                            LoadFromDB();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtCheckOutDate.Value.Date > txtCheckInDate.Value.Date && txtCheckInDate.Value > DateTime.Now.Date && txtCNIC != null && txtRoomNo != null)
                {
                    if (BLClass.checkCustomer(txtCNIC.Text))
                    {
                        if (MessageBox.Show("Do you want to Book the Room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Booking obj = new Booking();
                            obj.customerCNIC = txtCNIC.Text;
                            obj.BookingDate = DateTime.Now.Date;
                            obj.CheckIn = txtCheckInDate.Value.Date;
                            obj.CheckOut = txtCheckOutDate.Value.Date;
                            TimeSpan timeSpan = obj.CheckOut - obj.CheckIn;
                            obj.days = timeSpan.Days;
                            obj.BookRoomNo = txtRoomNo.Text;
                            obj.price = obj.days * priceindex;
                            if (AddDB.AddBooking(obj))
                            {
                                MessageBox.Show("Room has been booked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadFromDB();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer with this CNIC does not exist","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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