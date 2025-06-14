using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class Admin : User
    {
        public bool isMainAdmin { get; set; }
        public Admin() { }
        //For userlist
        public Admin(string name, string CNIC, string UserName, string Password, string Role) : base(name, CNIC, UserName, Password, Role)
        {
        }
        public Admin(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password) : base(name, CNIC, PhoneNo, Address, Gender, UserName, Password)
        {
            this.isMainAdmin = false;
            this.Role = "Admin";
        }
        // for festching data from database
        public Admin(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password, bool isMainAdmin) : base(name, CNIC, PhoneNo, Address, Gender, UserName, Password)
        {
            this.isMainAdmin = isMainAdmin;
        }
        public override bool CheckData()
        {
            bool check = false;
            if (string.IsNullOrEmpty(this.name) || string.IsNullOrEmpty(this.CNIC) || string.IsNullOrEmpty(this.UserName) || string.IsNullOrEmpty(this.Password) || string.IsNullOrEmpty(this.PhoneNo)||this.CNIC.Length!=13||this.PhoneNo.Length!=11)
            {
                check = true;
            }
            return check;
        }
    }
}