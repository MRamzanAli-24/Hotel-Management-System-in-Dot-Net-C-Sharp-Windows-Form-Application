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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System.UI
{
    public partial class AdminView : Form
    {
        public static AdminView Instance;

        public AdminView()
        {
            InitializeComponent();
            Instance = this;
        }

        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchAdmins @1, @2", searchType, searchValue);

            if (reader != null)
            {
                AdminDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    if (Convert.ToBoolean(reader["IsMainAdmin"]) == true)
                    {
                        AdminDataGridView.Rows.Add(reader["Name"].ToString(), reader["CNIC"].ToString(), reader["PhoneNo"].ToString(), reader["Address"].ToString(), reader["Gender"].ToString(), "Can't Delete", "Update");
                    }
                    else
                    {
                        AdminDataGridView.Rows.Add(reader["Name"].ToString(), reader["CNIC"].ToString(), reader["PhoneNo"].ToString(), reader["Address"].ToString(), reader["Gender"].ToString(), "Delete", "Update");
                    }
                }
                reader.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 5)
            {
                if (AdminDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() == "Delete")
                {
                    string CNIC = AdminDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";
                    if (MessageBox.Show("Do you want to Delete the record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool check = DeleteDB.DeleteAdmin(CNIC);
                        if (check)
                        {
                            MessageBox.Show("Data deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("You can not delete Main Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                Admin admin = new Admin();
                foreach (Admin check in FetchDB.adminList)
                {
                    if (check.CNIC == AdminDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString())
                    {
                        admin = check;
                        break;
                    }
                }
                new AdminDashboard(true).showAdminForm(admin);
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            txtSearchBy.SelectedIndex = 0;
        }

        private void txtSeacrch_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }
    }
}
