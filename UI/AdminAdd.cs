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
    public partial class AdminAdd : Form
    {
        bool checkAdd = false;
        bool checkUpdate = false;
        public AdminAdd(string text,string header)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = header;
            checkAdd = true;
            TopPanel.Visible = false;
            TopPanel.Enabled = false;
        }
        public static string CNIC = "";
        public AdminAdd(string text, string header, Admin admin)
        {
            InitializeComponent();
            setData(admin);
            btn1.Text = text;
            lbl1.Text = header;
            CNIC = admin.CNIC;
            checkUpdate = true;

            TopPanel.Visible = true;
            TopPanel.Enabled = true;
        }
        public void AddAdmin()
        {
            Admin obj = new Admin(txtName.Text, txtCNIC.Text, txtPhoneNo.Text, txtAddress.Text, txtGender.Text, txtUserName.Text, txtPassword.Text);

            if (obj.CheckData())
            {
                lbl11.Visible = true;
                return;
            }

            if (BLClass.IsAdminExist(obj))
            {
                MessageBox.Show("The Admin already exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AddDB.AddAdmin(obj))
            {
                FetchDB.adminList.Add(obj);
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
            }
        }
        public void UpdateAdmin()
        {
            Admin obj = new Admin(txtName.Text, txtCNIC.Text, txtPhoneNo.Text, txtAddress.Text, txtGender.Text, txtUserName.Text, txtPassword.Text);

            if (obj.CheckData())
            {
                lbl11.Visible = true;
            }
            else
            {
                if (UpdateDB.UpdateAdmin(CNIC, obj))
                {
                    MessageBox.Show("Record Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkUpdate = false;
                    AdminView.Instance.LoadFromDB();
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
                        AddAdmin();
                    }
                    else if (checkUpdate)
                    {
                        UpdateAdmin();
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


        public void setData(Admin admin)
        {
            txtName.Text = admin.name;
            txtCNIC.Text = admin.CNIC;
            txtGender.Text = admin.Gender;
            txtUserName.Text = admin.UserName;
            txtPassword.Text = admin.Password;
            txtAddress.Text = admin.Address;
            txtPhoneNo.Text = admin.PhoneNo;
            txtCPassword.Text = admin.Password;
        }
        private void AdminAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}