using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class Customer : User
    {
        public bool BookedRoom { get; set; }
        public int totalAmount { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public List<Orders> Orders { get; set; } = new List<Orders>();
        public Customer() { }
        //for user list
        public Customer(string name, string CNIC, string UserName, string Password,string Role):base(name, CNIC, UserName, Password,Role)
        {

        }
        public Customer(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password) : base(name, CNIC, PhoneNo, Address, Gender, UserName, Password)
        {
            this.BookedRoom = false;
            this.Role = "Customer";
        }
        // for fetch database
        public Customer(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password,int TotalAmount) : base(name, CNIC, PhoneNo, Address, Gender, UserName, Password)
        {
            this.totalAmount= TotalAmount;
        }
        public override bool CheckData()
        {
            bool check = false;
            if (string.IsNullOrEmpty(this.name) || string.IsNullOrEmpty(this.CNIC) || string.IsNullOrEmpty(this.UserName) || string.IsNullOrEmpty(this.Password) || string.IsNullOrEmpty(this.PhoneNo) || this.CNIC.Length != 13 || this.PhoneNo.Length != 11)
            {
                check = true;
            }
            return check;
        }
    }
}