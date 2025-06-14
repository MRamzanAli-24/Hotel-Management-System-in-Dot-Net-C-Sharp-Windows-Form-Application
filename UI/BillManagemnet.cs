using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.DL;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Hotel_Management_System.UI
{
    public partial class BillManagemnet : Form
    {
        public BillManagemnet()
        {
            InitializeComponent();
           
        }
        string CNIC;
        string phone;
        string name;
        public void setData(string name, string phoneNo, int amount, string cnic)
        {
            if (amount > 0)
            {
                txtName.Text = name;
                txtPhoneNo.Text = phoneNo;
                txtAmount.Text = amount.ToString();
                this.CNIC = cnic;
                this.name = name;
                this.phone = phoneNo;
                this.ShowDialog();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillMaagemnet_Load(object sender, EventArgs e)
        {

        }

        private void txtPayable_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPayable.Text))
            {
                int remaining = Convert.ToInt32(txtAmount.Text) - Convert.ToInt32(txtPayable.Text);
                txtRemaining.Text = remaining.ToString();
            }
            else
            {
                txtRemaining.Text = null;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int remaining = 0; int amount = 0; int payable = 0;
            bool check1 = int.TryParse(txtRemaining.Text, out remaining);
            bool check2 = int.TryParse(txtAmount.Text, out amount);
            bool check3 = int.TryParse(txtPayable.Text, out payable);
            if (remaining >= 0 && remaining <= amount)
            {
                if (MessageBox.Show("Are you sure customer has paid the amount", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (AddDB.AddPyement(txtName.Text, CNIC, txtPhoneNo.Text, payable))
                    {
                        MessageBox.Show("Payment added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustomerView.Instance.LoadFromDB();
                    }
                }
            }
            else
            {
                lbl7.Visible = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }
    }
}
