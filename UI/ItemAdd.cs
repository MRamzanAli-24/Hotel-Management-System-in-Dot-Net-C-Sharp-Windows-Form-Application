using Hotel_Management_System.BL;
using Hotel_Management_System.DL;

namespace Hotel_Management_System.UI
{
    public partial class ItemAdd : Form
    {
        bool checkAdd = false;
        bool checkUpdate = false;
        string name = "";
        public ItemAdd(string text, string header)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = header;
            checkAdd = true;
            TopPanel.Visible = false;
            TopPanel.Enabled = false;
        }
        public ItemAdd(string text, string header, FoodItem item)
        {
            InitializeComponent();
            btn1.Text = text;
            lbl1.Text = header;
            checkUpdate = true;
            setData(item);
            name = item.itemName;
        }
        public void setData(FoodItem item)
        {
            txtItemName.Text = item.itemName;
            txtItemPrice.Text = item.itemPrice.ToString();
        }
        public void AddFoodItem(FoodItem obj)
        {
            if (!BLClass.checkFoodItem(obj.itemName))
            {
                if (!BLClass.checkFoodItem(obj.itemName))
                {
                    if (AddDB.AddFoodItem(obj))
                    {
                        MessageBox.Show("Food Item added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchDB.foodItemsList.Add(obj);
                        txtItemName.Text = "";
                        txtItemPrice.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Food Item with this name already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lbl4.Visible = true;
            }
        }
        public void UpdateFoodItem(FoodItem obj)
        {

            if (!BLClass.checkFoodItem(obj.itemName))
            {
                lbl4.Visible = true;
            }
            else
            {
                if (UpdateDB.UpdateFoodItem(obj, name))
                {
                    MessageBox.Show("Food Item updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ItemView.Instance.LoadFromDB();
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
            lbl4.Visible = false;

            if (!int.TryParse(txtItemPrice.Text, out int price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return;
            }

            FoodItem obj = new FoodItem(txtItemName.Text, price);
            lbl4.Visible = false;

            if (checkAdd)
            {
                AddFoodItem(obj);
            }
            else if (checkUpdate)
            {
                UpdateFoodItem(obj);
            }
            else
            {
                MessageBox.Show("Error: Invalid operation");
            }
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}