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
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchAllOrders @1, @2", searchType, searchValue);

            if (reader != null)
            {
                OrderDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    if (Convert.ToBoolean(reader["OrderStatus"]))
                        OrderDataGridView.Rows.Add(Convert.ToInt32(reader["OrderId"]), reader["ItemName"].ToString(), reader["CustomerCNIC"].ToString() ?? "", reader["RoomNumber"].ToString() ?? "", reader["Quantity"].ToString() ?? "", (Convert.ToDateTime(reader["OrderTime"]).Date).ToString("dd-MMM-yy"), Convert.ToInt32(reader["amount"]), "Deliverd", "Delete");
                    else
                        OrderDataGridView.Rows.Add(Convert.ToInt32(reader["OrderId"]), reader["ItemName"].ToString(), reader["CustomerCNIC"].ToString() ?? "", reader["RoomNumber"].ToString() ?? "", reader["Quantity"].ToString() ?? "", (Convert.ToDateTime(reader["OrderTime"]).Date).ToString("dd-MMM-yy"), Convert.ToInt32(reader["amount"]), "Pending", "Can't Delete");

                }
                reader.Close();
            }
        }
        private void ManageOrder_Load(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = Convert.ToInt32(OrderDataGridView.Rows[e.RowIndex].Cells[0].Value);
            int amount = Convert.ToInt32(OrderDataGridView.Rows[e.RowIndex].Cells[6].Value);
            string CNIC = OrderDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                if (OrderDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString() == "Pending")
                {
                    if (MessageBox.Show("Are you sure to deliver the order", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (UpdateDB.orderPlaced(orderID, amount, CNIC))
                            MessageBox.Show("Order Deliverd Succesflly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFromDB();
                    }
                }
                else
                {
                    MessageBox.Show("Order has already Deliverd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 8)
            {
                if (OrderDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString() == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete the order", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (DeleteDB.DeleteOrder(orderID))
                            MessageBox.Show("Order Deleted Succesflly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFromDB();
                    }
                }
                else
                {
                    MessageBox.Show("Can't Delete, As Order has not  Deliverd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}