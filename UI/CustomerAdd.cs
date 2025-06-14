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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Hotel_Management_System.UI
{
    public partial class CustomerAdd : Form
    {
        bool checkAdd = false;
        bool checkUpdate = false;
        string CNIC = "";
        public CustomerAdd(string text, string Header)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = Header;
            checkAdd = true;
            lbl11.Visible = false;
            lbl12.Visible = false;
            this.TopPanel.Enabled = false;
            this.TopPanel.Visible = false;
        }
        public CustomerAdd(string text,string Header, Customer customer)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = Header;
            CNIC = customer.CNIC;
            checkUpdate = true;
            setData(customer);
            TopPanel.Visible = true;
            TopPanel.Enabled = true;
        }
        public void AddCustomer()
        {
            Customer obj = new Customer(txtName.Text, txtCNIC.Text, txtPhoneNo.Text, txtAddress.Text, txtGender.Text, txtUserName.Text, txtPassword.Text);

            if (obj.CheckData())
            {
                lbl11.Visible = true;
                return;
            }

            if (BLClass.IsCustomerExist(obj))
            {
                MessageBox.Show("The Customer already exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AddDB.AddCustomer(obj))
            {
                FetchDB.customerList.Add(obj);
                FetchDB.userList.Add(obj);
                MessageBox.Show("Record Saved Successfully", "Database Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
                txtCNIC.Text = "";
                txtPhoneNo.Text = "";
                txtAddress.Text = "";
                txtGender.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtCPassword.Text = "";
            }
        }
        public void UpdateCustomer()
        {
            Customer obj = new Customer(txtName.Text, txtCNIC.Text, txtPhoneNo.Text, txtAddress.Text, txtGender.Text, txtUserName.Text, txtPassword.Text);

            if (obj.CheckData())
            {
                lbl11.Visible = true;
            }
            else
            {
                if (UpdateDB.UpdateCustomer(CNIC, obj))
                {
                    MessageBox.Show("Record Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkUpdate = false;
                    CustomerView.Instance.LoadFromDB();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {

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
                        AddCustomer();
                    }
                    else if (checkUpdate)
                    {
                        UpdateCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setData(Customer customer)
        {
            txtName.Text = customer.name;
            txtCNIC.Text = customer.CNIC;
            txtGender.Text = customer.Gender;
            txtUserName.Text = customer.UserName;
            txtPassword.Text = customer.Password;
            txtAddress.Text = customer.Address;
            txtPhoneNo.Text = customer.PhoneNo;
            txtCPassword.Text = customer.Password;
        }
    }
}