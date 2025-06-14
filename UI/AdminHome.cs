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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            float earning = 0;
            var reader= new DLClass().ReturnQuery("select PaidAmount from Report;");
            while (reader.Read())
            {
                if (reader["PaidAmount"] != DBNull.Value)
                {
                    earning += Convert.ToSingle(reader["PaidAmount"]);
                }
            }
            lblAdmin.Text= "Total Admin:   "+FetchDB.adminList.Count.ToString();
            lblEmployee.Text= "Total Employee:   "+FetchDB.employeeList.Count.ToString();
            lblCustomer.Text = "Total Customer:   " + FetchDB.customerList.Count.ToString();
            lblRoom.Text= "Total Room:   "+FetchDB.roomList.Count.ToString();
            lblAvaiableRoom.Text= "Available Room:   "+FetchDB.availableRoomsCount.ToString();
            lblTotalEarning.Text="Total Earning:  " + earning.ToString();
        }
    }
}