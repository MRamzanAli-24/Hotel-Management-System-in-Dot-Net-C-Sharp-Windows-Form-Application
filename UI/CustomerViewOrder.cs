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
using Microsoft.Data.SqlClient;

namespace Hotel_Management_System.UI
{
    public partial class CustomerViewOrder : Form
    {
        public CustomerViewOrder()
        {
            InitializeComponent();
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchOrderedItems @1, @2,@3;", searchType, searchValue, CustomerDashboard.customer.CNIC);

            if (reader != null)
            {
                OrderDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    if (Convert.ToBoolean(reader["OrderStatus"]) == true)
                    {
                        OrderDataGridView.Rows.Add(reader["OrderID"].ToString() ?? "", reader["ItemName"].ToString() ?? "", reader["Quantity"].ToString() ?? "", reader["amount"].ToString() ?? "", reader["RoomNumber"].ToString() ?? "", Convert.ToDateTime(reader["OrderTime"]).Date.ToString("dd-MMM-yy") ?? "", "Delivered", "Can't Cancel");
                    }
                    else
                    {
                        OrderDataGridView.Rows.Add(reader["OrderID"].ToString() ?? "", reader["ItemName"].ToString() ?? "", reader["Quantity"].ToString() ?? "", reader["amount"].ToString() ?? "", reader["RoomNumber"].ToString() ?? "", Convert.ToDateTime(reader["OrderTime"]).Date.ToString("dd-MMM-yy") ?? "", "Pending", "Cancel");
                    }
                }
                reader.Close();
            }
        }
        private void searchbyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void CustomerViewOrder_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            txtSearchBy.SelectedIndex = 0;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(OrderDataGridView.Rows[e.RowIndex].Cells[0].Value);
            string checkCnacel = OrderDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString() ?? "";
            if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                if (checkCnacel == "Cancel")
                {
                    if (MessageBox.Show("Do you want to cancle the Order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool check = DeleteDB.DeleteOrder(id);
                        if (check)
                        {
                            MessageBox.Show("Order cancled successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFromDB();
                            FetchDB.GetOrderList(CustomerDashboard.customer);
                        }
                        else
                        {
                            MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You can not cancle the Delivered order","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}