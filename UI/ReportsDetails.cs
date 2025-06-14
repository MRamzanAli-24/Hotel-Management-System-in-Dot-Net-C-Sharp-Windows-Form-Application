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
using Microsoft.Data.SqlClient;

namespace Hotel_Management_System.UI
{
    public partial class ReportsDetails : Form
    {
        public ReportsDetails()
        {
            InitializeComponent();
        }
        public void LoadFromDB()
        {
            string searchType = txtSearchBy.SelectedItem?.ToString() ?? "All";
            string searchValue = txtSearch.Text;

            SqlDataReader reader = new DLClass().ReturnQuery("EXEC SearchReport @1, @2", searchType, searchValue);

            if (reader != null)
            {
                ReportDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    ReportDataGridView.Rows.Add(reader["id"].ToString(), reader["CustomerName"].ToString(), reader["CustomerPhoneNo"].ToString(), reader["PaidAmount"].ToString(), (Convert.ToDateTime(reader["paymentDate"]).Date).ToString("dd-MMM-yy"));
                }
                reader.Close();
            }
        }
        public void setData()
        {
            float earning = 0;
            var reader = new DLClass().ReturnQuery("select PaidAmount from Report;");
            while (reader.Read())
            {
                if (reader["PaidAmount"] != DBNull.Value)
                {
                    earning += Convert.ToSingle(reader["PaidAmount"]);
                }
            }
            txtTotalExpance.Text = FileData.expances.ToString();
            txtTotalEarning.Text = earning.ToString();
        }
        private void ViewReports_Load(object sender, EventArgs e)
        {
            txtSearchBy.SelectedIndex = 0;
            setData();
            LoadFromDB();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFromDB();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double newExpance = 0.0;
            if (double.TryParse(txtExpences.Text, out newExpance) && newExpance > 0)
            {
                if (MessageBox.Show("Are you sure you want to add this expance?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FileData.expances += newExpance;
                    FileData.addExpances();
                    txtTotalExpance.Text = FileData.expances.ToString();
                    txtExpences.Clear();
                    MessageBox.Show("Expance added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setData();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid expance amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
