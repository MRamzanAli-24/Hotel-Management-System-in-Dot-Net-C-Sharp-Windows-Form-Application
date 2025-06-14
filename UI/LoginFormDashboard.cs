using System.Runtime.CompilerServices;
using Hotel_Management_System.DL;
using Hotel_Management_System.UI;

namespace Hotel_Management_System
{
    public partial class LoginFormDashboard : Form
    {
        public LoginFormDashboard()
        {
            InitializeComponent();
        }
        public void LoginFormShow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            mainpanel.Controls.Clear();
            this.LoadForm(new LoginForm());
            lbl5.Enabled = true;
        }
        public void LoadForm(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            if (form is Form obj)
            {
                obj.TopLevel = false;
                obj.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(obj);
                this.mainpanel.Tag = obj;
                obj.Show();
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            LoadForm(new LoginForm());
            WindowState = FormWindowState.Normal;
            btn5.Visible = false;
            lbl5.Enabled = true;
        }

        private void LoginFormDashboard_Load(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            LoadForm(new LoginForm());
            FetchDB.GetUserData();
            FetchDB.GetAdminData();
            FetchDB.GetEmployeeData();
            FetchDB.GetCustomerData();
            FetchDB.GetRoomData();
            FetchDB.GetFoodItems();
            FetchDB.GetFeedBack();
            FetchDB.GetBookingData();
            FileData.getRoomType();
            FileData.getRoomCategory();
            FileData.getExpances();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            LoadForm(new CustomerAdd("SignUP","Enter Your Data"));
            WindowState = FormWindowState.Maximized;
            btn5.Visible = true;
            lbl5.Enabled = false;
        }
    }
}