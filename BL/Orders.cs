using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class Orders
    {
        public int id;
        public string ItemName;
        public DateTime orderDate;
        public int ammont;
        public int roomNumber;
        public bool status;
        public int quantity;
        public Orders() 
        {
            this.ItemName = string.Empty;
        }
        public Orders(int id, string itemName, DateTime orderDate, int ammont, int roomNumber, bool status, int quantity)
        {
            this.id = id;
            ItemName = itemName;
            this.orderDate = orderDate;
            this.ammont = ammont;
            this.roomNumber = roomNumber;
            this.status = status;
            this.quantity = quantity;
        }
    }
}