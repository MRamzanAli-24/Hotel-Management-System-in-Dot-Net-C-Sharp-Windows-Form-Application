using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class FoodItem
    {
        public string itemName;
        public int itemPrice;
        public FoodItem() 
        {
            this.itemName = string.Empty;
        }
        public FoodItem(string itemName,int itemPrice)
        { 
            this.itemName = itemName;
            this.itemPrice = itemPrice;
        }

    }
}