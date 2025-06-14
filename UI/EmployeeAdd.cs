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

namespace Hotel_Management_System.UI
{
    public partial class EmployeeAdd : Form
    {
        bool checkAdd = false;
        bool checkUpdate = false;
        public EmployeeAdd(string text, string header)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = header;
            checkAdd = true;
            TopPanel.Visible = false;
            TopPanel.Enabled = false;
        }
        public static string CNIC = "";
        public EmployeeAdd(string text, string header, Employee employee)
        {
            InitializeComponent();
            setData(employee);
            btn1.Text = text;
            lbl1.Text = header;
            CNIC = employee.CNIC;
            checkUpdate = true;
            TopPanel.Visible = true;
            TopPanel.Enabled = true;
        }
        public void AddEmployee()
        {
            Employee obj = new Employee(txtName.Text, txtCNIC.Text, txtPhoneNo.Text, txtAddress.Text, txtGender.Text, txtUserName.Text, txtPassword.Text, Convert.ToInt32(txtSalary.Text));

            if (obj.CheckData())
            {
                lbl11.Visible = true;
                return;
            }

            if (BLClass.IsEmployeeExist(obj))
            {
                MessageBox.Show("The Admin already exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AddDB.AddEmployee(obj))
            {
                FetchDB.employeeList.Add(obj);
                FetchDB.userList.Add(obj);
                MessageBox.Show("Record Saved Successfully", "Database Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkAdd = false;
                txtName.Text = "";
                txtCNIC.Text = "";
                txtPhoneNo.Text = "";
                txtAddress.Text = "";
                txtGender.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtCPassword.Text = "";
                txtSalary.Text = "";
            }
        }
        public void UpdateEmployee()
        {
            Employee obj = new Employee(txtName.Text, txtCNIC.Text, txtPhoneNo.Text, txtAddress.Text, txtGender.Text, txtUserName.Text, txtPassword.Text, Convert.ToInt32(txtSalary.Text));

            if (obj.CheckData())
            {
                lbl11.Visible = true;
            }
            else
            {
                if (UpdateDB.UpdateEmployee(CNIC, obj))
                {
                    MessageBox.Show("Record Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkUpdate = false;
                    EmployeeView.Instance.LoadFromDB();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            lbl11.Visible = false;
            lbl12.Visible = false;

            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtCPassword.Text))
            {
                if (txtPassword.Text == txtCPassword.Text)
                {
                    if (checkAdd)
                    {
                        AddEmployee();
                    }
                    else if (checkUpdate)
                    {
                        UpdateEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    lbl12.Visible = true;
                }
            }
            else
            {
                lbl11.Visible = true;
            }
        }
        public void setData(Employee employee)
        {
            txtName.Text = employee.name;
            txtCNIC.Text = employee.CNIC;
            txtGender.Text = employee.Gender;
            txtUserName.Text = employee.UserName;
            txtPassword.Text = employee.Password;
            txtAddress.Text = employee.Address;
            txtPhoneNo.Text = employee.PhoneNo;
            txtCPassword.Text = employee.Password;
            txtSalary.Text = employee.salary.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}