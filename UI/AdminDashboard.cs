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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(bool admin)
        {
            InitializeComponent();
            if (admin == true)
            {
                adminPanel.Enabled = true;
            }
            else
            {
                adminPanel.Enabled = false;
            }
        }
        public void LoadForm(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }
        void setLocaion()
        {
            adminPanel.Location = new Point(58, 227);
            EmployeePanel.Location = new Point(58, 293);
            RoomPanel.Location = new Point(58, 356);
            ReportPanel.Location = new Point(58, 421);
            FeadbackPanel.Location = new Point(58, 487);
            logoutPanel.Location = new Point(58, 551);
        }
        public void showAdminForm(Admin admin)
        {
            AdminAdd obj = new AdminAdd("Update Admin Data", "Update", admin);
            obj.ShowDialog();
        }
        public void showEmployeeForm(Employee employee)
        {
            EmployeeAdd obj = new EmployeeAdd("Update Employee Data", "Update", employee);
            obj.ShowDialog();
        }
        public void showRoomForm(Room room)
        {
            RoomAdd obj = new RoomAdd("Update Room Data", "Update", room);
            obj.ShowDialog();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new AdminHome());
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btn5_Click_2(object sender, EventArgs e)
        {
            int heightDifference = adminPanel.MaximumSize.Height - adminPanel.MinimumSize.Height;
            EmployeePanel.Size=  EmployeePanel.MinimumSize;
            RoomPanel.Size=  RoomPanel.MinimumSize;
            setLocaion();
            if (adminPanel.Size == adminPanel.MaximumSize)
            {
                adminPanel.Size = adminPanel.MinimumSize;
            }
            else
            {
                adminPanel.Size = adminPanel.MaximumSize;
                EmployeePanel.Top += heightDifference;
                RoomPanel.Top += heightDifference;
                ReportPanel.Top += heightDifference;
                FeadbackPanel.Top += heightDifference;
                logoutPanel.Top += heightDifference;
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new AdminAdd("Add", "Enter Admin Data"));
        }
        private void btn7_Click_1(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new AdminView());
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            int heightDifference = EmployeePanel.MaximumSize.Height - EmployeePanel.MinimumSize.Height;
            adminPanel.Size = adminPanel.MinimumSize;
            RoomPanel.Size = RoomPanel.MinimumSize;
            setLocaion();
            if (EmployeePanel.Size == EmployeePanel.MaximumSize)
            {
                EmployeePanel.Size = EmployeePanel.MinimumSize;
            }
            else
            {
                EmployeePanel.Size = EmployeePanel.MaximumSize;
                RoomPanel.Top += heightDifference;
                ReportPanel.Top += heightDifference;
                FeadbackPanel.Top += heightDifference;
                logoutPanel.Top += heightDifference;
            }
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new EmployeeAdd("Add", "Enter Employee Data"));
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new EmployeeView());
        }
        private void btn13_Click(object sender, EventArgs e)
        {
            int heightDifference = RoomPanel.MaximumSize.Height - RoomPanel.MinimumSize.Height;
            EmployeePanel.Size = EmployeePanel.MinimumSize;
            adminPanel.Size = adminPanel.MinimumSize;
            setLocaion();
            if (RoomPanel.Size == RoomPanel.MaximumSize)
            {
                RoomPanel.Size = RoomPanel.MinimumSize;
            }
            else
            {
                RoomPanel.Size = RoomPanel.MaximumSize;
                ReportPanel.Top += heightDifference;
                FeadbackPanel.Top += heightDifference;
                logoutPanel.Top += heightDifference;
            }
        }
        private void btn14_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new RoomAdd("Add", "Add Room Data"));
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new RoomView());
        }
        private void btn17_Click(object sender, EventArgs e)
        {
            EmployeePanel.Size = EmployeePanel.MinimumSize;
            RoomPanel.Size = RoomPanel.MinimumSize;
            adminPanel.Size = adminPanel.MinimumSize;
            mainPanel.Controls.Clear();
            setLocaion() ;
            LoadForm(new ReportsDetails());
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            EmployeePanel.Size = EmployeePanel.MinimumSize;
            RoomPanel.Size = RoomPanel.MinimumSize;
            adminPanel.Size = adminPanel.MinimumSize;
            setLocaion();
            mainPanel.Controls.Clear();
            LoadForm(new ViewFeedback());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new AdminHome());
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadForm(new RoomTypeCategory());
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginFormDashboard().Show();
        }
    }
}