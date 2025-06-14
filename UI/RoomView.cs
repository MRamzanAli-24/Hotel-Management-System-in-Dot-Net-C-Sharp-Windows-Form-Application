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
    public partial class RoomView : Form
    {

        public static RoomView Instance;
        public RoomView()
        {
            InitializeComponent();
            Instance = this;
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchRooms @1, @2", searchType, searchValue);

            if (reader != null)
            {
                RoomDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    bool avaiable = Convert.ToBoolean(reader["IsAvailable"]); //IsAvailable
                    if (avaiable)
                    {
                        RoomDataGridView.Rows.Add(reader["RoomNumber"].ToString(), reader["Type"].ToString(), reader["Category"].ToString(), reader["Price"].ToString(), "Avaiable", "Delete", "Update");
                    }
                    else
                    {
                        RoomDataGridView.Rows.Add(reader["RoomNumber"].ToString(), reader["Type"].ToString(), reader["Category"].ToString(), reader["Price"].ToString(), "Not Avaiable", "Delete", "Update");
                    }
                }
                reader.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string RoomNumber = RoomDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            if (e.RowIndex > -1 && e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Do you want to Delete the Room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BLClass.CheckRoom(RoomNumber))
                    {
                        bool check = DeleteDB.DeleteRoom(RoomNumber);
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
                    else
                    {
                        MessageBox.Show("Can not Delete Room as its is not Avaialbe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                Room room = new Room();
                room.RoomNumber = RoomNumber;
                foreach (Room check in FetchDB.roomList)
                {
                    if (check.RoomNumber == RoomNumber)
                    {
                        room = check;
                        break;
                    }
                }
                if (room.isAvaiable)
                {
                    new AdminDashboard(true).showRoomForm(room);
                }
                else
                {
                    MessageBox.Show("Can not Update Room as its is not Avaialbe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }
        private void RoomView_Load(object sender, EventArgs e)
        {
            txtSearchBy.SelectedIndex = 0;
            LoadFromDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }
    }
}
