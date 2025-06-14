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
    public partial class CustomerAddOrder : Form
    {
        string Name;
        int price;
        int totalPrice;
        public CustomerAddOrder()
        {
            InitializeComponent();
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchFoodItems @1, @2", searchType, searchValue);

            if (reader != null)
            {
                OrderDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    OrderDataGridView.Rows.Add(reader["ItemName"].ToString() ?? "", reader["ItemPrice"].ToString() ?? "", "Order");
                }
                reader.Close();
            }
        }
        public void LoadRoomData()
        {
            txtcbRoomNumber.Items.Clear();

            foreach (Booking booking in CustomerDashboard.customer.Bookings)
            {
                txtcbRoomNumber.Items.Add(booking.BookRoomNo);
            }
        }

        private void CustomerAddOrder_Load(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name = OrderDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            price = Convert.ToInt32(OrderDataGridView.Rows[e.RowIndex].Cells[1].Value);
            if (e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                txtItemName.Text = Name;
                LoadRoomData();
            }
        }
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                totalPrice = price * Convert.ToInt16(txtQuantity.Text);
                txtPrice.Text = totalPrice.ToString();
            }
            else
            {
                txtPrice.Text = 0.ToString();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemName.Text) && totalPrice > 0 && !string.IsNullOrEmpty(txtcbRoomNumber.Text))
            {
                if (AddDB.PlaceOder(Name, Convert.ToInt32(txtQuantity.Text), totalPrice, txtcbRoomNumber.Text, CustomerDashboard.customer.CNIC))
                {
                    MessageBox.Show("Order Placed successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter complete information ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}