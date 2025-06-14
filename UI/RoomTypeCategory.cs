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
    public partial class RoomTypeCategory : Form
    {
        public RoomTypeCategory()
        {
            InitializeComponent();
        }
        public void LoadRoomData()
        {
            cbRoomType.Items.Clear();
            cbRoomType.Items.AddRange(FileData.roomTypeList.ToArray());
            cbRoomCategory.Items.Clear();
            cbRoomCategory.Items.AddRange(FileData.roomCategoryList.ToArray());
        }
        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void RoomTypeCategory_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRoomType.Text))
            {
                if (!BLClass.checkRoomType(txtRoomType.Text))
                {
                    FileData.roomTypeList.Add(txtRoomType.Text);
                    FileData.addRoomType();
                    MessageBox.Show("The Room Type Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomData();
                    txtRoomType.Text = "";
                }
                else
                {
                    MessageBox.Show("The Room Type All Ready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a Room Type to add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRoomCategory.Text))
            {
                if (!BLClass.checkRoomCategory(txtRoomCategory.Text))
                {
                    FileData.roomCategoryList.Add(txtRoomCategory.Text);
                    FileData.addRoomCategory();
                    MessageBox.Show("The Room Category Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomData();
                    txtRoomCategory.Text = "";
                }
                else
                {
                    MessageBox.Show("The Room Type All Ready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a Room Type to add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (cbRoomType.SelectedItem != null)
            {
                string RoomType = cbRoomType.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(RoomType))
                {
                    if (!BLClass.checkAvaialableRoomType(RoomType))
                    {
                        FileData.roomTypeList.Remove(RoomType);
                        FileData.addRoomType();
                        LoadRoomData();
                        MessageBox.Show("Room Type deleted successfully", "Tnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Can not remove the Room Type \n Because the room of {RoomType} type exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (cbRoomCategory.SelectedItem != null)
            {
                string RoomCategory = cbRoomCategory.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(RoomCategory))
                {
                    if (!BLClass.checkAvaialableRoomCategory(RoomCategory))
                    {
                        FileData.roomCategoryList.Remove(RoomCategory);
                        FileData.addRoomCategory();
                        LoadRoomData();
                        MessageBox.Show("Room category deleted successfully","Tnfo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Can not remove the Room Type \n Because the room of {RoomCategory} category exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
