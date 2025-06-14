using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public bool isAvaiable { get; set; }
        public Room()
        {
            this.RoomNumber = string.Empty;
            this.Type = string.Empty;
            this.Category = string.Empty;
        }   
        public Room(string RoomNumber, string Type, string Category, float Price, bool isAvaiable)
        {
            this.RoomNumber = RoomNumber;
            this.Type = Type;
            this.Category = Category;
            this.Price = Price;
            this.isAvaiable = isAvaiable;
        }
        public Room(string RoomNumber, string Type, string Category, float Price)
        {
            this.RoomNumber = RoomNumber;
            this.Type = Type;
            this.Category = Category;
            this.Price = Price;
            this.isAvaiable = true;
        }

        public bool CheckData()
        {
            bool check = false;
            if (string.IsNullOrEmpty(this.RoomNumber) || string.IsNullOrEmpty(this.Type) || string.IsNullOrEmpty(this.Category) || this.Price <= 0)
            {
                check = true;
            }
            return check;
        }
    }
}