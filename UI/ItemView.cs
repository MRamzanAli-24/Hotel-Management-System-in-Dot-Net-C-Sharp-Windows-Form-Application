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
    public partial class ItemView : Form
    {
        public static ItemView Instance;

        public ItemView()
        {
            InitializeComponent();
            Instance = this;
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchFoodItems @1, @2", searchType, searchValue);

            if (reader != null)
            {
                ItemDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    ItemDataGridView.Rows.Add(reader["ItemName"].ToString() ?? "", reader["ItemPrice"].ToString() ?? "", "Delete", "Update");
                }
                reader.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void searchbyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = ItemDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            int price = Convert.ToInt32(ItemDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Do you want to Delete the Item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool check = DeleteDB.DeleteItem(name);
                    if (check)
                    {
                        MessageBox.Show("Data deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFromDB();
                        FetchDB.GetRoomData();
                    }
                    else
                    {
                        MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 3)
            {
                FoodItem item = new FoodItem();
                item.itemName = name;
                item.itemPrice = price;

                if (item!=null)
                {
                    new EmployeeDashboard().showItemForm(item);
                }
                else
                {
                    MessageBox.Show("Can not Update Room as its is not Avaialbe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            txtSearchBy.SelectedIndex = 0;
        }
    }
}
