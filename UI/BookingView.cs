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
using Microsoft.Data.SqlClient;

namespace Hotel_Management_System.UI
{
    public partial class BookingView : Form
    {
        public BookingView()
        {
            InitializeComponent();
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchAllBookings @1, @2", searchType, searchValue);

            if (reader != null)
            {
                BookedDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    BookedDataGridView.Rows.Add(reader["RoomNumber"].ToString(), reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["PhoneNo"].ToString ()?? "", reader["RoomType"].ToString(), reader["RoomCategory"].ToString(), (Convert.ToDateTime(reader["BookingDate"]).Date).ToString("dd-MMM-yy"),( Convert.ToDateTime((Convert.ToDateTime(reader["CheckInDate"])).Date).ToString("dd-MMM-yy")), (Convert.ToDateTime(reader["CheckOutDate"]).Date).ToString("dd-MMM-yy"), Convert.ToInt32(reader["DurationDays"]), Convert.ToInt32(reader["RoomPrice"].ToString()), "Cancel", "Update");                    
                }
                reader.Close();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSeacrhBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string RoomNumber = BookedDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            DateTime CheckInDate = Convert.ToDateTime(BookedDataGridView.Rows[e.RowIndex].Cells[7].Value).Date;
            DateTime CheckOutDate = Convert.ToDateTime(BookedDataGridView.Rows[e.RowIndex].Cells[8].Value).Date;
            int days = Convert.ToInt32(BookedDataGridView.Rows[e.RowIndex].Cells[9].Value);
            int price = Convert.ToInt32(BookedDataGridView.Rows[e.RowIndex].Cells[10].Value);
            int totalPrice = price * days;
            string CNIC = BookedDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "";
            if (e.RowIndex > -1 && e.ColumnIndex == 11)
            {
                if (DateTime.Now < CheckInDate)
                {
                    if (MessageBox.Show("Do you want to Cancle the Booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool check = DeleteDB.DeleteBooking(RoomNumber, CNIC);
                        if (check)
                        {
                            MessageBox.Show("Booked room canceled successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FetchDB.GetRoomData();
                            LoadFromDB();
                        }
                        else
                        {
                            MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Now the CheckIN Date has start \n So can not delete the Booking", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 12)
            {
                Booking obj = new Booking(RoomNumber, CheckInDate, CheckOutDate, price);
                new BookingUpdate(obj, totalPrice,true,CNIC).ShowDialog();
                LoadFromDB();
            }
        }

        private void BookingView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
        }
    }
}
