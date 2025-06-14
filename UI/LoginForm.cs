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

namespace Hotel_Management_System.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            string checkUserName = txtUserName.Text;
            string checkPassword = txtPassword.Text;
            User user=BLClass.checkUser(checkUserName, checkPassword);
            if (user != null)
            {
                Form topForm = this.TopLevelControl as Form;
                if (topForm != null)
                {
                    topForm.Hide(); 
                }
                if (user.Role=="Admin")
                {
                    new AdminDashboard(BLClass.GetAdmin(user)).Show();
                }
                else if(user.Role=="Customer")
                {
                    Customer cust = BLClass.GetCustomer(user);
                    if (cust != null)
                    {
                        new CustomerDashboard(cust).Show();
                    }
                    else
                    {
                        MessageBox.Show("Customer data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(user.Role=="Employee")
                {
                    new EmployeeDashboard().Show();
                }
            }
            else
            {
                MessageBox.Show("User not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}