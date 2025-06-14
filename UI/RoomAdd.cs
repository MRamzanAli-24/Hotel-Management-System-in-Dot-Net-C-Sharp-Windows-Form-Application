using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Hotel_Management_System.BL;
using Hotel_Management_System.DL;
namespace Hotel_Management_System.UI
{
    public partial class RoomAdd : Form
    {
        bool checkAdd = false;
        bool checkUpdate = false;
        public RoomAdd(string text, string header)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = header;
            lbl6.Visible = false;
            checkAdd = true;
            TopPanel.Visible = false;
            TopPanel.Enabled = false;
            txtcbRoomCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Room room;
        public static string RoomNumber = "";
        public RoomAdd(string text, string header, Room room)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = header;
            checkUpdate = true;
            this.room = room;
            TopPanel.Visible = true;
            TopPanel.Enabled = true;
        }
        public void setData(Room room)
        {
            txtRoomNo.Text = room.RoomNumber;
            txtPrice.Text = room.Price.ToString();
            txtcbRoomType.SelectedItem = room.Type;
            txtcbRoomCategory.SelectedItem = room.Category;
        }
        public void LoadRoomData()
        {
            txtcbRoomType.Items.Clear();
            txtcbRoomType.Items.AddRange(FileData.roomTypeList.ToArray());
            txtcbRoomCategory.Items.Clear();
            txtcbRoomCategory.Items.AddRange(FileData.roomCategoryList.ToArray());
        }
        public void AddRoom(Room obj)
        {
            if (!obj.CheckData())
            {
                if (!BLClass.isRoomExist(obj))
                {
                    if (AddDB.AddRoom(obj))
                    {
                        MessageBox.Show("Room Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchDB.roomList.Add(obj);
                        txtRoomNo.Text = "";
                        txtPrice.Text = "";
                        txtcbRoomType.Text = null;
                        txtcbRoomCategory.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Room  Allready Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lbl6.Visible = true;
            }
        }
        public void RoomUpdate(Room obj)
        {

            if (obj.CheckData())
            {
                lbl6.Visible = true;
            }
            else
            {
                if (UpdateDB.UpdateRoom(obj))
                {
                    checkUpdate = false;
                    MessageBox.Show("Room updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomView.Instance.LoadFromDB();
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
            float price;
            if (!float.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return;
            }
            Room obj = new Room(txtRoomNo.Text, txtcbRoomType.Text, txtcbRoomCategory.Text, price);
            lbl6.Visible = false;
            if (checkAdd)
            {
                AddRoom(obj);
            }
            else if (checkUpdate)
            {
                RoomUpdate(obj);
            }
            else
            {
                MessageBox.Show("Error ");
            }
        }

        private void RoomAdd_Load(object sender, EventArgs e)
        {
            LoadRoomData();
            if (checkUpdate)
            {
                setData(room);
                txtRoomNo.ReadOnly = true;
                txtcbRoomCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                txtcbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
