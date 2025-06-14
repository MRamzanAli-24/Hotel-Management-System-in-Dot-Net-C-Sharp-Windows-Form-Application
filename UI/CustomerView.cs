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
    public partial class CustomerView : Form
    {
        public static CustomerView Instance;
        public CustomerView()
        {
            InitializeComponent();
            Instance = this;
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchCustomers @1, @2", searchType, searchValue);

            if (reader != null)
            {
                CustomerDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    CustomerDataGridView.Rows.Add(reader["Name"].ToString(), reader["CNIC"].ToString(), reader["PhoneNo"].ToString(), reader["Address"].ToString(), reader["Gender"].ToString(),reader["TotalAmount"].ToString()??"","Pay" ,"Delete", "Update");
                }
                reader.Close();
            }
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = CustomerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            string phoneNo = CustomerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "";
            int amount =Convert.ToInt32(CustomerDataGridView.Rows[e.RowIndex].Cells[5].Value);
            string CNIC = CustomerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "";
            if (e.RowIndex > -1 && e.ColumnIndex == 6&& amount>0)
            {
                new UI.BillManagemnet().setData(name,phoneNo,amount,CNIC);
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                Customer obj = new Customer();
                obj.CNIC=CNIC;
                FetchDB.GetOrderList(obj);

                if (!BLClass.capableToDelete(CNIC)&&obj.Orders.Count==0)
                {
                    if (MessageBox.Show("Do you want to Delete the record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool check = DeleteDB.DeleteCustomer(CNIC);
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
                    MessageBox.Show("Cannot Delete the Customer \n Customer has Booked room OR  Customer has to pay amount OR customer has some orders", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 8)
            {
                Customer customer = new Customer();
                foreach (Customer check in FetchDB.customerList)
                {
                    if (check.CNIC == CustomerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString())
                    {
                        customer = check;
                        break;
                    }
                }
                new EmployeeDashboard().showCustomerForm(customer);
            }
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            LoadFromDB();
            txtSearchBy.SelectedIndex = 0;
        }
    }
}
