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

namespace Hotel_Management_System.UI
{
    public partial class CustomerFeedback : Form
    {
        public CustomerFeedback()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string feedback;
            feedback=txtFeedback.Text;
            if (!string.IsNullOrEmpty(feedback))
            {
                if ((MessageBox.Show("Do you want to enter this feedback", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    BL.FeedBack obj = new BL.FeedBack(CustomerDashboard.customer.name, CustomerDashboard.customer.PhoneNo, feedback);
                    if (AddDB.AddFeedback(obj))
                    {
                        MessageBox.Show("Feedback entered successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFeedback.Clear();
                        FetchDB.feedBackList.Add(obj);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter feedback", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
