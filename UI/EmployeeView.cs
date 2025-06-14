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
    public partial class EmployeeView : Form
    {
        public static EmployeeView Instance;

        public EmployeeView()
        {
            InitializeComponent();
            Instance = this;
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchEmployees @1, @2", searchType, searchValue);

            if (reader != null)
            {
                EmployeeDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    EmployeeDataGridView.Rows.Add(reader["Name"].ToString(), reader["CNIC"].ToString(), reader["PhoneNo"].ToString(), reader["Address"].ToString(), reader["Gender"].ToString(), reader["Salary"], "Delete", "Update");
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

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                string CNIC = EmployeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";
                if (MessageBox.Show("Do you want to Delete the record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool check = DeleteDB.DeleteEmployee(CNIC);
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
            else if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                Employee employee = new Employee();
                foreach (Employee check in FetchDB.employeeList)
                {
                    if (check.CNIC == EmployeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString())
                    {
                        employee = check;
                        break;
                    }
                }
                new AdminDashboard(true).showEmployeeForm(employee);
            }
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            txtSearchBy.SelectedIndex = 0;
        }
    }
}
